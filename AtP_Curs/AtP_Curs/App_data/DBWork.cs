using System;
using System.Data.OleDb; // connect to ole db
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
        // method check users in table
        public bool UCheck()
        {
            string conStr = @"Data Source=(local);Initial Catalog =user; Integrate Security=true";

            SqlConnection connection = new SqlConnection(conStr);
            
            try
            {
                connection.Open();
                Console.WriteLine(connection.State);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
                Console.WriteLine(connection.State);
            }

            return false;
        }
    }
}
