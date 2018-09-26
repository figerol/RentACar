namespace RentACarA
{
    partial class frmSelectVehicle
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
            this.lvVehicles = new System.Windows.Forms.ListView();
            this.VehicleID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Made = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Plate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mileage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSeletVehicle = new MetroFramework.Controls.MetroButton();
            this.tbSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lvVehicles
            // 
            this.lvVehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.VehicleID,
            this.Made,
            this.Model,
            this.Plate,
            this.Type,
            this.Mileage,
            this.Price});
            this.lvVehicles.FullRowSelect = true;
            this.lvVehicles.HideSelection = false;
            this.lvVehicles.Location = new System.Drawing.Point(0, 148);
            this.lvVehicles.MultiSelect = false;
            this.lvVehicles.Name = "lvVehicles";
            this.lvVehicles.Size = new System.Drawing.Size(884, 384);
            this.lvVehicles.TabIndex = 5;
            this.lvVehicles.UseCompatibleStateImageBehavior = false;
            this.lvVehicles.View = System.Windows.Forms.View.Details;
            this.lvVehicles.SelectedIndexChanged += new System.EventHandler(this.lvVehicles_SelectedIndexChanged);
            // 
            // VehicleID
            // 
            this.VehicleID.Text = "Jármű Azonosító";
            this.VehicleID.Width = 100;
            // 
            // Made
            // 
            this.Made.Text = "Gyártó";
            this.Made.Width = 150;
            // 
            // Model
            // 
            this.Model.Text = "Modell";
            this.Model.Width = 150;
            // 
            // Plate
            // 
            this.Plate.Text = "Rendszám";
            this.Plate.Width = 120;
            // 
            // Type
            // 
            this.Type.Text = "Típus";
            this.Type.Width = 120;
            // 
            // Mileage
            // 
            this.Mileage.Text = "Km futás";
            this.Mileage.Width = 120;
            // 
            // Price
            // 
            this.Price.Text = "Bérleti díj / nap";
            this.Price.Width = 120;
            // 
            // btnSeletVehicle
            // 
            this.btnSeletVehicle.Location = new System.Drawing.Point(0, 103);
            this.btnSeletVehicle.Name = "btnSeletVehicle";
            this.btnSeletVehicle.Size = new System.Drawing.Size(174, 39);
            this.btnSeletVehicle.TabIndex = 6;
            this.btnSeletVehicle.Text = "Jármű kiválasztása";
            this.btnSeletVehicle.UseSelectable = true;
            this.btnSeletVehicle.Click += new System.EventHandler(this.btnSeletVehicle_Click);
            // 
            // tbSearch
            // 
            // 
            // 
            // 
            this.tbSearch.CustomButton.Image = null;
            this.tbSearch.CustomButton.Location = new System.Drawing.Point(261, 1);
            this.tbSearch.CustomButton.Name = "";
            this.tbSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSearch.CustomButton.TabIndex = 1;
            this.tbSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSearch.CustomButton.UseSelectable = true;
            this.tbSearch.CustomButton.Visible = false;
            this.tbSearch.Lines = new string[0];
            this.tbSearch.Location = new System.Drawing.Point(322, 103);
            this.tbSearch.MaxLength = 32767;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearch.SelectedText = "";
            this.tbSearch.SelectionLength = 0;
            this.tbSearch.SelectionStart = 0;
            this.tbSearch.ShortcutsEnabled = true;
            this.tbSearch.Size = new System.Drawing.Size(283, 23);
            this.tbSearch.TabIndex = 12;
            this.tbSearch.UseSelectable = true;
            this.tbSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(257, 107);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Keresés :";
            // 
            // frmSelectVehicle
            // 
            this.AcceptButton = this.btnSeletVehicle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 533);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnSeletVehicle);
            this.Controls.Add(this.lvVehicles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectVehicle";
            this.Text = "Jármű kiválasztása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvVehicles;
        private System.Windows.Forms.ColumnHeader VehicleID;
        private System.Windows.Forms.ColumnHeader Made;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Plate;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Mileage;
        private System.Windows.Forms.ColumnHeader Price;
        private MetroFramework.Controls.MetroButton btnSeletVehicle;
        private MetroFramework.Controls.MetroTextBox tbSearch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}