using HandbookSchool.ViewModels;

namespace HandbookSchool.Views.SchoolProfileContentViews;

public partial class ExaminationViews : ContentPage
{
	public ExaminationViews(SchoolProfileViewModel Examination)
	{
		InitializeComponent();
		this.BindingContext = Examination;
	}

	async void ImageButton_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("..", animate: true);
        /*Navigation.PopAsync(); */
    }
}