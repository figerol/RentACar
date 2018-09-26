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
    public partial class frmRents : MetroFramework.Forms.MetroForm
    {
        RACverBEntities model = new RACverBEntities();

        public frmRents()
        {
            InitializeComponent();
            FillListViewRents();
        }

        private void FillListViewRents()
        {
            Cursor.Current = Cursors.WaitCursor;

            lvRents.Items.Clear();

            if (tbSearch.Text == "")
            {
                foreach (var r in model.Rents)
                {
                    string activeRent = "Aktív";

                    if (r.DateFrom <= r.DateBack)
                    {
                        activeRent = "Lezárt";
                    }

                    ListViewItem it = new ListViewItem(r.RentalID.ToString());

                    it.SubItems.Add(activeRent);
                    it.SubItems.Add(r.CustomerID.ToString());
                    it.SubItems.Add(r.Customers.LastName.ToString());
                    it.SubItems.Add(r.Customers.FirstName.ToString());
                    it.SubItems.Add(r.VehicleID.ToString());
                    it.SubItems.Add(r.Vehicles.Made);
                    it.SubItems.Add(r.Vehicles.VehiclePlatesAndModels1.Model);
                    it.SubItems.Add(r.DateFrom.ToShortDateString());
                    it.SubItems.Add(r.DateBack.ToShortDateString());

                    lvRents.Items.Add(it);

                }
                Cursor.Current = Cursors.Default;
            }
            else
            {
                foreach (var r in model.Rents)
                {
                    if (r.RentalID.ToString().ToLower() == tbSearch.Text.ToLower() ||
                        r.CustomerID.ToString().ToLower() == tbSearch.Text.ToLower() ||
                        r.Customers.LastName.ToLower().Contains(tbSearch.Text.ToLower()) ||
                        r.Customers.FirstName.ToLower().Contains(tbSearch.Text.ToLower()) ||
                        r.VehicleID.ToString().ToLower() == tbSearch.Text.ToLower() ||
                        r.Vehicles.Made.ToLower().Contains(tbSearch.Text.ToLower()) ||
                        r.Vehicles.VehiclePlatesAndModels1.Model.ToLower().Contains(tbSearch.Text.ToLower()) ||
                        r.DateFrom.ToShortDateString().ToLower() == tbSearch.Text.ToLower() ||
                        r.DateBack.ToShortDateString().ToLower() == tbSearch.Text.ToLower())
                    {
                        string activeRent = "Aktív";

                        if (r.DateFrom <= r.DateBack)
                        {
                            activeRent = "Lezárt";
                        }

                        ListViewItem it = new ListViewItem(r.RentalID.ToString());


                        it.SubItems.Add(r.CustomerID.ToString());
                        it.SubItems.Add(activeRent);
                        it.SubItems.Add(r.Customers.LastName.ToString());
                        it.SubItems.Add(r.VehicleID.ToString());
                        it.SubItems.Add(r.Vehicles.Made);
                        it.SubItems.Add(r.Vehicles.VehiclePlatesAndModels1.Model);
                        it.SubItems.Add(r.DateFrom.ToShortTimeString());
                        it.SubItems.Add(r.DateBack.ToShortTimeString());

                        lvRents.Items.Add(it);
                    }
                }
                Cursor.Current = Cursors.Default;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            FillListViewRents();
        }

        private void lvRents_ItemActivate(object sender, EventArgs e)
        {
            int active;

            ListViewItem it = lvRents.SelectedItems[0];
            if (it.SubItems[1].Text == "Aktív")
            {
                active = 1;
            }
            else
            {
                active = 2;
            }
            

            switch (active)
            {
                case 1:
                    if (lvRents.SelectedItems.Count > 0)
                    {
                        ListViewItem item = lvRents.SelectedItems[0];

                        int rID = Convert.ToInt32(item.SubItems[0].Text);


                        using (frmOpenRentDetails frm1 = new frmOpenRentDetails(rID))
                        {

                            if (frm1.ShowDialog() == DialogResult.OK)
                            {
                                Rents end = model.Rents.Find(rID);
                                end.Vehicles.Avalaible = true;
                                end.DateBack = DateTime.Today;
                                

                                //end.Vehicles.Mileage
                                

                                model.SaveChanges();
                                FillListViewRents();



                            }
                        }
                    }
                    break;


                case 2:
                    if (lvRents.SelectedItems.Count > 0)
                    {
                        ListViewItem item = lvRents.SelectedItems[0];

                        int rID = Convert.ToInt32(item.SubItems[0].Text);


                        using (frmOpenClosedRent frm2 = new frmOpenClosedRent(rID))
                        {

                            if (frm2.ShowDialog() == DialogResult.OK)
                            {
                               

                                FillListViewRents();



                            }
                        }
                    }
                    break;
            }
        }
    }
}
