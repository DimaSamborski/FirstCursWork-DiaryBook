using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AtP_Curs
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

       

        private void Main_Load(object sender, EventArgs e)
        {
           /* Verification fVerification = new Verification();
            if (fVerification.ShowDialog() != DialogResult.OK) Application.Exit();*/


        }

        private void FormAdd()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FAddnewUser fAddNewUser = new FAddnewUser;
            fAddNewUser.ShowDialog();
        }
        App_data.DBWork db = new App_data.DBWork();
        private void cmbRedactingFacults_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRedactingGroup.DataSource = db.SelectGroup(cmbRedactingFacults.Text);
        }

        private void cmbDeleteFacukltets_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdDeleteGroup.DataSource = db.SelectGroup(cmbDeleteFacukltets.Text);
        }

        private void cmbViewFacults_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbViewGroup.DataSource = db.SelectGroup(cmbViewFacults.Text);
        }

        private void cmbAddFacults_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
