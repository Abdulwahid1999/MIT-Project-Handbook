using CommunityToolkit.Mvvm.ComponentModel;
using HandbookSchool.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandbookSchool.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        protected readonly INavigationServicesMIT NavigateServices;
        public BaseViewModel(INavigationServicesMIT _navigateServices)
        {
            NavigateServices = _navigateServices; 
        }
    }
}
