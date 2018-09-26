using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarA
{
    public partial class frmOpenCustomer : MetroFramework.Forms.MetroForm
    {
        enum locationstype
        {
            utca,
            ut,
            tér,
            sétány,
            egyéb

        }

        RACverBEntities db;

        public frmOpenCustomer(int cID)
        {

            InitializeComponent();

            cbLocType.DataSource = Enum.GetValues(typeof(locationstype));

            db = new RACverBEntities();

            

            Customers c = db.Customers.Find(cID);
            CustomerAddresses adrs = db.CustomerAddresses.Find(cID);

            customersBindingSource.DataSource = c;
            customerAddressesBindingSource.DataSource = adrs;

        }
        

        private void frmOpenCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                db.SaveChanges();
                
            }
        }

       
    }
}
