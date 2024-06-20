using HandbookSchool.Views;

namespace HandbookSchool;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
