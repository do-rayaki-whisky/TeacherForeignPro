using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace TeacherForeignPro
{
    class THistory
    {
        public String HisID
        {
            get { return _HisID; }
            set { _HisID = value; }
        }
        public String Passport
        {
            get { return _Passport; }
            set { _Passport = value; }
        }
        public String Th_Title
        {
            get { return _Th_Title; }
            set { _Th_Title = value; }
        }
        public String Th_Name
        {
            get { return _Th_Name; }
            set { _Th_Name = value; }
        }
        public String Th_Lastname
        {
            get { return _Th_Lastname; }
            set { _Th_Lastname = value; }
        }
        public String En_Title
        {
            get { return _En_Title; }
            set { _En_Title = value; }
        }
        public String En_Name
        {
            get { return _En_Name; }
            set { _En_Name = value; }
        }
        public String En_Lastname
        {
            get { return _En_Lastname; }
            set { _En_Lastname = value; }
        }
        public String Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }
        public String Nationality
        {
            get { return _Nationality; }
            set { _Nationality = value; }
        }
        public String Nationality_En
        {
            get { return _Nationality_En; }
            set { _Nationality_En = value; }
        }
        public String Date_Birth
        {
            get { return _Date_Birth; }
            set { _Date_Birth = value; }
        }
        public String Month_Birth
        {
            get { return _Month_Birth; }
            set { _Month_Birth = value; }
        }
        public String Month_Birth_En
        {
            get { return _Month_Birth_En; }
            set { _Month_Birth_En = value; }
        }
        public String Year_Birth
        {
            get { return _Year_Birth; }
            set { _Year_Birth = value; }
        }
        public String Year_Birth_En
        {
            get { return _Year_Birth_En; }
            set { _Year_Birth_En = value; }
        }
        public String Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        public String Degree
        {
            get { return _Degree; }
            set { _Degree = value; }
        }
        public String Year_Received
        {
            get { return _Year_Received; }
            set { _Year_Received = value; }
        }
        public String Name_Institute
        {
            get { return _Name_Institute; }
            set { _Name_Institute = value; }
        }
        public String Country_Edu
        {
            get { return _Country_Edu; }
            set { _Country_Edu = value; }
        }
        public String Stuffed_ID
        {
            get { return _Stuffed_ID; }
            set { _Stuffed_ID = value; }
        }
        public String StuffedDate
        {
            get { return _StuffedDate; }
            set { _StuffedDate = value; }
        }
        public String StuffedMonth
        {
            get { return _StuffedMonth; }
            set { _StuffedMonth = value; }
        }
        public String StuffedMonth_En
        {
            get { return _StuffedMonth_En; }
            set { _StuffedMonth_En = value; }
        }
        public String StuffedYear
        {
            get { return _StuffedYear; }
            set { _StuffedYear = value; }
        }
        public String StuffedYear_En
        {
            get { return _StuffedYear_En; }
            set { _StuffedYear_En = value; }
        }
        public String DateStarted
        {
            get { return _DateStarted; }
            set { _DateStarted = value; }
        }
        public String MonthStarted
        {
            get { return _MonthStarted; }
            set { _MonthStarted = value; }
        }
        public String MonthStarted_En
        {
            get { return _MonthStarted_En; }
            set { _MonthStarted_En = value; }
        }
        public String YearStarted
        {
            get { return _YearStarted; }
            set { _YearStarted = value; }
        }
        public String YearStarted_En
        {
            get { return _YearStarted_En; }
            set { _YearStarted_En = value; }
        }
        public String Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
        public String Pic
        {
            get { return _Pic; }
            set { _Pic = value; }
        }
        public String blood_Grp
        {
            get { return _blood_Grp; }
            set { _blood_Grp = value; }
        }
        public String ResultMessage
        {
            get { return _ResultMessage; }
        }
        private string _HisID;
        private string _Passport;
        private string _Th_Title;
        private string _Th_Name;
        private string _Th_Lastname;
        private string _En_Title;
        private string _En_Name;
        private string _En_Lastname;
        private string _Sex;
        private string _Nationality;
        private string _Nationality_En;
        private string _Date_Birth;
        private string _Month_Birth;
        private string _Month_Birth_En;
        private string _Year_Birth;
        private string _Year_Birth_En;
        private string _Age;
        private string _Degree;
        private string _Year_Received;
        private string _Name_Institute;
        private string _Country_Edu;
        private string _Stuffed_ID;
        private string _StuffedDate;
        private string _StuffedMonth;
        private string _StuffedMonth_En;
        private string _StuffedYear;
        private string _StuffedYear_En;
        private string _DateStarted;
        private string _MonthStarted;
        private string _MonthStarted_En;
        private string _YearStarted;
        private string _YearStarted_En;
        private string _Phone;
        private string _Pic;
        private string _blood_Grp;

        private string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\Database\\Data.mdb;User Id=admin;Password=;";
        public readonly string TableName = "THistory";
        private string _ResultMessage;

        public void SelectTeacher(string _PassportID)
        {
            string QueryString = "select * from [" + TableName + "] where [Passport]='" + _PassportID + "'";
            OleDbConnection Con = new OleDbConnection(ConnectionString);
            OleDbCommand Com = new OleDbCommand(QueryString, Con);
            OleDbDataReader Read;
            try
            {
                Con.Open();
                Read = Com.ExecuteReader();

                if (Read.HasRows == true)
                {
                    Read.Read();
                    _HisID = Read.GetValue(0).ToString();
                    _Passport = Read.GetString(1);
                    _Th_Title = Read.GetString(2);
                    _Th_Name = Read.GetString(3);
                    _Th_Lastname = Read.GetString(4);
                    _En_Title = Read.GetString(5);
                    _En_Name = Read.GetString(6);
                    _En_Lastname = Read.GetString(7);
                    _Sex = Read.GetString(8);
                    _Nationality = Read.GetString(9);
                    _Nationality_En = Read.GetString(10);
                    _Date_Birth = Read.GetString(11);
                    _Month_Birth = Read.GetString(12);
                    _Month_Birth_En = Read.GetString(13);
                    _Year_Birth = Read.GetString(14);
                    _Year_Birth_En = Read.GetString(15);
                    _Age = Read.GetString(16);
                    _Degree = Read.GetString(17);
                    _Year_Received = Read.GetString(18);
                    _Name_Institute = Read.GetString(19);
                    _Country_Edu = Read.GetString(20);
                    _Stuffed_ID = Read.GetString(22);
                    _StuffedDate = Read.GetString(23);
                    _StuffedMonth = Read.GetString(24);
                    _StuffedMonth_En = Read.GetString(25);
                    _StuffedYear = Read.GetString(26);
                    _StuffedYear_En = Read.GetString(27);
                    _DateStarted = Read.GetString(28);
                    _MonthStarted = Read.GetString(29);
                    _MonthStarted_En = Read.GetString(30);
                    _YearStarted = Read.GetString(31);
                    _YearStarted_En = Read.GetString(32);
                    _Phone = Read.GetString(33);
                    _Pic = Read.GetString(34);
                    _blood_Grp = Read.GetString(35);

                    _ResultMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                _ResultMessage = ex.ToString();
            }
            Con.Close();
        }
    }
}
