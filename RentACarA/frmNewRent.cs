using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Drawing.Drawing2D;
using System.Diagnostics;



namespace RentACarA
{
    public partial class frmNewRent : MetroFramework.Forms.MetroForm
    {
        
        RACverBEntities db;

        internal int vID;

        internal string path;
        internal object rID;

        public frmNewRent(int cID)
        {
            InitializeComponent();

            db = new RACverBEntities();


            Customers c = db.Customers.Find(cID);
            CustomerAddresses adrs = db.CustomerAddresses.Find(cID);

            customersBindingSource.DataSource = c;
            customerAddressesBindingSource.DataSource = adrs;

            lbCID.Text = c.CustomerID.ToString();

            lbDate.Text = DateTime.Today.ToShortDateString();


        }

        private void btnSelectVehicle_Click(object sender, EventArgs e)
        {


            frmSelectVehicle selectVehicle = new frmSelectVehicle();
            selectVehicle.ShowDialog();
            if (selectVehicle.DialogResult == DialogResult.OK)
            {
                vID = selectVehicle.selectedVehicleID;
            
                Vehicles v = db.Vehicles.Find(vID);
                VehiclePlatesAndModels vpm = db.VehiclePlatesAndModels.Find(vID);
            
                vehiclesBindingSource.DataSource = v;
                vehiclePlatesAndModelsBindingSource.DataSource = vpm;

                lbVID.Text = v.VehicleID.ToString();

                path = System.Windows.Forms.Application.StartupPath + "\\template.docx";
            }
            



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Vehicles v = db.Vehicles.Find(vID);
            VehiclePlatesAndModels vpm = db.VehiclePlatesAndModels.Find(vID);

            vehiclesBindingSource.DataSource = v;
            vehiclePlatesAndModelsBindingSource.DataSource = vpm;

            

            Customers c = db.Customers.Find(Convert.ToInt32(lbCID.Text));

            db = new RACverBEntities();

            Rents newrent = new Rents();

            newrent.CustomerID = c.CustomerID;
            newrent.VehicleID = v.VehicleID;
            newrent.UserID = 1;
            newrent.RentNote = tbRent.Text.Trim();
            newrent.DateFrom = DateTime.Today;
            


            if (MessageBox.Show("Megerősíti a bérlést ? ", "Megerősítés ! ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (RACverBEntities db = new RACverBEntities())
                {
                    Vehicles start = db.Vehicles.Find(v.VehicleID);
                    start.Avalaible = false;

                    db.Rents.Add(newrent);

                    try
                    {
                        Rents last = (from l in db.Rents orderby l.RentalID descending select l).First();
                        rID = last.RentalID;

                        SaveDocument.FileName = rID.ToString() + ". számű bérlési szerződés.";

                        if (SaveDocument.ShowDialog() == DialogResult.OK)
                        {
                            CreateWordDocument(path, SaveDocument.FileName);
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nem sikerült a dokumentum létrehozása" + ex.Message, "Hiba történt ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                    

                    

                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Megszakította a bérlés indítását !", "Megszakítás ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
       
        // method keresés és csere
        private void FindAndReplaceText(Microsoft.Office.Interop.Word.Application wordsapp, object findText, object replaceText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object readOnly = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordsapp.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundsLike, ref matchAllForms,
                ref forward, ref wrap, ref format, ref replaceText, ref replace, ref matchKashida, ref matchDiactitics, ref matchAlefHamza, ref matchControl);

        }

        
        //dokumentum létrehozása
        private void CreateWordDocument(object filename, object saveAs)
        {

            List<int> processesbeforegen = getRunningProcesses();
            object missing = Missing.Value;
            Word.Application wordApp = new Word.Application();
            Word.Document aDoc = null;

            if (File.Exists((string)filename))
            {
                DateTime today = DateTime.Now;

                object readOnly = false;
                object isVisible = false;

                wordApp.Visible = false;

                aDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                                ref missing, ref missing, ref missing,
                                                ref missing, ref missing, ref missing,
                                                ref missing, ref missing, ref missing,
                                                ref missing, ref missing, ref missing, ref missing);
                aDoc.Activate();

                //kereés és csere

                this.FindAndReplaceText(wordApp, "<rentID>", rID.ToString());
                this.FindAndReplaceText(wordApp, "<lastname>", tbLastName.Text);
                this.FindAndReplaceText(wordApp, "<firstname>", tbFirstName.Text);
                this.FindAndReplaceText(wordApp, "<postcode>", tbPostal.Text);
                this.FindAndReplaceText(wordApp, "<city>", tbCity.Text);
                this.FindAndReplaceText(wordApp, "<street>", tbStreet.Text);
                this.FindAndReplaceText(wordApp, "<loctype>", tbLocType.Text);
                this.FindAndReplaceText(wordApp, "<building>", tbBuilding.Text);
                this.FindAndReplaceText(wordApp, "<phone>", tbPhone.Text);
                this.FindAndReplaceText(wordApp, "<email>", tbEmail.Text);
                this.FindAndReplaceText(wordApp, "<drivinglicense>", tbLicense.Text);
                this.FindAndReplaceText(wordApp, "<plate>", tbPlate.Text);
                this.FindAndReplaceText(wordApp, "<made>", tbMade.Text);
                this.FindAndReplaceText(wordApp, "<model>", tbModel.Text);
                this.FindAndReplaceText(wordApp, "<mileage>", tbMileage.Text);
                this.FindAndReplaceText(wordApp, "<price>", tbPrice.Text);
                this.FindAndReplaceText(wordApp, "<today>", DateTime.Now.ToShortDateString());
                this.FindAndReplaceText(wordApp, "<note>", tbRent.Text);


            }
            else
            {
                MessageBox.Show("A fájlt nem sikerült létrehozni !");
                return;
            }
             //mentés
            aDoc.SaveAs2(ref saveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            // dokumentum bezárása
            
            
            //File.Delete(tempPath);
            MessageBox.Show("Fájl létrehozva", "Fájl", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        
        

        public List<int> getRunningProcesses()
        {
            List<int> ProcessIDs = new List<int>();
            
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (Process.GetCurrentProcess().Id == clsProcess.Id)
                    continue;
                if (clsProcess.ProcessName.Contains("WINWORD"))
                {
                    ProcessIDs.Add(clsProcess.Id);
                }
            }
            return ProcessIDs;
        }


        private void killProcesses(List<int> processesbeforegen, List<int> processesaftergen)
        {
            foreach (int pidafter in processesaftergen)
            {
                bool processfound = false;
                foreach (int pidbefore in processesbeforegen)
                {
                    if (pidafter == pidbefore)
                    {
                        processfound = true;
                    }
                }

                if (processfound == false)
                {
                    Process clsProcess = Process.GetProcessById(pidafter);
                    clsProcess.Kill();
                }
            }
        }
    }
}