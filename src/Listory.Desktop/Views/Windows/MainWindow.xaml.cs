using Listory.Desktop.Configuration;
using Listory.Desktop.ViewModels.Windows;
using Microsoft.Extensions.Options;
using System.ComponentModel;
using Wpf.Ui;
using Wpf.Ui.Abstractions;
using Wpf.Ui.Controls;

namespace Listory.Desktop.Views.Windows;

/// <summary>
/// MainWindow
/// </summary>
public partial class MainWindow : FluentWindow, INavigationWindow
{
    private readonly DesktopSettings desktopSettings;

    /// <summary>
    /// MainViewModel
    /// </summary>
    public MainViewModel ViewModel { get; }

    /// <summary>
    /// MainWindowのコンストラクタ
    /// </summary>
    public MainWindow(
        MainViewModel viewModel,
        ISnackbarService snackbarService,
        INavigationViewPageProvider navigationViewPageProvider,
        INavigationService navigationService,
        IOptions<DesktopSettings> options)
    {
        ViewModel = viewModel;
        DataContext = this;
        InitializeComponent();

        SetPageService(navigationViewPageProvider);
        navigationService.SetNavigationControl(RootNavigation);
        snackbarService.SetSnackbarPresenter(SnackbarPresenter);
        desktopSettings = options.Value;
        TrayMenu.DataContext = this;
    }

    /// <summary>
    /// ナビゲーションビューを取得する
    /// </summary>
    public INavigationView GetNavigation() => RootNavigation;

    /// <summary>
    /// 指定されたページタイプにナビゲートする
    /// </summary>
    public bool Navigate(Type pageType) => RootNavigation.Navigate(pageType);

    /// <summary>
    /// サービスプロバイダーを設定する
    /// </summary>
    public void SetServiceProvider(IServiceProvider serviceProvider) => throw new NotImplementedException();

    /// <summary>
    /// ページサービスを設定する
    /// </summary>
    public void SetPageService(INavigationViewPageProvider navigationViewPageProvider) => RootNavigation.SetPageProviderService(navigationViewPageProvider);

    /// <summary>
    /// ウィンドウを表示する
    /// </summary>
    public void ShowWindow() => Show();

    /// <summary>
    /// ウィンドウを閉じる
    /// </summary>
    public void CloseWindow() => Close();

    /// <summary>
    /// ウィンドウのClosingイベントを処理しタスクトレイ格納設定時は非表示にする
    /// </summary>
    /// <param name="sender">イベント送信者</param>
    /// <param name="e">キャンセル可能なイベント引数</param>
    private void OnClosing(object sender, CancelEventArgs e)
    {
        if (desktopSettings.IsMinimizedToTray)
        {
            e.Cancel = true;
            Hide();
        }
    }
}