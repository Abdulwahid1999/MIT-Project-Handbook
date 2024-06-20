using HandbookSchool.ViewModels;

namespace HandbookSchool.Views.InstructionalSupportViews;

public partial class RegistrarOfficeViews : ContentPage
{
	public RegistrarOfficeViews(InstructionalSupportViewModel Registrar)
	{
		InitializeComponent();
		this.BindingContext = Registrar; 
	}

	async void ImageButton_Clicked_1(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("..", animate:true); 

	}
}