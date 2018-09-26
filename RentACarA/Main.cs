using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RentACarA
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();

            
        }

        

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmCustomers custs = new frmCustomers();
                        custs.Show();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            frmVehicles vehs = new frmVehicles();
            vehs.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings set = new frmSettings();
            set.ShowDialog();
           
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRents_Click(object sender, EventArgs e)
        {
            frmRents frmrent = new frmRents();
            frmrent.ShowDialog();

        }

        
    }
}
