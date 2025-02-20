using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiDemo.ViewModel;

public partial class ShowDataViewModel : ObservableObject
{
    [ObservableProperty]
    // List<string> listData=["One", "Two", "Three", "Four", "Five"];
    ObservableCollection<string> listData = new() { "One", "Two", "Three", "Four", "Five" };

    [ObservableProperty]
    string itemText = "";

    [RelayCommand]
    void Add(string item) { 
        ListData.Add(item);
    }
}