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
            else
            {
                T2_INPUT_Passport.Text = "False";
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
         
        }

        public void _NewTeacher()
        {
            THistory.NewTeacher();
            TDocument.NewTeacher();
            TPassportExp.NewTeacher();
        }

        public void _NewTeacher(int _Mode)
        {
            // _Mode ใส่อะไรก้ได้ เพื่อล้างค่าในฟอร์ม
            THistory.NewTeacher();
            TDocument.NewTeacher();
            TPassportExp.NewTeacher();

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
        }

        public bool _AssignData()
        {
            bool IsSuccess = false;
            
            if ((T1_INPUT_HisID.Text.Trim() != string.Empty) && (T1_INPUT_Passport.Text.Trim() != string.Empty))
            {
                /* Tab 1 */
                THistory.HisID = this.T1_INPUT_HisID.Text;
                THistory.Passport = this.T1_INPUT_Passport.Text;
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
                //TDocument.Passport = string.Empty;
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
                IsSuccess = true;
            }
            else
            {
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
        }

        private void MAIN_BTN_Save_Click(object sender, EventArgs e)
        {
            if(_AssignData() == true){
                THistory.InsertTeacher();
                MessageBox.Show(THistory.ResultMessage);
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
    }
}