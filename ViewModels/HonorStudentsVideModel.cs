using HandbookSchool.Services;
using HandbookSchool.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace HandbookSchool.ViewModels
{
    public partial class HonorStudentsVideModel : BaseViewModel
    {
        public ObservableCollection<HonorStudentsModel> honorStudents { get; set; } = new ObservableCollection<HonorStudentsModel>();
        public HonorStudentsVideModel(INavigationServicesMIT navigationServices) : base(navigationServices)
        {
            AddHonorStudents();
        }

        public void AddHonorStudents()
        {
            //HONOR STUDENTS WITH ONE OR MORE YEARS OF RESIDENCE
            honorStudents.Add(new HonorStudentsModel
            {
                HonorStudents = "HONOR STUDENTS WITH ONE MORE YEARS OF RESIDENCE",
                ToQualify = "To qualify for a tuition privilege:",
                HonorStudentsList = "The student must be on the Honor List with a general weighted average of no less than\n 1.70 for he preceding semester. A full-tuition privilege will be granted to the first ranking \n student among at least 30 students in the same curriculum year.\n" +
                "If there are more than 30 students in the curriculum year, the second ranking\n students will receive a half-tuition privilege" +
                "In case of a tie, privilege will be equally divided among the places affected." +
                "In order to qualify for othe above-cited privilege, it is further required that the student must\n be in need of financial help, must be enjoying no other scholarship or privilege, must not be\n engaged in gainful employment, must carry the normal load of his curriculum, and must not have violated the Students Code of Discipline." +
                "In the event that any of the first two ranking students fail to qualify for the tuition privilege,\n the next ranking students on the Honor List will considered.\n",
                ApplicationForAcademicTitle = "APPLICATIONS FOR ACADEMIC PRIVILEGES.",
                ApplicationForAcademic = "Application forms for academic privileges\n are to be obtained from and submitted to the Scholarship Office. All applications for privileges\n must be submitted within the official registration period, unless, otherwise specified.\n Applications for privileges submitted after the official registration period, unless, otherwise specified. Applications for privileges submitted after the Official registration period shall be deemed forfeited.",

            });

        }
    }
}
