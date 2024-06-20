using HandbookSchool.ViewModels;

namespace HandbookSchool.Views.InstructionalSupportViews;

public partial class SupportServicesViews : ContentPage
{
	public SupportServicesViews(InstructionalSupportViewModel Support)
	{
		InitializeComponent();
		this.BindingContext = Support;
	}

	async void ImageButton_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("..", animate: true);
	}
}