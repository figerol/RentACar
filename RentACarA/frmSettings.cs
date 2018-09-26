using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace RentACarA
{
    public partial class frmSettings : MetroFramework.Forms.MetroForm
    {
       

        public frmSettings()
        {
            InitializeComponent();
            
            


        }


        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();

        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.OK;


        }

       

    }
}
