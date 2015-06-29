using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace TeacherForeignPro
{
    class TPassportExp
    {
        public String Passport { get { return _Passport; } set { _Passport = value; } }
        public String PassportExpDate { get { return _PassportExpDate; } set { _PassportExpDate = value; } }
        public String PassportExpMonth { get { return _PassportExpMonth; } set { _PassportExpMonth = value; } }
        public String PassportExpMonth_En { get { return _PassportExpMonth_En; } set { _PassportExpMonth_En = value; } }
        public String PassportExpMonth_Text { get { return _PassportExpMonth_Text; } set { _PassportExpMonth_Text = value; } }
        public String PassportExpYear { get { return _PassportExpYear; } set { _PassportExpYear = value; } }
        public String PassportExpYear_En { get { return _PassportExpYear_En; } set { _PassportExpYear_En = value; } }
        public String ContractDate { get { return _ContractDate; } set { _ContractDate = value; } }
        public String ContractMonth { get { return _ContractMonth; } set { _ContractMonth = value; } }
        public String ContractMonth_En { get { return _ContractMonth_En; } set { _ContractMonth_En = value; } }
        public String ContractMonth_Text { get { return _ContractMonth_Text; } set { _ContractMonth_Text = value; } }
        public String ContractYear { get { return _ContractYear; } set { _ContractYear = value; } }
        public String ContractYear_En { get { return _ContractYear_En; } set { _ContractYear_En = value; } }
        public String CheckStetar { get { return _CheckStetar; } set { _CheckStetar = value; } }
        public String ErrorMessage { get { return _ErrorMessage; } }
        public String SuccessMessage { get { return _SuccessMessage; } }

        private string _Passport;
        private string _PassportExpDate;
        private string _PassportExpMonth;
        private string _PassportExpMonth_En;
        private string _PassportExpMonth_Text;
        private string _PassportExpYear;
        private string _PassportExpYear_En;
        private string _ContractDate;
        private string _ContractMonth;
        private string _ContractMonth_En;
        private string _ContractMonth_Text;
        private string _ContractYear;
        private string _ContractYear_En;
        private string _CheckStetar;

        private string _ErrorMessage;
        private string _SuccessMessage;
        private string var_ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\Database\\Data.mdb;User Id=admin;Password=;";

        private string[] Columns = new string[]{
            "TPassportExp",             // Table name
            "Passport",                 // 1
            "PassportExpDate",          // 2
            "PassportExpMonth",         // 3
            "PassportExpMonth_En",      // 4
            "PassportExpMonth_Text",    // 5
            "PassportExpYear",          // 6
            "PassportExpYear_En",       // 7
            "ContractDate",             // 8
            "ContractMonth",            // 9
            "ContractMonth_En",         // 10
            "ContractMonth_Text",       // 11
            "ContractYear",             // 12
            "ContractYear_En",          // 13
            "CheckStetar",              // 14
        };

        public string FormatColumn(string _Column, string _Format)
        {
            string r = "";
            char _Open = _Format[0];
            char _Close = _Format[1];
            r = _Open + _Column + _Close;
            return r;
        }

        public bool NewTeacher()
        {
            bool IsResult = false;
            _Passport = string.Empty;
            _PassportExpDate = string.Empty;
            _PassportExpMonth = string.Empty;
            _PassportExpMonth_En = string.Empty;
            _PassportExpMonth_Text = string.Empty;
            _PassportExpYear = string.Empty;
            _PassportExpYear_En = string.Empty;
            _ContractDate = string.Empty;
            _ContractMonth = string.Empty;
            _ContractMonth_En = string.Empty;
            _ContractMonth_Text = string.Empty;
            _ContractYear = string.Empty;
            _ContractYear_En = string.Empty;
            _CheckStetar = string.Empty;
            IsResult = true;
            return IsResult;
        }

        public bool SelectTeacher()
        {
            bool IsResult = false;
            if (_Passport == string.Empty) { _ErrorMessage = "A Property _Passport no assign."; return IsResult; }

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
                    _PassportExpDate = Reader.GetValue(1).ToString();
                    _PassportExpMonth = Reader.GetValue(2).ToString();
                    _PassportExpMonth_En = Reader.GetValue(3).ToString();
                    _PassportExpMonth_Text = Reader.GetValue(4).ToString();
                    _PassportExpYear = Reader.GetValue(5).ToString();
                    _PassportExpYear_En = Reader.GetValue(6).ToString();
                    _ContractDate = Reader.GetValue(7).ToString();
                    _ContractMonth = Reader.GetValue(8).ToString();
                    _ContractMonth_En = Reader.GetValue(9).ToString();
                    _ContractMonth_Text = Reader.GetValue(10).ToString();
                    _ContractYear = Reader.GetValue(11).ToString();
                    _ContractYear_En = Reader.GetValue(12).ToString();
                    _CheckStetar = Reader.GetValue(13).ToString();

                    _SuccessMessage = "Correct";
                    IsResult = true;
                }
            }
            catch (Exception ex)
            {
                _ErrorMessage = ex.ToString();               
            }
            Con.Close();
            return IsResult;
        }

        public bool UpdateTeacher()
        {
            bool IsSuccess = false;
            string var_UpdateQuery = "update " + FormatColumn(Columns[0], "[]") +
                                     "set " +
                                     FormatColumn(Columns[2], "[]") + "='" + _PassportExpDate + "', " +
                                     FormatColumn(Columns[3], "[]") + "='" + _PassportExpMonth + "', " +
                                     FormatColumn(Columns[4], "[]") + "='" + _PassportExpMonth_En + "', " +
                                     FormatColumn(Columns[5], "[]") + "='" + _PassportExpMonth_Text + "', " +
                                     FormatColumn(Columns[6], "[]") + "='" + _PassportExpYear + "', " +
                                     FormatColumn(Columns[7], "[]") + "='" + _PassportExpYear_En + "', " +
                                     FormatColumn(Columns[8], "[]") + "='" + _ContractDate + "', " +
                                     FormatColumn(Columns[9], "[]") + "='" + _ContractMonth + "', " +
                                     FormatColumn(Columns[10], "[]") + "='" + _ContractMonth_En + "', " +
                                     FormatColumn(Columns[11], "[]") + "='" + _ContractMonth_Text + "', " +
                                     FormatColumn(Columns[12], "[]") + "='" + _ContractYear + "', " +
                                     FormatColumn(Columns[13], "[]") + "='" + _ContractYear_En + "', " +
                                     FormatColumn(Columns[14], "[]") + "='" + _CheckStetar + "', " +
                                     "where " +
                                     FormatColumn(Columns[1], "[]") + "='" + _Passport + "'";

            OleDbConnection Con = new OleDbConnection(var_ConnectionString);
            OleDbCommand Com = new OleDbCommand(var_UpdateQuery, Con);
            try
            {
                Con.Open();
                Com.ExecuteNonQuery();
                _SuccessMessage = "Correct";
                IsSuccess = true;
            }
            catch (Exception ex)
            {
                _ErrorMessage = ex.ToString();
            }
            Con.Close();
            return IsSuccess;
        }
    }
}
