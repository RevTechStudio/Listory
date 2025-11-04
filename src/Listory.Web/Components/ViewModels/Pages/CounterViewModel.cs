using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Listory.Web.Components.ViewModels.Pages;

/// <summary>
/// CounterViewModel
/// </summary>
public partial class CounterViewModel(ILogger<CounterViewModel> logger) : ObservableObject
{
    /// <summary>
    /// カウント
    /// </summary>
    [ObservableProperty]
    private int currentCount = 0;

    /// <summary>
    /// カウントの増加
    /// </summary>
    [RelayCommand]
    private void IncrementCount()
    {
        CurrentCount++;
        logger.LogInformation("CurrentCount incremented to {CurrentCount}", CurrentCount);
    }

    /// <summary>
    /// カウントの増加アクション
    /// </summary>
    public Action IncrementCountAction => () => IncrementCountCommand.Execute(null);
}
