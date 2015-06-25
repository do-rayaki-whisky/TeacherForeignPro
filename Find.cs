using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TeacherForeignPro
{
    public partial class FORM_FIND : Form
    {
        Form_Main _Form_Main;
        public FORM_FIND()
        {
            InitializeComponent();
        }

        public FORM_FIND(Form_Main fm)
        {
            InitializeComponent();
            _Form_Main = new Form_Main();
            _Form_Main = fm;
        }

        private string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\Database\\Data.mdb;User Id=admin;Password=;";

        private void FindTeacher(string _Keyword)
        {
            FIND_OUTPUT_ListView.Items.Clear();

            string Query = "SELECT [THistory.Passport], [THistory.HisID], [THistory.Th_Title], [THistory.Th_Name], [THistory.Th_Lastname], [TWorkplace.School] " +
                    "FROM [THistory] INNER JOIN [TWorkplace] ON THistory.Passport = TWorkplace.Passport " +
                    "WHERE [THistory.Passport] like '" + _Keyword + "%' OR [THistory.HisID] like '" + _Keyword + "%' OR [THistory.Th_Name] like '" + _Keyword + "%' OR [THistory.Th_Lastname] like '" + _Keyword + "%' " +
                    "ORDER BY [THistory.HisID] ASC";

            OleDbConnection Con = new OleDbConnection(ConnectionString);
            OleDbCommand Com = new OleDbCommand(Query, Con);
            OleDbDataReader Read;

            try
            {
                Con.Open();
                Read = Com.ExecuteReader();

                if (Read.HasRows)
                {
                    while (Read.Read())
                    {
                        string[] _Items = new string[]{
                            Read.GetValue(0).ToString(),
                            Read.GetValue(1).ToString(),
                            Read.GetValue(2).ToString(),
                            Read.GetValue(3).ToString(),
                            Read.GetValue(4).ToString(),
                            Read.GetValue(5).ToString(),
                        };

                        ListViewItem _ListView = new ListViewItem(_Items);                      
                        FIND_OUTPUT_ListView.Items.Add(_ListView);
                    }                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Con.Close();
        }

        private void FindTeacherBySchool(string _School)
        {
            FIND_OUTPUT_ListView.Items.Clear();
            string Query;
            if (_School == "all")
            {
                Query = "SELECT THistory.Passport, THistory.HisID, THistory.Th_Title, THistory.Th_Name, THistory.Th_Lastname, TWorkplace.School " +
                    "FROM THistory INNER JOIN TWorkplace ON THistory.Passport = TWorkplace.Passport " +
                    "ORDER BY THistory.HisID ASC";
            }
            else
            {
                Query = "SELECT THistory.Passport, THistory.HisID, THistory.Th_Title, THistory.Th_Name, THistory.Th_Lastname, TWorkplace.School " +
                    "FROM THistory INNER JOIN TWorkplace ON THistory.Passport = TWorkplace.Passport " +
                    "WHERE [TWorkplace.School]='" + _School + "' " +
                    "ORDER BY THistory.HisID ASC";
            }

            OleDbConnection Con = new OleDbConnection(ConnectionString);
            OleDbCommand Com = new OleDbCommand(Query, Con);
            OleDbDataReader Read;

            try
            {
                Con.Open();
                Read = Com.ExecuteReader();

                if (Read.HasRows)
                {
                    while (Read.Read())
                    {
                        string[] _Items = new string[]{
                            Read.GetValue(0).ToString(),
                            Read.GetValue(1).ToString(),
                            Read.GetValue(2).ToString(),
                            Read.GetValue(3).ToString(),
                            Read.GetValue(4).ToString(),
                            Read.GetValue(5).ToString(),
                        };

                        ListViewItem _ListView = new ListViewItem(_Items);
                        FIND_OUTPUT_ListView.Items.Add(_ListView);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Con.Close();
        }

        private void FIND_INPUT_FindWord_TextChanged(object sender, EventArgs e)
        {
            FindTeacher(FIND_INPUT_FindWord.Text.Trim());
        }

        private void FIND_INPUT_Pattaya_Click(object sender, EventArgs e)
        {
            FindTeacherBySchool("มารีวิทย์");
        }

        private void FIND_INPUT_All_Click(object sender, EventArgs e)
        {
            FindTeacherBySchool("all");
        }

        private void FIND_INPUT_Sattahip_Click(object sender, EventArgs e)
        {
            FindTeacherBySchool("มารีวิทย์สัตหีบ");
        }

        private void FIND_INPUT_Bowin_Click(object sender, EventArgs e)
        {
            FindTeacherBySchool("มารีวิทย์บ่อวิน");
        }

        private void FIND_BTN_Send_Click(object sender, EventArgs e)
        {
            _Form_Main.T1_INPUT_Passport.Text = FIND_OUTPUT_ListView.SelectedItems[0].Text;
            _Form_Main._SelectData(_Form_Main.T1_INPUT_Passport.Text);
            _Form_Main._NewTeacher();
        }
    }
}
