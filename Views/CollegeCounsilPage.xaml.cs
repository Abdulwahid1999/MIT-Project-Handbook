namespace HandbookSchool.Views;

public partial class CollegeCounsilPage : ContentPage
{
	public CollegeCounsilPage()
	{
		InitializeComponent();
	}

	async void ImageButton_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("..", animate: true);
	}
}