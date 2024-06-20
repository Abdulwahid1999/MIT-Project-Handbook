using HandbookSchool.Views.SchoolProfileContentViews;
using HandbookSchool.Views;
using HandbookSchool.Views.InstructionalSupportViews;

namespace HandbookSchool;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(SchoolProfilePage), typeof(SchoolProfilePage));
        Routing.RegisterRoute(nameof(HighSchoolHonorPage), typeof(HighSchoolHonorPage));
        Routing.RegisterRoute(nameof(HonorStudentsPage), typeof(HonorStudentsPage));
        Routing.RegisterRoute(nameof(ApplicationAcademicPage), typeof(ApplicationAcademicPage));
        Routing.RegisterRoute(nameof(InstructionalSupportPage), typeof(InstructionalSupportPage));
        Routing.RegisterRoute(nameof(CollegeCounsilPage), typeof(CollegeCounsilPage));
        Routing.RegisterRoute(nameof(OrganizationalStructurePage), typeof(OrganizationalStructurePage));
        Routing.RegisterRoute(nameof(MITuniform), typeof(MITuniform));
        Routing.RegisterRoute(nameof(LocationPage), typeof(LocationPage)); 
        Routing.RegisterRoute(nameof(AboutUsPage), typeof(AboutUsPage));
        Routing.RegisterRoute(nameof(AcademicViews), typeof(AcademicViews));
        Routing.RegisterRoute(nameof(Enrollment), typeof(Enrollment));
        Routing.RegisterRoute(nameof(CurricularViews), typeof(CurricularViews));
        Routing.RegisterRoute(nameof(ExaminationViews), typeof(ExaminationViews));
        Routing.RegisterRoute(nameof(GraduationViews), typeof(GraduationViews));
        Routing.RegisterRoute(nameof(FeesViews), typeof(FeesViews));
        Routing.RegisterRoute(nameof(FeesAdjustmentViews), typeof(FeesAdjustmentViews));
        Routing.RegisterRoute(nameof(ScholarshipViews), typeof(ScholarshipViews));
        Routing.RegisterRoute(nameof(RegistrarOfficeViews), typeof(RegistrarOfficeViews));
        Routing.RegisterRoute(nameof(LibrarySystemViews), typeof(LibrarySystemViews));
        Routing.RegisterRoute(nameof(SupportServicesViews), typeof(SupportServicesViews));
    }
}
