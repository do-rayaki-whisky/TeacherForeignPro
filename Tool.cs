using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace TeacherForeignPro
{
    class Tool
    {
        public String ResultMessage { get { return _ResultMessage; } }

        OleDbConnection Jane_Connection;
        OleDbCommand Jane_Command;

        private string _ResultMessage;
        private string Var_ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\Database\\Data.mdb;User Id=admin;Password=;";

        ///<summary>
        /// Remove Duplicate Passport Number in Database.
        /// <para>Return Status Code 4 digi. 1 is Data deleted. 0 is no Data deleted.</para>
        /// <para>First digi is TDocument Table.</para>
        /// <para>Second digi is TPassportExp Table.</para>
        /// <para>Third digi is TWorkplace Table.</para>
        /// <para>Fourth digi is THistory Table.</para>
        ///</summary>
        public string RoleRemoveDuplicate(string _PassportNo)
        {
            if (_PassportNo.Trim() == string.Empty) { return _ResultMessage = "Passport No is Empty."; }
            _ResultMessage = string.Empty;
            string Var_PassportUpper = _PassportNo.ToUpper();
            string Var_PassportLower = _PassportNo.ToLower();
            string[] Var_TableName = new string[]{              
                "TDocument",
                "TPassportExp",
                "TWorkplace",
                "THistory",
            };
            string Var_TableNameTemp = string.Empty;
            string Var_DeleteCmd = string.Empty;;
            Jane_Connection = new OleDbConnection(Var_ConnectionString);
            try
            {
                Jane_Connection.Open();
                for (int i = 0; i < 4; i++)
                {
                    Var_TableNameTemp = Var_TableName[i];
                    Var_DeleteCmd = "delete from [" + Var_TableNameTemp + "] where [Passport]='" + Var_PassportUpper + "' or [Passport]='" + Var_PassportLower + "'";
                    Jane_Command = new OleDbCommand(Var_DeleteCmd, Jane_Connection);
                    try
                    {
                        _ResultMessage += Jane_Command.ExecuteNonQuery().ToString();
                    }
                    catch (Exception Ex)
                    {
                        _ResultMessage = Ex.Message;
                    }
                }
            }
            catch (Exception Ex)
            {
                _ResultMessage = Ex.Message;
            }
            Jane_Connection.Close();
            return _ResultMessage;
        }
    }
}
