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
    public partial class blokiraj : Form
    {
        public blokiraj()
        {
            InitializeComponent();
        }
        private void grid_populate()
        {
            SqlConnection veza = konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(
                "select id, datum, termin from termini " +
                "where admin_id = @admin_id and dostupnost = 0 and klijent_id is null " +
                "and datum = @datum " +
                "order by datum, termin", veza);
            adapter.SelectCommand.Parameters.AddWithValue("@admin_id", Program.user_id);
            adapter.SelectCommand.Parameters.AddWithValue("@datum", blok_datum.Value.Date);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            grid_blokirani.DataSource = tabela;
            grid_blokirani.ReadOnly = true;
        }
        private void cmb_termini_populate()
        {
            SqlConnection veza = konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(
                "select distinct termin from termini " +
                "where admin_id = @admin_id and datum = @datum " +
                "order by termin", veza);
            adapter.SelectCommand.Parameters.AddWithValue("@admin_id", Program.user_id);
            adapter.SelectCommand.Parameters.AddWithValue("@datum", blok_datum.Value.Date);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);

            cmb_termin1.DataSource = tabela;
            cmb_termin1.DisplayMember = "termin";
            cmb_termin1.ValueMember = "termin";

            DataTable tabela2 = new DataTable();
            adapter.Fill(tabela2);
            cmb_termin2.DataSource = tabela2;
            cmb_termin2.DisplayMember = "termin";
            cmb_termin2.ValueMember = "termin";
        }


        private void blokiraj_Load(object sender, EventArgs e)
        {
            blok_datum.MinDate = DateTime.Today;
            grid_populate();
            cmb_termini_populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan od = (TimeSpan)cmb_termin1.SelectedValue;
            TimeSpan do_ = (TimeSpan)cmb_termin2.SelectedValue;

            if (od > do_)
            {
                MessageBox.Show("Pocetni termin ne moze biti posle krajnjeg!");
                return;
            }

            SqlConnection veza = konekcija.Connect();

            SqlDataAdapter provera = new SqlDataAdapter(
                "select klijenti.ime, klijenti.prezime, klijenti.broj_telefona, termini.termin " +
                "from termini join klijenti on termini.klijent_id = klijenti.id " +
                "where termini.admin_id = @admin_id and termini.datum = @datum " +
                "and termini.termin between @od and @do " +
                "and termini.dostupnost = 0 and termini.klijent_id is not null", veza);
            provera.SelectCommand.Parameters.AddWithValue("@admin_id", Program.user_id);
            provera.SelectCommand.Parameters.AddWithValue("@datum", blok_datum.Value.Date);
            provera.SelectCommand.Parameters.AddWithValue("@od", od);
            provera.SelectCommand.Parameters.AddWithValue("@do", do_);
            DataTable zakazani = new DataTable();
            provera.Fill(zakazani);

            if (zakazani.Rows.Count > 0)
            {
                StringBuilder poruka = new StringBuilder();
                for (int i = 0; i < zakazani.Rows.Count; i++)
                {
                    poruka.AppendLine("Rezervisao: " + zakazani.Rows[i]["ime"] + " " + zakazani.Rows[i]["prezime"] +
                                      " termin u " + ((TimeSpan)zakazani.Rows[i]["termin"]).ToString(@"hh\:mm"));
                    poruka.AppendLine("Broj telefona: " + zakazani.Rows[i]["broj_telefona"]);
                    poruka.AppendLine();
                }
                MessageBox.Show(poruka.ToString(), "Zakazani termini", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand komanda = new SqlCommand(
                    "update termini set dostupnost = 0 " +
                    "where admin_id = @admin_id and datum = @datum and termin between @od and @do", veza);
                komanda.Parameters.AddWithValue("@admin_id", Program.user_id);
                komanda.Parameters.AddWithValue("@datum", blok_datum.Value.Date);
                komanda.Parameters.AddWithValue("@od", od);
                komanda.Parameters.AddWithValue("@do", do_);
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                MessageBox.Show("Termini uspesno blokirani!");
                grid_populate();
            }
        }

        private void blok_datum_ValueChanged(object sender, EventArgs e)
        {
            grid_populate();
            cmb_termini_populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (grid_blokirani.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite termin za odblokiranje!");
                return;
            }

            int id = Convert.ToInt32(grid_blokirani.SelectedRows[0].Cells["id"].Value);

            SqlConnection veza = konekcija.Connect();
            SqlCommand komanda = new SqlCommand(
                "update termini set dostupnost = 1 where id = @id", veza);
            komanda.Parameters.AddWithValue("@id", id);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();

            MessageBox.Show("Termin uspesno odblokiran!");
            grid_populate();
        }
    }
}

