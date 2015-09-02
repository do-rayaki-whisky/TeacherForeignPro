using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

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
        public String Active
        {
            get { return _Active; }
            set { _Active = value; }
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
        private string _Active;

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
                    _Passport = Read.GetString(1).Trim();
                    _Th_Title = Read.GetString(2).Trim();
                    _Th_Name = Read.GetString(3).Trim();
                    _Th_Lastname = Read.GetString(4).Trim();
                    _En_Title = Read.GetString(5).Trim();
                    _En_Name = Read.GetString(6).Trim();
                    _En_Lastname = Read.GetString(7).Trim();
                    _Sex = Read.GetString(8).Trim();
                    _Nationality = Read.GetString(9).Trim();
                    _Nationality_En = Read.GetString(10).Trim();
                    _Date_Birth = Read.GetString(11).Trim();
                    _Month_Birth = Read.GetString(12).Trim();
                    _Month_Birth_En = Read.GetString(13).Trim();
                    _Year_Birth = Read.GetString(14).Trim();
                    _Year_Birth_En = Read.GetString(15).Trim();
                    _Age = Read.GetString(16).Trim();
                    _Degree = Read.GetString(17).Trim();
                    _Year_Received = Read.GetString(18).Trim();
                    _Name_Institute = Read.GetString(19).Trim();
                    _Country_Edu = Read.GetString(20).Trim();
                    _Stuffed_ID = Read.GetString(22).Trim();
                    _StuffedDate = Read.GetString(23).Trim();
                    _StuffedMonth = Read.GetString(24).Trim();
                    _StuffedMonth_En = Read.GetString(25).Trim();
                    _StuffedYear = Read.GetString(26).Trim();
                    _StuffedYear_En = Read.GetString(27).Trim();
                    _DateStarted = Read.GetString(28).Trim();
                    _MonthStarted = Read.GetString(29).Trim();
                    _MonthStarted_En = Read.GetString(30).Trim();
                    _YearStarted = Read.GetString(31).Trim();
                    _YearStarted_En = Read.GetString(32).Trim();
                    _Phone = Read.GetString(33).Trim();
                    _Pic = Read.GetString(34).Trim();
                    _blood_Grp = Read.GetString(35).Trim();
                    _Active = Read.GetValue(36).ToString();

                    _ResultMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                _ResultMessage = ex.ToString();
            }
            Con.Close();
        }

        public string ImageLocation(string _ImageName)
        {
            string Result = string.Empty;
            if (_ImageName == string.Empty) { } else { Result = ".//Pic/" + _ImageName + ".jpg"; }
            return Result;
        }

        public void NewTeacher()
        {
            _HisID = string.Empty;
            _Passport = string.Empty;
            _Th_Title = string.Empty; ;
            _Th_Name = string.Empty;
            _Th_Lastname = string.Empty;
            _En_Title = string.Empty; ;
            _En_Name = string.Empty;
            _En_Lastname = string.Empty;
            _Sex = string.Empty; ;
            _Nationality = string.Empty;
            _Nationality_En = string.Empty;
            _Date_Birth = string.Empty;
            _Month_Birth = string.Empty; ;
            _Month_Birth_En = string.Empty;
            _Year_Birth = string.Empty;
            _Year_Birth_En = string.Empty;
            _Age = string.Empty;
            _Degree = string.Empty;
            _Year_Received = string.Empty;
            _Name_Institute = string.Empty;
            _Country_Edu = string.Empty;
            _Stuffed_ID = string.Empty;
            _StuffedDate = string.Empty;
            _StuffedMonth = string.Empty; ;
            _StuffedMonth_En = string.Empty;
            _StuffedYear = string.Empty;
            _StuffedYear_En = string.Empty;
            _DateStarted = string.Empty;
            _MonthStarted = string.Empty;
            _MonthStarted_En = string.Empty;
            _YearStarted = string.Empty;
            _YearStarted_En = string.Empty;
            _Phone = string.Empty;
            _Pic = string.Empty;
            _blood_Grp = string.Empty;
            _Active = "1";
        }

        public void InsertTeacher()
        {
            if (_Passport == string.Empty)
            {
                _ResultMessage = "หมายเลข Passport ว่างเปล่าไม่ได้";
                return;
            }
            if(_HisID == string.Empty)
            {
                _ResultMessage = "รหัสประจำตัวครูว่างเปล่าไม่ได้";
            }

            bool n = _HisID.IsNumeric();          
            if (n == false)
            {
                _ResultMessage = "รหัสครูต้องเป็นตัวเลขเท่านั้น";
                return;
            }
   
            string var_QuerySelectPassportA = "select [Passport] from [THistory] where [Passport]='" + _Passport + "'";
            string var_QuerySelectPassportB = "select [HisID] from [THistory] where [HisID]=" + _HisID;
            string var_QuerySelectPassportC = "select [Passport], [HisID] from [THistory] where [Passport]='" + _Passport + "' and [HisID]=" + _HisID;

            string var_QueryInsertTHistory = "insert into [THistory] ([Passport], [HisID], [Active]) values ('" + _Passport + "', " + _HisID + ", " + _Active + ")";
            string var_QueryInsterTDocument = "insert into [TDocument] ([Passport]) values ('" + _Passport + "')";
            string var_QueryInsterTPassportExp = "insert into [TPassportExp] ([Passport]) values ('" + _Passport + "')";
            string var_QueryInsterTWorkplace = "insert into [TWorkplace] ([Passport]) values ('" + _Passport + "')";

            bool var_HasKeyPassport;
            bool var_HasKeyHisID;
            bool var_HasKeyPassportAndHisID;

            OleDbConnection Con = new OleDbConnection(ConnectionString);      
            OleDbCommand Com = new OleDbCommand();
            OleDbDataReader Reader;
            
            try
            {
                Con.Open();
                Com.Connection = Con;
                Com.CommandText = var_QuerySelectPassportA;
                Reader = Com.ExecuteReader();
                var_HasKeyPassport = Reader.HasRows;
                Reader.Close();

                Com.CommandText = var_QuerySelectPassportB;
                Reader = Com.ExecuteReader();
                var_HasKeyHisID = Reader.HasRows;
                Reader.Close();

                Com.CommandText = var_QuerySelectPassportC;
                Reader = Com.ExecuteReader();
                var_HasKeyPassportAndHisID = Reader.HasRows;
                Reader.Close();

                if ((var_HasKeyPassport == true) && (var_HasKeyHisID == true) && (var_HasKeyPassportAndHisID == true))
                {
                    _ResultMessage = UpdateTeacher();
                }
                else if ((var_HasKeyPassport == false) && (var_HasKeyHisID == false) && (var_HasKeyPassportAndHisID == false))
                {                    
                    Com.CommandText = var_QueryInsertTHistory;
                    Com.ExecuteNonQuery();

                    Com.CommandText = var_QueryInsterTDocument;
                    Com.ExecuteNonQuery();

                    Com.CommandText = var_QueryInsterTPassportExp;
                    Com.ExecuteNonQuery();

                    Com.CommandText = var_QueryInsterTWorkplace;
                    Com.ExecuteNonQuery();

                    _ResultMessage = UpdateTeacher();
                }
                else if ((var_HasKeyPassport == true) && (var_HasKeyHisID == false) && (var_HasKeyPassportAndHisID == false))
                {
                    _ResultMessage = "หมายเลข Passport " + _Passport + " มีอยู่ในฐานข้อมูลแล้ว";
                }
                else if ((var_HasKeyPassport == false) && (var_HasKeyHisID == true) && (var_HasKeyPassportAndHisID == false))
                {
                    _ResultMessage = "หมายเลขประจำตัวครู " + _HisID + " มีอยู่ในฐานข้อมูลแล้ว";
                }
            }
            catch (Exception ex)
            {
                _ResultMessage = ex.Message;
            }
            Con.Close();
        }

        public string UpdateTeacher()
        {
            string var_UpdateQuery = "update [THistory] " +
                                     "set [Th_Title]='" + _Th_Title + "', " +
                                     "[Th_Name]='" + _Th_Name + "', " +
                                     "[Th_Lastname]='" + _Th_Lastname + "', " +
                                     "[En_Title]='" + _En_Title + "', " +
                                     "[En_Name]='" + _En_Name + "', " +
                                     "[En_Lastname]='" + _En_Lastname + "', " +
                                     "[Sex]='" + _Sex + "', " +
                                     "[Nationality]='" + _Nationality + "', " +
                                     "[Nationality_En]='" + _Nationality_En + "', " +
                                     "[Date_Birth]='" + _Date_Birth + "', " +
                                     "[Month_Birth]='" + _Month_Birth + "', " +
                                     "[Month_Birth_En]='" + _Month_Birth_En + "', " +
                                     "[Year_Birth]='" + _Year_Birth + "', " +
                                     "[Year_Birth_En]='" + _Year_Birth_En + "', " +
                                     "[Age]='" + _Age + "', " +
                                     "[Degree]='" + _Degree + "', " +
                                     "[Year_Received]='" + _Year_Received + "', " +
                                     "[Name_Institute]='" + _Name_Institute + "', " +
                                     "[Country_Edu]='" + _Country_Edu + "', " +
                                     "[Stuffed_ID]='" + _Stuffed_ID + "', " +
                                     "[StuffedDate]='" + _StuffedDate + "', " +
                                     "[StuffedMonth]='" + _StuffedMonth + "', " +
                                     "[StuffedMonth_En]='" + _StuffedMonth_En + "', " +
                                     "[StuffedYear]='" + _StuffedYear + "', " +
                                     "[StuffedYear_En]='" + _StuffedYear_En + "', " +
                                     "[DateStarted]='" + _DateStarted + "', " +
                                     "[MonthStarted]='" + _MonthStarted + "', " +
                                     "[MonthStarted_En]='" + _MonthStarted_En + "', " +
                                     "[YearStarted]='" + _YearStarted + "', " +
                                     "[YearStarted_En]='" + _YearStarted_En + "', " +
                                     "[Phone]='" + _Phone + "', " +
                                     "[Pic]='" + _Pic + "', " +
                                     "[blood_Grp]='" + _blood_Grp + "', " +
                                     "[Active]=" + _Active + " " +
                                     "where " +
                                     "[HisID]=" + _HisID + " and " +
                                     "[Passport]='" + _Passport + "'";
            OleDbConnection Con = new OleDbConnection(ConnectionString);
            OleDbCommand Com = new OleDbCommand(var_UpdateQuery, Con);
            string r = "None";
            try
            {
                Con.Open();
                r = Com.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                r = ex.ToString();
            }
            Con.Close();
            return r;
        }
        ///<summary>
        ///ChangeStatusTeacher Function is Change 3 type of status.
        ///0 = Delete
        ///1 = Active (Default)
        ///2 = Unactive
        ///</summary>
        public bool ChangeStatusTeacher(int _Status)
        {
            bool IsSuccess = false;
            _Passport = _Passport.Trim();
            if ((_Passport == "") || (_Passport == string.Empty) || (_Passport.Length < 1)) { _ResultMessage = "_Passport is NULL"; return IsSuccess = false; }
            if ((_HisID == "") || (_HisID == string.Empty) || (_HisID.Length < 1)) { _ResultMessage = "_HisID is NULL"; return IsSuccess = false; }
            string var_UpdateStatus = "update [THistory] set [Active] =" + _Status + " where [HisID]=" + _HisID + " and [Passport]='" + _Passport + "'";
            OleDbConnection Con = new OleDbConnection(ConnectionString);
            OleDbCommand Com = new OleDbCommand(var_UpdateStatus, Con);
            try
            {
                Con.Open();
                Com.ExecuteNonQuery();
                _ResultMessage = "ลบเสร็จแหละ";
                IsSuccess = true;
            }
            catch (Exception ex) { _ResultMessage = ex.ToString(); }
            Con.Close();
            return IsSuccess;
        }
        public string AutoTeacherNumber()
        {
            int _result = 0;
            string varMaxCommand = "select max([HisID]) from [THistory]";
            OleDbConnection Con = new OleDbConnection(ConnectionString);
            OleDbCommand Com = new OleDbCommand(varMaxCommand, Con);
            OleDbDataReader ObjectMaxTeacherID;
            try
            {
                Con.Open();
                ObjectMaxTeacherID = Com.ExecuteReader();
                ObjectMaxTeacherID.Read();
                _result = Convert.ToInt32(ObjectMaxTeacherID.GetValue(0).ToString()) + 1;
            }
            catch
            {
                _result = 1;
            }
            return _result.ToString();
        }
        ///<summary>
        /// คัดลอกรูปภาพมาเก็บไว้ที่ Folder ของโปรแกรม
        /// <para>Return Image Location (New Path)</para>
        ///</summary>
        public string Role_GetPicture(string _TeacherNumber, string _School)
        {
            if (_TeacherNumber.Trim() == string.Empty) { _ResultMessage = "No Teacher Number"; return string.Empty; }
            if (_School.Trim() == string.Empty) { _ResultMessage = "No School Name"; return string.Empty; }
            OpenFileDialog Jane_OpenPicture = new OpenFileDialog();
            string Var_FileName = string.Empty;
            string Var_FullPath = string.Empty;
            string Var_NewFileName = string.Empty;
            string Var_NewPath = string.Empty;
            string Var_Prefix = string.Empty;
            string Var_Extension = string.Empty;
            if (_School == "มารีวิทย์") { Var_Prefix = "P"; }
            else if (_School == "มารีวิทย์สัตหีบ") { Var_Prefix = "S"; }
            else if (_School == "มารีวิทย์บ่อวิน") { Var_Prefix = "B"; }
            Jane_OpenPicture.Filter = "Image File|*.jpg";           
            if (Jane_OpenPicture.ShowDialog() == DialogResult.OK)
            {
                Var_FileName = Jane_OpenPicture.SafeFileName;
                Var_FullPath = Jane_OpenPicture.FileName;
                Var_Extension = Path.GetExtension(Var_FullPath);        
                Var_NewFileName = Var_Prefix + _TeacherNumber;
                Var_NewPath = @"./Pic/" + Var_NewFileName + Var_Extension;
                File.Copy(Var_FullPath, Var_NewPath , true);
            }
            return Var_NewPath;
        }
    }
}
