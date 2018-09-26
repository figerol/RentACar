namespace RentACarA
{
    partial class frmVehicles
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
            this.btnNewVehicle = new MetroFramework.Controls.MetroButton();
            this.lvVehicles = new System.Windows.Forms.ListView();
            this.VehicleID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Available = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Made = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Plate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mileage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnNewVehicle
            // 
            this.btnNewVehicle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewVehicle.Location = new System.Drawing.Point(0, 88);
            this.btnNewVehicle.Name = "btnNewVehicle";
            this.btnNewVehicle.Size = new System.Drawing.Size(129, 23);
            this.btnNewVehicle.TabIndex = 3;
            this.btnNewVehicle.Text = "Új jármű felvétele";
            this.btnNewVehicle.UseSelectable = true;
            this.btnNewVehicle.Click += new System.EventHandler(this.btnNewVehicle_Click);
            // 
            // lvVehicles
            // 
            this.lvVehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.VehicleID,
            this.Available,
            this.Made,
            this.Model,
            this.Plate,
            this.Type,
            this.Mileage,
            this.Price});
            this.lvVehicles.FullRowSelect = true;
            this.lvVehicles.Location = new System.Drawing.Point(0, 117);
            this.lvVehicles.Name = "lvVehicles";
            this.lvVehicles.Size = new System.Drawing.Size(944, 408);
            this.lvVehicles.TabIndex = 4;
            this.lvVehicles.UseCompatibleStateImageBehavior = false;
            this.lvVehicles.View = System.Windows.Forms.View.Details;
            this.lvVehicles.ItemActivate += new System.EventHandler(this.lvVehicles_ItemActivate);
            // 
            // VehicleID
            // 
            this.VehicleID.Text = "Jármű Azonosító";
            this.VehicleID.Width = 100;
            // 
            // Available
            // 
            this.Available.Text = "Állapot";
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
            // tbSearch
            // 
            // 
            // 
            // 
            this.tbSearch.CustomButton.Image = null;
            this.tbSearch.CustomButton.Location = new System.Drawing.Point(315, 1);
            this.tbSearch.CustomButton.Name = "";
            this.tbSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSearch.CustomButton.TabIndex = 1;
            this.tbSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSearch.CustomButton.UseSelectable = true;
            this.tbSearch.CustomButton.Visible = false;
            this.tbSearch.Lines = new string[0];
            this.tbSearch.Location = new System.Drawing.Point(299, 88);
            this.tbSearch.MaxLength = 32767;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearch.SelectedText = "";
            this.tbSearch.SelectionLength = 0;
            this.tbSearch.SelectionStart = 0;
            this.tbSearch.ShortcutsEnabled = true;
            this.tbSearch.Size = new System.Drawing.Size(337, 23);
            this.tbSearch.TabIndex = 10;
            this.tbSearch.UseSelectable = true;
            this.tbSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(234, 92);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Keresés :";
            // 
            // frmVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 524);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lvVehicles);
            this.Controls.Add(this.btnNewVehicle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVehicles";
            this.Text = "Járművek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnNewVehicle;
        private System.Windows.Forms.ListView lvVehicles;
        private System.Windows.Forms.ColumnHeader VehicleID;
        private System.Windows.Forms.ColumnHeader Made;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Plate;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Mileage;
        private System.Windows.Forms.ColumnHeader Price;
        private MetroFramework.Controls.MetroTextBox tbSearch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ColumnHeader Available;
    }
}