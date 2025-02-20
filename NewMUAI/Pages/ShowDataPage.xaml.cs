using MauiDemo.ViewModel;

namespace NewMUAI.Pages;

public partial class ShowDataPage : ContentPage
{
	public ShowDataPage()
	{
		InitializeComponent();
		BindingContext = new ShowDataViewModel();
	}
}