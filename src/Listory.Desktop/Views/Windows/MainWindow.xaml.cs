using Listory.Desktop.ViewModels.Windows;
using System.Windows;

namespace Listory.Desktop.Views.Windows;

/// <summary>
/// MainWindow
/// </summary>
public partial class MainWindow : Window
{
    /// <summary>
    /// MainViewModel
    /// </summary>
    public MainViewModel ViewModel { get; }

    /// <summary>
    /// MainWindowのコンストラクタ
    /// </summary>
    public MainWindow(MainViewModel viewModel)
    {
        ViewModel = viewModel;
        DataContext = this;
        InitializeComponent();
    }
}