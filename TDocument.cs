using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using COMiCZ;

namespace TeacherForeignPro
{
    class TDocument
    {
        public String Passport { get { return _Passport; } set { _Passport = value; } }
        public String PassportDate { get { return _PassportDate; } set { _PassportDate = value; } }
        public String PassportMonth { get { return _PassportMonth; } set { _PassportMonth = value; } }
        public String PassportMonth_En { get { return _PassportMonth_En; } set { _PassportMonth_En = value; } }
        public String PassportYear { get { return _PassportYear; } set { _PassportYear = value; } }
        public String PassportYear_En { get { return _PassportYear_En; } set { _PassportYear_En = value; } }
        public String PassportIssuedAt { get { return _PassportIssuedAt; } set { _PassportIssuedAt = value; } }
        public String KindVISA { get { return _KindVISA; } set { _KindVISA = value; } }
        public String VisaNo { get { return _VisaNo; } set { _VisaNo = value; } }
        public String VisaDate { get { return _VisaDate; } set { _VisaDate = value; } }
        public String VisaMonth { get { return _VisaMonth; } set { _VisaMonth = value; } }
        public String VisaMonth_En { get { return _VisaMonth_En; } set { _VisaMonth_En = value; } }
        public String VisaYear { get { return _VisaYear; } set { _VisaYear = value; } }
        public String VisaYear_En { get { return _VisaYear_En; } set { _VisaYear_En = value; } }
        public String VisaIssuedAt { get { return _VisaIssuedAt; } set { _VisaIssuedAt = value; } }
        public String ReachedDate { get { return _ReachedDate; } set { _ReachedDate = value; } }
        public String ReachedMonth { get { return _ReachedMonth; } set { _ReachedMonth = value; } }
        public String ReachedMonth_En { get { return _ReachedMonth_En; } set { _ReachedMonth_En = value; } }
        public String ReachedYear { get { return _ReachedYear; } set { _ReachedYear = value; } }
        public String ReachedYear_En { get { return _ReachedYear_En; } set { _ReachedYear_En = value; } }
        public String AllowedAt { get { return _AllowedAt; } set { _AllowedAt = value; } }
        public String DefineYear { get { return _DefineYear; } set { _DefineYear = value; } }
        public String DefineMonth { get { return _DefineMonth; } set { _DefineMonth = value; } }
        public String DefineDay { get { return _DefineDay; } set { _DefineDay = value; } }
        public String DueDate { get { return _DueDate; } set { _DueDate = value; } }
        public String DueMonth { get { return _DueMonth; } set { _DueMonth = value; } }
        public String DueMonth_En { get { return _DueMonth_En; } set { _DueMonth_En = value; } }
        public String DueYear { get { return _DueYear; } set { _DueYear = value; } }
        public String DueYear_En { get { return _DueYear_En; } set { _DueYear_En = value; } }
        public String Renew_Date { get { return _Renew_Date; } set { _Renew_Date = value; } }
        public String Renew_Month { get { return _Renew_Month; } set { _Renew_Month = value; } }
        public String Renew_Month_En { get { return _Renew_Month_En; } set { _Renew_Month_En = value; } }
        public String Renew_Year { get { return _Renew_Year; } set { _Renew_Year = value; } }
        public String Renew_Year_En { get { return _Renew_Year_En; } set { _Renew_Year_En = value; } }
        public String ErrorMessage { get { return _ErrorMessage; } }

        private string _Passport;
        private string _PassportDate;
        private string _PassportMonth;
        private string _PassportMonth_En;
        private string _PassportYear;
        private string _PassportYear_En;
        private string _PassportIssuedAt;
        private string _KindVISA;
        private string _VisaNo;
        private string _VisaDate;
        private string _VisaMonth;
        private string _VisaMonth_En;
        private string _VisaYear;
        private string _VisaYear_En;
        private string _VisaIssuedAt;
        private string _ReachedDate;
        private string _ReachedMonth;
        private string _ReachedMonth_En;
        private string _ReachedYear;
        private string _ReachedYear_En;
        private string _AllowedAt;
        private string _DefineYear;
        private string _DefineMonth;
        private string _DefineDay;
        private string _DueDate;
        private string _DueMonth;
        private string _DueMonth_En;
        private string _DueYear;
        private string _DueYear_En;
        private string _Renew_Date;
        private string _Renew_Month;
        private string _Renew_Month_En;
        private string _Renew_Year;
        private string _Renew_Year_En;

        private string _ErrorMessage;
        private string var_ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\Database\\Data.mdb;User Id=admin;Password=;";

