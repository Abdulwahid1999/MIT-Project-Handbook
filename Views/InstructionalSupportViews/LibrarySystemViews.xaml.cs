using HandbookSchool.ViewModels;

namespace HandbookSchool.Views.InstructionalSupportViews;

public partial class LibrarySystemViews : ContentPage
{
	public LibrarySystemViews(InstructionalSupportViewModel Instructional)
	{
		InitializeComponent();
		this.BindingContext = Instructional; 
	}

	async void ImageButton_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("..", animate: true);
	}
}