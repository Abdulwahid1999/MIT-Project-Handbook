using HandbookSchool.ViewModels;

namespace HandbookSchool.Views.SchoolProfileContentViews;

public partial class AcademicViews : ContentPage
{
	public AcademicViews(SchoolProfileViewModel Academic)
	{
		InitializeComponent();
		this.BindingContext = Academic;
	}

	async void ImageButton_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("..", animate: true);
        /*Navigation.PopAsync(); */
    }
}