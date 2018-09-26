using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarA
{
    public partial class frmChangePassword : MetroFramework.Forms.MetroForm
    {
        RACverBEntities db;
        

        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            db = new RACverBEntities();
            
            

            if (string.IsNullOrEmpty(tbOldUsername.Text))  
            {
                MessageBox.Show("A felhasználónév mező nem lehet üres !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (string.IsNullOrEmpty(tbOldPassword.Text))
            {
                MessageBox.Show("A jelszó mező nem lehet üres !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (string.IsNullOrEmpty(tbNewUsername.Text))
            {
                MessageBox.Show("Az új felhasználónév mező nem lehet üres !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (string.IsNullOrEmpty(tbNewUsername.Text))
            {
                MessageBox.Show("Az új jelszó mező nem lehet üres !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (string.IsNullOrEmpty(tbNewUsername.Text))
            {
                MessageBox.Show("Az új jelszó megerősítése mező nem lehet üres !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (tbNewPassword.Text != tbNewPasswordConfirm.Text)
            {
                MessageBox.Show("A jelszó megerősítése nem egyezik a jelszóval !", "Hiba! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                foreach (var us in db.Users)
                {

                    if (us.Username.Trim() == tbOldUsername.Text && us.Password.Trim() == tbOldPassword.Text)
                    {
                        us.Username = tbNewUsername.Text.Trim();
                       
                        us.Password = tbNewPassword.Text.Trim();

                        MessageBox.Show("A felhasználónév és a jelszó sikeresen megváltoztatva !", "Info! ", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    }
                  
                }
                
                DialogResult = DialogResult.OK;
                db.SaveChanges();
            }
        }
    }
}
