using HandbookSchool.ViewModels;

namespace HandbookSchool.Views;

public partial class InstructionalSupportPage : ContentPage
{
	public InstructionalSupportPage(InstructionalSupportViewModel _instructionalViewModel)
	{
		InitializeComponent();
		this.BindingContext = _instructionalViewModel; 
	}

    async void ImageButton_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..", animate: true);
        /*Navigation.PopAsync(); */
    }
}