using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarA
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        SqlConnection cn;

        RACverBEntities mod = new RACverBEntities();


        

        public frmLogin()
        {
            InitializeComponent();

            

        }


        

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUserName.Text))
            {

                MessageBox.Show("Kérem adja meg a felhasználónevet !", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUserName.Focus();
                return;

            }
            else if (string.IsNullOrEmpty(tbPassword.Text))
            {

                MessageBox.Show("Kérem adja meg a jelszót !", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbPassword.Focus();
                return;

            }
            else
            {
                try
                {
                     
                    foreach (var user in mod.Users)
                    {

                        if (user.Username.Trim() == tbUserName.Text && user.Password.Trim() == tbPassword.Text)
                        {
                            this.Hide();
                            Main main = new Main();
                            main.Show();

                        }
                        else
                        {
                            MessageBox.Show("Hibás Felhasználónév vagy jelszó !", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba az adatbázis kapcsolatban !" + ex.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                
            }
        }

        



    }
}
