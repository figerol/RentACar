namespace RentACarA
{
    partial class frmCustomers
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
            this.lvCustomers = new System.Windows.Forms.ListView();
            this.CustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PostCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Street = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Building = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNewCustomer = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnNewRentStart = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lvCustomers
            // 
            this.lvCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerID,
            this.LastName,
            this.FirstName,
            this.Phone,
            this.Email,
            this.PostCode,
            this.City,
            this.Street,
            this.LocationType,
            this.Building,
            this.columnHeader11});
            this.lvCustomers.FullRowSelect = true;
            this.lvCustomers.Location = new System.Drawing.Point(0, 153);
            this.lvCustomers.Name = "lvCustomers";
            this.lvCustomers.Size = new System.Drawing.Size(1154, 405);
            this.lvCustomers.TabIndex = 3;
            this.lvCustomers.UseCompatibleStateImageBehavior = false;
            this.lvCustomers.View = System.Windows.Forms.View.Details;
            this.lvCustomers.ItemActivate += new System.EventHandler(this.lvCustomers_ItemActivate);
            // 
            // CustomerID
            // 
            this.CustomerID.Text = "Vevő Azonosító";
            this.CustomerID.Width = 90;
            // 
            // LastName
            // 
            this.LastName.Text = "Vezetéknév";
            this.LastName.Width = 150;
            // 
            // FirstName
            // 
            this.FirstName.Text = "Keresztnév";
            this.FirstName.Width = 150;
            // 
            // Phone
            // 
            this.Phone.Text = "Telefon";
            this.Phone.Width = 100;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 150;
            // 
            // PostCode
            // 
            this.PostCode.Text = "Irányítószám";
            this.PostCode.Width = 90;
            // 
            // City
            // 
            this.City.Text = "Város";
            this.City.Width = 150;
            // 
            // Street
            // 
            this.Street.Text = "Utca";
            this.Street.Width = 150;
            // 
            // LocationType
            // 
            this.LocationType.Text = "utca/ut/tér";
            // 
            // Building
            // 
            this.Building.Text = "Házszám";
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(423, 5);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(116, 43);
            this.btnNewCustomer.TabIndex = 6;
            this.btnNewCustomer.Text = "Új kliens felvétele";
            this.btnNewCustomer.UseSelectable = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(295, 111);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Keresés :";
            // 
            // tbSearch
            // 
            // 
            // 
            // 
            this.tbSearch.CustomButton.Image = null;
            this.tbSearch.CustomButton.Location = new System.Drawing.Point(404, 1);
            this.tbSearch.CustomButton.Name = "";
            this.tbSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSearch.CustomButton.TabIndex = 1;
            this.tbSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSearch.CustomButton.UseSelectable = true;
            this.tbSearch.CustomButton.Visible = false;
            this.tbSearch.Lines = new string[0];
            this.tbSearch.Location = new System.Drawing.Point(360, 107);
            this.tbSearch.MaxLength = 32767;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearch.SelectedText = "";
            this.tbSearch.SelectionLength = 0;
            this.tbSearch.SelectionStart = 0;
            this.tbSearch.ShortcutsEnabled = true;
            this.tbSearch.Size = new System.Drawing.Size(426, 23);
            this.tbSearch.TabIndex = 8;
            this.tbSearch.UseSelectable = true;
            this.tbSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_TextChanged);
            // 
            // btnNewRentStart
            // 
            this.btnNewRentStart.Location = new System.Drawing.Point(545, 5);
            this.btnNewRentStart.Name = "btnNewRentStart";
            this.btnNewRentStart.Size = new System.Drawing.Size(116, 43);
            this.btnNewRentStart.TabIndex = 48;
            this.btnNewRentStart.Text = "Új bérlés indítása";
            this.btnNewRentStart.UseSelectable = true;
            this.btnNewRentStart.Click += new System.EventHandler(this.btnNewRentStart_Click);
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 558);
            this.Controls.Add(this.btnNewRentStart);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.lvCustomers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomers";
            this.Text = "Kliensek";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvCustomers;
        private System.Windows.Forms.ColumnHeader CustomerID;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader PostCode;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader Street;
        private System.Windows.Forms.ColumnHeader LocationType;
        private System.Windows.Forms.ColumnHeader Building;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private MetroFramework.Controls.MetroButton btnNewCustomer;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbSearch;
        private MetroFramework.Controls.MetroButton btnNewRentStart;
    }
}