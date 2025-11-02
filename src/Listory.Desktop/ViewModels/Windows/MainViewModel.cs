using CommunityToolkit.Mvvm.ComponentModel;

namespace Listory.Desktop.ViewModels.Windows;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private string applicationTitle = "Listory";
}