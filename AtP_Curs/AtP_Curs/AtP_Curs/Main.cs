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

        App_data.DBWork b = new App_data.DBWork();

        private void Main_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = b.ShowTable();
            dataGridView1.Update();
        }

        private bool CheckSettings()
        {
            string settings = @"settings.txt";
            if (File.Exists(settings))
            {
                string[] mass = File.ReadAllLines(settings);
            }
            else
            {
                Application.Run(new FSearchDatabase());
            }

            return false;
        }
    }
}
