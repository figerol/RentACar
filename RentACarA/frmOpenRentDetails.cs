using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Drawing.Drawing2D;

namespace RentACarA
{
    public partial class frmOpenRentDetails : MetroFramework.Forms.MetroForm
    {
        

        internal string path;
        internal object rIDcar;
        internal int em;

        RACverBEntities db;

        public frmOpenRentDetails(int rID)
        {
            InitializeComponent();

            db = new RACverBEntities();

            Rents r = db.Rents.Find(rID);



            rentsBindingSource.DataSource = r;
            customersBindingSource.DataSource = r.Customers;
            customerAddressesBindingSource.DataSource = r.Customers.CustomerAddresses;
            vehiclesBindingSource.DataSource = r.Vehicles;
            vehiclePlatesAndModelsBindingSource.DataSource = r.Vehicles.VehiclePlatesAndModels1;

            lbCID.Text = r.CustomerID.ToString();

            lbDateToDay.Text = DateTime.Today.ToShortDateString();

            int rentedDays;
        
            TimeSpan i = DateTime.Today - r.DateFrom;

           
                rentedDays = i.Days;
            

            lbRentedDays.Text = rentedDays.ToString();
            lbPriceOfRent.Text = (r.Vehicles.Price + r.Vehicles.Price * rentedDays).ToString() + "Ft";
        }

        private void btnEndOfRent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Megerősíti a bérlés végét ? ", "Megerősítés ! ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(tbEndMileage.Text))
                {
                    MessageBox.Show("Adja meg a jármű Km óra állását !", "Hiányzó adat ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if(Convert.ToInt32(tbEndMileage.Text) > Convert.ToInt32(tbMileage.Text))
                {


                    using (RACverBEntities db = new RACverBEntities())
                    {
                        try
                        {
                            SaveDocument.FileName = lbRentID.Text + ". számű bérlésről számla.";
                            //Rents last = (from l in db.Rents orderby l.RentalID descending select l).First();
                            rIDcar = lbRentID.Text;



                            if (SaveDocument.ShowDialog() == DialogResult.OK)
                            {


                                CreateWordDocument(path, SaveDocument.FileName);

                                em = Convert.ToInt32(tbEndMileage.Text);
                                DialogResult = DialogResult.OK;

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Nem sikerült a dokumentum létrehozása" + ex.Message, "Hiba történt ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        //DialogResult = DialogResult.OK;

                    }
                }
                else
                {
                    MessageBox.Show("A Km óra állás nem lehet kevesebb mint a bérlés kezdetekor !", "Hibás adat ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Megszakította a bérlés lezárását !", "Megszakítás ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                this.FindAndReplaceText(wordApp, "<rentID>", rIDcar.ToString());
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
                this.FindAndReplaceText(wordApp, "<price2>", lbPriceOfRent.Text);
                this.FindAndReplaceText(wordApp, "<startday>", lbDatestart.Text);
                this.FindAndReplaceText(wordApp, "<endday>", DateTime.Now.ToShortDateString());
                this.FindAndReplaceText(wordApp, "<note>", tbRent.Text);


            }
            else
            {
                MessageBox.Show("A fájl nem létezik !");
                return;
            }
            //mentés
            aDoc.SaveAs2(ref saveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            // dokumentum bezárása


            //File.Delete(tempPath);
            MessageBox.Show("Fájl létrehozva");


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

        private void frmOpenRentDetails_Load(object sender, EventArgs e)
        {
            path = System.Windows.Forms.Application.StartupPath + "\\template2.docx";

        }

        
    }
}
