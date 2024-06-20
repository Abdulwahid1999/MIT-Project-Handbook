using HandbookSchool.ViewModels;

namespace HandbookSchool.Views.SchoolProfileContentViews;

public partial class ScholarshipViews : ContentPage
{
	public ScholarshipViews(SchoolProfileViewModel Scholarship)
	{
		InitializeComponent();
		this.BindingContext = Scholarship; 

	}
	async void ImageButton_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("..", animate: true);
        /*Navigation.PopAsync(); */
    }
}