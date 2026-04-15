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
    public partial class recenzija : Form
    {
        int ocena = 0;
        public recenzija()
        {
            InitializeComponent();
        }
        private void oboji_zvezde(int value)
        {
            lbl_zvezda1.Text = value >= 1 ? "★" : "☆";
            lbl_zvezda2.Text = value >= 2 ? "★" : "☆";
            lbl_zvezda3.Text = value >= 3 ? "★" : "☆";
            lbl_zvezda4.Text = value >= 4 ? "★" : "☆";
            lbl_zvezda5.Text = value >= 5 ? "★" : "☆";
        }

        private void lbl_zvezda1_Click(object sender, EventArgs e)
        {
            ocena = 1;
            oboji_zvezde(ocena);
        }

        private void lbl_zvezda2_Click(object sender, EventArgs e)
        {
            ocena = 2;
            oboji_zvezde(ocena);
        }

        private void lbl_zvezda3_Click(object sender, EventArgs e)
        {
            ocena = 3;
            oboji_zvezde(ocena);
        }

        private void lbl_zvezda4_Click(object sender, EventArgs e)
        {
            ocena = 4;
            oboji_zvezde(ocena);
        }

        private void lbl_zvezda5_Click(object sender, EventArgs e)
        {
            ocena = 5;
            oboji_zvezde(ocena);
        }

        private void btn_postavi_rec_Click(object sender, EventArgs e)
        {
            SqlConnection veza=konekcija.Connect();
            
            string naredba = ("insert into recenzije (komentar, broj_zvezdica, klijent_id) values ('"+ txt_recenzija.Text + "', " + ocena + ", " + Program.user_id+")");
            
            SqlCommand komanda= new SqlCommand(naredba.ToString(),veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            MessageBox.Show("Uspesno ste ostavili recenziju");

        }

        private void btn_nazad_Click(object sender, EventArgs e)
        {
            glavna frm_glavna=new glavna();
            frm_glavna.Show();
            this.Hide();    
        }
    }
}
