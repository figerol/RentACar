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
    public partial class frmSelectVehicle : MetroFramework.Forms.MetroForm
    {
        RACverBEntities model = new RACverBEntities();

        internal int selectedVehicleID;

        public frmSelectVehicle()
        {
            InitializeComponent();
            FillListViewVehicles();

           

        }
        

        private void FillListViewVehicles()
        {
            Cursor.Current = Cursors.WaitCursor;

            lvVehicles.Items.Clear();

            if (tbSearch.Text == "")
            {
                foreach (var v in model.Vehicles)
                {



                    ListViewItem it = new ListViewItem(v.VehicleID.ToString());

                    it.SubItems.Add(v.Made);
                    it.SubItems.Add(v.VehiclePlatesAndModels1.Model);
                    it.SubItems.Add(v.VehiclePlatesAndModels1.Plate);
                    it.SubItems.Add(v.Type);
                    it.SubItems.Add(v.Mileage.ToString());
                    it.SubItems.Add(v.Price.ToString());

                    if (v.Avalaible == true)
                    {
                        lvVehicles.Items.Add(it);
                    }
                    Cursor.Current = Cursors.Default;
                }
            }
            else
            {
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

                        ListViewItem it = new ListViewItem(v.VehicleID.ToString());

                        it.SubItems.Add(v.Made);
                        it.SubItems.Add(v.VehiclePlatesAndModels1.Model);
                        it.SubItems.Add(v.VehiclePlatesAndModels1.Plate);
                        it.SubItems.Add(v.Type);
                        it.SubItems.Add(v.Mileage.ToString());
                        it.SubItems.Add(v.Price.ToString());

                        if (v.Avalaible == true)
                        {
                            lvVehicles.Items.Add(it);
                        }
                    }
                }

                Cursor.Current = Cursors.Default;


            }
        }

       
            
        

        private void btnSeletVehicle_Click(object sender, EventArgs e)
        {
            
            if (selectedVehicleID == 0)
            {
                MessageBox.Show("Nincs kiválaztott Jármű !", "Hiba !", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                
                DialogResult = DialogResult.OK;
            }
        }

        private void lvVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvVehicles.SelectedItems != null)
            {
                ListViewItem item = lvVehicles.SelectedItems[0];
                selectedVehicleID = Convert.ToInt32(item.SubItems[0].Text);
            }
        }
    }
}
