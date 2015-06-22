using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace TeacherForeignPro
{
    class TSchool
    {
        public String School
        {
            get
            {
                return this.school;
            }
            set
            {
                school = value;
            }
        }
        public String HomeNo
        {
            get
            {
                return homeno;
            }
            set
            {
                homeno = value;
            }
        }
        public String Village
        {
            get
            {
                return village;
            }
            set
            {
                village = value;
            }
        }
        public String Lane
        {
            get
            {
                return lane;
            }
            set
            {
                lane = value;
            }
        }
        public String Road
        {
            get
            {
                return road;
            }
            set
            {
                road = value;
            }
        }
        public String Tambol
        {
            get
            {
                return tambol;
            }
            set
            {
                tambol = value;
            }
        }
        public String Amphur
        {
            get
            {
                return amphur;
            }
            set
            {
                amphur = value;
            }
        }
        public String Province
        {
            get
            {
                return province;
            }
            set
            {
                province = value;
            }
        }
        public String PostCode
        {
            get
            {
                return postcode;
            }
            set
            {
                postcode = value;
            }
        }
        public String Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
        public String Bossname
        {
            get
            {
                return bossname;
            }
            set
            {
                bossname = value;
            }
        }
        public String ErrorString
        {
            get
            {
                return errorstring;
            }
        }
        public String Message
        {
            get
            {
                return message;
            }
        }

        private string school;
        private string homeno;
        private string village;
        private string lane;
        private string road;
        private string tambol;
        private string amphur;
        private string province;
        private string postcode;
        private string phone;
        private string bossname;
        private string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\Database\\Data.mdb;User Id=admin;Password=;";
        public readonly string TableName = "TSchool";
        private string errorstring;
        private string message;

        public void SelectQuery(string _SchoolName){
            string SelectString = "select * from TSchool where [School]='"+ _SchoolName + "'";
            OleDbConnection Con = new OleDbConnection(ConnectionString);
            OleDbCommand Com = new OleDbCommand(SelectString, Con);
            OleDbDataReader Read;
            try
            {
                Con.Open();
                Read = Com.ExecuteReader();

                if (Read.HasRows)
                {
                    Read.Read();
                    school = Read.GetString(0);
                    homeno = Read.GetString(1);
                    village = Read.GetString(2);
                    lane = Read.GetString(3);
                    road = Read.GetString(4);
                    tambol = Read.GetString(5);
                    amphur = Read.GetString(6);
                    province = Read.GetString(7);
                    postcode = Read.GetString(8);
                    phone = Read.GetString(9);
                    bossname = Read.GetString(10);
                }
            }
            catch (Exception ex)
            {
                errorstring = ex.Message;
            }
            this.School = school;
            Con.Close();
        }

        public void UpdateQuery(string _SchoolName)
        {
            string UpdateString = "update [" + TableName + "] " +
                                  "set [HomeNo]='" + homeno + "', " +
                                  "[Village]='" + village + "', " +
                                  "[Lane]='" + lane + "', " +
                                  "[Road]='" + road + "', " +
                                  "[Tambol]='" + tambol + "', " +
                                  "[Amphur]='" + amphur + "', " +
                                  "[Province]='" + province + "', " +
                                  "[PostCode]='" + postcode + "', " +
                                  "[Phone]='" + phone + "', " +
                                  "[Bossname]='" + bossname + "' " +
                                  "where [School]='" + _SchoolName + "'";
            OleDbConnection Con = new OleDbConnection(ConnectionString);
            OleDbCommand Com = new OleDbCommand(UpdateString, Con);
            try
            {
                Con.Open();
                if (Com.ExecuteNonQuery() > 0)
                {
                    message = "บัณทึกข้อมูลเรียบร้อย";
                }
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            Con.Close();
        }
    }
}
