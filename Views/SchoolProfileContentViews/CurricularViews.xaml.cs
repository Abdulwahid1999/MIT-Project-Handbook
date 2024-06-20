using HandbookSchool.ViewModels;

namespace HandbookSchool.Views.SchoolProfileContentViews;

public partial class CurricularViews : ContentPage
{
	public CurricularViews(SchoolProfileViewModel Curricular)
	{
		InitializeComponent();
		this.BindingContext = Curricular;
	}

	async void ImageButton_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("..", animate: true);
        /*Navigation.PopAsync(); */
    }
}