        private string[] Columns = new string[]{
            "TDocument",
            "Passport",
            "PassportDate",
            "PassportMonth",
            "PassportMonth_En",
            "PassportYear",
            "PassportYear_En",
            "PassportIssuedAt",
            "Tm_Residence",
            "Tm_No",
            "Date_Issue",
            "Month_Issue",
            "Year_Issue",
            "Year_Issue_En",
            "IssuedAt",
            "Province_Issued",
            "RenewedUntil",
            "RenewedMonth",
            "RenewedMonth_En",
            "RenewedYear", 
            "RenewedYear_En", 
            "KindVISA",
            "VisaNo",
            "VisaDate", 
            "VisaMonth",
            "VisaMonth_En",
            "VisaYear",
            "VisaYear_En",
            "VisaIssuedAt",
            "ReachedDate",
            "ReachedMonth",
            "ReachedMonth_En",
            "ReachedYear",
            "ReachedYear_En",
            "AllowedAt",
            "DefineYear",
            "DefineMonth",
            "DefineDay",
            "DueDate",
            "DueMonth",
            "DueMonth_En",
            "DueYear",    
            "DueYear_En",
            "Renew_Date",
            "Renew_Month",
            "Renew_Month_En",
            "Renew_Year",
            "Renew_Year_En",
        };

