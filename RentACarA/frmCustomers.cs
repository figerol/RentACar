using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarA
{
    public partial class frmCustomers : MetroFramework.Forms.MetroForm
    {
        RACverBEntities model;

        public frmCustomers()
        {
            InitializeComponent();

            FillListViewCustomers();
            lvCustomers.View = View.Details;
        }



        private void FillListViewCustomers()
        {
            Cursor.Current = Cursors.WaitCursor;

            lvCustomers.Items.Clear();

            if (tbSearch.Text == "")
            {
                model = new RACverBEntities();

                foreach (var c in model.Customers)
                {

                    ListViewItem it = new ListViewItem(c.CustomerID.ToString());

                    it.SubItems.Add(c.LastName);
                    it.SubItems.Add(c.FirstName);
                    it.SubItems.Add(c.Phone.ToString());
                    it.SubItems.Add(c.Email.ToString());
                    it.SubItems.Add(c.PostCode.ToString());

                    it.SubItems.Add(c.CustomerAddresses.City);
                    it.SubItems.Add(c.CustomerAddresses.Street);
                    it.SubItems.Add(c.CustomerAddresses.LocType);
                    it.SubItems.Add(c.CustomerAddresses.Building.ToString());

                    lvCustomers.Items.Add(it);

                }
                Cursor.Current = Cursors.Default;
            }
            else
            {
                model = new RACverBEntities();

                foreach (var c in model.Customers)
                {
                    if (c.CustomerID.ToString().ToLower() == tbSearch.Text.ToLower() ||
                        c.LastName.ToLower().Contains(tbSearch.Text.ToLower()) ||
                        c.FirstName.ToLower().Contains(tbSearch.Text.ToLower()) ||
                        c.Phone.ToString().Contains(tbSearch.Text) ||
                        c.PostCode.ToString().ToLower().Contains(tbSearch.Text) ||
                        c.DrivingLicenseNumber.ToLower().ToString().Contains(tbSearch.Text) ||
                        c.Email.ToLower().ToString().Contains(tbSearch.Text))
                    {

                        ListViewItem it = new ListViewItem(c.CustomerID.ToString());

                        it.SubItems.Add(c.LastName);
                        it.SubItems.Add(c.FirstName);
                        it.SubItems.Add(c.Phone.ToString());
                        it.SubItems.Add(c.Email.ToString());
                        it.SubItems.Add(c.PostCode.ToString());

                        it.SubItems.Add(c.CustomerAddresses.City);
                        it.SubItems.Add(c.CustomerAddresses.Street);
                        it.SubItems.Add(c.CustomerAddresses.LocType);
                        it.SubItems.Add(c.CustomerAddresses.Building.ToString());

                        lvCustomers.Items.Add(it);
                    }
                }
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmNewCustomer newcust = new frmNewCustomer();
            newcust.ShowDialog();
        }

        private void tbSearch_TextChanged(object sender, KeyEventArgs e)
        {

            FillListViewCustomers();

        }


        private void lvCustomers_ItemActivate(object sender, EventArgs e)
        {
            if (lvCustomers.SelectedItems.Count > 0)
            {
                ListViewItem item = lvCustomers.SelectedItems[0];
                using (RACverBEntities db = new RACverBEntities())
                {
                    int cID = Convert.ToInt32(item.SubItems[0].Text);


                    using (frmOpenCustomer frm = new frmOpenCustomer(cID))
                    {

                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            FillListViewCustomers();

                        }
                    }
                }
            }
        }

        private void btnNewRentStart_Click(object sender, EventArgs e)
        {

            if (lvCustomers.SelectedItems.Count > 0)
            {
                ListViewItem item = lvCustomers.SelectedItems[0];

                int cID = Convert.ToInt32(item.SubItems[0].Text);


                frmNewRent frmnr = new frmNewRent(cID);

                frmnr.ShowDialog();

                

            }
            else
            {
                MessageBox.Show( "Nincs kijelölt kliens !", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        private void frmCustomers_Load(object sender, EventArgs e)
        {

        }


    }
}

