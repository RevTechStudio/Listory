using Listory.Desktop.Configuration;
using Listory.Desktop.Views.Pages;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Wpf.Ui;
using Wpf.Ui.Appearance;

namespace Listory.Desktop.Services;

/// <summary>
/// アプリケーションのライフサイクル管理サービス
/// </summary>
public class ApplicationHostService(IServiceProvider serviceProvider, ILogger<ApplicationHostService> logger, IOptions<DesktopSettings> options) : IHostedService
{
    /// <summary>
    /// メインウィンドウのナビゲーションインターフェース
    /// </summary>
    private readonly INavigationWindow mainWindow = (serviceProvider.GetService(typeof(INavigationWindow)) as INavigationWindow)!;

    /// <summary>
    /// アプリケーションを開始します。
    /// </summary>
    /// <param name="cancellationToken">キャンセルトークン</param>
    /// <returns>非同期タスク</returns>
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        logger.LogInformation("===================================");
        logger.LogInformation("アプリケーションを起動しています...");
        mainWindow.ShowWindow();
        ApplicationThemeManager.Apply(options.Value.ApplicationTheme, options.Value.WindowBackdropType);
        mainWindow.Navigate(typeof(DashboardPage));
        await Task.CompletedTask;
    }

    /// <summary>
    /// アプリケーションを停止します。
    /// </summary>
    /// <param name="cancellationToken">キャンセルトークン</param>
    /// <returns>非同期タスク</returns>
    public async Task StopAsync(CancellationToken cancellationToken)
    {
        logger.LogInformation("アプリケーションを停止しています...");
        await Task.CompletedTask;
    }
}