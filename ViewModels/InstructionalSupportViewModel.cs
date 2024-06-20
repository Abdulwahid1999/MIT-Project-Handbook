using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.Input;
using HandbookSchool.Models;
using HandbookSchool.Services;
using HandbookSchool.Views.InstructionalSupportViews;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandbookSchool.ViewModels
{
    public partial class InstructionalSupportViewModel : BaseViewModel
    {
        public ObservableCollection<InstructionalSupportModel> InstructionModel { get; set; } = new ObservableCollection<InstructionalSupportModel>();
        public InstructionalSupportViewModel(INavigationServicesMIT navigationServices) : base(navigationServices)
        {
            AddInstructionalSupport();
        }

        [RelayCommand]
        public void NavigateToRegistrarOffice()
        {
            NavigateServices.NavigateToAsync(nameof(RegistrarOfficeViews));
        }

        [RelayCommand]
        public void NavigateToLibrarySystem()
        {
            NavigateServices.NavigateToAsync(nameof(LibrarySystemViews));
        }

        [RelayCommand]
        public void NavigateToSupportServices()
        {
            NavigateServices.NavigateToAsync(nameof(SupportServicesViews));
        }

       
        private void AddInstructionalSupport()
        {
            InstructionModel.Add(new InstructionalSupportModel
            {
              
                RegistrarOffice = "I. REGISTRAR'S OFFICE",
                Registrar1 = "1. The Office of the Registrar coordinates and controls activities involving student registration, transfer, and graduation. The officeis primarily responsible for the updating and safekeeping of student and faculty records as well as other vital documents and records in strict confidentialy. The office is also primarily responsible for the enforcement of the rules and regulations of the Commission On Higher Education (CHED) regarding admission and transfer, accreditation of subjects and units curricular load, sequence of subjects, etc. Inquires concerning, admissio, curricular offerings, and similar information are routinely refered to and handled by the Office of the Registrar.", 
                Registrar2 = "2. In order to carry out its mandated functions effectively, the Office of the Registrar is composed of two distinct sections: The Record Section and the Evaluation Section.",
                RegistrarA = "a. RECORD SECTION. The Record Section issues transfer crendentials, transcript of records, certification on academic documents needed or employment, travel abroad, scholarship grants, board / etc. it also handles applications for completion of incomplete grades(1C, 1E, 1A, & 1L) as well as verification of academic status of students and graduates. All students and faculty records are constantly updated and maintained in utmost confidentiality at the ARCHIEVES of the Office of the Registrar. Enrollment data and other related statistics may be requested from the records section in connection with student research and other academic activies.",
                RegistrarB = "b. EVALUATION SECTION. The Evaluation Sectionof the student academic records to determine credits earned for purposes of graduation." +       "The Section sees to it the CHED Rules and Regulations, as well as MIT policies, regarding sequence of subjects, course contents, semestral load, reisdence requirements, cross-erollment, etc. are enforced and properly compiled with. The evaluation section calendars the schedules for evaluation and application for graduation every term, and such schedules are always posted on the bulletin boards. Students are advised to apply for evaluation for their academic records at least one (1) semester / summer before their expected graduation term.",
                Registrar3 = "3. The Office of the Registrar coordinates with the Deans, the Department Chairman, and other Administrative Officers of MIT with regards to academic activies of students and with the college / department regarding revisions of curricular programs,offering of new courses, etc. Students who wish to verify their academic records are urged to see the Section. For cases not normally handled by the Sections are encouraged to see Registrar for proper guidance.\n",
              
                LibrarySystem = "II LIBRARY SYSTEM",
                LibrarySystemDescription = "SERVICES. In carrying out its information service function, the MIT library System offers\n" +
                "the following services;",
                LibrarySystemList = "Book Borrowing\n" +
                " • Library Newsletter \n " +
                "• Periodical Routing\n " +
                "• Reference and Information Service\n " +
                "• Reader Advisory Guidance\n " +
                "• Searching, Reserving and Stack Service\n " +
                "• Table of Contents Listing\n " +
                "• Multi Media ",

                GeneralRules = "GENERAL RULES ",
                GeneralRulesDescription = "In order to perform its function to the satisfaction of all its clientele, the MIT Library needs your cooperation in observing the following rules:    ",
                GeneralRulesList1 = "1. Observe SILENCE. idle conversation, loud laughter and other unnecessary noise disturb the clientele, must, therefore, be avoided. Talking the must be done in subdued tones. ",
                GeneralRulesList2 = "2. Eating, Smoking, and sleeping are not allowed in the Library.",
                GeneralRulesList3 = "3. Books in the reading areas should not be returned to their shelves but left on the tables\n " +
                "(to avoid their being misplaced). Exception: Individual volumes belonging to set, such as encyclopedias, should be returned to their proper places.",

                //use of identification cards 

                IdentificationCards = "Use of Identification Cards",
                IdentificationDescription = "A properly validated and countersigned Identificationt Card must be presented at the\n" +
                "counters whenever a library material is called for. This card is not transferable. For any library material drawn upon it, the owner to whom it made\n" +
                "out will be held responsible. A validated ID bears the initials of the Librarian and entitles the student to borrow library materials. Validation of ID cards is done during enrollment period.",
                IdentificationDescription1 = "When returning library at the counter, the student should get back his identification Card. The Library will assume no reponsibility for exchange for loss of ID after one has left the counter.",

                ControlPrecedures = "Control Precudures",
                ControlPreceduresDescription = "Every library clientele should present his ID upon entering the library. Attache cases, big bags and big envelopes must be left at the deposit counter of libary units maintaining such facility.\n" +
                " Do not leave handbags, pursues, and other valuables of the deposit counter, as it is unsupervised.",

                ControlPrecedures1 = "Upon leaving the Library, every user will be required to:",
                ControlPrecedures2 = "1. Open and show contents of the bag, folder, and / or big evelopes.\n" +
                                     "2. Show date due slips of every library material that he takes out.",

                //Rule of Borrowing of Materials

                RulesBorrowing = "Rules on Barrowing of Materials",
                RulesDescription = "1. Reference books (Ref) and Faculty Reference (FR) may be barrowed for two (2) days, renewable for another two (2d) days unless wanted by another user.\n" +
                                   "2. Stack (S) and Browsing (B) books may be borrowed for one (1) week renewable for another one (1) week, unless wanted by another patron.\n" +
                                   "3. Reserve (Res) books are issued for one hour at a time, of use within the room only. Extension for additional hours is granted unless there is prior request by another user.",
                RulesList = "The following types of materials are read only in the Library; they are not circulated for home use;" +
                            "a. General Reference (Gref) such as encyclopedias, dictionaries, atlases, and other types.\n" +
                            "b. Art Collection books (AC)\n" +
                            "c. Rare books (RB) and Rare Filipiniaina (Rfil) \n" +
                            "d. Thesis\n" +
                            "e. Periodicals\n" +
                            "f. Filipiniaina materials\n" +
                            "g. Microfilms",

                //Maximum number of books that may be borrowed at on time: 

                Maximum = "Maximum number of books that may be borrowed at on time:",
                MaximumDescription = "a. Students are allowed to borrow three (3) books at a time.\n" +
                                     "b. Bonafide MIT Faculty members are allowed to borrow for the length of one (1)\n" +
                                     "semester, two  reference books for every subject they teach, up to a maximum of three (3) library books not clearly connected with the subjects taught by the faculty member may be borrowed.\n",

                //Fines and other Penalties 
                Penalties = "FINES AND OTHER PENALTIES",
                PenaltiesDescription = "1. For overdue books the following fines imposed:",
                PenaltiesDescription1 ="1.1 Reference books, Stack/Browsing books - P3.00 /" +
                                       "day excluding Sundays and Holidays.\n" +
                                       "1.2 Books on Reserve -P3.00 for the first hour, P2.00 for the second and succeeding hours,\n" +
                                          "and P5.00 for each full day including Sundays and Holidays if these are service days.",
                PenaltiesDescription2 ="2. Fines must be paid to the Librarian within one(1) week from the date the fine was imposed.\n" +
                                          "Failure to pay within this period means submission of the borrower's name to the Cashier, with a minimum charge of ten pesos (10.00) each case.\n" +
                                       "3. When a book is lost, the borrower should immediately report the loss at the Librarian.\n" +
                                          "Otherwise if the book become overdue, the borrower will have to pay the overdue fine incurred until the day the loss reported, in addition to paying for the current replacement cost of the book.\n" +
                                       "4. Discipline. Students who fail to observe library regulations and procedures will be refered to the Director of Student Affairs for disciplinary action.\n" +
                                       "5. Stealing and mutilating books are serious offenses and will be dealt with more strictly:",
               PenaltiesDescription5 = "5.1 Anyone found guilty of stealing any library material will be liable to grave disciplinary action sanctioned by the Commission On Higher Education (CHED), depending on the gravity offense; in addition, he will be made to pay a fine P100.00 plus the current cost of acquiring a replacement. \n" +
                                       "5.2. Anyone found guilty of mutilating any Library material will be liable of grave disciplinary action sanctioned by the Comission On Higher Education (CHED), depending on the gravity offense; in addition, he will be made to pay  a fine of P100.00 plus the current cost of acquiring a replacement.\n",



                //III SUPPORT SERVICES 

                SupportServices ="III SUPPORT SERVICES",
                Dental = "A. DENTAL & MEDICAL",
                DentalList = "a. Dental / Medical examination for all first year and transferee students, providing them with an individual dental/ medical record as prescribed by the Department of Health, will be done.\n" +
                             "b. Rendering of emergency dental / medical treatment.\n" +
                             "c. Making of referrals and follow up of all referred to the student's family dentist.",
                StudentOrganization = "B. STUDENT ORGANIZATION",
                StudentOrganization1 = "The organizational activities are divided into six major areas of development to cater to different need of students. The following areas are: Spiritual, Physical, Socio-Cultural, Civic, Leadership Development, and Financial (Fund Raising) Areas.",
                StudentGeneralBehavior = "C. STUDENT GENERAL BEHAVIOR",
                StudentGeneralList = "a. Students shall at all times be neat, clean and descent in their dress. Slippers and rubber sandals must not be used in school.\n" +
                "b. Students shall attend their classes regularly and punctually." +
                "c. Students shall recite the classroom prayer with decorum and piety" +
                "d. Students shall at all refrain from committing acts that may embarrass the MIT or bring dishonor to her name.\n" +
                "e. Students shall regard fellow students, the administrative employees, and faculty members of the MIT with respect and charity. A faculty member or administrator may ask for the ID of any student who displays disrepectful behavior.\n" +
                "f. In case of any problem or complaint, the student is advised to talk the matter over with any faculty member, his Dean / Department Chairman, of a Guidance Counselor in the MIT for proper guidance and help.\n" +
                "g. Every student of MIT is equired to bring along his offial ID and to present it to any person in authority upon demand. The ID is required for the following:",

                Following = "• Admittance to the MIT premises and campuses;\n" +
                "• Use of MIT facilities and services like the library, recreational facilities\n" +
                "• Admittance to programs, convocations, lectures, film showing, etc\n",

                SchoolAttire = "D. SCHOOL ATTIRE",
                SchoolAttireList = "All students are required to wear the prescribed achool uniform during regular classes." +
                "During weekend, holidays, they are expected to wear decent civilian attire and NOT in any of the following;",
                Following2 = "a. Tube-style\n" +
                "b. Backless\n" +
                "c. Spaghetti straps\n" +
                "d. Narrow shoulder straps\n" +
                "e. Halter cut\n" +
                "f. Low cut necklines\n" +
                "g. Transparent attires with no proper under garments.\n",

                Notices = "E. NOTICES AND POSTERS",
                NoticesList1 = "• Clearance must be obtained from the Dean of Student Affairs for the posting of announcements or notices and for distribution of any reading materials within the preimses of MIT. The Dean of Student Affairs shall confiscate materials poster or distributed without prior permit and proper charges shall e filed against violators.",
                NoticesList2 = "• Only duly registered organizations are given the privileges to distribute leaflets, handbills, manifestor, and the like in the campuses.",
                NoticesList3 = "• Authorship of reading materials, including leaflets and handbills issues and circulated in the MIT, should be properly identified and stated therein, for the purpose of determining legal liability and reponsibility, under existing law.\n",

                Disciplinary = "F. DISCIPLINARY ACTION",
                Sanctions = "SANCTION. The following sanctions may be imposed for irreponsible behavior;",
                SanctionsList = "a. Previous ecord of the student\n" +
                "b. Gravity of the offense\n " +
                "c. Character and position of the aggrieved person\n" +
                "d. Established precedents\n" +
                "e. Other extenuating circumatances as deemed proper and necessary by the Disciplinary Board.",
                Definitions = "DEFINITIONS AND TYPES OF OFFENSES",
                DefinitionsList = "• Drunkennes and Drug Abuse\n" +
                "• Carrying deadly weapon (bladed, sharpened letter openeer, fire-arms, etc.) and threating to use such weapons (intention to harm somebody).\n" +
                "• Molesting and committing and vandalistic.\n" +
                "• Vulgar, and indecent acts (committed against co-students, emploees and faculty members) destroying MIT properlty.",
                Following3 = "- tearing off or defacing any library book, magazine, or periodical\n" +
                "- writing of drawing on the walls and pieces of furniture\n" +
                "- unauthorized removal of official notices and posters from the bulletin boards and similar.\n" +
                "- Destroying plants or flower pots\n" +
                "- Destroying chairs and tables",
                DefinitionsList2 = "• Forgery, tampering, and stealing records and papers alterations or misuse of MIT documents, records, and credentials;",
                Following4 = "- plagiarism in connection with academic work, ID's admission slips, and other official receipts and records.\n" +
                "- Lending one's ID to another and the willful possession of two or more ID's\n" +
                "- Representing or wearing / using any uniform, insignia or other indentifying symbols of the MIT without proper authority.",
                DefinitionsList3 = "• Immoral acts, (petting, neckling, orgies, and other indecent acts offensive to public laws and islamic teaching).\n" +
                "• Public or Campus Disturbance.",

                //---
                Discipline = "G. DISCIPLINE AND ITS ENFORCEMENT",
                Purpose = "1. PURPOSE",
                PurposeDescription1 = "1.1 The proper functioning of any social system requires some regulations to govern the\n" +
                "behavior of its members. This is no less true of school system. For a school system to function proerly, the conduct of students must conform to conditions that are conducive to order and learning.",
                PurposeDescription2 = "1.2 The MIT adhers to the modern concept of discipline, which is based on a rational approach. The students are made to understand why certain modes of behavior are to observed. At the same time, it recognized the inherent dignity and rights of every individual.",
                PurposeDescription3 = "1.3 All students, therefore, are expected to conduct themselves in accordance with the required standard of propriety and decency paracticed in civilzed society.\n" +
                "in other words, they are presumed to eave as ladies and gentleman, and they, in turn, will be so treated.\n",
                PurposeDescription4 = "1.4 The MIT expects all students to obey its regulation. It will not hesitate to punish erring students to preserve the peace and order in the campus.",

                Penal = "2. PENALTIES",
                Penal2 = "The MIT prescribes three categories of administrative disciplinary penalties which may be imposed upon erring students. These pernalties which may be imposed upon erring students. These penalties are equal to the nature and gravity of the offense.",
                Suspension = "A. Suspension. A student who has committed a minor offense may be suspended for a period not exceeding 20% of the prescribed number of school days without the approval of CHED or as deemded appropriate by the College Board of Discipline.",
                Dismissal = "B. Dismissal. A student who has commited a major offense may be dismissed or dropped from the roll of the school.",
                Explusion = "C. Expulsion. Expulsion is looked upon as an extreme form of penalty. The offender is barred from enrolling an all public and private schools. To be valid and effective, expulsion requires the prior approval of CHED.",

                OffensesPunishable = "3. OFFENSES PUNISHABLE BY SUSPENSION",
                OffensesDescription = "The following are punishable by suspension in varying lengths of time, depending on the nature and gravity of the offense committed.",
                OffensesList = "1. Doing an act that causes disruption in one's class, or that of another, or any academic activity or school function.\n" +
                "2. Entering a class, or breaking into a academic activity or school function without permission.\n" +
                "3. Not wearing ID or improperly displaying it.\n" +
                "4. Coming to the MIT under the influence of liquor or in a state of intoxication.\n" +
                "5. Bringing to or drinking alcoholic beverage on the campus or smelling of liquor.\n" +
                "6. Smoking in the classroom, library, laboratory and other restricted areas. \n" +
                "7. Dressing inappropriately (Refer to section on dress code.)\n" +
                "8. Deliberate utterance of obscene and vulgar words.\n" +
                "9. Deliberate disruption of a class or meeting with noise or mischief\n" +
                "10. Repeated refusal or by pernicious designs to wear the prescribed MIT uniform.\n" +
                "11. Excessive public displa of affection such as kissing on the lips, holding or caressing of private parts, sitting on the lap of the opposite sex, and other such acts hthat are offensive to the sensibilities of the other members of the community\n" +
                "12. Use of classrooms and other school facilities for any purpose without ay reservation or permission from proper authority.\n" +
                "13. Repeated violation of any of the aforementioned provisions will immediately be classified as or elevated to a serious offense under section.",

                //Serious Offenses Punishable 
                SeriousOffenses = "4. SERIOUS OFFENSES PUNISHABLE BY DISMISSAL",
                SeriousDescription = "The following offenses classified a serious are punishable by dismissal or dropping from the roll.",
                SeriousList = "1. Any form of cheating on an examination which may include talking, whispering, using cheating materials, looking at the paper of others, making unnecessary noise, or any other suspicious behavior or any combination of these actions during an examination. These are sufficient grounds\n" +
                "to establish a case of cheating and to pass the burden of justifying the act to the student\n" +
                "2. Plagiarism\n" +
                "3. Any form of vandalism which may include writing or drawing on walls, pieces of furniture including textbooks or any other property of the MIT.\n" +
                "4. Possessing or exploding firecrackers in campus.\n" +
                "5. Hazing. (Hazing is any act that injures, degrades, or disgraces fellow student or an outsider, even in mere conspiracy. A harmful act that includes, but is not limited to, unwarranted initiations or admissions to fraternities and other unrecognized student organization).\n" +
                "6. Theft or Stealing or any attempt thereof.\n" +
                "7. Gross disrescpect to teacher, other personnel and fellow students.\n" +
                "8. Threating someone with infliction upon his/her person, honor, property or any act mounting to a crime\n" +
                "9. Bringing to campus pornographic picture or literature or any related materials.\n" +
                "10. Gross dishonesty.\n" +
                "11. Gross Immorality (e.g abortion, prostituion, illicit relationships).\n" +
                "12. Any form of gambling in campus or art off-campus functions.\n" +
                "13. Erasig, removing, tampering or destroying of official notices and posters\n" +
                "14. Itentionally making a false statement or conducting fraudulent acts or deception in connection with anything that has to do with the MIT.\n" +
                "15. Fighting in campus or at MIT functions off-campus.\n" +
                "16. Inflicting physical and moral injuries\n" +
                "17. Borrowing, lending or tampering of ID.\n" +
                "18. Doliberate disrespect of fellow student\n" +
                "19. Organizing, recruiting or meeting of Greek-letter organizations or other secret societies of the same nature.\n" +
                "20. Any student who knowingly and by overt act becomes a member, or remains a member of a recruit prospective members, for any organization or society, whether\n" +
                "open or secretm which requires or tolerates acts of violence or affronts to personal dignity in any form or any person as part of initiation rights or of other organization or siciety activities, or which requires or tolerates such as acts or affronts as part of initiation rights or of other organization or society activities, shall be dismissed from the school or denied re-enrollment\n" +
                "21. Misuse and / or abuse of Information Technology (IT) resource: accessing a school computer server, workstation, associated peripheral and / or network without proper authorization. These include but not limited the following.\n" +
                "22. Using the School computers, their associated and networks without written authorization.\n" +
                "23. Disclosing password or similar information that allows access to the school computers, workstations, hubs, switches and other associated peripherals and networks withtout written authorization. \n" +
                "24. Altering information such as changing password of someone elese's account, etc.\n" +
                "25. Damaging or destroying information (deleting someone else's file, etc.)\n" +
                "26. Using someone ele's account and / or sending offensive e-mail.\n" +
                "27. Introducing computer viruses or anything that endagers the security of the School computer networks, workstation and users.\n" +
                "28. Downloading and / or uploading materials which would violate copyright laws or inconsistent with the School vision-mission.\n" +
                "29. Installing software in School computers without written authorization from the Computer Center.\n" +
                "Changing the configuration of installed sofware, operating system and / or hardware without proper authorization.\n" +
                "31. Participating any action which would degrade the performance of the School IT resources. This includes but is not limited to Denial of Service Attacks launched from off-campus IT resources.\n" +
                "" +
                "32. Repeated violation of any of the aforementioned provisions will automatically be classified as or elevated to a very serious offense under section 5.",

                //VERY SERIOUS OFFENSES PUNISHABLE BY EXPULSION

                VerySerious = "5. VERY SERIOUS OFFENSES PUNISHABLE BY EXPULSION",
                VerySeriousDescription = "The following offenses which are classified most serious are punishable by expulsion which bars an individual enrolling in any publis and private schools.",
                VerySeriousList = "1. Possessing and using deadly weapons and explosive in the campus.\n" +
                "2. Engaing in suversive acts as defined by national laws\n" +
                "3. Possessing, distributing, pedding or using marijuana or an other dangerous / banned drugs. \n" +
                "4. Possessing, distributing, or using leaked examination papers and questions\n" +
                "5. Engaing in hooliganism\n" +
                "6. Threatening and or assaulting a teacher, School Personnel or Student on or off\n" +
                "7. Instigating, leading or participating in an unlawful activity leading to stppage of classes.\n" +
                "8. Unlawfully preventing or threatening faculty members, or other School Personnel or Students from attending classes or entering SChool premises.\n" +
                "9. Forging or tampering official School records or transfer from, or knowingly securing, using transfer credential under false pretenses.",

                //SCHOOL BOARD OF DISCIPLINE
                SchoolBoard = "6. SCHOOL BOARD OF DISCIPLINE",
                SchoolBoardList = "a. The Board of Discipline is empowered to hear, try , and reder decisions on disciplinary cases brough to it by the Dean of Student Affairs and upon the approval of the School Director.\n" +
                "b. The Board is composed of the respective Head of the Colleges (members comprising the four colleges), the Dean of Student Affairs, Representative the Faculty, Student Council, Parents and A Guidance Counselor.\n" +
                "c. The nine members in the Board, Head of Colleges and 5 representatives are the oly ones who have the voting power, the Presiding Officer may vote in case of tie.\n" +
                "d. The School Director shall apoint a Hearing Officer to the Board to act as the Presiding Officer or Hearing Officer depending on what College the student to be investigated belongs.\n" +
                "e. It shall the duty of the HO to present to the Board each case to be investigated, including the student/students charged, the witnessses, and all papers, documents, and other evidence in his custody.\n" +
                "f. The student to be investigated shall also be referred to the Fuidance Counselor after initial investigation made by HO. There shall be case conference where counclors and members of the Voard shall have an in depth presentation of the party's profile.\n" +
                "The HO  shall call for the case conference to be attended by the year level counselor and the Members of the Board. During the actual trail of the case, the counselor will not particiapte actively in the hearing and deliberation.\n" +
                "g. The hearing shall be summary in nature and shall be conducted according to due process of law. The students / students charged shall have the right to present witness and / or evidence in his / her favor.\n" +
                "Except in very rare cases, when so warranted and upon the discretion of the board, the services of counsels are dispensed with in conformity with the summary nature of the invetigation.\n" +
                "h. Viva voce shall be deemed as the decision of the Board.\n" +
                "i. The Boards decision shall be final.\n" +
                "j. Students under investigation pending its termination shall be allowed to remain in the School and to attend classes without prejudice to their immediate exclusion from the School oremises when, in the judgement of the Board, the security of persons or of the SChool is not in danger.\n" +
                "k. Confidentiality of the preceedings of the case must be maintained at all time / cost. ",

                //JURISDICTION

                Jurisdiction = "7. JURISDICTION",
                JurisdictionList = "7.1 The members of the Board of Discipline properly convened shall take cognizance of all complaints, written or verbal try cases involving serious offenses committed by students, They are consulted, either indivudally or as a group.\n" +
                "7.1.1 Offense must be reported to the OSA. Written / Verbal complaints must be signed or attested by the complainant.\n" +
                "7.1.2. The HO shall call the person concerned for investigation. Both the offender and the complainant will be asked to make statements on the matter under investigation.\n" +
                "7.1.3. All minor offenses shall be taken cognizance of and decided b the HO in consultation with the School Director and some members of the Disciplinary Board (The offending party may not be allowed to enter the campus until the parent / guardian is brought in for consultation with HO.)\n" +
                "7.2 Major offenses:",
                JurisdictionList2 = "7.2.1 The OSA conducts an investigation of the reported case and summons the parent of the offending party right away.\n" +
                "7.2.2 A specific day is set for the Disciplinary Board to try the case, and the concerned student / students is / are notified, verbally or in writing, of the hearing.\n" +
                "7.2.3 The Board renders a decision.\n" +
                "7.2.4 The School Director informs, writing, the parent of the party conccerned of the Board's decision on the case.\n" +
                "7.2.5 Written copies of the decision are filed with the office of the President, the Dean of Student Affairs, the College Registrar, the Finance Office (if punishment is dismissal), the Dean for Admission and Guidance Office.\n" +
                "7.2.6 Appeals should be forwarded to the School Director of the Colleges for proper actions.",

                //PROCEDURE FOR THE HEARING OF A CASE

                Procedure = "8. PROCEDURE FOR THE HEARING OF A CASE",
                ProcedureDescription1 = "The HO calls the roll by presenting the offending party, the witness, and others to the members of the Board. Technical rules of evidence as approved by the court in proceedings. in law or equity, shall not be strictly observed, however, the principles of due process shall have mandatory application.\n",
                ProcedureDescription2 = "The HO presents the entire case per his investigation to the Board. The members of the Board start the questioning session, agter which the floor is given to the defendant for comments or countervailing proofs.\n",
                ProcedureDescription3 = "N.B. Disciplinary hearing cannot be postponed, except for highly justifiable reasons ruled by the Board alone. The Board continues the hearing even in the avsence of the complainant, but the presence of the offending party shall be indispensable unless such right has been waived. Such waiver, however, shall be presumed when the repondent failed to appear despite the notice served. \n"

            });

        }
    }
}
