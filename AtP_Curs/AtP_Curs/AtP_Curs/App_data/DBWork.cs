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
        private void Connect()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\App_data\data\Diary.accdb;Persist Security Info=False");
            command = connection.CreateCommand();
        }

        public DBWork()
        {
            Connect();
        }

        public DataTable ShowTable()
        {
            string sql = "SELECT * FROM [User]";
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            connection.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable scores = new DataTable();
            da.Fill(scores);
            connection.Close();
            return scores;
        }

    }
}
