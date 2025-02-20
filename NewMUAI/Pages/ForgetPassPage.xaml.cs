namespace NewMUAI.Pages;

//recive data
[QueryProperty(nameof(Username), "username")]
[QueryProperty("Password","password")]
[QueryProperty(nameof(LoginObject), "data")]
public partial class ForgetPassPage : ContentPage
{

	public LoginData LoginObject { get; set; } = new LoginData();
	public string Username { get; set; } = "";
	public string Password { get; set; } = "";
	public ForgetPassPage()
	{
		InitializeComponent();
		// System.Diagnostics.Debug.WriteLine(Uname);
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");
    }

    private void Button_Clicked1(object sender, EventArgs e)
    {
		System.Diagnostics.Debug.WriteLine("Uname: " + Username);
		// System.Diagnostics.Debug.WriteLine($"Pwd: {Pwd}");
		System.Diagnostics.Debug.WriteLine("Object Uname: " + LoginObject.Uname);
		System.Diagnostics.Debug.WriteLine("Object Uname: " + LoginObject.Pwd);
    }
}