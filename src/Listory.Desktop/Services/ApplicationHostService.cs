using Listory.Desktop.Views.Windows;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Listory.Desktop.Services;

/// <summary>
/// アプリケーションのライフサイクル管理サービス
/// </summary>
/// <param name="serviceProvider">サービスプロバイダー</param>
/// <param name="logger">ロガー</param>
public class ApplicationHostService(IServiceProvider serviceProvider, ILogger<ApplicationHostService> logger) : IHostedService
{
    /// <summary>
    /// メインウィンドウ
    /// </summary>
    private readonly MainWindow mainWindow = serviceProvider.GetService(typeof(MainWindow)) as MainWindow ??
        throw new InvalidOperationException("MainWindowの取得に失敗しました。");

    /// <summary>
    /// アプリケーションを開始します。
    /// </summary>
    /// <param name="cancellationToken">キャンセルトークン</param>
    /// <returns>非同期タスク</returns>
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        logger.LogInformation("===================================");
        logger.LogInformation("アプリケーションを起動しています...");
        mainWindow.Show();
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