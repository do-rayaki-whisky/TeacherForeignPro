using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMiCZ;

namespace TeacherForeignPro
{
    public partial class Form_Main : Form
    {
        ComboBoxConvert ComboConv = new ComboBoxConvert();
        TSchool Tschool = new TSchool(); /* Class ตาราง TSchool */
        THistory THistory = new THistory();
        TDocument TDocument = new TDocument();
        TPassportExp TPassportExp = new TPassportExp();
        TWorkplace TWorkplace = new TWorkplace();
        public Form_Main()
        {
            InitializeComponent();
            /* Tab 1 */
            _NewTeacher(0);

            /* Tab 6 */
            T6_INPUT_Choose.SelectedIndex = 0;
        }

        public void _SelectData(string _PassportID)
        {
            THistory.SelectTeacher(_PassportID);
            this.T1_INPUT_HisID.Text = THistory.HisID;
            //this.T1_INPUT_Passport.Text = THistory.Passport;
            this.T1_INPUT_Th_Title.SelectedIndex = ComboConv.ConvTitleToIndex(THistory.Th_Title);
            this.T1_INPUT_Th_Name.Text = THistory.Th_Name;
            this.T1_INPUT_Th_Lastname.Text = THistory.Th_Lastname;
            this.T1_INPUT_En_Title.SelectedIndex = ComboConv.ConvTitleToIndex(THistory.En_Title);
            this.T1_INPUT_En_Name.Text = THistory.En_Name;
            this.T1_INPUT_EN_Lastname.Text = THistory.En_Lastname;
            this.T1_INPUT_Sex.SelectedIndex = ComboConv.ConvSexToIndex(THistory.Sex);
            this.T1_INPUT_Nationality.Text = THistory.Nationality;
            this.T1_INPUT_Nationality_EN.Text = THistory.Nationality_En;
            this.T1_INPUT_Date_Birth.Text = THistory.Date_Birth;
            this.T1_INPUT_Month_Birth.SelectedIndex = ComboConv.ConvMonthToIndex(THistory.Month_Birth);
            //this.T1_INPUT_Month_Birth_En.Text = THistory.Month_Birth_En;
            this.T1_INPUT_Year_Birth.Text = THistory.Year_Birth;
            //this.T1_INPUT_Year_Birth_En.Text = THistory.Year_Birth_En;
            this.T1_INPUT_Age.Text = THistory.Age;
            this.T1_INPUT_Degree.Text = THistory.Degree;
            this.T1_INPUT_Year_Recievied.Text = THistory.Year_Received;
            this.T1_INPUT_Name_institute.Text = THistory.Name_Institute;
            this.T1_INPUT_Country_Edu.Text = THistory.Country_Edu;
            this.T1_INPUT_Stuffed_ID.Text = THistory.Stuffed_ID;
            this.T1_INPUT_StuffedDate.Text = THistory.StuffedDate;
            this.T1_INPUT_StuffedMonth.SelectedIndex = ComboConv.ConvMonthToIndex(THistory.StuffedMonth);
            //this.T1_INPUT_StuffedMonth_En.Text = THistory.StuffedMonth_En;
            this.T1_INPUT_StuffedYear.Text = THistory.StuffedYear;
            //this.T1_INPUT_StuffedYear_En.Text = THistory.StuffedYear_En;
            this.T1_INPUT_DateStarted.Text = THistory.DateStarted;
            this.T1_INPUT_MonthStarted.SelectedIndex = ComboConv.ConvMonthToIndex(THistory.MonthStarted);
            //this.T1_INPUT_MonthStarted_En.Text = THistory.MonthStarted_En;
            this.T1_INPUT_YearStarted.Text = THistory.YearStarted;
            //this.T1_INPUT_YearStarted_En.Text = THistory.YearStarted_En;
            this.T1_INPUT_Phone.Text = THistory.Phone;
            this.T1_INPUT_Pic.ImageLocation = THistory.ImageLocation(THistory.Pic);
            this.T1_INPUT_blood_Grp.SelectedIndex = ComboConv.ConvBloodToIndex(THistory.blood_Grp);
            //MessageBox.Show((THistory.blood_Grp).ToString());

            TDocument.Passport = T1_INPUT_Passport.Text.Trim();
            if (TDocument.SelectTeacher() == true)
            {   
                this.T2_INPUT_Passport.Text = TDocument.Passport;
                this.T2_INPUT_PassportDate.Text = TDocument.PassportDate;
                this.T2_INPUT_PassportMonth.SelectedIndex = ComboConv.ConvMonthToIndex(TDocument.PassportMonth);
                this.T2_INPUT_PassportYear.Text = TDocument.PassportYear;
                this.T2_INPUT_PassportIssuedAt.Text = TDocument.PassportIssuedAt;
                this.T2_INPUT_KindVISA.Text = TDocument.KindVISA;
                this.T2_INPUT_VisaNo.Text = TDocument.VisaNo;
                this.T2_INPUT_VisaDate.Text = TDocument.VisaDate;
                this.T2_INPUT_VisaMonth.SelectedIndex = ComboConv.ConvMonthToIndex(TDocument.VisaMonth);
                this.T2_INPUT_VisaYear.Text = TDocument.VisaYear;
                this.T2_INPUT_VisaIssuedAt.Text = TDocument.VisaIssuedAt;
                this.T2_INPUT_ReachedDate.Text = TDocument.ReachedDate;
                this.T2_INPUT_ReachedMonth.SelectedIndex = ComboConv.ConvMonthToIndex(TDocument.ReachedMonth);
                this.T2_INPUT_ReachedYear.Text = TDocument.ReachedYear;
                this.T2_INPUT_AllowedAt.Text = TDocument.AllowedAt;
                this.T2_INPUT_DefineYear.Text = TDocument.DefineYear;
                this.T2_INPUT_DefineMonth.Text = TDocument.DefineMonth;
                this.T2_INPUT_DefineDay.Text = TDocument.DefineDay;
                this.T2_INPUT_DueDate.Text = TDocument.DueDate;
                this.T2_INPUT_DueMonth.SelectedIndex = ComboConv.ConvMonthToIndex(TDocument.DueMonth);
                this.T2_INPUT_DueYear.Text = TDocument.DueYear;
                this.T2_INPUT_Renew_Date.Text = TDocument.Renew_Date;
                this.T2_INPUT_Renew_Month.SelectedIndex = ComboConv.ConvMonthToIndex(TDocument.Renew_Month);
                this.T2_INPUT_Renew_Year.Text = TDocument.Renew_Year;
            }

            TPassportExp.Passport = T1_INPUT_Passport.Text.Trim();
            if (TPassportExp.SelectTeacher() == true)
            {
                this.T3_INPUT_PassportExpDate.Text = TPassportExp.PassportExpDate;
                this.T3_INPUT_PassportExpMonth.SelectedIndex = ComboConv.ConvMonthToIndex(TPassportExp.PassportExpMonth);
                this.T3_INPUT_PassportExpYear.Text = TPassportExp.PassportExpYear;
                this.T3_INPUT_ContractDate.Text = TPassportExp.ContractDate;
                this.T3_INPUT_ContractMonth.SelectedIndex = ComboConv.ConvMonthToIndex(TPassportExp.ContractMonth);
                this.T3_INPUT_ContractYear.Text = TPassportExp.ContractYear;
            }

            TWorkplace.Passport = T1_INPUT_Passport.Text.Trim();
            if(TWorkplace.SelectTeacher() == true){
                this.T4_INPUT_WorkpermitNo.Text = TWorkplace.WorkpermitNo;
                this.T4_INPUT_DateIssue.Text = TWorkplace.DateIssue;
                this.T4_INPUT_MonthIssue.SelectedIndex = ComboConv.ConvMonthToIndex(TWorkplace.MonthIssue);
                this.T4_INPUT_YearIssue.Text = TWorkplace.YearIssue;
                this.T4_INPUT_PlaceIssue.Text = TWorkplace.PlaceIssue;
                this.T4_INPUT_PeriodPermission.Text = TWorkplace.PeriodPermission;
                this.T4_INPUT_ExpireOn.Text = TWorkplace.ExpireOn;
                this.T4_INPUT_ExpireMonth.SelectedIndex = ComboConv.ConvMonthToIndex(TWorkplace.ExpireMonth);
                this.T4_INPUT_ExpireYear.Text = TWorkplace.ExpireYear;
                this.T4_INPUT_PerLicenseDate.Text = TWorkplace.PerLicenseDate;
                this.T4_INPUT_PerLicenseMonth.SelectedIndex = ComboConv.ConvMonthToIndex(TWorkplace.PerLicenseMonth);
                this.T4_INPUT_PerLicenseYear.Text = TWorkplace.PerLicenseYear;
                this.T4_INPUT_ThroughDate.Text = TWorkplace.ThroughDate;
                this.T4_INPUT_ThroughMonth.SelectedIndex = ComboConv.ConvMonthToIndex(TWorkplace.ThroughMonth);
                this.T4_INPUT_ThroughYear.Text = TWorkplace.ThroughYear;
                this.T4_INPUT_Profession.Text = TWorkplace.Profession;
                this.T4_INPUT_JobDescription.Text = TWorkplace.JobDescription;
                this.T4_INPUT_Wage.Text = TWorkplace.Wage;
                this.T4_INPUT_Bossname.Text = TWorkplace.Bossname;
                this.T4_INPUT_School.Text = TWorkplace.School;
                this.T4_INPUT_HomeNo.Text = TWorkplace.HomeNo;
                this.T4_INPUT_Village.Text = TWorkplace.Village;
                this.T4_INPUT_Lane.Text = TWorkplace.Lane;
                this.T4_INPUT_Road.Text = TWorkplace.Road;
                this.T4_INPUT_Tambol.Text = TWorkplace.Tambol;
                this.T4_INPUT_Amphur.Text = TWorkplace.Amphur;
                this.T4_INPUT_Province.Text = TWorkplace.Province;
                this.T4_INPUT_PostCode.Text = TWorkplace.PostCode;
                this.T4_INPUT_Phone.Text = TWorkplace.Phone;
                this.T4_INPUT_Employment_Year.Text = TWorkplace.Employment_Year;
                this.T4_INPUT_Employment_Month.Text = TWorkplace.Employment_Month;
                this.T4_INPUT_Employment_Day.Text = TWorkplace.Employment_Day;
                this.T4_INPUT_Contract.Text = TWorkplace.Contract;
            }
        }

