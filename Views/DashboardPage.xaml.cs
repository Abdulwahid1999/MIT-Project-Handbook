using HandbookSchool.Models;
using HandbookSchool.ViewModels;
using Microsoft.Maui.Controls;

namespace HandbookSchool.Views;

public partial class DashboardPage : ContentPage
{
	public DashboardPage(DashboardPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}