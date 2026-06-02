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

namespace projekat_2026_Ognjen_Brkic
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        private void grid_populate()
        {
            SqlConnection veza = konekcija.Connect();
            StringBuilder upit = new StringBuilder();
            upit.Append("select min(termini.termin) as termin, termini.datum, ");
            upit.Append("termini.usluga, klijenti.ime, klijenti.prezime, klijenti.broj_telefona ");
            upit.Append("from termini ");
            upit.Append("join klijenti on termini.klijent_id = klijenti.id ");
            upit.Append("where termini.admin_id = @admin_id and termini.klijent_id is not null ");
            upit.Append("group by termini.datum, termini.usluga, klijenti.ime, klijenti.prezime, klijenti.broj_telefona ");
            upit.Append("order by termini.datum, min(termini.termin)");

            SqlDataAdapter adapter = new SqlDataAdapter(upit.ToString(), veza);
            adapter.SelectCommand.Parameters.AddWithValue("@admin_id", Program.user_id);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            grid_terminiadmin.DataSource = tabela;
            grid_terminiadmin.ReadOnly = true;
        }
        private void admin_Load(object sender, EventArgs e)
        {
            grid_populate();
        }

        private void btn_blokiraj_Click(object sender, EventArgs e)
        {
            blokiraj frm_blok=new blokiraj();
            frm_blok.Show();
            this.Hide();
        }

        private void admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
