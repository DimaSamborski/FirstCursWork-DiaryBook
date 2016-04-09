using System;
using System.Data.OleDb; // connect to ole db
using System.Data;
using System.Data.SqlClient; // ADO connect to sql server 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtP_Curs.App_data
{
    // Class for work on db
    class DBWork
    {
        OleDbConnection connection;
        OleDbCommand command;
        private static void Connect()
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\Dima\Documents\GitHub\first_curs_normal\AtP_Curs\AtP_Curs\App_data\data\Diary.accdb; Persist Security Info=False");
            OleDbCommand command = connection.CreateCommand();
        }

        public DBWork()
        {
            Connect();
        }

        public bool UserCheck(string name, string password)
        {
            try
            {
                command.CommandText = "";
            }
            catch
            {

            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }

            }
            bool ckUser = false;
            bool ckPassword = false;



            // search user

            if ()
            {

            }

            return false;
        }
    }
}
