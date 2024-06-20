using CommunityToolkit.Mvvm.Input;
using HandbookSchool.Services;
using HandbookSchool.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandbookSchool.ViewModels
{
    public partial class DashboardPageViewModel : BaseViewModel
    {   
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public DashboardPageViewModel(INavigationServicesMIT navigationServices) : base(navigationServices)
        {

        }

        [RelayCommand]
        public void NavigateToSchoolProfile()
        {
            NavigateServices.NavigateToAsync(nameof(SchoolProfilePage));
        }

        [RelayCommand]
        public void NavigateToHighSchoolHonor()
        {
            NavigateServices.NavigateToAsync(nameof(HighSchoolHonorPage));
        }

        [RelayCommand]

        public void NavigateToHonorStudents()
        {
            /*NavigateServices.NavigateToAsync(nameof(HonorStudentsPage));*/
        }

        [RelayCommand]
        public void NavigateToApplicationAcademic()
        {
            NavigateServices.NavigateToAsync(nameof(ApplicationAcademicPage));

        }

        [RelayCommand]
        public void NavigateToInstructionalSupport()
        {
            NavigateServices.NavigateToAsync(nameof(InstructionalSupportPage));
        }

        [RelayCommand]
        public void NavigateToCollegeCounsil()
        {
            NavigateServices.NavigateToAsync(nameof(CollegeCounsilPage));

        }

        [RelayCommand]
        public void NavigateToOrganizationalStructure()
        {
            NavigateServices.NavigateToAsync(nameof(OrganizationalStructurePage));

        }

        [RelayCommand]
        public void NavigateToMITuniform()
        {
            NavigateServices.NavigateToAsync(nameof(MITuniform));
        }

        [RelayCommand]

        public void NavigateToLocation()
        {
            NavigateServices.NavigateToAsync(nameof(LocationPage));
        }

        [RelayCommand]
        public void NavigateToAboutUS()
        {
            NavigateServices.NavigateToAsync(nameof(AboutUsPage));

        }

    }
}