        public string FormatColumn(string _Column, string _Format)
        {
            string r = "";
            char _Open = _Format[0];
            char _Close = _Format[1];
            r = _Open + _Column + _Close;
            return r;
        }
        public bool UpdateTeacher()
        {
            bool r = false;
            string var_UpdateQuery = "update " + FormatColumn(Columns[0], "[]") +
                                     "set " +
                                     FormatColumn(Columns[2], "[]") + "='" + _PassportDate + "', " +
                                     FormatColumn(Columns[3], "[]") + "='" + _PassportMonth + "', " +
                                     FormatColumn(Columns[4], "[]") + "='" + _PassportMonth_En + "', " +
                                     FormatColumn(Columns[5], "[]") + "='" + _PassportYear + "', " +
                                     FormatColumn(Columns[6], "[]") + "='" + _PassportYear_En + "', " +
                                     FormatColumn(Columns[7], "[]") + "='" + _PassportIssuedAt + "', " +
                                     FormatColumn(Columns[22], "[]") + "='" + _KindVISA + "', " +
                                     FormatColumn(Columns[23], "[]") + "='" + _VisaNo + "', " +
                                     FormatColumn(Columns[24], "[]") + "='" + _VisaDate + "', " +
                                     FormatColumn(Columns[25], "[]") + "='" + _VisaMonth + "', " +
                                     FormatColumn(Columns[26], "[]") + "='" + _VisaMonth_En + "', " +
                                     FormatColumn(Columns[27], "[]") + "='" + _VisaYear + "', " +
                                     FormatColumn(Columns[28], "[]") + "='" + _VisaYear_En + "', " +
                                     FormatColumn(Columns[29], "[]") + "='" + _VisaIssuedAt + "', " +
                                     FormatColumn(Columns[30], "[]") + "='" + _ReachedDate + "', " +
                                     FormatColumn(Columns[31], "[]") + "='" + _ReachedMonth + "', " +
                                     FormatColumn(Columns[32], "[]") + "='" + _ReachedMonth_En + "', " +
                                     FormatColumn(Columns[33], "[]") + "='" + _ReachedYear + "', " +
                                     FormatColumn(Columns[34], "[]") + "='" + _ReachedYear_En + "', " +
                                     FormatColumn(Columns[35], "[]") + "='" + _AllowedAt + "', " +
                                     FormatColumn(Columns[36], "[]") + "='" + _DefineYear + "', " +
                                     FormatColumn(Columns[37], "[]") + "='" + _DefineMonth + "', " +
                                     FormatColumn(Columns[38], "[]") + "='" + _DefineDay + "', " +
                                     FormatColumn(Columns[39], "[]") + "='" + _DueDate + "', " +
                                     FormatColumn(Columns[40], "[]") + "='" + _DueMonth + "', " +
                                     FormatColumn(Columns[41], "[]") + "='" + _DueMonth_En + "', " +
                                     FormatColumn(Columns[42], "[]") + "='" + _DueYear + "', " +
                                     FormatColumn(Columns[43], "[]") + "='" + _DueYear_En + "', " +
                                     FormatColumn(Columns[44], "[]") + "='" + _Renew_Date + "', " +
                                     FormatColumn(Columns[45], "[]") + "='" + _Renew_Month + "', " +
                                     FormatColumn(Columns[46], "[]") + "='" + _Renew_Month_En + "', " +
                                     FormatColumn(Columns[47], "[]") + "='" + _Renew_Year + "', " +
                                     FormatColumn(Columns[48], "[]") + "='" + _Renew_Year_En + "', " +
                                     "where " +
                                     FormatColumn(Columns[1], "[]") + "='" + _Passport + "'";
            OleDbConnection Con = new OleDbConnection(var_ConnectionString);
            OleDbCommand Com = new OleDbCommand(var_UpdateQuery, Con);
            int var_RowAffect;
            try
            {
                Con.Open();
                var_RowAffect = Com.ExecuteNonQuery();
                r = true;
            }
            catch
            {
                r = false;
                throw;
            }
            Con.Close();
            return r;
        }
        public void NewTeacher()
        {
            _Passport = string.Empty;
            _PassportDate = string.Empty;
            _PassportMonth = string.Empty;
            _PassportMonth_En = string.Empty;
            _PassportYear = string.Empty;
            _PassportYear_En = string.Empty;
            _PassportIssuedAt = string.Empty;
            _KindVISA = string.Empty;
            _VisaNo = string.Empty;
            _VisaDate = string.Empty;
            _VisaMonth = string.Empty;
            _VisaMonth_En = string.Empty;
            _VisaYear = string.Empty;
            _VisaYear_En = string.Empty;
            _VisaIssuedAt = string.Empty;
            _ReachedDate = string.Empty;
            _ReachedMonth = string.Empty;
            _ReachedMonth_En = string.Empty;
            _ReachedYear = string.Empty;
            _ReachedYear_En = string.Empty;
            _AllowedAt = string.Empty;
            _DefineYear = string.Empty;
            _DefineMonth = string.Empty;
            _DefineDay = string.Empty;
            _DueDate = string.Empty;
            _DueMonth = string.Empty;
            _DueMonth_En = string.Empty;
            _DueYear = string.Empty;
            _DueYear_En = string.Empty;
            _Renew_Date = string.Empty;
            _Renew_Month = string.Empty;
            _Renew_Month_En = string.Empty;
            _Renew_Year = string.Empty;
            _Renew_Year_En = string.Empty;
        }
        public bool SelectTeacher()
        {
            bool r = false;
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
                    _PassportDate = Reader.GetValue(1).ToString();
                    _PassportMonth = Reader.GetValue(2).ToString();
                    _PassportMonth_En = Reader.GetValue(3).ToString();
                    _PassportYear = Reader.GetValue(4).ToString();
                    _PassportYear_En = Reader.GetValue(5).ToString();
                    _PassportIssuedAt = Reader.GetValue(6).ToString();
                    _KindVISA = Reader.GetValue(21).ToString();
                    _VisaNo = Reader.GetValue(22).ToString();
                    _VisaDate = Reader.GetValue(23).ToString();
                    _VisaMonth = Reader.GetValue(24).ToString();
                    _VisaMonth_En = Reader.GetValue(25).ToString();
                    _VisaYear = Reader.GetValue(26).ToString();
                    _VisaYear_En = Reader.GetValue(27).ToString();
                    _VisaIssuedAt = Reader.GetValue(28).ToString();
                    _ReachedDate = Reader.GetValue(29).ToString();
                    _ReachedMonth = Reader.GetValue(30).ToString();
                    _ReachedMonth_En = Reader.GetValue(31).ToString();
                    _ReachedYear = Reader.GetValue(32).ToString();
                    _ReachedYear_En = Reader.GetValue(33).ToString();
                    _AllowedAt = Reader.GetValue(34).ToString();
                    _DefineYear = Reader.GetValue(35).ToString();
                    _DefineMonth = Reader.GetValue(36).ToString();
                    _DefineDay = Reader.GetValue(37).ToString();
                    _DueDate = Reader.GetValue(38).ToString();
                    _DueMonth = Reader.GetValue(39).ToString();
                    _DueMonth_En = Reader.GetValue(40).ToString();
                    _DueYear = Reader.GetValue(41).ToString();
                    _DueYear_En = Reader.GetValue(42).ToString();
                    _Renew_Date = Reader.GetValue(43).ToString();
                    _Renew_Month = Reader.GetValue(44).ToString();
                    _Renew_Month_En = Reader.GetValue(45).ToString();
                    _Renew_Year = Reader.GetValue(46).ToString();
                    _Renew_Year_En = Reader.GetValue(47).ToString();
                    r = true;
                }
            }
            catch (Exception ex)
            {
                _ErrorMessage = ex.ToString();
                //throw;
            }
            return r;
        }
    }
}
