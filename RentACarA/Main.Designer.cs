namespace RentACarA
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCustomers = new MetroFramework.Controls.MetroButton();
            this.btnRents = new MetroFramework.Controls.MetroButton();
            this.bntVehicles = new MetroFramework.Controls.MetroButton();
            this.btnSettings = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 58.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(42, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 89);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rent a Car";
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCustomers.Location = new System.Drawing.Point(994, 202);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(289, 58);
            this.btnCustomers.TabIndex = 11;
            this.btnCustomers.Text = "Kliensek";
            this.btnCustomers.UseSelectable = true;
            this.btnCustomers.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnRents
            // 
            this.btnRents.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRents.Location = new System.Drawing.Point(994, 275);
            this.btnRents.Name = "btnRents";
            this.btnRents.Size = new System.Drawing.Size(289, 58);
            this.btnRents.TabIndex = 12;
            this.btnRents.Text = "Bérlések";
            this.btnRents.UseSelectable = true;
            this.btnRents.Click += new System.EventHandler(this.btnRents_Click);
            // 
            // bntVehicles
            // 
            this.bntVehicles.BackColor = System.Drawing.Color.DodgerBlue;
            this.bntVehicles.Location = new System.Drawing.Point(994, 352);
            this.bntVehicles.Name = "bntVehicles";
            this.bntVehicles.Size = new System.Drawing.Size(289, 58);
            this.bntVehicles.TabIndex = 13;
            this.bntVehicles.Text = "Járművek";
            this.bntVehicles.UseSelectable = true;
            this.bntVehicles.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // btnSettings
            // 
            this.btnSettings.ActiveControl = null;
            this.btnSettings.Location = new System.Drawing.Point(994, 430);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(289, 58);
            this.btnSettings.TabIndex = 14;
            this.btnSettings.Text = "Beállítások";
            this.btnSettings.UseSelectable = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(764, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentACarA.Properties.Resources.mainPicture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackImage = global::RentACarA.Properties.Resources.mainPicture;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1283, 619);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.bntVehicles);
            this.Controls.Add(this.btnRents);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnCustomers;
        private MetroFramework.Controls.MetroButton btnRents;
        private MetroFramework.Controls.MetroButton bntVehicles;
        private MetroFramework.Controls.MetroTile btnSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}