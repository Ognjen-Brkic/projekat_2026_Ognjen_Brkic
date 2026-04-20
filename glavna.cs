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
    public partial class glavna : Form
    {
        public glavna()
        {
            InitializeComponent();
         
        }
        private int broj_slotova(string usluga)
        {
            switch (usluga)
            {
                case "Kosa i brada": return 3;
                case "Brada": return 1;
                case "Deca do 12 godina": return 2;
                default: return 2;
            }
        }

        private void grid_recenzije_populate()
        {
            SqlConnection veza = konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select klijenti.ime + ' ' + klijenti.prezime as klijent, recenzije.komentar, recenzije.broj_zvezdica from recenzije join klijenti on klijent_id=klijenti.id", veza);
            DataTable dt_recenzije = new DataTable();
            adapter.Fill(dt_recenzije);
            grid_recenzije.DataSource = dt_recenzije;
            grid_recenzije.ReadOnly = true;


        }
        private void grid_termini_populate()
        {
            SqlConnection veza = konekcija.Connect();
            StringBuilder upit = new StringBuilder();
            upit.Append("select min(termini.id) as id, termini.datum, min(termini.termin) as termin, ");
            upit.Append("termini.usluga, termini.admin_id, administratori.ime ");
            upit.Append("from termini ");
            upit.Append("join administratori on termini.admin_id = administratori.id ");
            upit.Append("where termini.klijent_id = @klijent_id ");
            upit.Append("group by termini.datum, termini.usluga, termini.admin_id, administratori.ime ");
            upit.Append("order by termini.datum, min(termini.termin)");

            SqlDataAdapter adapter = new SqlDataAdapter(upit.ToString(), veza);
            adapter.SelectCommand.Parameters.AddWithValue("@klijent_id", Program.user_id);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            grid_termini.DataSource = tabela;
            grid_termini.ReadOnly = true;
            grid_termini.Columns["id"].Visible = false;
            grid_termini.Columns["admin_id"].Visible = false;
        }

        private void glavna_Load(object sender, EventArgs e)
        {
            grid_recenzije_populate();
            grid_termini_populate();

        }

        private void grid_recenzije_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (grid_recenzije.Columns[e.ColumnIndex].Name == "broj_zvezdica")
            {
                if (e.Value != null)
                {
                    int broj = Convert.ToInt32(e.Value);
                    e.Value = new string('★', broj);
                    e.FormattingApplied = true;
                }
            }

        }

        private void btn_rec_Click(object sender, EventArgs e)
        {
            recenzija frm_rec= new recenzija();
            frm_rec.Show();
            this.Hide();
        }

        private void btn_rezervacija_Click(object sender, EventArgs e)
        {
            rezervacija frm_rez= new rezervacija();
            frm_rez.Show();
            this.Hide();
        }

        private void glavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_otkazi_Click(object sender, EventArgs e)
        {
            if (grid_termini.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite termin za otkazivanje!");
                return;
            }

            DateTime datum = Convert.ToDateTime(grid_termini.SelectedRows[0].Cells["datum"].Value);
            TimeSpan termin = (TimeSpan)grid_termini.SelectedRows[0].Cells["termin"].Value;
            string usluga = grid_termini.SelectedRows[0].Cells["usluga"].Value.ToString();
            int admin_id = Convert.ToInt32(grid_termini.SelectedRows[0].Cells["admin_id"].Value);
            int br = broj_slotova(usluga);

            SqlConnection veza = konekcija.Connect();

            
            SqlDataAdapter adapter = new SqlDataAdapter("select id from termini where admin_id = @admin_id and datum = @datum and termin >= @termin order by termin", veza);
            adapter.SelectCommand.Parameters.AddWithValue("@admin_id", admin_id);
            adapter.SelectCommand.Parameters.AddWithValue("@datum", datum);
            adapter.SelectCommand.Parameters.AddWithValue("@termin", termin);

            DataTable slotovi = new DataTable();
            adapter.Fill(slotovi);

            for (int j = 0; j < br && j < slotovi.Rows.Count; j++)
            {
                int slot_id = Convert.ToInt32(slotovi.Rows[j]["id"]);
                SqlCommand komanda = new SqlCommand("update termini set dostupnost = 1, klijent_id = NULL, usluga = NULL where id = @id", veza);
                komanda.Parameters.AddWithValue("@id", slot_id);
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }

            MessageBox.Show("Termin uspešno otkazan!");
            grid_termini_populate();
        }
    }
}
