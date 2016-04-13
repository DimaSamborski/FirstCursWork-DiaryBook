using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AtP_Curs
{
    public partial class Verification : Form
    {
        public Verification()
        {
            InitializeComponent();
        }

        private void Verification_Load(object sender, EventArgs e)
        {

        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            string name, password;
            name = txtLogin.Text;
            password = txtPassword.Text;

            /*if (CheckUser())
            {
                Application.Run(new Main());
            }
            else
            {
                bEnter.Text = "Error";
            }*/
        }

        /*private bool CheckUser(string login, string password)
        {
          
        }*/
    }
}
