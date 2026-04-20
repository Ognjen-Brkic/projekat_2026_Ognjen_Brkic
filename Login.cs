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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

    

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Morate uneti podatke!");
                return;
            }
            else
            {
                SqlConnection veza = konekcija.Connect();
                DataTable tabela = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from klijenti where username='"+txt_email.Text+"'", veza);
                adapter.Fill(tabela);
                int brojac=tabela.Rows.Count;
                if (brojac == 1)
                {
                    if (String.Compare(tabela.Rows[0]["password"].ToString(), txt_password.Text) == 0)
                    {
                        MessageBox.Show("Uspesno ste se ulogovali");
                        Program.user_id = Convert.ToInt32(tabela.Rows[0]["id"]);
                        glavna frm_glavna=new glavna();
                        frm_glavna.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Neispravna lozinka");
                    }
                }
                else
                {
                    SqlDataAdapter adapter2 = new SqlDataAdapter("select * from administratori where username='" + txt_email.Text+"'", veza);
                    DataTable tabela2 = new DataTable();
                    adapter2.Fill(tabela2);
                    brojac = tabela2.Rows.Count;
                    if (brojac == 1)
                    {
                        if (String.Compare(tabela2.Rows[0]["password"].ToString(), txt_password.Text) == 0)
                        {
                            MessageBox.Show("Uspesno ste se ulogovali");
                            Program.user_id = Convert.ToInt32(tabela2.Rows[0]["id"]);
                            admin frm_admin=new admin();
                            frm_admin.Show();
                            this.Hide();
                            
                        }
                        else
                        {
                            MessageBox.Show("Neispravna lozinka");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Ova email adresa ne postoji, molim vas da se registrujete");
                    }
                }
                }
               
            }

        private void btn_sign_up_Click(object sender, EventArgs e)
        {
            signup frm_signup=new signup();
            frm_signup.Show();
            this.Hide();

        }
    }
    }