        public void _NewTeacher()
        {
            THistory.NewTeacher();
            TDocument.NewTeacher();
            TPassportExp.NewTeacher();
            TWorkplace.NewTeacher();
        }

        public void _NewTeacher(int _Mode)
        {
            // _Mode ใส่อะไรก้ได้ เพื่อล้างค่าในฟอร์ม
            THistory.NewTeacher();
            TDocument.NewTeacher();
            TPassportExp.NewTeacher();
            TWorkplace.NewTeacher();

            this.T1_INPUT_HisID.Text = THistory.HisID;
            this.T1_INPUT_Passport.Text = THistory.Passport;
            this.T1_INPUT_Th_Title.SelectedIndex = ComboConv.ConvTitleToIndex(THistory.Th_Title);
            this.T1_INPUT_Th_Name.Text = THistory.Th_Name;
            this.T1_INPUT_Th_Lastname.Text = THistory.Th_Lastname;
            this.T1_INPUT_En_Title.SelectedIndex = ComboConv.ConvTitleToIndex(THistory.En_Title);
            this.T1_INPUT_En_Name.Text = THistory.En_Name;
            this.T1_INPUT_EN_Lastname.Text = THistory.En_Lastname;
            this.T1_INPUT_Sex.SelectedIndex = ComboConv.ConvSexToIndex(THistory.Sex);
            this.T1_INPUT_Nationality.Text = THistory.Nationality;
            this.T1_INPUT_Nationality_EN.Text = THistory.Nationality_En;
            this.T1_INPUT_Date_Birth.Text = THistory.Date_Birth;
            this.T1_INPUT_Month_Birth.SelectedIndex = ComboConv.ConvMonthToIndex(THistory.Month_Birth);
            this.T1_INPUT_Month_Birth_En.Text = THistory.Month_Birth_En;
            this.T1_INPUT_Year_Birth.Text = THistory.Year_Birth;
            this.T1_INPUT_Year_Birth_En.Text = THistory.Year_Birth_En;
            this.T1_INPUT_Age.Text = THistory.Age;
            this.T1_INPUT_Degree.Text = THistory.Degree;
            this.T1_INPUT_Year_Recievied.Text = THistory.Year_Received;
            this.T1_INPUT_Name_institute.Text = THistory.Name_Institute;
            this.T1_INPUT_Country_Edu.Text = THistory.Country_Edu;
            this.T1_INPUT_Stuffed_ID.Text = THistory.Stuffed_ID;
            this.T1_INPUT_StuffedDate.Text = THistory.StuffedDate;
            this.T1_INPUT_StuffedMonth.SelectedIndex = ComboConv.ConvMonthToIndex(THistory.StuffedMonth);
            this.T1_INPUT_StuffedMonth_En.Text = THistory.StuffedMonth_En;
            this.T1_INPUT_StuffedYear.Text = THistory.StuffedYear;
            this.T1_INPUT_StuffedYear_En.Text = THistory.StuffedYear_En;
            this.T1_INPUT_DateStarted.Text = THistory.DateStarted;
            this.T1_INPUT_MonthStarted.SelectedIndex = ComboConv.ConvMonthToIndex(THistory.MonthStarted);
            this.T1_INPUT_MonthStarted_En.Text = THistory.MonthStarted_En;
            this.T1_INPUT_YearStarted.Text = THistory.YearStarted;
            this.T1_INPUT_YearStarted_En.Text = THistory.YearStarted_En;
            this.T1_INPUT_Phone.Text = THistory.Phone;
            this.T1_INPUT_Pic.ImageLocation = THistory.ImageLocation(THistory.Pic);
            this.T1_INPUT_blood_Grp.SelectedIndex = ComboConv.ConvBloodToIndex(THistory.blood_Grp);

            this.T2_INPUT_Passport.Text = TDocument.Passport;
            this.T2_INPUT_PassportDate.Text = TDocument.PassportDate;
            this.T2_INPUT_PassportMonth.SelectedIndex = ComboConv.ConvMonthToIndex(TDocument.PassportMonth);
            this.T2_INPUT_PassportYear.Text = TDocument.PassportYear;
            this.T2_INPUT_PassportIssuedAt.Text = TDocument.PassportIssuedAt;
            this.T2_INPUT_KindVISA.Text = TDocument.KindVISA;
            this.T2_INPUT_VisaNo.Text = TDocument.VisaNo;
            this.T2_INPUT_VisaDate.Text = TDocument.VisaDate;
            this.T2_INPUT_VisaMonth.SelectedIndex = ComboConv.ConvMonthToIndex(TDocument.VisaMonth);
            this.T2_INPUT_VisaYear.Text = TDocument.VisaYear;
            this.T2_INPUT_VisaIssuedAt.Text = TDocument.VisaIssuedAt;
            this.T2_INPUT_ReachedDate.Text = TDocument.ReachedDate;
            this.T2_INPUT_ReachedMonth.SelectedIndex = ComboConv.ConvMonthToIndex(TDocument.ReachedMonth);
            this.T2_INPUT_ReachedYear.Text = TDocument.ReachedYear;
            this.T2_INPUT_AllowedAt.Text = TDocument.AllowedAt;
            this.T2_INPUT_DefineYear.Text = TDocument.DefineYear;
            this.T2_INPUT_DefineMonth.Text = TDocument.DefineMonth;
            this.T2_INPUT_DefineDay.Text = TDocument.DefineDay;
            this.T2_INPUT_DueDate.Text = TDocument.DueDate;
            this.T2_INPUT_DueMonth.SelectedIndex = ComboConv.ConvMonthToIndex(TDocument.DueMonth);
            this.T2_INPUT_DueYear.Text = TDocument.DueYear;
            this.T2_INPUT_Renew_Date.Text = TDocument.Renew_Date;
            this.T2_INPUT_Renew_Month.SelectedIndex = ComboConv.ConvMonthToIndex(TDocument.Renew_Month);
            this.T2_INPUT_Renew_Year.Text = TDocument.Renew_Year;

            this.T3_INPUT_PassportExpDate.Text = TPassportExp.PassportExpDate;
            this.T3_INPUT_PassportExpMonth.SelectedIndex = ComboConv.ConvMonthToIndex(TPassportExp.PassportExpMonth);
            this.T3_INPUT_PassportExpYear.Text = TPassportExp.PassportExpYear;
            this.T3_INPUT_ContractDate.Text = TPassportExp.ContractDate;
            this.T3_INPUT_ContractMonth.SelectedIndex = ComboConv.ConvMonthToIndex(TPassportExp.ContractMonth);
            this.T3_INPUT_ContractYear.Text = TPassportExp.ContractYear;

            this.T4_INPUT_WorkpermitNo.Text = TWorkplace.WorkpermitNo;
            this.T4_INPUT_DateIssue.Text = TWorkplace.DateIssue;
            this.T4_INPUT_MonthIssue.SelectedIndex = ComboConv.ConvMonthToIndex(TWorkplace.MonthIssue);
            this.T4_INPUT_YearIssue.Text = TWorkplace.YearIssue;
            this.T4_INPUT_PlaceIssue.Text = TWorkplace.PlaceIssue;
            this.T4_INPUT_PeriodPermission.Text = TWorkplace.PeriodPermission;
            this.T4_INPUT_ExpireOn.Text = TWorkplace.ExpireOn;
            this.T4_INPUT_ExpireMonth.SelectedIndex = ComboConv.ConvMonthToIndex(TWorkplace.ExpireMonth);
            this.T4_INPUT_ExpireYear.Text = TWorkplace.ExpireYear;
            this.T4_INPUT_PerLicenseDate.Text = TWorkplace.PerLicenseDate;
            this.T4_INPUT_PerLicenseMonth.SelectedIndex = ComboConv.ConvMonthToIndex(TWorkplace.PerLicenseMonth);
            this.T4_INPUT_PerLicenseYear.Text = TWorkplace.PerLicenseYear;
            this.T4_INPUT_ThroughDate.Text = TWorkplace.ThroughDate;
            this.T4_INPUT_ThroughMonth.SelectedIndex = ComboConv.ConvMonthToIndex(TWorkplace.ThroughMonth);
            this.T4_INPUT_ThroughYear.Text = TWorkplace.ThroughYear;
            this.T4_INPUT_Profession.Text = TWorkplace.Profession;
            this.T4_INPUT_JobDescription.Text = TWorkplace.JobDescription;
            this.T4_INPUT_Wage.Text = TWorkplace.Wage;
            this.T4_INPUT_Bossname.Text = TWorkplace.Bossname;
            this.T4_INPUT_School.Text = TWorkplace.School;
            this.T4_INPUT_HomeNo.Text = TWorkplace.HomeNo;
            this.T4_INPUT_Village.Text = TWorkplace.Village;
            this.T4_INPUT_Lane.Text = TWorkplace.Lane;
            this.T4_INPUT_Road.Text = TWorkplace.Road;
            this.T4_INPUT_Tambol.Text = TWorkplace.Tambol;
            this.T4_INPUT_Amphur.Text = TWorkplace.Amphur;
            this.T4_INPUT_Province.Text = TWorkplace.Province;
            this.T4_INPUT_PostCode.Text = TWorkplace.PostCode;
            this.T4_INPUT_Phone.Text = TWorkplace.Phone;
            this.T4_INPUT_Employment_Year.Text = TWorkplace.Employment_Year;
            this.T4_INPUT_Employment_Month.Text = TWorkplace.Employment_Month;
            this.T4_INPUT_Employment_Day.Text = TWorkplace.Employment_Day;
            this.T4_INPUT_Contract.Text = TWorkplace.Contract;

            
        }

