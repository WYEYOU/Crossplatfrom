namespace NewMUAI.Pages;

public partial class ViewsPage : ContentPage
{
	public ViewsPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
    {
		System.Diagnostics.Debug.Write("No enty");
		DisplayAlert("Alert", "Message", "Close");
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}