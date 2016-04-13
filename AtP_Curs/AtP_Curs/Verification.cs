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

            App_data.Encryption crypt = new App_data.Encryption();
            App_data.DBWork b = new App_data.DBWork();

            password = crypt.EncryptString(password, 14);

            if(b.UserCheck(name, password))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Неправильний логін або пароль");
            }
        }

        
    }
}
