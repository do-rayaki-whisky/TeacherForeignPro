using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherForeignPro
{
    public partial class Form_Main : Form
    {
        ComboBoxConvert ComboConv = new ComboBoxConvert();
        TSchool Tschool = new TSchool(); /* Class ตาราง TSchool */
        THistory THistory = new THistory();
        public Form_Main()
        {
            InitializeComponent();
            /* Tab 1 */
            T1_INPUT_Th_Title.SelectedIndex = 0;

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
        }

        public void _NewTeacher()
        {
            THistory.NewTeacher();
        }

        public void _AssignData()
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
            THistory.NewTeacher();
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
        }

        private void MAIN_BTN_Save_Click(object sender, EventArgs e)
        {
            _AssignData();
            THistory.InsertTeacher();
            MessageBox.Show(THistory.ResultMessage);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _AssignData();
        }
    }
}