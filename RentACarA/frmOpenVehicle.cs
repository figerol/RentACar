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
    public partial class frmOpenVehicle : MetroFramework.Forms.MetroForm
    {
        RACverBEntities dbv;

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

        public frmOpenVehicle(int vID)
        {
            


            InitializeComponent();

            cbType.DataSource = Enum.GetValues(typeof(vehicletype));

            dbv = new RACverBEntities();



            Vehicles v = dbv.Vehicles.Find(vID);
            VehiclePlatesAndModels vpms = dbv.VehiclePlatesAndModels.Find(vID);

            vehiclesBindingSource.DataSource = v;
            vehiclePlatesAndModelsBindingSource.DataSource = vpms;


        }
        /*
        private void frmOpenVehicle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                dbv.SaveChanges();

            }
        }
        */

        private void btnSave_Click(object sender, EventArgs e)
        {
            dbv.SaveChanges();
            this.Close();
        }
    }
}
