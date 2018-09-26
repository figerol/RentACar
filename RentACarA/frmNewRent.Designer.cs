namespace RentACarA
{
    partial class frmNewRent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbNoteCustomer = new System.Windows.Forms.TextBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rACverBDataSet = new RentACarA.RACverBDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbBuilding = new System.Windows.Forms.TextBox();
            this.customerAddressesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbPostal = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbLicense = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLocType = new MetroFramework.Controls.MetroTextBox();
            this.lbVID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblAvailable = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.tbPrice = new MetroFramework.Controls.MetroTextBox();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbMileage = new MetroFramework.Controls.MetroTextBox();
            this.cbType = new MetroFramework.Controls.MetroComboBox();
            this.tbPlate = new MetroFramework.Controls.MetroTextBox();
            this.vehiclePlatesAndModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbModel = new MetroFramework.Controls.MetroTextBox();
            this.tbMade = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbNoteVehicle = new MetroFramework.Controls.MetroTextBox();
            this.btnSelectVehicle = new MetroFramework.Controls.MetroButton();
            this.lbCID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lbDate = new MetroFramework.Controls.MetroLabel();
            this.tbRent = new MetroFramework.Controls.MetroTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SaveDocument = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rACverBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAddressesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePlatesAndModelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNoteCustomer
            // 
            this.tbNoteCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerNote", true));
            this.tbNoteCustomer.Location = new System.Drawing.Point(19, 337);
            this.tbNoteCustomer.Multiline = true;
            this.tbNoteCustomer.Name = "tbNoteCustomer";
            this.tbNoteCustomer.ReadOnly = true;
            this.tbNoteCustomer.Size = new System.Drawing.Size(254, 182);
            this.tbNoteCustomer.TabIndex = 66;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.rACverBDataSet;
            // 
            // rACverBDataSet
            // 
            this.rACverBDataSet.DataSetName = "RACverBDataSet";
            this.rACverBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 71;
            this.label10.Text = "Megjegyzés (Kliens) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Vezetéknév :";
            // 
            // tbLastName
            // 
            this.tbLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "LastName", true));
            this.tbLastName.Location = new System.Drawing.Point(87, 115);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            this.tbLastName.Size = new System.Drawing.Size(186, 20);
            this.tbLastName.TabIndex = 49;
            // 
            // tbFirstName
            // 
            this.tbFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "FirstName", true));
            this.tbFirstName.Location = new System.Drawing.Point(87, 156);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(186, 20);
            this.tbFirstName.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Telefonszám:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 70;
            this.label12.Text = "Keresztnév  :";
            // 
            // tbPhone
            // 
            this.tbPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Phone", true));
            this.tbPhone.Location = new System.Drawing.Point(87, 238);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = true;
            this.tbPhone.Size = new System.Drawing.Size(186, 20);
            this.tbPhone.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Email cím:";
            // 
            // tbEmail
            // 
            this.tbEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Email", true));
            this.tbEmail.Location = new System.Drawing.Point(87, 197);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(186, 20);
            this.tbEmail.TabIndex = 52;
            // 
            // tbBuilding
            // 
            this.tbBuilding.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerAddressesBindingSource, "Building", true));
            this.tbBuilding.Location = new System.Drawing.Point(461, 239);
            this.tbBuilding.Name = "tbBuilding";
            this.tbBuilding.ReadOnly = true;
            this.tbBuilding.Size = new System.Drawing.Size(110, 20);
            this.tbBuilding.TabIndex = 62;
            // 
            // customerAddressesBindingSource
            // 
            this.customerAddressesBindingSource.DataMember = "CustomerAddresses";
            this.customerAddressesBindingSource.DataSource = this.rACverBDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Lakcím:";
            // 
            // tbStreet
            // 
            this.tbStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerAddressesBindingSource, "Street", true));
            this.tbStreet.Location = new System.Drawing.Point(364, 198);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.ReadOnly = true;
            this.tbStreet.Size = new System.Drawing.Size(110, 20);
            this.tbStreet.TabIndex = 60;
            // 
            // tbPostal
            // 
            this.tbPostal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "PostCode", true));
            this.tbPostal.Location = new System.Drawing.Point(461, 115);
            this.tbPostal.Name = "tbPostal";
            this.tbPostal.ReadOnly = true;
            this.tbPostal.Size = new System.Drawing.Size(110, 20);
            this.tbPostal.TabIndex = 56;
            // 
            // tbCity
            // 
            this.tbCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerAddressesBindingSource, "City", true));
            this.tbCity.Location = new System.Drawing.Point(461, 156);
            this.tbCity.Name = "tbCity";
            this.tbCity.ReadOnly = true;
            this.tbCity.Size = new System.Drawing.Size(110, 20);
            this.tbCity.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Jogosítvány szám:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "Házszám :";
            // 
            // tbLicense
            // 
            this.tbLicense.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "DrivingLicenseNumber", true));
            this.tbLicense.Location = new System.Drawing.Point(117, 280);
            this.tbLicense.Name = "tbLicense";
            this.tbLicense.ReadOnly = true;
            this.tbLicense.Size = new System.Drawing.Size(156, 20);
            this.tbLicense.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Város :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Irányítószám :";
            // 
            // tbLocType
            // 
            // 
            // 
            // 
            this.tbLocType.CustomButton.Image = null;
            this.tbLocType.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.tbLocType.CustomButton.Name = "";
            this.tbLocType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbLocType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLocType.CustomButton.TabIndex = 1;
            this.tbLocType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLocType.CustomButton.UseSelectable = true;
            this.tbLocType.CustomButton.Visible = false;
            this.tbLocType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerAddressesBindingSource, "LocType", true));
            this.tbLocType.Lines = new string[0];
            this.tbLocType.Location = new System.Drawing.Point(480, 198);
            this.tbLocType.MaxLength = 32767;
            this.tbLocType.Name = "tbLocType";
            this.tbLocType.PasswordChar = '\0';
            this.tbLocType.ReadOnly = true;
            this.tbLocType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLocType.SelectedText = "";
            this.tbLocType.SelectionLength = 0;
            this.tbLocType.SelectionStart = 0;
            this.tbLocType.ShortcutsEnabled = true;
            this.tbLocType.Size = new System.Drawing.Size(91, 23);
            this.tbLocType.TabIndex = 72;
            this.tbLocType.UseSelectable = true;
            this.tbLocType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbLocType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbVID
            // 
            this.lbVID.AutoSize = true;
            this.lbVID.Location = new System.Drawing.Point(762, 283);
            this.lbVID.Name = "lbVID";
            this.lbVID.Size = new System.Drawing.Size(27, 19);
            this.lbVID.TabIndex = 89;
            this.lbVID.Text = "---";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(671, 283);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 88;
            this.metroLabel1.Text = "Azonosító :";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(1095, 235);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(57, 19);
            this.lblAvailable.TabIndex = 87;
            this.lblAvailable.Text = "Elérhető";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(385, 422);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(254, 31);
            this.btnSave.TabIndex = 86;
            this.btnSave.Text = "Bérlés indítása";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbPrice
            // 
            // 
            // 
            // 
            this.tbPrice.CustomButton.Image = null;
            this.tbPrice.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.tbPrice.CustomButton.Name = "";
            this.tbPrice.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPrice.CustomButton.TabIndex = 1;
            this.tbPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPrice.CustomButton.UseSelectable = true;
            this.tbPrice.CustomButton.Visible = false;
            this.tbPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Price", true));
            this.tbPrice.Lines = new string[0];
            this.tbPrice.Location = new System.Drawing.Point(1033, 150);
            this.tbPrice.MaxLength = 32767;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.ReadOnly = true;
            this.tbPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPrice.SelectedText = "";
            this.tbPrice.SelectionLength = 0;
            this.tbPrice.SelectionStart = 0;
            this.tbPrice.ShortcutsEnabled = true;
            this.tbPrice.Size = new System.Drawing.Size(119, 29);
            this.tbPrice.TabIndex = 85;
            this.tbPrice.UseSelectable = true;
            this.tbPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataSource = typeof(RentACarA.Vehicles);
            // 
            // tbMileage
            // 
            // 
            // 
            // 
            this.tbMileage.CustomButton.Image = null;
            this.tbMileage.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.tbMileage.CustomButton.Name = "";
            this.tbMileage.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbMileage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMileage.CustomButton.TabIndex = 1;
            this.tbMileage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMileage.CustomButton.UseSelectable = true;
            this.tbMileage.CustomButton.Visible = false;
            this.tbMileage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Mileage", true));
            this.tbMileage.Lines = new string[0];
            this.tbMileage.Location = new System.Drawing.Point(1016, 115);
            this.tbMileage.MaxLength = 32767;
            this.tbMileage.Name = "tbMileage";
            this.tbMileage.PasswordChar = '\0';
            this.tbMileage.ReadOnly = true;
            this.tbMileage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMileage.SelectedText = "";
            this.tbMileage.SelectionLength = 0;
            this.tbMileage.SelectionStart = 0;
            this.tbMileage.ShortcutsEnabled = true;
            this.tbMileage.Size = new System.Drawing.Size(136, 29);
            this.tbMileage.TabIndex = 84;
            this.tbMileage.UseSelectable = true;
            this.tbMileage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMileage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbType
            // 
            this.cbType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.vehiclesBindingSource, "Type", true));
            this.cbType.FormattingEnabled = true;
            this.cbType.ItemHeight = 23;
            this.cbType.Location = new System.Drawing.Point(739, 225);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(186, 29);
            this.cbType.TabIndex = 83;
            this.cbType.UseSelectable = true;
            // 
            // tbPlate
            // 
            // 
            // 
            // 
            this.tbPlate.CustomButton.Image = null;
            this.tbPlate.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.tbPlate.CustomButton.Name = "";
            this.tbPlate.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbPlate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPlate.CustomButton.TabIndex = 1;
            this.tbPlate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPlate.CustomButton.UseSelectable = true;
            this.tbPlate.CustomButton.Visible = false;
            this.tbPlate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclePlatesAndModelsBindingSource, "Plate", true));
            this.tbPlate.Lines = new string[0];
            this.tbPlate.Location = new System.Drawing.Point(739, 185);
            this.tbPlate.MaxLength = 32767;
            this.tbPlate.Name = "tbPlate";
            this.tbPlate.PasswordChar = '\0';
            this.tbPlate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPlate.SelectedText = "";
            this.tbPlate.SelectionLength = 0;
            this.tbPlate.SelectionStart = 0;
            this.tbPlate.ShortcutsEnabled = true;
            this.tbPlate.Size = new System.Drawing.Size(186, 29);
            this.tbPlate.TabIndex = 82;
            this.tbPlate.UseSelectable = true;
            this.tbPlate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPlate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // vehiclePlatesAndModelsBindingSource
            // 
            this.vehiclePlatesAndModelsBindingSource.DataSource = typeof(RentACarA.VehiclePlatesAndModels);
            // 
            // tbModel
            // 
            // 
            // 
            // 
            this.tbModel.CustomButton.Image = null;
            this.tbModel.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.tbModel.CustomButton.Name = "";
            this.tbModel.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbModel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbModel.CustomButton.TabIndex = 1;
            this.tbModel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbModel.CustomButton.UseSelectable = true;
            this.tbModel.CustomButton.Visible = false;
            this.tbModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclePlatesAndModelsBindingSource, "Model", true));
            this.tbModel.Lines = new string[0];
            this.tbModel.Location = new System.Drawing.Point(739, 150);
            this.tbModel.MaxLength = 32767;
            this.tbModel.Name = "tbModel";
            this.tbModel.PasswordChar = '\0';
            this.tbModel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbModel.SelectedText = "";
            this.tbModel.SelectionLength = 0;
            this.tbModel.SelectionStart = 0;
            this.tbModel.ShortcutsEnabled = true;
            this.tbModel.Size = new System.Drawing.Size(186, 29);
            this.tbModel.TabIndex = 81;
            this.tbModel.UseSelectable = true;
            this.tbModel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbModel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbMade
            // 
            // 
            // 
            // 
            this.tbMade.CustomButton.Image = null;
            this.tbMade.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.tbMade.CustomButton.Name = "";
            this.tbMade.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbMade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMade.CustomButton.TabIndex = 1;
            this.tbMade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMade.CustomButton.UseSelectable = true;
            this.tbMade.CustomButton.Visible = false;
            this.tbMade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Made", true));
            this.tbMade.Lines = new string[0];
            this.tbMade.Location = new System.Drawing.Point(739, 115);
            this.tbMade.MaxLength = 32767;
            this.tbMade.Name = "tbMade";
            this.tbMade.PasswordChar = '\0';
            this.tbMade.ReadOnly = true;
            this.tbMade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMade.SelectedText = "";
            this.tbMade.SelectionLength = 0;
            this.tbMade.SelectionStart = 0;
            this.tbMade.ShortcutsEnabled = true;
            this.tbMade.Size = new System.Drawing.Size(186, 29);
            this.tbMade.TabIndex = 80;
            this.tbMade.UseSelectable = true;
            this.tbMade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(668, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 79;
            this.label8.Text = "Megjegyzés (Jármű) :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(668, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 73;
            this.label13.Text = "Gyártó :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(668, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 74;
            this.label14.Text = "Típus";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(668, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 78;
            this.label15.Text = "Modell :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(668, 200);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 75;
            this.label16.Text = "Rendszám:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(943, 118);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 76;
            this.label17.Text = "Km futás :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(943, 159);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 13);
            this.label18.TabIndex = 77;
            this.label18.Text = "Bérleti díj / nap :";
            // 
            // tbNoteVehicle
            // 
            // 
            // 
            // 
            this.tbNoteVehicle.CustomButton.Image = null;
            this.tbNoteVehicle.CustomButton.Location = new System.Drawing.Point(419, 1);
            this.tbNoteVehicle.CustomButton.Name = "";
            this.tbNoteVehicle.CustomButton.Size = new System.Drawing.Size(61, 61);
            this.tbNoteVehicle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNoteVehicle.CustomButton.TabIndex = 1;
            this.tbNoteVehicle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNoteVehicle.CustomButton.UseSelectable = true;
            this.tbNoteVehicle.CustomButton.Visible = false;
            this.tbNoteVehicle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "VechNote", true));
            this.tbNoteVehicle.Lines = new string[0];
            this.tbNoteVehicle.Location = new System.Drawing.Point(671, 337);
            this.tbNoteVehicle.MaxLength = 32767;
            this.tbNoteVehicle.Multiline = true;
            this.tbNoteVehicle.Name = "tbNoteVehicle";
            this.tbNoteVehicle.PasswordChar = '\0';
            this.tbNoteVehicle.ReadOnly = true;
            this.tbNoteVehicle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNoteVehicle.SelectedText = "";
            this.tbNoteVehicle.SelectionLength = 0;
            this.tbNoteVehicle.SelectionStart = 0;
            this.tbNoteVehicle.ShortcutsEnabled = true;
            this.tbNoteVehicle.Size = new System.Drawing.Size(481, 63);
            this.tbNoteVehicle.TabIndex = 90;
            this.tbNoteVehicle.UseSelectable = true;
            this.tbNoteVehicle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNoteVehicle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSelectVehicle
            // 
            this.btnSelectVehicle.Location = new System.Drawing.Point(385, 337);
            this.btnSelectVehicle.Name = "btnSelectVehicle";
            this.btnSelectVehicle.Size = new System.Drawing.Size(254, 31);
            this.btnSelectVehicle.TabIndex = 91;
            this.btnSelectVehicle.Text = "Járműválasztás";
            this.btnSelectVehicle.UseSelectable = true;
            this.btnSelectVehicle.Click += new System.EventHandler(this.btnSelectVehicle_Click);
            // 
            // lbCID
            // 
            this.lbCID.AutoSize = true;
            this.lbCID.Location = new System.Drawing.Point(408, 283);
            this.lbCID.Name = "lbCID";
            this.lbCID.Size = new System.Drawing.Size(27, 19);
            this.lbCID.TabIndex = 93;
            this.lbCID.Text = "---";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(317, 283);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.TabIndex = 92;
            this.metroLabel4.Text = "Azonosító :";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(1069, 60);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(36, 19);
            this.lbDate.TabIndex = 94;
            this.lbDate.Text = "Date";
            // 
            // tbRent
            // 
            // 
            // 
            // 
            this.tbRent.CustomButton.Image = null;
            this.tbRent.CustomButton.Location = new System.Drawing.Point(419, 1);
            this.tbRent.CustomButton.Name = "";
            this.tbRent.CustomButton.Size = new System.Drawing.Size(61, 61);
            this.tbRent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbRent.CustomButton.TabIndex = 1;
            this.tbRent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbRent.CustomButton.UseSelectable = true;
            this.tbRent.CustomButton.Visible = false;
            this.tbRent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "VechNote", true));
            this.tbRent.Lines = new string[0];
            this.tbRent.Location = new System.Drawing.Point(671, 456);
            this.tbRent.MaxLength = 32767;
            this.tbRent.Multiline = true;
            this.tbRent.Name = "tbRent";
            this.tbRent.PasswordChar = '\0';
            this.tbRent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbRent.SelectedText = "";
            this.tbRent.SelectionLength = 0;
            this.tbRent.SelectionStart = 0;
            this.tbRent.ShortcutsEnabled = true;
            this.tbRent.Size = new System.Drawing.Size(481, 63);
            this.tbRent.TabIndex = 96;
            this.tbRent.UseSelectable = true;
            this.tbRent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbRent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(668, 440);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 95;
            this.label11.Text = "Megjegyzés (Bérlés) :";
            // 
            // frmNewRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 552);
            this.Controls.Add(this.tbRent);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbCID);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnSelectVehicle);
            this.Controls.Add(this.tbNoteVehicle);
            this.Controls.Add(this.lbVID);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbMileage);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbPlate);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbMade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tbLocType);
            this.Controls.Add(this.tbNoteCustomer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbBuilding);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.tbPostal);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbLicense);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewRent";
            this.Text = "Új bérlés indítása";
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rACverBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAddressesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePlatesAndModelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNoteCustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbBuilding;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.TextBox tbPostal;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbLicense;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private RACverBDataSet rACverBDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.BindingSource customerAddressesBindingSource;
        private MetroFramework.Controls.MetroTextBox tbLocType;
        private MetroFramework.Controls.MetroLabel lbVID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblAvailable;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox tbPrice;
        private MetroFramework.Controls.MetroTextBox tbMileage;
        private MetroFramework.Controls.MetroComboBox cbType;
        private MetroFramework.Controls.MetroTextBox tbPlate;
        private MetroFramework.Controls.MetroTextBox tbModel;
        private MetroFramework.Controls.MetroTextBox tbMade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private MetroFramework.Controls.MetroTextBox tbNoteVehicle;
        private MetroFramework.Controls.MetroButton btnSelectVehicle;
        private MetroFramework.Controls.MetroLabel lbCID;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private System.Windows.Forms.BindingSource vehiclePlatesAndModelsBindingSource;
        private MetroFramework.Controls.MetroLabel lbDate;
        private MetroFramework.Controls.MetroTextBox tbRent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.SaveFileDialog SaveDocument;
    }
}