using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandbookSchool.Models
{
    public class SchoolProfileModel
    {
        //I ACADEMIC POLICIES

        //Admission & Retention
        public string Academic { get; set; }
        public string Admission { get; set; }
        public string DescriptionA { get; set; }
        public string Image { get; set; }

        //New Students
        public string NewStudents { get; set; }
        public string DescriptionB { get; set; }
        /*  public string Image { get; set; }*/

        //Transfer Studens
        public string Transfer { get; set; }
        public string DescriptionC { get; set; }
        public string DescriptionList { get; set; }


        //II ENROLLMENT 
        public string Enrollment { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string Description4List { get; set; }
        public string Description5 { get; set; }
        public string Description6 { get; set; }

        /*public string Image { get; set; }*/

        //III CURRICULAR and NON-CURRICULAR ACADEMIC REQUIRENTS
        public string Curricular { get; set; }
        public string CurricularDescription1 { get; set; }
        public string CurricularDescription11 { get; set; }
        public string CurricularDescription12 { get; set; }
        public string CurricularDescription13 { get; set; }
        public string CurricularDescription2 { get; set; }


        public string Orderedlista { get; set; }
        public string OrderedListA { get; set; }
        public string OrderedListb { get; set; }
        public string OrderedListB { get; set; }
        public string OrderedListc { get; set; }
        public string OrderedListC { get; set; }
        public string OrderedListd { get; set; }
        public string OrderedListD { get; set; }
        public string OrderedListe { get; set; }
        public string OrderedListE { get; set; }



        public string NonCurricularDescription { get; set; }
        public string OrderedList2 { get; set; }
        public string OrderedList2A { get; set; }
        public string OrderedList2B { get; set; }
        public string OrderedList2C { get; set; }
        public string OrderedList2D { get; set; }
        public string OrderedList2E { get; set; }
        /*  public string Image { get; set; }*/

        //IV EXAMINATIONS AND GRADING SYSTEM
        public string Examination { get; set; }
        public string ExaminationDescription { get; set; }
        public string OrderedList3A { get; set; }
        public string OrderedList3B { get; set; }
        public string OrderedList3C { get; set; }
        public string Grade { get; set; }
        public string Equivalent { get; set; }
        public string Indication { get; set; }

        public string ThreeWeeks { get; set; }
        public string OneC { get; set; }
        public string OneE { get; set; }
        public string OneA { get; set; }
        public string OneL { get; set; }
        public string OneR { get; set; }
        public string W { get; set; }
        public string DR { get; set; }
        public string LastDecsription { get; set; }

        //INCOMPLETE GRADES
        public string IncompleteGrades { get; set; }
        public string IncompleteDescriptions { get; set; }


        //V GRADUATION 

        public string Graduation { get; set; }
        public string GraduationDescription { get; set; }
        public string OrdereListGraduationA { get; set; }
        public string OrderedListGraduation1 { get; set; }
        public string OrderedListGraduation2 { get; set; }
        public string OrderedListGraduation3 { get; set; }
        public string OrdereListGraduationB { get; set; }
        public string OrderedListGraduationa { get; set; }
        public string OrderedListGraduationb { get; set; }
        public string OrderedListGraduationc { get; set; }
        public string OrderedListGraduationd { get; set; }

        public string OrderedListAverage { get; set; }


        //FEES AND PAYMENT
        public string Payments { get; set; }
        public string Installment { get; set; }
        public string Penalty { get; set; }
        public string Payment { get; set; }
        public string PaymentList { get; set; }

        public string refund { get; set; }

        //VII FEE ADJUSTMENT PRIVILEGES 

        public string FeeAdjustment { get; set; }
        public string FeeAdjustmentDescription { get; set; }
        public string FeeAdjustmentList { get; set; }
        public string FamilyRelations { get; set; }
        public string  FamilyRelationsDescription {get; set;}
        //VIII ACADEMIC PRIVILEGES AND SCHOLAR PROGRAM
        public string AcademicPrevileges { get; set; }
        public string AcademicDescripstion { get; set; }
        public string AcademicList { get; set; }
        public string AcademicList1 { get; set; }
        public string AcademicList2 { get; set; }
        public string AcademicList3 { get; set; }
        public string AcademicDescription2 { get; set; }
        public string AcademicDescription3 { get; set; }

        public string AcademicOrderlist1 { get; set; }
        public string AcademicOrderlist2 { get; set; }
        public string AcademicListA { get; set; }
        public string AcademicListB { get; set; }
        public string AcademicListC { get; set; }
        public string AcademicListD { get; set; }
        public string AcademicListE { get; set; }
        public string AcademicListF { get; set; }


        //HONOR STUDENTS WITH ONE OR MORE YEARS OF RESIDENCE
        public string HonorStudents { get; set; }
        public string ToQualify { get; set; }
        public string HonorStudentsList { get; set; }
        public string ApplicationForAcademicTitle { get; set; }

        //APPLICATION FOR ACADEMIC PRIVILEGES
        public string ApplicationForAcademic { get; set; }


        //Content 

        public string Title { get; set; }
        public string Images { get; set; }


    }
}
