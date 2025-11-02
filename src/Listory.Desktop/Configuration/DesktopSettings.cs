using System.Text.Json.Serialization;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace Listory.Desktop.Configuration;

/// <summary>
/// デスクトップアプリ設定
/// </summary>
public class DesktopSettings
{
    /// <summary>
    /// アプリケーションテーマ設定
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ApplicationTheme ApplicationTheme { get; set; } = ApplicationTheme.Light;

    /// <summary>
    /// 最前面設定
    /// </summary>
    public bool Topmost { get; set; } = false;

    /// <summary>
    /// サイドメニューの幅設定
    /// </summary>
    public double PaneWidth { get; set; } = 250;

    /// <summary>
    /// タスクトレイ常駐設定
    /// </summary>
    public bool IsMinimizedToTray { get; set; } = false;

    /// <summary>
    /// ウィンドウの背景効果設定
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public WindowBackdropType WindowBackdropType { get; set; } = WindowBackdropType.Mica;

    /// <summary>
    /// スナックバーの表示時間（秒）
    /// </summary>
    public double SnackbarDuration { get; set; } = 2.5;
}
