using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Listory.Desktop.Configuration;
using Listory.Desktop.Views.Pages;
using Microsoft.Extensions.Options;
using System.Collections.ObjectModel;
using System.Windows;
using Wpf.Ui.Controls;

namespace Listory.Desktop.ViewModels.Windows;

/// <summary>
/// MainViewModel
/// </summary>
public partial class MainViewModel(IOptions<DesktopSettings> options) : ObservableObject
{
    /// <summary>
    /// デスクトップアプリケーション設定
    /// </summary>
    [ObservableProperty]
    private DesktopSettings desktopSettings = options.Value;

    /// <summary>
    /// アプリケーションタイトル
    /// </summary>
    [ObservableProperty]
    private string applicationTitle = "Listory";

    /// <summary>
    /// メインナビゲーションメニューのアイテムコレクション
    /// </summary>
    [ObservableProperty]
    private ObservableCollection<object> menuItems =
        [
            new NavigationViewItem()
            {
                Content = "ダッシュボード",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Home24 },
                TargetPageType = typeof(DashboardPage)
            }
        ];

    /// <summary>
    /// フッターメニューのアイテムコレクション
    /// </summary>
    [ObservableProperty]
    private ObservableCollection<object> footerMenuItems =
        [
            new NavigationViewItem()
            {
                Content = "設定",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                TargetPageType = typeof(SettingsPage)
            }
        ];

    /// <summary>
    /// アプリケーションを終了する
    /// </summary>
    [RelayCommand]
    private static void Exit() => Application.Current.Shutdown();
}