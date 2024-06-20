    
using CommunityToolkit.Mvvm.Input;
using HandbookSchool.Models;
using HandbookSchool.Services;
using HandbookSchool.Views.SchoolProfileContentViews;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandbookSchool.ViewModels
{
    public partial class SchoolProfileViewModel : BaseViewModel 
    {   
        public ObservableCollection<SchoolProfileModel>SchoolProfile { get; set; } = new ObservableCollection<SchoolProfileModel>();
        public ObservableCollection<SchoolProfileModel> SchoolProfileContent { get; set; } = new ObservableCollection<SchoolProfileModel>();
        public SchoolProfileViewModel(INavigationServicesMIT navigationServices) : base (navigationServices)
        {
            AddSchoolProfile();
        }

        [RelayCommand]
        public void NavigateToAcademicViews()
        {
            NavigateServices.NavigateToAsync(nameof(AcademicViews));
        }

        [RelayCommand]
        public void NavigateToEnrollment()
        {
            NavigateServices.NavigateToAsync(nameof(Enrollment));
        }

        [RelayCommand]
        public void NavigateToCurricular()
        {
            NavigateServices.NavigateToAsync(nameof(CurricularViews));
        }

        [RelayCommand]
        public void NavigateToExamination()
        {
            NavigateServices.NavigateToAsync(nameof(ExaminationViews));
        }

        [RelayCommand]
        public void NavigateToGraduation()
        {
            NavigateServices.NavigateToAsync(nameof(GraduationViews));
        }

        [RelayCommand]
        public void NavigateToFeesAndPayment()
        {
            NavigateServices.NavigateToAsync(nameof(FeesViews));
        }

        [RelayCommand]
        public void NavigateToFeesAdjustment()
        {
            NavigateServices.NavigateToAsync(nameof(FeesAdjustmentViews));
        }

        [RelayCommand]
        public void NavigateToScholarship()
        {
            NavigateServices.NavigateToAsync(nameof(ScholarshipViews));
        }


        private void AddSchoolProfileContent()
        {
            SchoolProfileContent.Add(new SchoolProfileModel
            {
                Title = "Academic Policies", 
                Images = "campus.png" 
            });

            SchoolProfileContent.Add(new SchoolProfileModel
            {
                Title = "II ENROLLMENT",
                Images = "class1.png",
            });

            SchoolProfileContent.Add(new SchoolProfileModel
            {
                Title = "II ENROLLMENT", 
                Images = "class1.png",
            });

            SchoolProfileContent.Add(new SchoolProfileModel { Title = "III CURRICULAR and NON-CURRICULAR", Images = "children.png"});
        }

        private void AddSchoolProfile()
        {
            SchoolProfile.Add(new SchoolProfileModel
            {   
                //ACADEMIC POLICIES
                Academic = "I. ACADEMIC POLICIES",
                Admission = "A. Admission & Retention",
                DescriptionA = "Academic entrance requirements vary with the status of the prospective student and the program in which he desires to enroll. The MIT reserves the right not to accept any applicant whose qualification do not meet the standard and requirements of the program in which he desires to enroll. ",

                NewStudents = "B. New Students",
                DescriptionB = "New students are high school graduates enrolling in MIT for the first time. At the time of enrolment, a new student must submit his High School Report Card (Form 138-A) duly certified by the Principal, " +
                " the original copy of Birth Certificate, Certificate of Good Moral Character issued by the school Principal.",

                Transfer = "C. Transfer Students",
                DescriptionC = "Transfer students are those who wish to enroll in MIT after having seen in college courses at another institution. ",
                DescriptionList = 
                                  "1. A certificate of transfer crendential from the school \b last attended. \n" +
                                  "2. A statement of good moral character signed by on adviser and certified by the " +
                                  "Dean or Head of School and / or the Director of Student Affairs. \n" +
                                  "3. An informative copy of his transcript of records which should include the descriptive title of the subjects taken the number of units and the grades earned. \n" +
                                  "4. Original copy of Birth Certificate. \n" +
                                  "5. Permit-to-study is needed if the student intends to enroll for summer only.\n",


                // II ENROLLMENT
                Enrollment = "II. ENROLLMENT",
                Description1 = "• Every prospective student must enroll during the prescribed registration period. Detailed Instructions on enrollment procedures are posted at enrollment time. No enrollment is possible without necessary crendentials. Enrollment by proxy is not allowed. ",
                Description2 = "• Considered a bonafide of MIT is one who is dully enrolled, that is, who has submitted his valid credentials has attended classes and has paid his fees or made arrangements for payment. ",
                Description3 = "• CHANGING SUBJECTS, during the enrollment period a student may, with the approval of the Department Chairman, change subjects or curriculum. Changes are not permitted after the close of the official enrollment period. ",
                Description4 = "• WITHDRAWAL FROM SUBJECTS AND CURRICULA. Students may officially withdraw from subjects even after the close of the enrollment period upon recommendation by the Department Chairman and with approval of the Registrar. Withdrawal from subjects is not ordinarily approved after the mid-ter examination. ",
                Description4List = "• if the accumulated number of absences from class make up of 20% of the officially scheduled number of classes; of \n" +
                "• if the student does not have written permission to withdraw from his parents our guardian.",
                Description5 = "• DROPPING FROM CLASS. A student is automatically dropped (DR) when the number of absences the maximum number of permitted absences consisting of 20% of the prescribed number of class periods for the course. ",
                Description6 = "• CERTIFICATE OF TRANSFER CRENDENTIAL Formerly Honorable Dismissal). A student who desires to transfer to another should apply for a certificate of transfer crendintial. Such a certificate will be issued only after the applicants has been cleared of all financial and properly liabilities and has surrendered his ID card.\n",
                //III CURRICULAR AND NON-CURRICULAR ACADEMIC REQUIREMENTS 
                Curricular = "III. CURRICULAR AND NON-CURRICULAR ACADEMIC REQUIREMENTS",
                CurricularDescription1 = "1. The normal semestral study load is ordinarily prescribed by the curriculum in which the student is enrolled. " +
                                        "A Student is considered Full Time or carrying a full load when he carries  all subjects prescribed for this curriculum. ",
                CurricularDescription11 = "• EXCESS LOAD Par. 134 of the Manual of Regulations also states the Students in the graduating class may be permitted a loadof three units " +
                                        "in college in excess of the regular load without prior approval of the CHED.",
                CurricularDescription12 ="• However, PE. of 2 units, NSTP of 3 units will constitute an excess load if taken in the third, fourth of fifth year, even if these subjects are supposed to be taken in first two (2) years of college as assignment in the curriculum. ",
                CurricularDescription13 ="• It strictly not allowed to excess the curriculum load. If graduating, a student who wants carry on overload needs the approval of the CHED under certain conditions. ",
                CurricularDescription2 = "2. During the summer session a student may carry a maximum load of nine (9) units with not overload whatsover permitted.",
                Orderedlista = "SEQUENCE OF SUBJECTS",
                OrderedListA = "Advance subjects should not be assigned to the student unless he has already passed pre-requisities to these subjects. Par.154 " +
                               "of the Manual of Regulations for Private States NO student should be permitted to take any subject  until he has satisfactory x passed  the pre-requisites subjects. ",
                OrderedListb = "NATIONAL SERVICE TRAINING PROGRAMS",
                OrderedListB = "In conformity with goverment regulations , MIT requires every student to register NSTP. " +
                               "A student who fails to comply with these regulations is considered an evader, a designation that entails severe penalties.",
                OrderedListc = "RELIGIOUS/ISLAMIC EDUCATION",
                OrderedListC = "In addition to the regular load every student including the transfer student, is required  to earn 12 units in values islamic Education. " +
                               "Non-Muslim students maybe substitute cultural subjects for these, and are advised to consult with the Chairman of the Deparment of Religious Education in the choice of the subjects.",
                OrderedListd = "PHYSICAL EDUCATION",
                OrderedListD = "(PE). All students further required to earn four (4) units in PE during the first two years. Simunaltaneous enrollment in two or more basic PE courses in a particular semester or term is not permitted.",
                OrderedListe = "ABSENCES FROM CLASS",
                OrderedListE = "The Maximum numberof permitted absences from class attendance consists of 20% of the prescribed number of class periods for the course. " +
                               "Thus, 10 absences from either a 3-unit lecture course or a 1-unit laboratory course.",

                //EXAMINATIONS AND GRADING SYSTEM

                Examination = "IV. EXAMINATIONS AND GRADING SYSTEM",
                ExaminationDescription = "Besides regular quizzes and tests, four official general examination are given every term; Pre-Mid, Mid-Term, Pre-final & Final Examination. Dates for these examination are posted on bulletin boards.",
                OrderedList3A = "a) No student is allowed to take an official examination unless he presents the admission slip issued by the Registrars / Cashier's Office.",
                OrderedList3B = "b) Students should claim their grades by presenting their ID to their Dean or his representative.",
                OrderedList3C = "c) Academic achievement is graded in the following manner:",
                /*    Grade = "GRADE\n" +
                    "1.0\n" +
                    "1.25-1.5\n" +
                    "1.75-2.0\n" +
                    "2.25-2.5\n" +
                    "2.75-3.0\n" +
                    "4.0-5.0\n",
                    Equivalent = "EQUIVALENT\n" +
                    "100 - 97%\n" +
                    "96 - 94%\n" +
                    "93 - 90%\n" +
                    "89 - 80%\n" +
                    "79 - 75%\n" +
                    "74 - 70%\n",
                    Indication = "INDICATION\n" +
                    "Excellent\n" +
                    "Very Good\n" +
                    "Good\n" +
                    "Fair\n" +
                    "Passed\n" +
                    "Failed\n",*/

                ThreeWeeks = "3W = Weak or Warning, given only as a Mid-Term grade.",
                OneC = "1C = Grade given for a subject in which the student lacked some required work.",
                OneE = "1E = Grade given for a subject in which the student failed to take the final examination.",
                OneA = "1A = Grade give for a subject in which the student who is a candidate for graduation failed " +
                       "or for a subject in whose pre-requisites the student failed.",
                OneL = "1L = Grade given for a laboratory course in which the student failed to perform " +
                       "the entire required laboratory experiments and / or to submit all required reports.",
                OneR = "1R = Signifies that the teacher failed to report the grade on time.",
                W = "W = Signifies that the student officially withdraw from the subject and / or had " +
                    "incurred academic or otherwise.",
                DR = "DR = Signifies that the student unofficially withdraws from the subject and or had " +
                     "incurred absences beyong the allowable limit",
                LastDecsription = "The grade DR is considered in the same category on a 5.0. " +
                    "It disqualifies a student from receiving honors and may be cause for non-readmission.",
                IncompleteGrades = "1.INCOMPLETE GRADES",
                IncompleteDescriptions = "Application for completion or removal of incomplete " +
                    "grades must be filed within the period announced in the MIT bulletin boards. A fine may be imposed on late applications. And incomplete grade or removed within one year has to be re-enrolled by the student.\n" +
                    "2. The prescribed period for all incomplete grades (1E, 1C, 1A, 1L, and 1R) is one full year. " +
                    "Thus, for example, on 1E grade incurred in the 2nd semester of 2000-2001 will expire at the end " +
                    "of the 2nd semester of 2001-2002, and thus has to be re-enrolled.\n" +
                    "3. every MIT term, the Office of the Registrar schedules specific periods for filling of application for completion " +
                    "in order to allow the offices involved to program their normal functions without being interrupted by continuous and " +
                    "ongoing filling of such applications.\n"+
                    "4. The Office of Registrar issues the application forms to complete.\n" +
                    "5. A grade of 1C may be removed by completing the required work and / or some additional work within the one year period " +
                    "prescribed for removal. The completion grade sheet shall be submitted to the Registrar by the Department Chairman themselves as early as possible.\n" +
                    "6. A grade of 1E may be removed by taking the examination arranged between the student and the Department Chairman after notifying the teacher concered. " +
                    "Examination papers shall be submitted together with the completion grade sheet to the REGISTRAR as early as possible. " +
                    " As a rule, no completion test outside the posted dates is allowed. In case of an exception, a fine may be imposed\n" +
                    "7. A grade of 1A may be removed by applying for completion during enrollment, attending classes regularly, participating in all types of examinations, and paying " +
                    "all fees during the semester and / or summer term.\n" +
                    "8. For 1R, a verification shall be made if the actual grades have already been submitted to the CHED. " +
                    "If not yet, submitted for the reason that the teacher has not yet forwarded to the REGISTRAR the student's grade, the proper application for " +
                    "completion shall be filed by the student, and certified copy of the class records as evidence of passing subject shall be submitted to the REGISTRAR " +
                    "office as early as possible\n" +
                    "9. All participants for completion of incomplete grades must be cleared of all old accounts before they are allowed to files such for completion.\n" +
                    "10. All other cases not covered by the precdure shall be referred to the MIT for evaluation and appropritate action on a case to case basis. ",
              

                 //V GRADUATION 
               Graduation ="V. GRADUATION" ,
               GraduationDescription ="a. Candidates for graduation are required to apply for evaluation of their records during the semester preceding their graduation in order that any deficiency may be attended to. Dates and deadines for evaluation are announced each semester Application Forms may be obtained from the Registrars's Office. ",
               OrderedListGraduation1 ="i. After a candidates records have been evaluated and cleared, he should file an application for graduation which is usually done a week after the " +
                                       "enrollment period. Application forms may be obtained from the Registrar Office.",
               OrderedListGraduation2 ="ii. Candidates for graduation are required to accomplish graduation clearance a day before final examination to clear them for financial property obligations. ",
               OrderedListGraduation3 ="iii. Fines are imposed on those who file their application late.",
               OrdereListGraduationB  ="b. Graduation Honors. Students who complete the courses with the following average computed on the basis of units shall receive the corresponding honors on graduation: ",
              /* OrderedListGraduationa ="a. Summa Cum Laude           1.00-1.25",
               OrderedListGraduationb ="b. Magna Cum Laude           1.26-1.5",
               OrderedListGraduationc ="c. Cum Laude\t                    1.51-1.75",
               OrderedListGraduationd ="d. With Honors              1.00-1.25 (for two-year cirrucula with full residence).",*/
               OrderedListAverage ="The average should be computed on the basis of the final grades and not on the Mid-Term grades.\n",

                //FEES AND PAYMENT
              Payments = "FEES AND PAYMENTS",
              Installment ="1. INSTALLMENT PAYMENT. Payment of fees may be made by installment provided 1/3 of the total fees are paid at the time of enrollment; a second 1/6 prior to the Pre-Mid examination, Third 1/6 prior to Mid-Term examination, fourth 1/6 prior to Pre-Final examination and the Final 1/6 pior to the Final Examination. ",
              Penalty ="2. PENALTY FOR LATE ENROLLMENT. Students enrolling after the second day of classes shall pay on additional registration fee.",
              Payment ="3. PAYMENT IN CASE OF WITHDRAWAL. A student who withdraws from any course shall be charge as follows: ",
              PaymentList ="•Within the first of classes  -  20% of total amount due for the term \n " +
              "•Within the second week  -  40% of the total amount due for the term \n " +
              "•After the second week of classes  - 100%",
              refund = "A refund of the account paid shall be maid if a student withdraws during the registrations period before the opening of classes. The matriculation fee, however. is non-refundable.",

                 //VII FEE ADJUSTMENT PRIVILEGES 
              FeeAdjustment ="VII. FEE ADJUSTMENT PRIVILEGES",
              FeeAdjustmentDescription ="TUITION FEE DISCOUNT PRIVILEGES FOR FACULTY MEMBERS AND ADMINISTRATIVE EMPLOYEES CHILDREN. Children of permanent faculty members and fulltime administrative employees enrolled in MIT on any level enjoy the following ; ",
              FeeAdjustmentList = " * First Child = 100% discount \n * Second Child = 75% discount \n * Third Child = 50% discount \n * Fourth Child = 25% discount\n",
              FamilyRelations ="FAMILY RELATIONS",
              FamilyRelationsDescription = "Members of the same family, i.e. brothers and sisters, enrolled in the elementary, secondary, or in any undergraduate college of the MIT granted a 25% discount on tuition fees.\n",
                 //VIII ACADEMIC PRIVILEGES AND SCHOLARSHIP PROGRAM

                AcademicPrevileges ="VIII. ACADEMIC PRIVILEGES AND SCHOLARSHIP PROGRAM", 
                AcademicDescripstion ="MIT grants academic privileges as a grant-in-aid to deserving students who excel in their studies.",
                AcademicList = "HIGH SCHOOL HONOR STUDENTS & ORPHANS",
                AcademicList1 = "‣ VALEDICTORIANS: to be granted a full-tuition privilege must come from a class of atleast 60 students. To Valedictorians from a class below 60 but not less than 25, a tuition privilege may be granted. ",
                AcademicList2 = "‣ SALUTATORIANS: to be granted a 3/4 tuition privilege must come from a class of atleast 60 students. To Salutatorians from a class below 60 but not less than 25, a 1/2 tuition privilege may be granted. ",
                AcademicList3 = "‣ SON OR DAUGHTER OF SHAHID). Daughter or Son of martyred MNLD combatants are entitled to 100% fee discount.",
                AcademicDescription2 = "For Honor Students, aforementioned privileges are given for Two Semesters only, provided that the grantee obtains a general average of 1.5 of better during the first semester and does not shift to another curriculum. ",
                AcademicDescription3 = "For the continuance of the privilege, applicants should be governed by rules for HONOR student with one more years residence except for orphans of war.",
                AcademicOrderlist1 = "• Students who ranked First Honorable Mention in a class of at least 60 students are granted a half-tuition privilege. ",
                AcademicOrderlist2 = "• All applicants for the above-cited privileges must:", 
                AcademicListA = "a. Present a letter from their High School Principal certifying their rank in the Honor Roll and Indicating the number of students in their class.\n"
                + "b. Not enjoy any other scholarship or privilege.\n"
                + "c. Not be engaged in any gainful employment.\n"
                + "d. Carry the normal load of their curriculum.\n"
                + "e. Not be liable for viilations of the Student's Code of Discipline.\n"
                + "f. For orphans of war, certification from community imam or MNLF officer. ",

                //HONOR STUDENTS WITH ONE OR MORE YEARS OF RESIDENCE
                HonorStudents = "HONOR STUDENTS WITH ONE MORE YEARS OF RESIDENCE",
                ToQualify = "To qualify for a tuition privilege:",
                HonorStudentsList = "• The student must be on the Honor List with a general weighted average of no less than\n 1.70 for he preceding semester. A full-tuition privilege will be granted to the first ranking \n student among at least 30 students in the same curriculum year.\n " +
                "• If there are more than 30 students in the curriculum year, the second ranking\n students will receive a half-tuition privilege\n " +
                "• In case of a tie, privilege will be equally divided among the places affected.\n " +
                "• In order to qualify for othe above-cited privilege, it is further required that the student must be in need of financial help, must be enjoying no other scholarship or privilege, must not be engaged in gainful employment, must carry the normal load of his curriculum, and must not have violated the Students Code of Discipline.\n " +
                "• In the event that any of the first two ranking students fail to qualify for the tuition privilege, the next ranking students on the Honor List will considered.\n",
                ApplicationForAcademicTitle = "APPLICATIONS FOR ACADEMIC PRIVILEGES. ",
                ApplicationForAcademic = "Application forms for academic privileges are to be obtained from and submitted to the Scholarship Office. All applications for privileges must be submitted within the official registration period, unless, otherwise specified.\n Applications for privileges submitted after the official registration period, unless, otherwise specified. Applications for privileges submitted after the Official registration period shall be deemed forfeited.",

            });

        }

    }
}
