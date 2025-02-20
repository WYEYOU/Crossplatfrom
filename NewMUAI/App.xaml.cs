using NewMUAI.Pages;

namespace NewMUAI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		// return new Window(new AppShell());
		//สร้าง object โดยเข้าหน้าเมนโดยตรง
		// return new Window(new MainPage());
		// return new Window(new HomePage());
		// return new Window(new FlexLayoutPage());
		// return new Window(new ViewsPage());
		return new Window(new AppShell());
	}
}