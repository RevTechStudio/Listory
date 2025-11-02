using Listory.Desktop.ViewModels.Pages;
using System.Windows.Controls;

namespace Listory.Desktop.Views.Pages;

/// <summary>
/// SettingsPage.xaml の相互作用ロジック
/// </summary>
public partial class SettingsPage : Page
{
    /// <summary>
    /// SettingsViewModel
    /// </summary>
    public SettingsViewModel ViewModel { get; }

    /// <summary>
    /// SettingsPageのコンストラクタ
    /// </summary>
    public SettingsPage(SettingsViewModel viewModel)
    {
        ViewModel = viewModel;
        DataContext = this;
        InitializeComponent();
    }
}
