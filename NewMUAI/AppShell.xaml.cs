using NewMUAI.Pages;

namespace NewMUAI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("forgetpassword", typeof(ForgetPassPage));
		Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
		Routing.RegisterRoute(nameof(ShowDataPage), typeof(ShowDataPage));
		Routing.RegisterRoute(nameof(ShowObjectPage), typeof(ShowObjectPage));
	}
}
