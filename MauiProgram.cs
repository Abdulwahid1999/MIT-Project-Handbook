using CommunityToolkit.Maui;
using HandbookSchool.Services;
using HandbookSchool.ViewModels;
using HandbookSchool.Views;
using HandbookSchool.Views.InstructionalSupportViews;
using HandbookSchool.Views.SchoolProfileContentViews;

namespace HandbookSchool;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		
#endif

		builder.Services.AddSingleton<INavigationServicesMIT, NavigateServices>();

		//UI registration 
		builder.Services.AddSingleton<DashboardPage>();
        builder.Services.AddTransient<SchoolProfilePage>();
        builder.Services.AddTransient<HighSchoolHonorPage>();
		builder.Services.AddTransient<HonorStudentsPage>();
		builder.Services.AddTransient<ApplicationAcademicPage>();
		builder.Services.AddTransient<InstructionalSupportPage>();
		builder.Services.AddTransient<CollegeCounsilPage>();
		builder.Services.AddTransient<OrganizationalStructurePage>();
		builder.Services.AddTransient<MITuniform>();
		builder.Services.AddTransient<LocationPage>();
		builder.Services.AddTransient<AboutUsPage>();
		builder.Services.AddTransient<AcademicViews>();
        builder.Services.AddTransient<Enrollment>();
        builder.Services.AddTransient<CurricularViews>();
        builder.Services.AddTransient<ExaminationViews>();
        builder.Services.AddTransient<GraduationViews>();
        builder.Services.AddTransient<FeesViews>();
        builder.Services.AddTransient<FeesAdjustmentViews>();
        builder.Services.AddTransient<ScholarshipViews>();
        builder.Services.AddTransient<RegistrarOfficeViews>();
		builder.Services.AddTransient<LibrarySystemViews>();
		builder.Services.AddTransient<SupportServicesViews>();

        //View Model Registration 
        builder.Services.AddSingleton<DashboardPageViewModel>();
        builder.Services.AddTransient<SchoolProfileViewModel>();
		builder.Services.AddTransient<HighSchoolHonorViewModel>();
		builder.Services.AddTransient<HonorStudentsVideModel>();
        builder.Services.AddTransient<InstructionalSupportViewModel>();


        return builder.Build();
	}
}
