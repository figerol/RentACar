﻿namespace RentACarA
{
    partial class frmOpenRentDetails
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
            this.tbRent = new MetroFramework.Controls.MetroTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbDatestart = new MetroFramework.Controls.MetroLabel();
            this.lbCID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbNoteVehicle = new MetroFramework.Controls.MetroTextBox();
            this.lbVID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnEndOfRent = new MetroFramework.Controls.MetroButton();
            this.tbPrice = new MetroFramework.Controls.MetroTextBox();
            this.tbMileage = new MetroFramework.Controls.MetroTextBox();
            this.cbType = new MetroFramework.Controls.MetroComboBox();
            this.tbPlate = new MetroFramework.Controls.MetroTextBox();
            this.tbModel = new MetroFramework.Controls.MetroTextBox();
            this.tbMade = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbNoteCustomer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLicense = new System.Windows.Forms.TextBox();
            this.tbBuilding = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPostal = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbLocType = new MetroFramework.Controls.MetroTextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lbRentID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lbDateToDay = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tbEndMileage = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lbPriceOfRent = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lbRentedDays = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.SaveDocument = new System.Windows.Forms.SaveFileDialog();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.rentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiclePlatesAndModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerAddressesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePlatesAndModelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAddressesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRent
            // 
            // 
            // 
            // 
            this.tbRent.CustomButton.Image = null;
            this.tbRent.CustomButton.Location = new System.Drawing.Point(464, 1);
            this.tbRent.CustomButton.Name = "";
            this.tbRent.CustomButton.Size = new System.Drawing.Size(81, 81);
            this.tbRent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbRent.CustomButton.TabIndex = 1;
            this.tbRent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbRent.CustomButton.UseSelectable = true;
            this.tbRent.CustomButton.Visible = false;
            this.tbRent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentsBindingSource, "RentNote", true));
            this.tbRent.Lines = new string[0];
            this.tbRent.Location = new System.Drawing.Point(649, 127);
            this.tbRent.MaxLength = 32767;
            this.tbRent.Multiline = true;
            this.tbRent.Name = "tbRent";
            this.tbRent.PasswordChar = '\0';
            this.tbRent.ReadOnly = true;
            this.tbRent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbRent.SelectedText = "";
            this.tbRent.SelectionLength = 0;
            this.tbRent.SelectionStart = 0;
            this.tbRent.ShortcutsEnabled = true;
            this.tbRent.Size = new System.Drawing.Size(546, 83);
            this.tbRent.TabIndex = 141;
            this.tbRent.UseSelectable = true;
            this.tbRent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbRent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(646, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 140;
            this.label11.Text = "Megjegyzés (Bérlés) :";
            // 
            // lbDatestart
            // 
            this.lbDatestart.AutoSize = true;
            this.lbDatestart.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentsBindingSource, "DateFrom", true));
            this.lbDatestart.Location = new System.Drawing.Point(516, 29);
            this.lbDatestart.Name = "lbDatestart";
            this.lbDatestart.Size = new System.Drawing.Size(36, 19);
            this.lbDatestart.TabIndex = 139;
            this.lbDatestart.Text = "Date";
            // 
            // lbCID
            // 
            this.lbCID.AutoSize = true;
            this.lbCID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
            this.lbCID.Location = new System.Drawing.Point(134, 102);
            this.lbCID.Name = "lbCID";
            this.lbCID.Size = new System.Drawing.Size(27, 19);
            this.lbCID.TabIndex = 138;
            this.lbCID.Text = "---";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(26, 102);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(107, 19);
            this.metroLabel4.TabIndex = 137;
            this.metroLabel4.Text = "Bérlő azonosító :";
            // 
            // tbNoteVehicle
            // 
            // 
            // 
            // 
            this.tbNoteVehicle.CustomButton.Image = null;
            this.tbNoteVehicle.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.tbNoteVehicle.CustomButton.Name = "";
            this.tbNoteVehicle.CustomButton.Size = new System.Drawing.Size(81, 81);
            this.tbNoteVehicle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNoteVehicle.CustomButton.TabIndex = 1;
            this.tbNoteVehicle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNoteVehicle.CustomButton.UseSelectable = true;
            this.tbNoteVehicle.CustomButton.Visible = false;
            this.tbNoteVehicle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "VechNote", true));
            this.tbNoteVehicle.Lines = new string[0];
            this.tbNoteVehicle.Location = new System.Drawing.Point(342, 450);
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
            this.tbNoteVehicle.Size = new System.Drawing.Size(254, 83);
            this.tbNoteVehicle.TabIndex = 135;
            this.tbNoteVehicle.UseSelectable = true;
            this.tbNoteVehicle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNoteVehicle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbVID
            // 
            this.lbVID.AutoSize = true;
            this.lbVID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "VehicleID", true));
            this.lbVID.Location = new System.Drawing.Point(458, 102);
            this.lbVID.Name = "lbVID";
            this.lbVID.Size = new System.Drawing.Size(27, 19);
            this.lbVID.TabIndex = 134;
            this.lbVID.Text = "---";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(340, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 19);
            this.metroLabel1.TabIndex = 133;
            this.metroLabel1.Text = "Jármű azonosító :";
            // 
            // btnEndOfRent
            // 
            this.btnEndOfRent.Location = new System.Drawing.Point(743, 502);
            this.btnEndOfRent.Name = "btnEndOfRent";
            this.btnEndOfRent.Size = new System.Drawing.Size(254, 31);
            this.btnEndOfRent.TabIndex = 131;
            this.btnEndOfRent.Text = "Bérlés Vége";
            this.btnEndOfRent.UseSelectable = true;
            this.btnEndOfRent.Click += new System.EventHandler(this.btnEndOfRent_Click);
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
            this.tbPrice.Location = new System.Drawing.Point(477, 354);
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
            this.tbPrice.TabIndex = 130;
            this.tbPrice.UseSelectable = true;
            this.tbPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.tbMileage.Location = new System.Drawing.Point(460, 319);
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
            this.tbMileage.TabIndex = 129;
            this.tbMileage.UseSelectable = true;
            this.tbMileage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMileage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbType
            // 
            this.cbType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Type", true));
            this.cbType.FormattingEnabled = true;
            this.cbType.ItemHeight = 23;
            this.cbType.Location = new System.Drawing.Point(410, 263);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(186, 29);
            this.cbType.TabIndex = 128;
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
            this.tbPlate.Location = new System.Drawing.Point(410, 223);
            this.tbPlate.MaxLength = 32767;
            this.tbPlate.Name = "tbPlate";
            this.tbPlate.PasswordChar = '\0';
            this.tbPlate.ReadOnly = true;
            this.tbPlate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPlate.SelectedText = "";
            this.tbPlate.SelectionLength = 0;
            this.tbPlate.SelectionStart = 0;
            this.tbPlate.ShortcutsEnabled = true;
            this.tbPlate.Size = new System.Drawing.Size(186, 29);
            this.tbPlate.TabIndex = 127;
            this.tbPlate.UseSelectable = true;
            this.tbPlate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPlate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.tbModel.Location = new System.Drawing.Point(410, 188);
            this.tbModel.MaxLength = 32767;
            this.tbModel.Name = "tbModel";
            this.tbModel.PasswordChar = '\0';
            this.tbModel.ReadOnly = true;
            this.tbModel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbModel.SelectedText = "";
            this.tbModel.SelectionLength = 0;
            this.tbModel.SelectionStart = 0;
            this.tbModel.ShortcutsEnabled = true;
            this.tbModel.Size = new System.Drawing.Size(186, 29);
            this.tbModel.TabIndex = 126;
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
            this.tbMade.Location = new System.Drawing.Point(410, 153);
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
            this.tbMade.TabIndex = 125;
            this.tbMade.UseSelectable = true;
            this.tbMade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 124;
            this.label8.Text = "Megjegyzés (Jármű) :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(339, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 118;
            this.label13.Text = "Gyártó :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(339, 279);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 119;
            this.label14.Text = "Típus";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(339, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 123;
            this.label15.Text = "Modell :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(339, 238);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 120;
            this.label16.Text = "Rendszám:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(387, 322);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 121;
            this.label17.Text = "Km futás :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(387, 363);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 13);
            this.label18.TabIndex = 122;
            this.label18.Text = "Bérleti díj / nap :";
            // 
            // tbNoteCustomer
            // 
            this.tbNoteCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerNote", true));
            this.tbNoteCustomer.Location = new System.Drawing.Point(23, 559);
            this.tbNoteCustomer.Multiline = true;
            this.tbNoteCustomer.Name = "tbNoteCustomer";
            this.tbNoteCustomer.ReadOnly = true;
            this.tbNoteCustomer.Size = new System.Drawing.Size(254, 83);
            this.tbNoteCustomer.TabIndex = 113;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 541);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 116;
            this.label10.Text = "Megjegyzés (Kliens) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "Vezetéknév :";
            // 
            // tbLastName
            // 
            this.tbLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "LastName", true));
            this.tbLastName.Location = new System.Drawing.Point(91, 153);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            this.tbLastName.Size = new System.Drawing.Size(186, 20);
            this.tbLastName.TabIndex = 98;
            // 
            // tbFirstName
            // 
            this.tbFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "FirstName", true));
            this.tbFirstName.Location = new System.Drawing.Point(91, 194);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(186, 20);
            this.tbFirstName.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Telefonszám:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 115;
            this.label12.Text = "Keresztnév  :";
            // 
            // tbPhone
            // 
            this.tbPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Phone", true));
            this.tbPhone.Location = new System.Drawing.Point(91, 276);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = true;
            this.tbPhone.Size = new System.Drawing.Size(186, 20);
            this.tbPhone.TabIndex = 103;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 108;
            this.label5.Text = "Jogosítvány szám:";
            // 
            // tbLicense
            // 
            this.tbLicense.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "DrivingLicenseNumber", true));
            this.tbLicense.Location = new System.Drawing.Point(121, 318);
            this.tbLicense.Name = "tbLicense";
            this.tbLicense.ReadOnly = true;
            this.tbLicense.Size = new System.Drawing.Size(156, 20);
            this.tbLicense.TabIndex = 104;
            // 
            // tbBuilding
            // 
            this.tbBuilding.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerAddressesBindingSource, "Building", true));
            this.tbBuilding.Location = new System.Drawing.Point(167, 491);
            this.tbBuilding.Name = "tbBuilding";
            this.tbBuilding.ReadOnly = true;
            this.tbBuilding.Size = new System.Drawing.Size(110, 20);
            this.tbBuilding.TabIndex = 110;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 114;
            this.label9.Text = "Házszám :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 106;
            this.label4.Text = "Lakcím:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 112;
            this.label7.Text = "Város :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 111;
            this.label6.Text = "Irányítószám :";
            // 
            // tbPostal
            // 
            this.tbPostal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "PostCode", true));
            this.tbPostal.Location = new System.Drawing.Point(167, 367);
            this.tbPostal.Name = "tbPostal";
            this.tbPostal.ReadOnly = true;
            this.tbPostal.Size = new System.Drawing.Size(110, 20);
            this.tbPostal.TabIndex = 105;
            // 
            // tbCity
            // 
            this.tbCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerAddressesBindingSource, "City", true));
            this.tbCity.Location = new System.Drawing.Point(167, 408);
            this.tbCity.Name = "tbCity";
            this.tbCity.ReadOnly = true;
            this.tbCity.Size = new System.Drawing.Size(110, 20);
            this.tbCity.TabIndex = 107;
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
            this.tbLocType.Location = new System.Drawing.Point(186, 450);
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
            this.tbLocType.TabIndex = 117;
            this.tbLocType.UseSelectable = true;
            this.tbLocType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbLocType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbStreet
            // 
            this.tbStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerAddressesBindingSource, "Street", true));
            this.tbStreet.Location = new System.Drawing.Point(70, 450);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.ReadOnly = true;
            this.tbStreet.Size = new System.Drawing.Size(110, 20);
            this.tbStreet.TabIndex = 109;
            // 
            // tbEmail
            // 
            this.tbEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Email", true));
            this.tbEmail.Location = new System.Drawing.Point(91, 235);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(186, 20);
            this.tbEmail.TabIndex = 101;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 238);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 142;
            this.label19.Text = "Email cím:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(203, 29);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.TabIndex = 143;
            this.metroLabel2.Text = "Bérlés azonosító :";
            // 
            // lbRentID
            // 
            this.lbRentID.AutoSize = true;
            this.lbRentID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentsBindingSource, "RentalID", true));
            this.lbRentID.Location = new System.Drawing.Point(330, 29);
            this.lbRentID.Name = "lbRentID";
            this.lbRentID.Size = new System.Drawing.Size(33, 19);
            this.lbRentID.TabIndex = 144;
            this.lbRentID.Text = "----";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(410, 29);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 19);
            this.metroLabel3.TabIndex = 145;
            this.metroLabel3.Text = "Bérlés kezdete :";
            // 
            // lbDateToDay
            // 
            this.lbDateToDay.AutoSize = true;
            this.lbDateToDay.Location = new System.Drawing.Point(1037, 29);
            this.lbDateToDay.Name = "lbDateToDay";
            this.lbDateToDay.Size = new System.Drawing.Size(43, 19);
            this.lbDateToDay.TabIndex = 146;
            this.lbDateToDay.Text = "Today";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Gray;
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.tbEndMileage);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.lbPriceOfRent);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.lbRentedDays);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(649, 263);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(348, 185);
            this.metroPanel1.TabIndex = 201;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(271, 131);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(28, 19);
            this.metroLabel9.TabIndex = 202;
            this.metroLabel9.Text = "Km";
            // 
            // tbEndMileage
            // 
            // 
            // 
            // 
            this.tbEndMileage.CustomButton.Image = null;
            this.tbEndMileage.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.tbEndMileage.CustomButton.Name = "";
            this.tbEndMileage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbEndMileage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbEndMileage.CustomButton.TabIndex = 1;
            this.tbEndMileage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbEndMileage.CustomButton.UseSelectable = true;
            this.tbEndMileage.CustomButton.Visible = false;
            this.tbEndMileage.Lines = new string[0];
            this.tbEndMileage.Location = new System.Drawing.Point(136, 127);
            this.tbEndMileage.MaxLength = 32767;
            this.tbEndMileage.Name = "tbEndMileage";
            this.tbEndMileage.PasswordChar = '\0';
            this.tbEndMileage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEndMileage.SelectedText = "";
            this.tbEndMileage.SelectionLength = 0;
            this.tbEndMileage.SelectionStart = 0;
            this.tbEndMileage.ShortcutsEnabled = true;
            this.tbEndMileage.Size = new System.Drawing.Size(129, 23);
            this.tbEndMileage.TabIndex = 201;
            this.tbEndMileage.UseSelectable = true;
            this.tbEndMileage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbEndMileage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(35, 131);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(95, 19);
            this.metroLabel8.TabIndex = 200;
            this.metroLabel8.Text = "Km óra állása :";
            // 
            // lbPriceOfRent
            // 
            this.lbPriceOfRent.AutoSize = true;
            this.lbPriceOfRent.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbPriceOfRent.Location = new System.Drawing.Point(231, 75);
            this.lbPriceOfRent.Name = "lbPriceOfRent";
            this.lbPriceOfRent.Size = new System.Drawing.Size(49, 25);
            this.lbPriceOfRent.TabIndex = 199;
            this.lbPriceOfRent.Text = "price";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(35, 75);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(143, 25);
            this.metroLabel7.TabIndex = 198;
            this.metroLabel7.Text = "Eddigi bérleti díj :";
            // 
            // lbRentedDays
            // 
            this.lbRentedDays.AutoSize = true;
            this.lbRentedDays.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbRentedDays.Location = new System.Drawing.Point(231, 17);
            this.lbRentedDays.Name = "lbRentedDays";
            this.lbRentedDays.Size = new System.Drawing.Size(46, 25);
            this.lbRentedDays.TabIndex = 197;
            this.lbRentedDays.Text = "days";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(35, 17);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(174, 25);
            this.metroLabel5.TabIndex = 196;
            this.metroLabel5.Text = "Bérelt napok száma : ";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(922, 29);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(80, 19);
            this.metroLabel6.TabIndex = 202;
            this.metroLabel6.Text = "Mai dátum :";
            // 
            // rentsBindingSource
            // 
            this.rentsBindingSource.DataSource = typeof(RentACarA.Rents);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataSource = typeof(RentACarA.Customers);
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataSource = typeof(RentACarA.Vehicles);
            // 
            // vehiclePlatesAndModelsBindingSource
            // 
            this.vehiclePlatesAndModelsBindingSource.DataSource = typeof(RentACarA.VehiclePlatesAndModels);
            // 
            // customerAddressesBindingSource
            // 
            this.customerAddressesBindingSource.DataSource = typeof(RentACarA.CustomerAddresses);
            // 
            // frmOpenRentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 653);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.lbDateToDay);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lbRentID);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tbRent);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbDatestart);
            this.Controls.Add(this.lbCID);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tbNoteVehicle);
            this.Controls.Add(this.lbVID);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnEndOfRent);
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
            this.Name = "frmOpenRentDetails";
            this.Text = "Bérlés adatai";
            this.Load += new System.EventHandler(this.frmOpenRentDetails_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePlatesAndModelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAddressesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbRent;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroLabel lbDatestart;
        private MetroFramework.Controls.MetroLabel lbCID;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbNoteVehicle;
        private MetroFramework.Controls.MetroLabel lbVID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnEndOfRent;
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
        private System.Windows.Forms.TextBox tbNoteCustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLicense;
        private System.Windows.Forms.TextBox tbBuilding;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPostal;
        private System.Windows.Forms.TextBox tbCity;
        private MetroFramework.Controls.MetroTextBox tbLocType;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.BindingSource rentsBindingSource;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private System.Windows.Forms.BindingSource vehiclePlatesAndModelsBindingSource;
        private System.Windows.Forms.BindingSource customerAddressesBindingSource;
        private System.Windows.Forms.Label label19;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lbRentID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lbDateToDay;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lbPriceOfRent;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lbRentedDays;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.SaveFileDialog SaveDocument;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox tbEndMileage;
    }
}