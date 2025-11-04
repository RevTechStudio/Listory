using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MudBlazor;

namespace Listory.Web.Components.ViewModels.Layout;

/// <summary>
/// MainViewModel
/// </summary>
public partial class MainViewModel : ObservableObject
{
    /// <summary>
    /// アプリケーションタイトル
    /// </summary>
    [ObservableProperty]
    private string applicationTitle = "CodeStudio.MudBlazorServer";

    /// <summary>
    /// ドロワーの開閉状態
    /// </summary>
    [ObservableProperty]
    private bool drawerOpen = true;

    /// <summary>
    /// ダークモードの状態
    /// </summary>
    [ObservableProperty]
    private bool isDarkMode = false;

    /// <summary>
    /// テーマ
    /// </summary>
    [ObservableProperty]
    private MudTheme? theme = new()
    {
        PaletteLight = lightPalette,
        PaletteDark = darkPalette,
        LayoutProperties = new LayoutProperties()
    };

    /// <summary>
    /// ドロワーの開閉切替
    /// </summary>
    [RelayCommand]
    private void DrawerToggle() { DrawerOpen = !DrawerOpen; }

    /// <summary>
    /// ドロワーの開閉切替アクション
    /// </summary>
    public Action DrawerToggleAction => () => DrawerToggleCommand.Execute(null);

    /// <summary>
    /// ダークモードの切替得
    /// </summary>
    [RelayCommand]
    private void DarkModeToggle() { IsDarkMode = !IsDarkMode; }

    /// <summary>
    /// ダークモード切替アクション
    /// </summary>
    public Action DarkModeToggleAction => () => DarkModeToggleCommand.Execute(null);

    /// <summary>
    /// ライトパレット
    /// </summary>
    private static readonly PaletteLight lightPalette = new()
    {
        Black = "#110e2d",
        AppbarText = "#424242",
        AppbarBackground = "rgba(255,255,255,0.8)",
        DrawerBackground = "#ffffff",
        GrayLight = "#e8e8e8",
        GrayLighter = "#f9f9f9",
    };

    /// <summary>
    /// ダークパレット
    /// </summary>
    private static readonly PaletteDark darkPalette = new()
    {
        Primary = "#7e6fff",
        Surface = "#1e1e2d",
        Background = "#1a1a27",
        BackgroundGray = "#151521",
        AppbarText = "#92929f",
        AppbarBackground = "rgba(26,26,39,0.8)",
        DrawerBackground = "#1a1a27",
        ActionDefault = "#74718e",
        ActionDisabled = "#9999994d",
        ActionDisabledBackground = "#605f6d4d",
        TextPrimary = "#b2b0bf",
        TextSecondary = "#92929f",
        TextDisabled = "#ffffff33",
        DrawerIcon = "#92929f",
        DrawerText = "#92929f",
        GrayLight = "#2a2833",
        GrayLighter = "#1e1e2d",
        Info = "#4a86ff",
        Success = "#3dcb6c",
        Warning = "#ffb545",
        Error = "#ff3f5f",
        LinesDefault = "#33323e",
        TableLines = "#33323e",
        Divider = "#292838",
        OverlayLight = "#1e1e2d80",
    };

    /// <summary>
    /// ダークモード切替ボタンのアイコン
    /// </summary>
    public string DarkLightModeButtonIcon => IsDarkMode switch
    {
        true => Icons.Material.Rounded.LightMode,
        false => Icons.Material.Outlined.DarkMode,
    };
}
