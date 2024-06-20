using HandbookSchool.ViewModels;

namespace HandbookSchool.Views.SchoolProfileContentViews;

public partial class FeesViews : ContentPage
{
	public FeesViews(SchoolProfileViewModel Fees)
	{
		InitializeComponent();
		this.BindingContext = Fees; 
	}
	async void ImageButton_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("..", animate: true);
        /*Navigation.PopAsync(); */
    }
}