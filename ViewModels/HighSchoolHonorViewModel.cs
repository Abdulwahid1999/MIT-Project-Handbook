using HandbookSchool.Models;
using HandbookSchool.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandbookSchool.ViewModels
{
    public partial class HighSchoolHonorViewModel : BaseViewModel
    {
        public HighSchoolHonorViewModel(INavigationServicesMIT navigationServices) : base (navigationServices)
        {
            HighSchoolHonor();
        }

        public void HighSchoolHonor()
        {


        }
    }
}
