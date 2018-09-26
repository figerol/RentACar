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
    public partial class frmVehicles : MetroFramework.Forms.MetroForm
    {
        RACverBEntities model;

        public frmVehicles()
        {
            InitializeComponent();
            FillListViewVehicles();
            lvVehicles.View = View.Details;

        }





        private void btnNewVehicle_Click(object sender, EventArgs e)
        {
            frmNewVehicle newVec = new frmNewVehicle();
            newVec.ShowDialog();
        }

        private void FillListViewVehicles()
        {
            model = new RACverBEntities();

            Cursor.Current = Cursors.WaitCursor;

            lvVehicles.Items.Clear();

            if (tbSearch.Text == "")
            {
                foreach (var v in model.Vehicles)
                {

                    string state = "Bérelhető";

                    if (v.Avalaible == false)
                    {
                        state = "Foglalt";
                    }


                    ListViewItem it = new ListViewItem(v.VehicleID.ToString());

                    it.SubItems.Add(state);
                    it.SubItems.Add(v.Made);                 
                    it.SubItems.Add(v.VehiclePlatesAndModels1.Model);
                    it.SubItems.Add(v.VehiclePlatesAndModels1.Plate);
                    it.SubItems.Add(v.Type);
                    it.SubItems.Add(v.Mileage.ToString());
                    it.SubItems.Add(v.Price.ToString());


                    lvVehicles.Items.Add(it);
                    Cursor.Current = Cursors.Default;
                }
            }
            else
            {
                model = new RACverBEntities();

                foreach (var v in model.Vehicles)
                {
                    if (v.VehicleID.ToString().ToLower() == tbSearch.Text.ToLower() ||
                        v.Made.ToLower().Contains(tbSearch.Text.ToLower()) ||
                        v.VehiclePlatesAndModels1.Model.ToLower().Contains(tbSearch.Text.ToLower()) ||
                        v.VehiclePlatesAndModels1.Plate.ToString().Contains(tbSearch.Text) ||
                        v.Type.ToString().ToLower().Contains(tbSearch.Text) ||
                        v.Mileage.ToString().Contains(tbSearch.Text) ||
                        v.Price.ToString().Contains(tbSearch.Text))
                    {

                        string state = "Bérelhető";

                        if (v.Avalaible == false)
                        {
                            state = "Foglalt";
                        }

                        ListViewItem it = new ListViewItem(v.VehicleID.ToString());

                        it.SubItems.Add(state);
                        it.SubItems.Add(v.Made);
                        it.SubItems.Add(v.VehiclePlatesAndModels1.Model);
                        it.SubItems.Add(v.VehiclePlatesAndModels1.Plate);
                        it.SubItems.Add(v.Type);
                        it.SubItems.Add(v.Mileage.ToString());
                        it.SubItems.Add(v.Price.ToString());

                        lvVehicles.Items.Add(it);
                    }
                }

                Cursor.Current = Cursors.Default;


            }


        }

        private void lvVehicles_ItemActivate(object sender, EventArgs e)
        {
            if (lvVehicles.SelectedItems.Count > 0)
            {
                ListViewItem item = lvVehicles.SelectedItems[0];
                using (RACverBEntities db = new RACverBEntities())
                {
                    int vID = Convert.ToInt32(item.SubItems[0].Text);


                    using (frmOpenVehicle frm = new frmOpenVehicle(vID))
                    {

                        frm.ShowDialog();
                        
                            FillListViewVehicles();

                        
                    }
                }
            }
        }
    }
}
