namespace RentACarA
{
    partial class frmOpenCustomer
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
            this.cbLocType = new System.Windows.Forms.ComboBox();
            this.customerAddressesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rACverBDataSet = new RentACarA.RACverBDataSet();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lbCID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbBuilding = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbPostal = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbLicense = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerAddressesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rACverBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLocType
            // 
            this.cbLocType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerAddressesBindingSource, "LocType", true));
            this.cbLocType.FormattingEnabled = true;
            this.cbLocType.Location = new System.Drawing.Point(476, 174);
            this.cbLocType.Name = "cbLocType";
            this.cbLocType.Size = new System.Drawing.Size(91, 21);
            this.cbLocType.TabIndex = 36;
            // 
            // customerAddressesBindingSource
            // 
            this.customerAddressesBindingSource.DataMember = "CustomerAddresses";
            this.customerAddressesBindingSource.DataSource = this.rACverBDataSet;
            // 
            // rACverBDataSet
            // 
            this.rACverBDataSet.DataSetName = "RACverBDataSet";
            this.rACverBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbNote
            // 
            this.tbNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerNote", true));
            this.tbNote.Location = new System.Drawing.Point(15, 364);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(552, 69);
            this.tbNote.TabIndex = 41;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataSource = typeof(RentACarA.Customers);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Megjegyzés :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Vezetéknév :";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(381, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(186, 23);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Mentés";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // tbLastName
            // 
            this.tbLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "LastName", true));
            this.tbLastName.Location = new System.Drawing.Point(83, 92);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(186, 20);
            this.tbLastName.TabIndex = 24;
            // 
            // tbFirstName
            // 
            this.tbFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "FirstName", true));
            this.tbFirstName.Location = new System.Drawing.Point(83, 133);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(186, 20);
            this.tbFirstName.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Telefonszám:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Keresztnév  :";
            // 
            // tbPhone
            // 
            this.tbPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Phone", true));
            this.tbPhone.Location = new System.Drawing.Point(83, 215);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(186, 20);
            this.tbPhone.TabIndex = 29;
            // 
            // lbCID
            // 
            this.lbCID.AutoSize = true;
            this.lbCID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
            this.lbCID.Location = new System.Drawing.Point(80, 304);
            this.lbCID.Name = "lbCID";
            this.lbCID.Size = new System.Drawing.Size(31, 13);
            this.lbCID.TabIndex = 44;
            this.lbCID.Text = "--------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Email cím:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Azonosító:";
            // 
            // tbEmail
            // 
            this.tbEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Email", true));
            this.tbEmail.Location = new System.Drawing.Point(83, 174);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(186, 20);
            this.tbEmail.TabIndex = 27;
            // 
            // tbBuilding
            // 
            this.tbBuilding.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerAddressesBindingSource, "Building", true));
            this.tbBuilding.Location = new System.Drawing.Point(457, 216);
            this.tbBuilding.Name = "tbBuilding";
            this.tbBuilding.Size = new System.Drawing.Size(110, 20);
            this.tbBuilding.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Lakcím:";
            // 
            // tbStreet
            // 
            this.tbStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerAddressesBindingSource, "Street", true));
            this.tbStreet.Location = new System.Drawing.Point(360, 175);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(110, 20);
            this.tbStreet.TabIndex = 35;
            // 
            // tbPostal
            // 
            this.tbPostal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "PostCode", true));
            this.tbPostal.Location = new System.Drawing.Point(457, 92);
            this.tbPostal.Name = "tbPostal";
            this.tbPostal.Size = new System.Drawing.Size(110, 20);
            this.tbPostal.TabIndex = 31;
            // 
            // tbCity
            // 
            this.tbCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerAddressesBindingSource, "City", true));
            this.tbCity.Location = new System.Drawing.Point(457, 133);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(110, 20);
            this.tbCity.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Jogosítvány szám:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(378, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Házszám :";
            // 
            // tbLicense
            // 
            this.tbLicense.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "DrivingLicenseNumber", true));
            this.tbLicense.Location = new System.Drawing.Point(113, 257);
            this.tbLicense.Name = "tbLicense";
            this.tbLicense.Size = new System.Drawing.Size(156, 20);
            this.tbLicense.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Város :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Irányítószám :";
            // 
            // frmOpenCustomer
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.cbLocType);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lbCID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
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
            this.Name = "frmOpenCustomer";
            this.Text = "Kliens adatai";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOpenCustomer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.customerAddressesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rACverBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLocType;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lbCID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
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
        private System.Windows.Forms.BindingSource customerAddressesBindingSource;
        private System.Windows.Forms.BindingSource customersBindingSource;
    }
}