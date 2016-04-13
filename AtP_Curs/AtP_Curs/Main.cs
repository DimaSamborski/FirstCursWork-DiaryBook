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
            Verification fVerification = new Verification();
            if (fVerification.ShowDialog() != DialogResult.OK) Application.Exit();


        }
        App_data.DBWork db = new App_data.DBWork();
        private void FormAdd()
        {
            cmbAddFacults.DataSource = db.InsertFacultets();
            cmbRedactingFacults.DataSource = db.InsertFacultets();
            cmbViewFacults.DataSource = db.InsertFacultets();
            cmbDeleteFacukltets.DataSource = db.InsertFacultets();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
           
        }

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
    }
}
