namespace RentACarA
{
    partial class frmOpenVehicle
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblAva = new MetroFramework.Controls.MetroLabel();
            this.tbNote = new MetroFramework.Controls.MetroTextBox();
            this.tbPrice = new MetroFramework.Controls.MetroTextBox();
            this.tbMileage = new MetroFramework.Controls.MetroTextBox();
            this.cbType = new MetroFramework.Controls.MetroComboBox();
            this.tbPlate = new MetroFramework.Controls.MetroTextBox();
            this.vehiclePlatesAndModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbModel = new MetroFramework.Controls.MetroTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMade = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePlatesAndModelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "VehicleID", true));
            this.metroLabel2.Location = new System.Drawing.Point(116, 298);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(27, 19);
            this.metroLabel2.TabIndex = 51;
            this.metroLabel2.Text = "---";
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataSource = typeof(RentACarA.Vehicles);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 298);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 50;
            this.metroLabel1.Text = "Azonosító :";
            // 
            // lblAva
            // 
            this.lblAva.AutoSize = true;
            this.lblAva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Avalaible", true));
            this.lblAva.Location = new System.Drawing.Point(438, 203);
            this.lblAva.Name = "lblAva";
            this.lblAva.Size = new System.Drawing.Size(65, 19);
            this.lblAva.TabIndex = 49;
            this.lblAva.Text = "Bérelhető";
            // 
            // tbNote
            // 
            // 
            // 
            // 
            this.tbNote.CustomButton.Image = null;
            this.tbNote.CustomButton.Location = new System.Drawing.Point(489, 1);
            this.tbNote.CustomButton.Name = "";
            this.tbNote.CustomButton.Size = new System.Drawing.Size(61, 61);
            this.tbNote.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNote.CustomButton.TabIndex = 1;
            this.tbNote.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNote.CustomButton.UseSelectable = true;
            this.tbNote.CustomButton.Visible = false;
            this.tbNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "VechNote", true));
            this.tbNote.Lines = new string[0];
            this.tbNote.Location = new System.Drawing.Point(23, 374);
            this.tbNote.MaxLength = 32767;
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.PasswordChar = '\0';
            this.tbNote.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNote.SelectedText = "";
            this.tbNote.SelectionLength = 0;
            this.tbNote.SelectionStart = 0;
            this.tbNote.ShortcutsEnabled = true;
            this.tbNote.Size = new System.Drawing.Size(551, 63);
            this.tbNote.TabIndex = 47;
            this.tbNote.UseSelectable = true;
            this.tbNote.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNote.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbPrice
            // 
            // 
            // 
            // 
            this.tbPrice.CustomButton.Image = null;
            this.tbPrice.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.tbPrice.CustomButton.Name = "";
            this.tbPrice.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPrice.CustomButton.TabIndex = 1;
            this.tbPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPrice.CustomButton.UseSelectable = true;
            this.tbPrice.CustomButton.Visible = false;
            this.tbPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Price", true));
            this.tbPrice.Lines = new string[0];
            this.tbPrice.Location = new System.Drawing.Point(455, 128);
            this.tbPrice.MaxLength = 32767;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPrice.SelectedText = "";
            this.tbPrice.SelectionLength = 0;
            this.tbPrice.SelectionStart = 0;
            this.tbPrice.ShortcutsEnabled = true;
            this.tbPrice.Size = new System.Drawing.Size(118, 29);
            this.tbPrice.TabIndex = 46;
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
            this.tbMileage.Location = new System.Drawing.Point(438, 93);
            this.tbMileage.MaxLength = 32767;
            this.tbMileage.Name = "tbMileage";
            this.tbMileage.PasswordChar = '\0';
            this.tbMileage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMileage.SelectedText = "";
            this.tbMileage.SelectionLength = 0;
            this.tbMileage.SelectionStart = 0;
            this.tbMileage.ShortcutsEnabled = true;
            this.tbMileage.Size = new System.Drawing.Size(136, 29);
            this.tbMileage.TabIndex = 45;
            this.tbMileage.UseSelectable = true;
            this.tbMileage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMileage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbType
            // 
            this.cbType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.vehiclesBindingSource, "Type", true));
            this.cbType.FormattingEnabled = true;
            this.cbType.ItemHeight = 23;
            this.cbType.Location = new System.Drawing.Point(91, 203);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(186, 29);
            this.cbType.TabIndex = 44;
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
            this.tbPlate.Location = new System.Drawing.Point(91, 163);
            this.tbPlate.MaxLength = 32767;
            this.tbPlate.Name = "tbPlate";
            this.tbPlate.PasswordChar = '\0';
            this.tbPlate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPlate.SelectedText = "";
            this.tbPlate.SelectionLength = 0;
            this.tbPlate.SelectionStart = 0;
            this.tbPlate.ShortcutsEnabled = true;
            this.tbPlate.Size = new System.Drawing.Size(186, 29);
            this.tbPlate.TabIndex = 43;
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
            this.tbModel.Location = new System.Drawing.Point(91, 128);
            this.tbModel.MaxLength = 32767;
            this.tbModel.Name = "tbModel";
            this.tbModel.PasswordChar = '\0';
            this.tbModel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbModel.SelectedText = "";
            this.tbModel.SelectionLength = 0;
            this.tbModel.SelectionStart = 0;
            this.tbModel.ShortcutsEnabled = true;
            this.tbModel.Size = new System.Drawing.Size(186, 29);
            this.tbModel.TabIndex = 42;
            this.tbModel.UseSelectable = true;
            this.tbModel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbModel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Megjegyzés :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Gyártó :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Típus";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Modell :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Rendszám:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Km futás :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Bérleti díj / nap :";
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
            this.tbMade.Location = new System.Drawing.Point(91, 93);
            this.tbMade.MaxLength = 32767;
            this.tbMade.Name = "tbMade";
            this.tbMade.PasswordChar = '\0';
            this.tbMade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMade.SelectedText = "";
            this.tbMade.SelectionLength = 0;
            this.tbMade.SelectionStart = 0;
            this.tbMade.ShortcutsEnabled = true;
            this.tbMade.Size = new System.Drawing.Size(186, 29);
            this.tbMade.TabIndex = 41;
            this.tbMade.UseSelectable = true;
            this.tbMade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(368, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(205, 32);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Mentés";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmOpenVehicle
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 466);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblAva);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbMileage);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbPlate);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbMade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOpenVehicle";
            this.Text = "Jármű adatai";
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePlatesAndModelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblAva;
        private MetroFramework.Controls.MetroTextBox tbNote;
        private MetroFramework.Controls.MetroTextBox tbPrice;
        private MetroFramework.Controls.MetroTextBox tbMileage;
        private MetroFramework.Controls.MetroComboBox cbType;
        private MetroFramework.Controls.MetroTextBox tbPlate;
        private MetroFramework.Controls.MetroTextBox tbModel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private System.Windows.Forms.BindingSource vehiclePlatesAndModelsBindingSource;
        private MetroFramework.Controls.MetroTextBox tbMade;
        private System.Windows.Forms.Button btnSave;
    }
}