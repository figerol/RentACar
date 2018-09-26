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
    public partial class frmOpenClosedRent : MetroFramework.Forms.MetroForm
    {
        RACverBEntities db;


        public frmOpenClosedRent(int rID)
        {
            InitializeComponent();

            db = new RACverBEntities();

            Rents r = db.Rents.Find(rID);



            rentsBindingSource.DataSource = r;
            customersBindingSource.DataSource = r.Customers;
            customerAddressesBindingSource.DataSource = r.Customers.CustomerAddresses;
            vehiclesBindingSource.DataSource = r.Vehicles;
            vehiclePlatesAndModelsBindingSource.DataSource = r.Vehicles.VehiclePlatesAndModels1;

            int rentedDays;

            var i = r.DateBack - r.DateFrom;

            rentedDays = i.Days;

            lbRentedDays.Text = rentedDays.ToString();
            lbPriceOfRent.Text = (r.Vehicles.Price + r.Vehicles.Price * rentedDays).ToString() + "Ft";
        }
    }
}