        public bool _AssignData()
        {
            bool IsSuccess = false;
            
            if ((T1_INPUT_HisID.Text.Trim() != string.Empty) && (T1_INPUT_Passport.Text.Trim() != string.Empty))
            {
                /* Tab 1 */
                THistory.HisID = this.T1_INPUT_HisID.Text;
                THistory.Passport = this.T1_INPUT_Passport.Text.Trim().ToUpper();
                THistory.Th_Title = this.T1_INPUT_Th_Title.SelectedItem.ToString();
                THistory.Th_Name = this.T1_INPUT_Th_Name.Text;
                THistory.Th_Lastname = this.T1_INPUT_Th_Lastname.Text;
                THistory.En_Title = this.T1_INPUT_En_Title.SelectedItem.ToString();
                THistory.En_Name = this.T1_INPUT_En_Name.Text;
                THistory.En_Lastname = this.T1_INPUT_EN_Lastname.Text;
                THistory.Sex = this.T1_INPUT_Sex.SelectedItem.ToString();
                THistory.Nationality = this.T1_INPUT_Nationality.Text;
                THistory.Nationality_En = this.T1_INPUT_Nationality_EN.Text;
                THistory.Date_Birth = this.T1_INPUT_Date_Birth.Text;
                THistory.Month_Birth = this.T1_INPUT_Month_Birth.SelectedItem.ToString();
                THistory.Month_Birth_En = this.T1_INPUT_Month_Birth_En.Text;
                THistory.Year_Birth = this.T1_INPUT_Year_Birth.Text;
                THistory.Year_Birth_En = this.T1_INPUT_Year_Birth_En.Text;
                THistory.Age = this.T1_INPUT_Age.Text;
                THistory.Degree = this.T1_INPUT_Degree.Text;
                THistory.Year_Received = this.T1_INPUT_Year_Recievied.Text;
                THistory.Name_Institute = this.T1_INPUT_Name_institute.Text;
                THistory.Country_Edu = this.T1_INPUT_Country_Edu.Text;
                THistory.Stuffed_ID = this.T1_INPUT_Stuffed_ID.Text;
                THistory.StuffedDate = this.T1_INPUT_StuffedDate.Text;
                THistory.StuffedMonth = this.T1_INPUT_StuffedMonth.SelectedItem.ToString();
                THistory.StuffedMonth_En = this.T1_INPUT_StuffedMonth_En.Text;
                THistory.StuffedYear = this.T1_INPUT_StuffedYear.Text;
                THistory.StuffedYear_En = this.T1_INPUT_StuffedYear_En.Text;
                THistory.DateStarted = this.T1_INPUT_DateStarted.Text;
                THistory.MonthStarted = this.T1_INPUT_MonthStarted.SelectedItem.ToString();
                THistory.MonthStarted_En = this.T1_INPUT_MonthStarted_En.Text;
                THistory.YearStarted = this.T1_INPUT_YearStarted.Text;
                THistory.YearStarted_En = this.T1_INPUT_YearStarted_En.Text;
                THistory.Phone = this.T1_INPUT_Phone.Text;
                THistory.Pic = "p" + this.T1_INPUT_HisID.Text;
                THistory.blood_Grp = this.T1_INPUT_blood_Grp.SelectedItem.ToString();

                /* Tab 2 */
                TDocument.Passport = this.T1_INPUT_Passport.Text.Trim().ToUpper();
                TDocument.PassportDate = this.T2_INPUT_PassportDate.Text.Trim();
                TDocument.PassportMonth = this.T2_INPUT_PassportMonth.SelectedItem.ToString();
                TDocument.PassportMonth_En = this.T2_INPUT_PassportMonth_En.Text.Trim();
                TDocument.PassportYear = this.T2_INPUT_PassportYear.Text.Trim();
                TDocument.PassportYear_En = this.T2_INPUT_PassportYear_En.Text.Trim();
                TDocument.PassportIssuedAt = this.T2_INPUT_PassportIssuedAt.Text.Trim();
                TDocument.KindVISA = this.T2_INPUT_KindVISA.Text.Trim();
                TDocument.VisaNo = this.T2_INPUT_VisaNo.Text.Trim();
                TDocument.VisaDate = this.T2_INPUT_VisaDate.Text.Trim();
                TDocument.VisaMonth = this.T2_INPUT_VisaMonth.SelectedItem.ToString();
                TDocument.VisaMonth_En = this.T2_INPUT_VisaMonth_En.Text.Trim();
                TDocument.VisaYear = this.T2_INPUT_VisaYear.Text.Trim();
                TDocument.VisaYear_En = this.T2_INPUT_VisaYear_En.Text.Trim();
                TDocument.VisaIssuedAt = this.T2_INPUT_VisaIssuedAt.Text.Trim();
                TDocument.ReachedDate = this.T2_INPUT_ReachedDate.Text.Trim();
                TDocument.ReachedMonth = this.T2_INPUT_ReachedMonth.SelectedItem.ToString();
                TDocument.ReachedMonth_En = this.T2_INPUT_ReachedMonth_En.Text.Trim();
                TDocument.ReachedYear = this.T2_INPUT_ReachedYear.Text.Trim();
                TDocument.ReachedYear_En = this.T2_INPUT_ReachedYear_En.Text.Trim();
                TDocument.AllowedAt = this.T2_INPUT_AllowedAt.Text.Trim();
                TDocument.DefineYear = this.T2_INPUT_DefineYear.Text.Trim();
                TDocument.DefineMonth = this.T2_INPUT_DefineMonth.Text.Trim();
                TDocument.DefineDay = this.T2_INPUT_DefineDay.Text.Trim();
                TDocument.DueDate = this.T2_INPUT_DueDate.Text.Trim();
                TDocument.DueMonth = this.T2_INPUT_DueMonth.SelectedItem.ToString();
                TDocument.DueMonth_En = this.T2_INPUT_DueMonth_En.Text.Trim();
                TDocument.DueYear = this.T2_INPUT_DueYear.Text.Trim();
                TDocument.DueYear_En = this.T2_INPUT_DueYear_En.Text.Trim();
                TDocument.Renew_Date = this.T2_INPUT_Renew_Date.Text.Trim();
                TDocument.Renew_Month = this.T2_INPUT_Renew_Month.SelectedItem.ToString();
                TDocument.Renew_Month_En = this.T2_INPUT_Renew_Month_En.Text.Trim();
                TDocument.Renew_Year = this.T2_INPUT_Renew_Year.Text.Trim();
                TDocument.Renew_Year_En = this.T2_INPUT_Renew_Year_En.Text.Trim();

                /* Tab 3 */
                TPassportExp.Passport = this.T1_INPUT_Passport.Text.Trim().ToUpper();
                TPassportExp.PassportExpDate = this.T3_INPUT_PassportExpDate.Text.Trim();
                TPassportExp.PassportExpMonth = this.T3_INPUT_PassportExpMonth.SelectedItem.ToString();
                TPassportExp.PassportExpMonth_En = this.T3_INPUT_PassportExpMonth_En.Text;
                TPassportExp.PassportExpMonth_Text = string.Empty;
                TPassportExp.PassportExpYear = this.T3_INPUT_PassportExpYear.Text.Trim();
                TPassportExp.PassportExpYear_En = this.T3_INPUT_PassportExpYear_En.Text;
                TPassportExp.ContractDate = this.T3_INPUT_ContractDate.Text.Trim();
                TPassportExp.ContractMonth = this.T3_INPUT_ContractMonth.SelectedItem.ToString();
                TPassportExp.ContractMonth_En = this.T3_INPUT_ContractMonth_En.Text;
                TPassportExp.ContractMonth_Text = string.Empty;
                TPassportExp.ContractYear = this.T3_INPUT_ContractYear.Text.Trim();
                TPassportExp.ContractYear_En = this.T3_INPUT_ContractYear_En.Text;
                TPassportExp.CheckStetar = string.Empty;

                /* Tab 4 */
                TWorkplace.Passport = this.T1_INPUT_Passport.Text.Trim().ToUpper();
                TWorkplace.WorkpermitNo = this.T4_INPUT_WorkpermitNo.Text.Trim();
                TWorkplace.DateIssue = this.T4_INPUT_DateIssue.Text;
                TWorkplace.MonthIssue = this.T4_INPUT_MonthIssue.SelectedItem.ToString();
                TWorkplace.MonthIssue_En = this.T4_INPUT_MonthIssue_En.Text;
                TWorkplace.YearIssue = this.T4_INPUT_YearIssue.Text.Trim();
                TWorkplace.YearIssue_En = this.T4_INPUT_YearIssue_En.Text;
                TWorkplace.PlaceIssue = this.T4_INPUT_PlaceIssue.Text.Trim();
                TWorkplace.PeriodPermission = this.T4_INPUT_PeriodPermission.Text.Trim();
                TWorkplace.ExpireOn = this.T4_INPUT_ExpireOn.Text.Trim();
                TWorkplace.ExpireMonth = this.T4_INPUT_ExpireMonth.SelectedItem.ToString();
                TWorkplace.ExpireMonth_En = this.T4_INPUT_ExpireMonth_En.Text.Trim();
                TWorkplace.ExpireYear = this.T4_INPUT_ExpireYear.Text.Trim();
                TWorkplace.ExpireYear_En = this.T4_INPUT_ExpireYear_en.Text;
                TWorkplace.PerLicenseDate = this.T4_INPUT_PerLicenseDate.Text.Trim();
                TWorkplace.PerLicenseMonth = this.T4_INPUT_PerLicenseMonth.SelectedItem.ToString();
                TWorkplace.PerLicenseMonth_En = this.T4_INPUT_PerLicenseMonth_En.Text;
                TWorkplace.PerLicenseYear = this.T4_INPUT_PerLicenseYear.Text.Trim();
                TWorkplace.PerLicenseYear_En = this.T4_INPUT_PerLicenseYear_En.Text;
                TWorkplace.ThroughDate = this.T4_INPUT_ThroughDate.Text.Trim();
                TWorkplace.ThroughMonth = this.T4_INPUT_ThroughMonth.SelectedItem.ToString();
                TWorkplace.ThroughMonth_En = this.T4_INPUT_ThroughMonth_En.Text;
                TWorkplace.ThroughYear = this.T4_INPUT_ThroughYear.Text.Trim();
                TWorkplace.ThroughYear_En = this.T4_INPUT_ThroughYear_En.Text;
                TWorkplace.Profession = this.T4_INPUT_Profession.Text.Trim();
                TWorkplace.JobDescription = this.T4_INPUT_JobDescription.Text.Trim();
                TWorkplace.Wage = this.T4_INPUT_Wage.Text.Trim();
                TWorkplace.Bossname = this.T4_INPUT_Bossname.Text.Trim();
                TWorkplace.School = this.T4_INPUT_School.Text.Trim();
                TWorkplace.HomeNo = this.T4_INPUT_HomeNo.Text.Trim();
                TWorkplace.Village = this.T4_INPUT_Village.Text.Trim();
                TWorkplace.Lane = this.T4_INPUT_Lane.Text.Trim();
                TWorkplace.Road = this.T4_INPUT_Road.Text.Trim();
                TWorkplace.Tambol = this.T4_INPUT_Tambol.Text.Trim();
                TWorkplace.Amphur = this.T4_INPUT_Amphur.Text.Trim();
                TWorkplace.Province = this.T4_INPUT_Province.Text.Trim();
                TWorkplace.PostCode = this.T4_INPUT_PostCode.Text.Trim();
                TWorkplace.Phone = this.T4_INPUT_Phone.Text.Trim();
                TWorkplace.Employment_Year = this.T4_INPUT_Employment_Year.Text.Trim();
                TWorkplace.Employment_Month = this.T4_INPUT_Employment_Month.Text.Trim();
                TWorkplace.Employment_Day = this.T4_INPUT_Employment_Day.Text.Trim();
                TWorkplace.Contract = this.T4_INPUT_Contract.Text.Trim();

                IsSuccess = true;
            }

            return IsSuccess;
        }

