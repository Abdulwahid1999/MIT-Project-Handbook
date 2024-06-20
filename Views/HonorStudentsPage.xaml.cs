using HandbookSchool.ViewModels;

namespace HandbookSchool.Views;

public partial class HonorStudentsPage : ContentPage
{
	public HonorStudentsPage(HonorStudentsVideModel _honorStudentsViewModel)
	{
		InitializeComponent();
		this.BindingContext = _honorStudentsViewModel;
	}

	async void ImageButton_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("..", animate: true);

	}
}