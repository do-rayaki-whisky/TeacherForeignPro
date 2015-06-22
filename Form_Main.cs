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

        private void button2_Click(object sender, EventArgs e)
        {
            _SelectData(T1_INPUT_Passport.Text);
            MessageBox.Show(THistory.ResultMessage);
        }
    }
}
