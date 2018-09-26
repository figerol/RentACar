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
    public partial class frmNewVehicle : MetroFramework.Forms.MetroForm
    {
        enum vehicletype
        {
            Compact,	
            Sedan,	
            SUV,	
            Cabrio,	
            Luxury,	
            Family,	
            Lorry,	
        }
        

        
        
        
        

        public frmNewVehicle()
        {
            InitializeComponent();

            cbType.DataSource = Enum.GetValues(typeof(vehicletype));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Vehicles model = new Vehicles();
            VehiclePlatesAndModels data = new VehiclePlatesAndModels();

            if (string.IsNullOrEmpty(tbMade.Text))
            {
                MessageBox.Show("A gyártó mező nem lehet üres !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                model.Made = tbMade.Text.Trim();
            }

            
                model.Type = cbType.Text;

            if (string.IsNullOrEmpty(tbModel.Text))
            {
                MessageBox.Show("A modell mező nem lehet üres !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                model.VehiclePlatesAndModels1.Model = tbModel.Text.Trim();
            }

            int mile;

            if (string.IsNullOrEmpty(tbMileage.Text))  // string.IsNullOrEmpty(tbLastName.Text)
            {
                MessageBox.Show("A Km futás mező nem lehet üres !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else if (!(int.TryParse(tbMileage.Text, out mile)))
            {
                MessageBox.Show("A  Km futás mezőbe csak számokat írhat !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (mile <0)
            {
                MessageBox.Show("A  Km futás mezőbe csak pozitív számokat írhat !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                model.Mileage = mile;
            }

            int price;

            if (string.IsNullOrEmpty(tbPrice.Text))  // string.IsNullOrEmpty(tbLastName.Text)
            {
                MessageBox.Show("A bérleti díj/nap mező nem lehet üres !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else if (!(int.TryParse(tbPrice.Text, out price)))
            {
                MessageBox.Show("A bérleti díj/nap mezőbe csak számokat írhat !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (price > 150000 && price > 0)
            {
                MessageBox.Show("Az ár nem lehet nulla vagy negatív és a felső határa 150.000 Ft !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                model.Price = price;
            }

            model.VechNote = tbNote.Text.Trim();



            if (string.IsNullOrEmpty(tbPlate.Text))
            {
                MessageBox.Show("A rendszám mező nem lehet üres !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                model.Made = tbPlate.Text.Trim();
            }




            using (RACverBEntities db = new RACverBEntities())
            {
                db.Vehicles.Add(model);
                db.VehiclePlatesAndModels.Add(data);
                

                db.SaveChanges();
                ClearTextBoxesNewVec();
            }
            this.Close();
            
        }

        private void ClearTextBoxesNewVec()
        {
            tbMade.Clear();
            tbModel.Clear();
            tbPlate.Clear();
            tbMileage.Clear();
            tbPrice.Clear();
            tbNote.Clear();

        }


    }
}
