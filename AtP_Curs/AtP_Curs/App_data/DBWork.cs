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
                command.CommandText = "SELECT * FROM [User] WHERE User_name = '" + name + "' AND User_password = '" + password + "'";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read()) return true;
                else return false;

            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void InsertUser(string name, string password)
        {
            try
            {
                command.Parameters.AddWithValue("@login", name);
                command.Parameters.AddWithValue("@pass", password);
                command.CommandText = "INSERT INTO [User] ([User_name], [User_password]) VALUES(@login, @pass)";
                command.CommandType = CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
        // write all group where Facultets name == facults
        public List<string> SelectGroup(string facults)
        {
            try
            {
                command.CommandText = "SELECT * FROM [Instituts] WHERE GFacults='" + facults + "'";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                List<string> fillCombobox = new List<string>();
                string steck = null;

                while (reader.Read())
                {
                    steck = reader["names"].ToString();
                    fillCombobox.Add(steck);
                }
                return fillCombobox;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
        // write Facultets in Check box
        public List<string> InsertFacultets()
        {
            try
            {
                command.CommandText = "SELECT * FROM [Instituts]";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                List<string> fillCombobox = new List<string>();
                string steck = null;

                while (reader.Read())
                {
                    steck = reader["names"].ToString();
                    fillCombobox.Add(steck);
                }
                return fillCombobox;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