        private void T6_INPUT_Choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tschool.SelectQuery(T6_INPUT_Choose.SelectedItem.ToString());
            T6_INPUT_School.Text = Tschool.School;
            T6_INPUT_HomeNo.Text = Tschool.HomeNo;
            T6_INPUT_Village.Text = Tschool.Village;
            T6_INPUT_Lane.Text = Tschool.Lane;
            T6_INPUT_Road.Text = Tschool.Road;
            T6_INPUT_Tambol.Text = Tschool.Tambol;
            T6_INPUT_Amphur.Text = Tschool.Amphur;
            T6_INPUT_Province.Text = Tschool.Province;
            T6_INPUT_PostCode.Text = Tschool.PostCode;
            T6_INPUT_Phone.Text = Tschool.Phone;
            T6_INPUT_Bossname.Text = Tschool.Bossname;
        }

        private void T6_SUMBIT_Update_Click(object sender, EventArgs e)
        {
            /* Save ข้อมูล โรงเรียน. */
            Tschool.HomeNo = T6_INPUT_HomeNo.Text.Trim();
            Tschool.Village = T6_INPUT_Village.Text;
            Tschool.Lane = T6_INPUT_Lane.Text.Trim();
            Tschool.Road = T6_INPUT_Road.Text.Trim();
            Tschool.Tambol = T6_INPUT_Tambol.Text.Trim();
            Tschool.Amphur = T6_INPUT_Amphur.Text.Trim();
            Tschool.Province = T6_INPUT_Province.Text.Trim();
            Tschool.PostCode = T6_INPUT_PostCode.Text.Trim();
            Tschool.Phone = T6_INPUT_Phone.Text.Trim();
            Tschool.Bossname = T6_INPUT_Bossname.Text.Trim();
            Tschool.UpdateQuery(T6_INPUT_Choose.SelectedItem.ToString());

            MessageBox.Show(Tschool.Message);
        }

