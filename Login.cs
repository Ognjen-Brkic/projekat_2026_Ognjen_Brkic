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

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ognjen Brkic
            // drugi red
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Morate uneti podatke!");
            }
            else
            {
                SqlConnection veza = konekcija.Connect();
                DataTable podaci = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from klijenti where email="+txt_email.Text, veza);
                adapter.Fill(podaci);
            }

            
        }
    }
}
