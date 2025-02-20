using NewMUAI.ViewModel;

namespace NewMUAI.Pages;

public partial class ShowObjectPage : ContentPage
{
	public ShowObjectPage()
	{
		InitializeComponent();
		BindingContext = new ShowObjectsViewModel();
	}
}