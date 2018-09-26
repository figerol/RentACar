using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarA
{
    public partial class frmNewCustomer : MetroFramework.Forms.MetroForm
    {
        RACverBEntities db = new RACverBEntities();

        enum locationstype
        {
            utca,
            ut,
            tér,
            sétány,
            egyéb

        }



        public frmNewCustomer()
        {
            InitializeComponent();

            cbLocType.DataSource = Enum.GetValues(typeof(locationstype));


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customers model = new Customers();
            CustomerAddresses adrs = new CustomerAddresses();
           
            if (string.IsNullOrEmpty(tbLastName.Text))  // string.IsNullOrEmpty(tbLastName.Text)
            {
                MessageBox.Show("A vezetéknév mező nem lehet üres !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                model.LastName = tbLastName.Text.Trim();

            }

            if (string.IsNullOrEmpty(tbFirstName.Text))  // string.IsNullOrEmpty(tbLastName.Text)
            {
                MessageBox.Show("A keresztnév mező nem lehet üres !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                model.FirstName = tbFirstName.Text.Trim();
            }

            if (string.IsNullOrEmpty(tbEmail.Text))  // string.IsNullOrEmpty(tbLastName.Text)
            {
                MessageBox.Show("Az E-mail mező nem lehet üres !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else if (!(IsEmailValid(tbEmail.Text)))
            {
                MessageBox.Show("A megadott E-mail cím helytelen !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                model.Email = tbEmail.Text.Trim();
            }

            int phone;

            if (string.IsNullOrEmpty(tbPhone.Text))  // string.IsNullOrEmpty(tbLastName.Text)
            {
                MessageBox.Show("A telefonszám mező nem lehet üres !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                
            }
            else if(!(int.TryParse(tbPhone.Text, out phone)))
            {
                MessageBox.Show("A telefonszám mezőbe csak számokat írhat !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                model.Phone = phone.ToString();
            }

            if (string.IsNullOrEmpty(tbLicense.Text))  
            {
                MessageBox.Show("A jogosítványszám mező nem lehet üres !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                model.DrivingLicenseNumber = tbLicense.Text.Trim();
            }

            if (string.IsNullOrEmpty(tbPostal.Text))
            {
                MessageBox.Show("Az irányítószám mező nem lehet üres !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                model.PostCode = tbPostal.Text.Trim();
            }


            if (string.IsNullOrEmpty(tbCity.Text))
            {
                MessageBox.Show("A város mező nem lehet üres !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                adrs.City = tbCity.Text.Trim();
            }

            if (string.IsNullOrEmpty(tbStreet.Text))
            {
                MessageBox.Show("Az utca mező nem lehet üres !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                adrs.Street = tbStreet.Text.Trim();
            }

            adrs.LocType = cbLocType.Text.Trim();

            if (string.IsNullOrEmpty(tbBuilding.Text))
            {
                MessageBox.Show("A házszám mező nem lehet üres !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                adrs.Building = tbBuilding.Text.Trim();
            }


            

           
            db.Customers.Add(model);
            db.CustomerAddresses.Add(adrs);

            db.SaveChanges();
            ClearTextBoxesNewCust();
            
            this.Close();


        }

        private void ClearTextBoxesNewCust()
        {
            tbFirstName.Clear();
            tbLastName.Clear();
            tbEmail.Clear();
            tbPhone.Clear();
            tbLicense.Clear();
            tbCity.Clear();
            tbPostal.Clear();
            tbBuilding.Clear();

        }

        public bool IsEmailValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
