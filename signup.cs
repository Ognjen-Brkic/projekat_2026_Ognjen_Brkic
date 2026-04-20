using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projekat_2026_Ognjen_Brkic
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            SqlConnection veza=konekcija.Connect();
            SqlCommand provera = new SqlCommand("SELECT COUNT(*) FROM klijenti WHERE username = @username", veza);
            provera.Parameters.AddWithValue("@username", txt_email.Text);
            veza.Open();
            int postoji = (int)provera.ExecuteScalar();
            veza.Close();

            if (postoji > 0)
            {
                MessageBox.Show("Korisnik sa tim emailom vec postoji!");
                return;
            }
            else
            {
                if (txt_password.Text == txt_password2.Text)
                {
                    StringBuilder naredba = new StringBuilder("Insert into klijenti (ime, prezime, username, password, broj_telefona) values('");
                    naredba.Append(txt_ime.Text + "', '" + txt_prezime.Text + "', '" + txt_email.Text + "', '" + txt_password.Text + "', '" + txt_broj_telefona.Text + "')");
                    
                    SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
                    veza.Open();
                    komanda.ExecuteNonQuery();
                    veza.Close();
                    MessageBox.Show("Uspesno ste se registrovali");
                    Login frm_login = new Login();
                    frm_login.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Loznike se ne podudaraju");
                }
            }
        }

        private void btn_nazad_Click(object sender, EventArgs e)
        {
            Login frm_login=new Login();
            frm_login.Show();
            this.Hide();
        }
    }
}