        private void T1_INPUT_Month_Birth_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.T1_INPUT_Month_Birth_En.Text = ComboConv.ConvThMonthToEnMonth(this.T1_INPUT_Month_Birth.SelectedItem.ToString());
        }

        private void T1_INPUT_Year_Birth_TextChanged(object sender, EventArgs e)
        {
            this.T1_INPUT_Year_Birth_En.Text = ComboConv.ConvThYearToEnYear(this.T1_INPUT_Year_Birth.Text);
        }

        private void MAIN_BTN_Find_Click(object sender, EventArgs e)
        {
            FORM_FIND ff = new FORM_FIND(this);
            ff.Show();
        }

        private void T1_INPUT_StuffedMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.T1_INPUT_StuffedMonth_En.Text = ComboConv.ConvThMonthToEnMonth(this.T1_INPUT_StuffedMonth.SelectedItem.ToString());
        }

        private void T1_INPUT_MonthStarted_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.T1_INPUT_MonthStarted_En.Text = ComboConv.ConvThMonthToEnMonth(this.T1_INPUT_MonthStarted.SelectedItem.ToString());
        }

        private void T1_INPUT_StuffedYear_TextChanged(object sender, EventArgs e)
        {
            this.T1_INPUT_StuffedYear_En.Text = ComboConv.ConvThYearToEnYear(this.T1_INPUT_StuffedYear.Text);
        }

        private void T1_INPUT_YearStarted_TextChanged(object sender, EventArgs e)
        {
            this.T1_INPUT_YearStarted_En.Text = ComboConv.ConvThYearToEnYear(this.T1_INPUT_YearStarted.Text);
        }

        private void MAIN_BTN_New_Click(object sender, EventArgs e)
        {
            _NewTeacher(0);
            this.T1_INPUT_HisID.Text = THistory.AutoTeacherNumber();
        }

        private void MAIN_BTN_Save_Click(object sender, EventArgs e)
        {
            if(_AssignData() == true){
                THistory.InsertTeacher();
                TDocument.UpdateTeacher();
                TPassportExp.UpdateTeacher();
                TWorkplace.UpdateTeacher();
                if ((THistory.ResultMessage == "1") && (TDocument.ResultMessage == "1") && (TPassportExp.ResultMessage == "1") && (TWorkplace.ResultMessage == "1"))
                {
                    MessageBox.Show("บัณทึกข้อมูลแล้ว");
                }
                else if (THistory.ResultMessage != "1") { MessageBox.Show("THistory" + Environment.NewLine + THistory.ResultMessage); }
                else if (TDocument.ResultMessage != "1") { MessageBox.Show("TDocument" + Environment.NewLine + TDocument.ResultMessage); }
                else if (TPassportExp.ResultMessage != "1") { MessageBox.Show("TPassportExp" + Environment.NewLine + TPassportExp.ResultMessage); }
                else if (TWorkplace.ResultMessage != "1") { MessageBox.Show("TWorkplace" + Environment.NewLine + TWorkplace.ResultMessage); }
            }                    
        }

        private void T2_INPUT_PassportMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.T2_INPUT_PassportMonth_En.Text = ComboConv.ConvThMonthToEnMonth(this.T2_INPUT_PassportMonth.SelectedItem.ToString());
        }

        private void T2_INPUT_VisaMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.T2_INPUT_VisaMonth_En.Text = ComboConv.ConvThMonthToEnMonth(this.T2_INPUT_VisaMonth.SelectedItem.ToString());
        }

        private void T2_INPUT_PassportYear_TextChanged(object sender, EventArgs e)
        {
            this.T2_INPUT_PassportYear_En.Text = ComboConv.ConvThYearToEnYear(this.T2_INPUT_PassportYear.Text);
        }

        private void T2_INPUT_VisaYear_TextChanged(object sender, EventArgs e)
        {
            this.T2_INPUT_VisaYear_En.Text = ComboConv.ConvThYearToEnYear(this.T2_INPUT_VisaYear.Text);
        }

        private void T2_INPUT_ReachedMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.T2_INPUT_ReachedMonth_En.Text = ComboConv.ConvThMonthToEnMonth(this.T2_INPUT_ReachedMonth.SelectedItem.ToString());
        }

        private void T2_INPUT_ReachedYear_TextChanged(object sender, EventArgs e)
        {
            this.T2_INPUT_ReachedYear_En.Text = ComboConv.ConvThYearToEnYear(this.T2_INPUT_ReachedYear.Text);
        }

        private void T2_INPUT_DueMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.T2_INPUT_DueMonth_En.Text = ComboConv.ConvThMonthToEnMonth(this.T2_INPUT_DueMonth.SelectedItem.ToString());
        }

        private void T2_INPUT_DueYear_TextChanged(object sender, EventArgs e)
        {
            this.T2_INPUT_DueYear_En.Text = ComboConv.ConvThYearToEnYear(this.T2_INPUT_DueYear.Text);
        }

        private void T2_INPUT_Renew_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.T2_INPUT_Renew_Month_En.Text = ComboConv.ConvThMonthToEnMonth(this.T2_INPUT_Renew_Month.SelectedItem.ToString());
        }

        private void T2_INPUT_Renew_Year_TextChanged(object sender, EventArgs e)
        {
            this.T2_INPUT_Renew_Year_En.Text = ComboConv.ConvThYearToEnYear(this.T2_INPUT_Renew_Year.Text);
        }

        private void T3_INPUT_PassportExpMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.T3_INPUT_PassportExpMonth_En.Text = ComboConv.ConvThMonthToEnMonth(this.T3_INPUT_PassportExpMonth.SelectedItem.ToString());
        }

        private void T3_INPUT_PassportExpYear_TextChanged(object sender, EventArgs e)
        {
            this.T3_INPUT_PassportExpYear_En.Text = ComboConv.ConvThYearToEnYear(this.T3_INPUT_PassportExpYear.Text);
        }

        private void T3_INPUT_ContractMonth_TextChanged(object sender, EventArgs e)
        {
            this.T3_INPUT_ContractMonth_En.Text = ComboConv.ConvThMonthToEnMonth(this.T3_INPUT_ContractMonth.SelectedItem.ToString());
        }

        private void T3_INPUT_ContractYear_TextChanged(object sender, EventArgs e)
        {
            this.T3_INPUT_ContractYear_En.Text = ComboConv.ConvThYearToEnYear(this.T3_INPUT_ContractYear.Text);
        }

        private void T4_INPUT_MonthIssue_SelectedIndexChanged(object sender, EventArgs e)
        {
            T4_INPUT_MonthIssue_En.Text = ComboConv.ConvThMonthToEnMonth(this.T4_INPUT_MonthIssue.SelectedItem.ToString());
        }

        private void T4_INPUT_YearIssue_TextChanged(object sender, EventArgs e)
        {
            T4_INPUT_YearIssue_En.Text = ComboConv.ConvThYearToEnYear(this.T4_INPUT_YearIssue.Text);
        }

        private void MAIN_BTN_Delete_Click(object sender, EventArgs e)
        {
            DialogResult Result;
            Result = MessageBox.Show("จะลบแล้วน่ะ เปลี่ยนใจกด NO ถ้าหมั่นใจกด YES", "ยืนยันการลบ", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                THistory.Passport = T1_INPUT_Passport.Text.Trim();
                THistory.HisID = T1_INPUT_HisID.Text.Trim();
                THistory.ChangeStatusTeacher(2);
                _NewTeacher(0);
                MessageBox.Show(THistory.ResultMessage);
            }
            else if (Result == DialogResult.No) { return; }
        }

        private void T4_INPUT_SelectSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            string var_SchoolName = T4_INPUT_SelectSchool.SelectedItem.ToString();
            if (var_SchoolName == "-") { return; }
            else 
            {
                Tschool.SelectQuery(var_SchoolName);
                T4_INPUT_School.Text = Tschool.School;
                T4_INPUT_Bossname.Text = Tschool.Bossname;
                T4_INPUT_HomeNo.Text = Tschool.HomeNo;
                T4_INPUT_Village.Text = Tschool.Village;
                T4_INPUT_Lane.Text = Tschool.Lane;
                T4_INPUT_Road.Text = Tschool.Road;
                T4_INPUT_Tambol.Text = Tschool.Tambol;
                T4_INPUT_Amphur.Text = Tschool.Amphur;
                T4_INPUT_Province.Text = Tschool.Province;
                T4_INPUT_PostCode.Text = Tschool.PostCode;
                T4_INPUT_Phone.Text = Tschool.Phone;
            }
        }

        private void T4_INPUT_PerLicenseMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            T4_INPUT_PerLicenseMonth_En.Text = ComboConv.ConvThMonthToEnMonth(this.T4_INPUT_PerLicenseMonth.SelectedItem.ToString());
        }

        private void T4_INPUT_PerLicenseYear_TextChanged(object sender, EventArgs e)
        {
            T4_INPUT_PerLicenseYear_En.Text = ComboConv.ConvThYearToEnYear(this.T4_INPUT_PerLicenseYear.Text);
        }

        private void T4_INPUT_ThroughMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            T4_INPUT_ThroughMonth_En.Text = ComboConv.ConvThMonthToEnMonth(this.T4_INPUT_ThroughMonth.SelectedItem.ToString());
        }

        private void T4_INPUT_ThroughYear_TextChanged(object sender, EventArgs e)
        {
            T4_INPUT_ThroughYear_En.Text = ComboConv.ConvThYearToEnYear(this.T4_INPUT_ThroughYear.Text);
        }

        private void T4_INPUT_ExpireMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            T4_INPUT_ExpireMonth_En.Text = ComboConv.ConvThMonthToEnMonth(this.T4_INPUT_ExpireMonth.SelectedItem.ToString());
        }

        private void T4_INPUT_ExpireYear_TextChanged(object sender, EventArgs e)
        {
            T4_INPUT_ExpireYear_en.Text = ComboConv.ConvThYearToEnYear(this.T4_INPUT_ExpireYear.Text);
        }

        private void BTN_RMDuplicate_Click(object sender, EventArgs e)
        {
            RemoveDuplicate Form_RmDuplicate = new RemoveDuplicate();
            Form_RmDuplicate.Show();
        }

        private void T1_SUMBIT_SelectPicture_Click(object sender, EventArgs e)
        {
            T1_INPUT_Pic.ImageLocation = THistory.Role_GetPicture(T1_INPUT_HisID.Text, T4_INPUT_School.Text);
        }
    }
}