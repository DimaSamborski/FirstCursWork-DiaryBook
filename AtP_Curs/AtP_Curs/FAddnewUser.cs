using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtP_Curs
{
    public partial class FAddnewUser : Form
    {
        public FAddnewUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            string password = txtUserPassword.Text;

            App_data.Encryption crypt = new App_data.Encryption();

            password = crypt.EncryptString(password,14);

            App_data.DBWork db = new App_data.DBWork();

            db.InsertUser(name,password);

        }
    }
}
