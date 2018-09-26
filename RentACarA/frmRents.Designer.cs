namespace RentACarA
{
    partial class frmRents
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
            this.lvRents = new System.Windows.Forms.ListView();
            this.RentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VehicleID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Made = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lvRents
            // 
            this.lvRents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RentID,
            this.State,
            this.CustomerID,
            this.LastName,
            this.FirstName,
            this.VehicleID,
            this.Made,
            this.Model,
            this.DateFrom,
            this.DateEnd});
            this.lvRents.FullRowSelect = true;
            this.lvRents.Location = new System.Drawing.Point(-2, 118);
            this.lvRents.Name = "lvRents";
            this.lvRents.Size = new System.Drawing.Size(1154, 469);
            this.lvRents.TabIndex = 4;
            this.lvRents.UseCompatibleStateImageBehavior = false;
            this.lvRents.View = System.Windows.Forms.View.Details;
            this.lvRents.ItemActivate += new System.EventHandler(this.lvRents_ItemActivate);
            // 
            // RentID
            // 
            this.RentID.Text = "Bérlés Azonosító";
            this.RentID.Width = 94;
            // 
            // State
            // 
            this.State.Text = "Állapot";
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
            // VehicleID
            // 
            this.VehicleID.Text = "Jármű azonosító";
            this.VehicleID.Width = 90;
            // 
            // Made
            // 
            this.Made.Text = "Gyártó";
            this.Made.Width = 150;
            // 
            // Model
            // 
            this.Model.Text = "Típus";
            this.Model.Width = 150;
            // 
            // DateFrom
            // 
            this.DateFrom.Text = "Bérlés kezdete";
            this.DateFrom.Width = 120;
            // 
            // DateEnd
            // 
            this.DateEnd.Text = "Bérlés vége";
            this.DateEnd.Width = 120;
            // 
            // tbSearch
            // 
            // 
            // 
            // 
            this.tbSearch.CustomButton.Image = null;
            this.tbSearch.CustomButton.Location = new System.Drawing.Point(341, 1);
            this.tbSearch.CustomButton.Name = "";
            this.tbSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSearch.CustomButton.TabIndex = 1;
            this.tbSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSearch.CustomButton.UseSelectable = true;
            this.tbSearch.CustomButton.Visible = false;
            this.tbSearch.Lines = new string[0];
            this.tbSearch.Location = new System.Drawing.Point(356, 89);
            this.tbSearch.MaxLength = 32767;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearch.SelectedText = "";
            this.tbSearch.SelectionLength = 0;
            this.tbSearch.SelectionStart = 0;
            this.tbSearch.ShortcutsEnabled = true;
            this.tbSearch.Size = new System.Drawing.Size(363, 23);
            this.tbSearch.TabIndex = 10;
            this.tbSearch.UseSelectable = true;
            this.tbSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(291, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Keresés :";
            // 
            // frmRents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 586);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lvRents);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRents";
            this.Text = "Bérlések";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvRents;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.ColumnHeader RentID;
        private System.Windows.Forms.ColumnHeader CustomerID;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader VehicleID;
        private System.Windows.Forms.ColumnHeader Made;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader DateFrom;
        private System.Windows.Forms.ColumnHeader DateEnd;
        private MetroFramework.Controls.MetroTextBox tbSearch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}