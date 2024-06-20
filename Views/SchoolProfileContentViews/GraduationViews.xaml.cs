using HandbookSchool.ViewModels;

namespace HandbookSchool.Views.SchoolProfileContentViews;

public partial class GraduationViews : ContentPage
{
	public GraduationViews(SchoolProfileViewModel Graduation)
	{
		InitializeComponent();
		this.BindingContext = Graduation;
	}
	async void ImageButton_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("..", animate: true);
        /*Navigation.PopAsync(); */
    }
}