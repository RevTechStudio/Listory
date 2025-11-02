using Listory.Desktop.Configuration;
using Listory.Desktop.Services;
using Listory.Desktop.ViewModels.Pages;
using Listory.Desktop.ViewModels.Windows;
using Listory.Desktop.Views.Pages;
using Listory.Desktop.Views.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Windows;
using Wpf.Ui;
using Wpf.Ui.DependencyInjection;

namespace Listory.Desktop;

/// <summary>
/// App.xamlのインタラクションロジック
/// </summary>
public partial class App : Application
{
    /// <summary>
    /// アプリケーションホスト
    /// </summary>
    private static readonly IHost host = CreateHost();

    /// <summary>
    /// アプリケーションホストの作成と設定
    /// </summary>
    /// <returns>構成済みのアプリケーションホスト</returns>
    private static IHost CreateHost()
    {
        var builder = Host.CreateApplicationBuilder();

        // ロギングの設定
        builder.Services.AddLogging(logging =>
        {
            logging.ClearProviders();
            logging.AddConfiguration(builder.Configuration.GetSection("Logging"));
            logging.AddDebug();
            logging.AddConsole();
        });

        // IOptions<DesktopSettings> を登録
        builder.Services.Configure<DesktopSettings>(
            builder.Configuration.GetSection("DesktopSettings"));

        // ページプロバイダーの登録
        builder.Services.AddNavigationViewPageProvider();

        // アプリケーションのホストサービスを登録
        builder.Services.AddHostedService<ApplicationHostService>();

        // サービスの登録
        builder.Services.AddSingleton<IThemeService, ThemeService>();
        builder.Services.AddSingleton<ITaskBarService, TaskBarService>();
        builder.Services.AddSingleton<ISnackbarService, SnackbarService>();
        builder.Services.AddSingleton<INavigationService, NavigationService>();

        // ViewとViewModelの登録
        builder.Services.AddSingleton<INavigationWindow, MainWindow>();
        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<DashboardPage>();
        builder.Services.AddSingleton<DashboardViewModel>();
        builder.Services.AddSingleton<SettingsPage>();
        builder.Services.AddSingleton<SettingsViewModel>();

        return builder.Build();
    }

    /// <summary>
    /// アプリケーション起動時の処理
    /// </summary>
    /// <param name="sender">イベント送信者</param>
    /// <param name="e">起動イベント引数</param>
    private async void OnStartup(object sender, StartupEventArgs e)
    {
        await host.StartAsync();
    }

    /// <summary>
    /// アプリケーション終了時の処理
    /// </summary>
    /// <param name="sender">イベント送信者</param>
    /// <param name="e">終了イベント引数</param>
    private async void OnExit(object sender, ExitEventArgs e)
    {
        await host.StopAsync();
        host.Dispose();
    }
}
