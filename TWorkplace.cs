using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace TeacherForeignPro
{
    class TWorkplace
    {
        public String Passport { get { return _Passport; } set { _Passport = value; } }
        public String WorkpermitNo { get { return _WorkpermitNo; } set { _WorkpermitNo = value; } }
        public String DateIssue { get { return _DateIssue; } set { _DateIssue = value; } }
        public String MonthIssue { get { return _MonthIssue; } set { _MonthIssue = value; } }
        public String MonthIssue_En { get { return _MonthIssue_En; } set { _MonthIssue_En = value; } }
        public String YearIssue { get { return _YearIssue; } set { _YearIssue = value; } }
        public String YearIssue_En { get { return _YearIssue_En; } set { _YearIssue_En = value; } }
        public String PlaceIssue { get { return _PlaceIssue; } set { _PlaceIssue = value; } }
        public String PeriodPermission { get { return _PeriodPermission; } set { _PeriodPermission = value; } }
        public String ExpireOn { get { return _ExpireOn; } set { _ExpireOn = value; } }
        public String ExpireMonth { get { return _ExpireMonth; } set { _ExpireMonth = value; } }
        public String ExpireMonth_En { get { return _ExpireMonth_En; } set { _ExpireMonth_En = value; } }
        public String ExpireYear { get { return _ExpireYear; } set { _ExpireYear = value; } }
        public String ExpireYear_En { get { return _ExpireYear_En; } set { _ExpireYear_En = value; } }
        public String PerLicenseDate { get { return _PerLicenseDate; } set { _PerLicenseDate = value; } }
        public String PerLicenseMonth { get { return _PerLicenseMonth; } set { _PerLicenseMonth = value; } }
        public String PerLicenseMonth_En { get { return _PerLicenseMonth_En; } set { _PerLicenseMonth_En = value; } }
        public String PerLicenseYear { get { return _PerLicenseYear; } set { _PerLicenseYear = value; } }
        public String PerLicenseYear_En { get { return _PerLicenseYear_En; } set { _PerLicenseYear_En = value; } }
        public String ThroughDate { get { return _ThroughDate; } set { _ThroughDate = value; } }
        public String ThroughMonth { get { return _ThroughMonth; } set { _ThroughMonth = value; } }
        public String ThroughMonth_En { get { return _ThroughMonth_En; } set { _ThroughMonth_En = value; } }
        public String ThroughYear { get { return _ThroughYear; } set { _ThroughYear = value; } }
        public String ThroughYear_En { get { return _ThroughYear_En; } set { _ThroughYear_En = value; } }
        public String Profession { get { return _Profession; } set { _Profession = value; } }
        public String JobDescription { get { return _JobDescription; } set { _JobDescription = value; } }
        public String Wage { get { return _Wage; } set { _Wage = value; } }
        public String Bossname { get { return _Bossname; } set { _Bossname = value; } }
        public String School { get { return _School; } set { _School = value; } }
        public String HomeNo { get { return _HomeNo; } set { _HomeNo = value; } }
        public String Village { get { return _Village; } set { _Village = value; } }
        public String Lane { get { return _Lane; } set { _Lane = value; } }
        public String Road { get { return _Road; } set { _Road = value; } }
        public String Tambol { get { return _Tambol; } set { _Tambol = value; } }
        public String Amphur { get { return _Amphur; } set { _Amphur = value; } }
        public String Province { get { return _Province; } set { _Province = value; } }
        public String PostCode { get { return _PostCode; } set { _PostCode = value; } }
        public String Phone { get { return _Phone; } set { _Phone = value; } }
        public String Employment_Year { get { return _Employment_Year; } set { _Employment_Year = value; } }
        public String Employment_Month { get { return _Employment_Month; } set { _Employment_Month = value; } }
        public String Employment_Day { get { return _Employment_Day; } set { _Employment_Day = value; } }
        public String Contract { get { return _Contract; } set { _Contract = value; } }
        public String ErrorMessage { get { return _ErrorMessage; } }
        public String SuccessMessage { get { return _SuccessMessage; } }
        public String ResultMessage { get { return _ResultMessage; } }

        private string _Passport;
        private string _WorkpermitNo;
        private string _DateIssue;
        private string _MonthIssue;
        private string _MonthIssue_En; 
        private string _YearIssue;
        private string _YearIssue_En; 
        private string _PlaceIssue;
        private string _PeriodPermission; 
        private string _ExpireOn;
        private string _ExpireMonth; 
        private string _ExpireMonth_En; 
        private string _ExpireYear;
        private string _ExpireYear_En; 
        private string _PerLicenseDate; 
        private string _PerLicenseMonth; 
        private string _PerLicenseMonth_En; 
        private string _PerLicenseYear;
        private string _PerLicenseYear_En; 
        private string _ThroughDate;
        private string _ThroughMonth; 
        private string _ThroughMonth_En; 
        private string _ThroughYear;
        private string _ThroughYear_En; 
        private string _Profession;
        private string _JobDescription;
        private string _Wage;
        private string _Bossname;
        private string _School;
        private string _HomeNo;
        private string _Village;
        private string _Lane;
        private string _Road;
        private string _Tambol;
        private string _Amphur;
        private string _Province;
        private string _PostCode;
        private string _Phone;
        private string _Employment_Year;
        private string _Employment_Month;
        private string _Employment_Day;
        private string _Contract;

        private string _ResultMessage;
        private string _ErrorMessage;
        private string _SuccessMessage;
        private string var_ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\Database\\Data.mdb;User Id=admin;Password=;";

        private string[] Columns = new string[]{
            "TWorkplace",           // 0
            "Passport",             // 1
            "WorkpermitNo",         // 2
            "DateIssue",            // 3
            "MonthIssue",           // 4
            "MonthIssue_En",        // 5
            "YearIssue ",           // 6
            "YearIssue_En",         // 7
            "PlaceIssue ",          // 8
            "PeriodPermission",     // 9
            "ExpireOn",             // 10
            "ExpireMonth",          // 11
            "ExpireMonth_En",       // 12
            "ExpireYear",           // 13
            "ExpireYear_En",        // 14
            "PerLicenseDate",       // 15
            "PerLicenseMonth",      // 16
            "PerLicenseMonth_En",   // 17
            "PerLicenseYear",       // 18
            "PerLicenseYear_En",    // 19
            "ThroughDate",          // 20
            "ThroughMonth",         // 21
            "ThroughMonth_En",      // 22
            "ThroughYear",          // 23
            "ThroughYear_En",       // 24
            "Profession",           // 25
            "JobDescription",       // 26
            "Wage",                 // 27
            "Bossname",             // 28
            "School",               // 29
            "HomeNo",               // 30
            "Village",              // 31
            "Lane",                 // 32
            "Road",                 // 33
            "Tambol",               // 34
            "Amphur",               // 35
            "Province",             // 36
            "PostCode",             // 37
            "Phone",                // 38
            "Employment_Year",      // 39
            "Employment_Month",     // 40
            "Employment_Day",       // 41
            "Contract",             // 42
        };

        public string FormatColumn(string _Column, string _Format)
        {
            string r = "";
            char _Open = _Format[0];
            char _Close = _Format[1];
            r = _Open + _Column + _Close;
            return r;
        }
        public void NewTeacher()
        {
            _Passport = string.Empty;
            _WorkpermitNo = string.Empty;
            _DateIssue = string.Empty;
            _MonthIssue = string.Empty;
            _MonthIssue_En = string.Empty;
            _YearIssue = string.Empty;
            _YearIssue_En = string.Empty;
            _PlaceIssue = string.Empty;
            _PeriodPermission = string.Empty;
            _ExpireOn = string.Empty;
            _ExpireMonth = string.Empty;
            _ExpireMonth_En = string.Empty;
            _ExpireYear = string.Empty;
            _ExpireYear_En = string.Empty;
            _PerLicenseDate = string.Empty;
            _PerLicenseMonth = string.Empty;
            _PerLicenseMonth_En = string.Empty;
            _PerLicenseYear = string.Empty;
            _PerLicenseYear_En = string.Empty;
            _ThroughDate = string.Empty;
            _ThroughMonth = string.Empty;
            _ThroughMonth_En = string.Empty;
            _ThroughYear = string.Empty;
            _ThroughYear_En = string.Empty;
            _Profession = string.Empty;
            _JobDescription = string.Empty;
            _Wage = string.Empty;
            _Bossname = string.Empty;
            _School = string.Empty;
            _HomeNo = string.Empty;
            _Village = string.Empty;
            _Lane = string.Empty;
            _Road = string.Empty;
            _Tambol = string.Empty;
            _Amphur = string.Empty;
            _Province = string.Empty;
            _PostCode = string.Empty;
            _Phone = string.Empty;
            _Employment_Year = string.Empty;
            _Employment_Month = string.Empty;
            _Employment_Day = string.Empty;
            _Contract = string.Empty;                                                                                                                                   
        }
        public bool SelectTeacher()
        {
            bool IsSuccess = false;
            if (_Passport == string.Empty) { _ErrorMessage = "A Property _Passport no assign."; return IsSuccess; }

            string var_SelectQuery = "select * from " + FormatColumn(Columns[0], "[]") + " where " + FormatColumn(Columns[1], "[]") + "='" + _Passport + "'";
            OleDbConnection Con = new OleDbConnection(var_ConnectionString);
            OleDbCommand Com = new OleDbCommand(var_SelectQuery, Con);
            OleDbDataReader Reader;

            try
            {
                Con.Open();
                Reader = Com.ExecuteReader();

                if (Reader.HasRows == true)
                {
                    Reader.Read();

                    _Passport = Reader.GetValue(0).ToString();
                    _WorkpermitNo = Reader.GetValue(1).ToString();
                    _DateIssue = Reader.GetValue(2).ToString();
                    _MonthIssue = Reader.GetValue(3).ToString();
                    _MonthIssue_En = Reader.GetValue(4).ToString();
                    _YearIssue = Reader.GetValue(5).ToString();
                    _YearIssue_En = Reader.GetValue(6).ToString();
                    _PlaceIssue = Reader.GetValue(7).ToString();
                    _PeriodPermission = Reader.GetValue(8).ToString();
                    _ExpireOn = Reader.GetValue(9).ToString();
                    _ExpireMonth = Reader.GetValue(10).ToString();
                    _ExpireMonth_En = Reader.GetValue(11).ToString();
                    _ExpireYear = Reader.GetValue(12).ToString();
                    _ExpireYear_En = Reader.GetValue(13).ToString();
                    _PerLicenseDate = Reader.GetValue(14).ToString();
                    _PerLicenseMonth = Reader.GetValue(15).ToString();
                    _PerLicenseMonth_En = Reader.GetValue(16).ToString();
                    _PerLicenseYear = Reader.GetValue(17).ToString();
                    _PerLicenseYear_En = Reader.GetValue(18).ToString();
                    _ThroughDate = Reader.GetValue(19).ToString();
                    _ThroughMonth = Reader.GetValue(20).ToString();
                    _ThroughMonth_En = Reader.GetValue(21).ToString();
                    _ThroughYear = Reader.GetValue(22).ToString();
                    _ThroughYear_En = Reader.GetValue(23).ToString();
                    _Profession = Reader.GetValue(24).ToString();
                    _JobDescription = Reader.GetValue(25).ToString();
                    _Wage = Reader.GetValue(26).ToString();
                    _Bossname = Reader.GetValue(27).ToString();
                    _School = Reader.GetValue(28).ToString();
                    _HomeNo = Reader.GetValue(29).ToString();
                    _Village = Reader.GetValue(30).ToString();
                    _Lane = Reader.GetValue(31).ToString();
                    _Road = Reader.GetValue(32).ToString();
                    _Tambol = Reader.GetValue(33).ToString();
                    _Amphur = Reader.GetValue(34).ToString();
                    _Province = Reader.GetValue(35).ToString();
                    _PostCode = Reader.GetValue(36).ToString();
                    _Phone = Reader.GetValue(37).ToString();
                    _Employment_Year = Reader.GetValue(38).ToString();
                    _Employment_Month = Reader.GetValue(39).ToString();
                    _Employment_Day = Reader.GetValue(40).ToString();
                    _Contract = Reader.GetValue(41).ToString(); 
                    _SuccessMessage = "Correct.";
                    IsSuccess = true;
                }
            }
            catch (Exception ex)
            {
                _ErrorMessage = ex.ToString();
            }
            Con.Close();
            return IsSuccess;
        }
        public string UpdateTeacher()
        {
            if (_Passport == string.Empty) { _ResultMessage = "A Property _Passport no assign."; return _ResultMessage; }

            string var_UpdateQuery = "update " + FormatColumn(Columns[0], "[]") +
                                     "set " +
                                     FormatColumn(Columns[2], "[]") + "='" + _WorkpermitNo + "', " +
                                     FormatColumn(Columns[3], "[]") + "='" + _DateIssue +"', " +
                                     FormatColumn(Columns[4], "[]") + "='" + _MonthIssue +"', " +
                                     FormatColumn(Columns[5], "[]") + "='" + _MonthIssue_En +"', " +
                                     FormatColumn(Columns[6], "[]") + "='" + _YearIssue +"', " +
                                     FormatColumn(Columns[7], "[]") + "='" + _YearIssue_En +"', " +
                                     FormatColumn(Columns[8], "[]") + "='" + _PlaceIssue +"', " +
                                     FormatColumn(Columns[9], "[]") + "='" + _PeriodPermission +"', " +
                                     FormatColumn(Columns[10], "[]") + "='" + _ExpireOn +"', " +
                                     FormatColumn(Columns[11], "[]") + "='" + _ExpireMonth +"', " +
                                     FormatColumn(Columns[12], "[]") + "='" + _ExpireMonth_En +"', " +
                                     FormatColumn(Columns[13], "[]") + "='" + _ExpireYear +"', " +
                                     FormatColumn(Columns[14], "[]") + "='" + _ExpireYear_En +"', " +
                                     FormatColumn(Columns[15], "[]") + "='" + _PerLicenseDate +"', " +
                                     FormatColumn(Columns[16], "[]") + "='" + _PerLicenseMonth +"', " +
                                     FormatColumn(Columns[17], "[]") + "='" + _PerLicenseMonth_En +"', " +
                                     FormatColumn(Columns[18], "[]") + "='" + _PerLicenseYear +"', " +
                                     FormatColumn(Columns[19], "[]") + "='" + _PerLicenseYear_En +"', " +
                                     FormatColumn(Columns[20], "[]") + "='" + _ThroughDate +"', " +
                                     FormatColumn(Columns[21], "[]") + "='" + _ThroughMonth +"', " +
                                     FormatColumn(Columns[22], "[]") + "='" + _ThroughMonth_En +"', " +
                                     FormatColumn(Columns[23], "[]") + "='" + _ThroughYear +"', " +
                                     FormatColumn(Columns[24], "[]") + "='" + _ThroughYear_En +"', " +
                                     FormatColumn(Columns[25], "[]") + "='" + _Profession +"', " +
                                     FormatColumn(Columns[26], "[]") + "='" + _JobDescription +"', " +
                                     FormatColumn(Columns[27], "[]") + "='" + _Wage + "', " +
                                     FormatColumn(Columns[28], "[]") + "='" + _Bossname +"', " +
                                     FormatColumn(Columns[29], "[]") + "='" + _School +"', " +
                                     FormatColumn(Columns[30], "[]") + "='" + _HomeNo +"', " +
                                     FormatColumn(Columns[31], "[]") + "='" + _Village +"', " +
                                     FormatColumn(Columns[32], "[]") + "='" + _Lane +"', " +
                                     FormatColumn(Columns[33], "[]") + "='" + _Road +"', " +
                                     FormatColumn(Columns[34], "[]") + "='" + _Tambol +"', " +
                                     FormatColumn(Columns[35], "[]") + "='" + _Amphur +"', " +
                                     FormatColumn(Columns[36], "[]") + "='" + _Province +"', " +
                                     FormatColumn(Columns[37], "[]") + "='" + _PostCode +"', " +
                                     FormatColumn(Columns[38], "[]") + "='" + _Phone +"', " +
                                     FormatColumn(Columns[39], "[]") + "='" + _Employment_Year +"', " +
                                     FormatColumn(Columns[40], "[]") + "='" + _Employment_Month +"', " +
                                     FormatColumn(Columns[41], "[]") + "='" + _Employment_Day +"', " +
                                     FormatColumn(Columns[42], "[]") + "='" + _Contract +"' " +
                                     "where " +
                                     FormatColumn(Columns[1], "[]") + "='" + _Passport + "'";

            OleDbConnection Con = new OleDbConnection(var_ConnectionString);
            OleDbCommand Com = new OleDbCommand(var_UpdateQuery, Con);
            try
            {
                Con.Open();
                _ResultMessage = Com.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                _ResultMessage = ex.Message;
            }
            Con.Close();
            return _ResultMessage;
        }
    }
}
