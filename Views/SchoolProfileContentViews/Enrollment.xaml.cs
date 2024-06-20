using HandbookSchool.ViewModels;
namespace HandbookSchool.Views.SchoolProfileContentViews;

public partial class Enrollment : ContentPage
{
	public Enrollment(SchoolProfileViewModel enrollment)
	{
		InitializeComponent();
		this.BindingContext = enrollment;
	}

	async void ImageButton_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("..", animate: true);
        /*Navigation.PopAsync(); */
    }
}