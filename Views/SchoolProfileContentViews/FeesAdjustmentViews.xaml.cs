using HandbookSchool.ViewModels;
namespace HandbookSchool.Views.SchoolProfileContentViews;

public partial class FeesAdjustmentViews : ContentPage
{
	public FeesAdjustmentViews(SchoolProfileViewModel FeesAdjustment)
	{
		InitializeComponent();
		this.BindingContext = FeesAdjustment;
	}
	async void ImageButton_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("..", animate: true);
        /*Navigation.PopAsync(); */
    }
}