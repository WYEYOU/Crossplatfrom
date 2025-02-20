using NewMUAI.ViewModel;

namespace NewMUAI.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new LoginViewModel();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		// System.Diagnostics.Debug.Write(uname.Text);
		// System.Diagnostics.Debug.Write(pwd.Text);
		// if (uname.Text == "admin" && pwd.Text == "1234")
		// {
		// 	await Navigation.PushAsync(new ViewsPage());
		// }
		// else
		// {
		// 	await DisplayAlert("Error", "Username or Password incorrect", "Close");
		// }
	}

	private async void ForgetPasswordTapped(object sender, EventArgs e)
	{
		// await Shell.Current.GoToAsync("forgetpassword");
		// await Shell.Current.GoToAsync($"forgetpassword?uname={uname.Text}&pwd={pwd.Text}");
		// var loginData = new LoginData()
		// {
		// 	Uname = uname.Text,
		// 	Pwd = pwd.Text
		// };
		// var queryParams = new Dictionary<string, object>(){
		// 	{ "data", loginData}
		// };
		// await Shell.Current.GoToAsync("forgetpassword", queryParams);
	}

}

public class LoginData
{
	public String Uname { get; set; } = "";
	public String Pwd { get; set; } = "";
}