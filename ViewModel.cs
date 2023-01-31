using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ScrollViewTest;

public partial class ViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<int> numbers = new();

    [RelayCommand]
    private void Add()
    {
        Numbers.Add(Numbers.Count + 1);
    }

    [RelayCommand]
    private async Task ButtonPressedAsync()
    {
        await Shell.Current.DisplayAlert(string.Empty, "Woo", "OK");
    }
}
