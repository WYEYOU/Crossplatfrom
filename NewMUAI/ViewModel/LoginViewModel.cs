using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NewMUAI.Pages;

namespace NewMUAI.ViewModel;

public partial class LoginViewModel : ObservableObject
{
    [ObservableProperty]
    string username = "";
    [ObservableProperty]
    string password = "";

    [RelayCommand]
    async Task Login()
    {
        System.Diagnostics.Debug.WriteLine($"Username: {Username}");
        System.Diagnostics.Debug.WriteLine($"Password: {Password}");
        //await GotoPage(nameof(ShowDataPage)); //When click botton Login will go to page ShowDataPage
        await GotoPage(nameof(ShowObjectPage));
    }

    [RelayCommand]
    async Task GotoPage(string page)
    {
        await Shell.Current.GoToAsync(page);
    }
}
