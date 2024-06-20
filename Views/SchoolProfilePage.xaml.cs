using HandbookSchool.ViewModels;

namespace HandbookSchool.Views;	

public partial class SchoolProfilePage : ContentPage
{
	public SchoolProfilePage(SchoolProfileViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}

	async void ImageButton_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("..", animate:true);  
		/*Navigation.PopAsync(); */
	}
}