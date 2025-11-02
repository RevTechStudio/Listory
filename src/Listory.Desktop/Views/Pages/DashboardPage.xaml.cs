using Listory.Desktop.ViewModels.Pages;
using System.Windows.Controls;

namespace Listory.Desktop.Views.Pages;

/// <summary>
/// DashboardPage.xaml の相互作用ロジック
/// </summary>
public partial class DashboardPage : Page
{
    /// <summary>
    /// DashboardViewModel
    /// </summary>
    public DashboardViewModel ViewModel { get; }

    /// <summary>
    /// DashboardPageのコンストラクタ
    /// </summary>
    public DashboardPage(DashboardViewModel viewModel)
    {
        ViewModel = viewModel;
        DataContext = this;
        InitializeComponent();
    }
}
