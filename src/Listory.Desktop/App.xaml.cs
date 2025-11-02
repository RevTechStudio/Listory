using Listory.Desktop.Services;
using Listory.Desktop.ViewModels.Windows;
using Listory.Desktop.Views.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

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

        builder.Services.AddHostedService<ApplicationHostService>();

        // ViewとViewModelの登録
        builder.Services.AddSingleton<MainWindow>();
        builder.Services.AddSingleton<MainViewModel>();

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
