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
    public partial class rezervacija : Form
    {
        private void cmb_frizer_populate()
        {
            SqlConnection veza= konekcija.Connect();
            SqlDataAdapter adapter= new SqlDataAdapter("select id, ime from administratori",veza);
            DataTable tabela= new DataTable();
            adapter.Fill(tabela);
            cmb_frizer.DataSource=tabela;
            cmb_frizer.ValueMember = "id";
            cmb_frizer.DisplayMember = "ime";
            cmb_frizer.SelectedValue = -1;
           
           
        }
        private void grid_cenovnik_populate()
        {
            SqlConnection veza=konekcija.Connect();
            SqlDataAdapter adapter= new SqlDataAdapter("select usluga, cena from cenovnik where admin_id="+cmb_frizer.SelectedValue,veza);
            DataTable dt_cenovnik = new DataTable();
            adapter.Fill(dt_cenovnik);
            grid_cenovnik.DataSource = dt_cenovnik;
            grid_cenovnik.ReadOnly = true;
        }
        private void cmb_usluga_populate()
        {
            SqlConnection veza = konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select id, usluga from cenovnik where admin_id=" + cmb_frizer.SelectedValue, veza);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            cmb_usluga.DataSource = tabela;
            cmb_usluga.ValueMember = "id";
            cmb_usluga.DisplayMember = "usluga";
            cmb_usluga.SelectedValue = -1;
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
        private void cmb_termin_populate()
        {
            int br=broj_slotova(cmb_usluga.Text);
            
            SqlConnection veza = konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select id, termin, dostupnost from termini where admin_id=" + cmb_frizer.SelectedValue + "and datum=@datum order by termin", veza);
            adapter.SelectCommand.Parameters.AddWithValue("@datum", datum_picker.Value.Date);
            DataTable svi_termini = new DataTable();
            adapter.Fill(svi_termini);
            DataTable rezultat = new DataTable();
            rezultat.Columns.Add("prikaz", typeof(string));
            rezultat.Columns.Add("termin_id", typeof(int));
            int i = 0;
            while (i < svi_termini.Rows.Count)
            {
                bool dostupan = Convert.ToBoolean(svi_termini.Rows[i]["dostupnost"]);

                if (!dostupan)
                {
                    i++;
                    continue;
                }
                if (i + br > svi_termini.Rows.Count)
                    break;
                bool slobodni = true;
                for (int j = 0; j < br; j++)
                {
                    if (!Convert.ToBoolean(svi_termini.Rows[i + j]["dostupnost"]))
                    {
                        slobodni = false;
                        break;
                    }
                }
                if (slobodni)
                {
                    TimeSpan vreme = (TimeSpan)svi_termini.Rows[i]["termin"];
                    DataRow novi = rezultat.NewRow();
                    novi["prikaz"] = ((TimeSpan)svi_termini.Rows[i]["termin"]).ToString(@"hh\:mm");
                    novi["termin_id"] = svi_termini.Rows[i]["id"];
                    rezultat.Rows.Add(novi);
                    i += 2;
                }
                else
                {
                    i++;
                }
            }
            cmb_termin.DataSource = rezultat;
            cmb_termin.DisplayMember = "prikaz";
            cmb_termin.ValueMember = "termin_id";
            cmb_termin.SelectedValue = -1;
        }   
        public rezervacija()
        {
            InitializeComponent();
        }

        private void rezervacija_Load(object sender, EventArgs e)
        {
            cmb_frizer_populate();
            cmb_termin.Enabled= false;
            datum_picker.Enabled = false;
            cmb_usluga.Enabled = false;
            datum_picker.MinDate = DateTime.Today;


        }

        private void cmb_frizer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_frizer.IsHandleCreated && cmb_frizer.Focused)
            {
             

              
                    grid_cenovnik_populate();
                    cmb_usluga_populate();
                    cmb_termin.Enabled = false;
                    cmb_termin.DataSource = null;
                    datum_picker.Enabled = true;
                    cmb_usluga.Enabled= true;


            }
        }

        private void cmb_usluga_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_usluga.IsHandleCreated && cmb_usluga.Focused)
            {
                cmb_termin_populate();
                cmb_termin.Enabled = true;
            }
        }

        private void datum_picker_ValueChanged(object sender, EventArgs e)
        {
            cmb_termin_populate();
        }

        private void btn_rezervisi_Click(object sender, EventArgs e)
        {
            if (cmb_termin.SelectedValue == null) return;
            int br = broj_slotova(cmb_usluga.Text);
            int prvi_termin = Convert.ToInt32(cmb_termin.SelectedValue);

            SqlConnection veza = konekcija.Connect();

            
            SqlDataAdapter adapter = new SqlDataAdapter("select id from termini where admin_id = " + cmb_frizer.SelectedValue + "and datum =@datum and termin >= (select termin from termini where id = " + prvi_termin + ")ORDER BY termin", veza);
             adapter.SelectCommand.Parameters.AddWithValue("@datum", datum_picker.Value.Date);

            DataTable slotovi = new DataTable();
            adapter.Fill(slotovi);

           
            

            for (int j = 0; j < br; j++)
            {
                int slot_id = Convert.ToInt32(slotovi.Rows[j]["id"]);
                string naredba = ("update termini set dostupnost = 0, usluga = '" + cmb_usluga.Text +"', klijent_id = " + Program.user_id +" where id = " + slot_id);
                SqlCommand komanda = new SqlCommand(naredba.ToString(),veza);
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }

            MessageBox.Show("Termin uspešno rezervisan!");
            cmb_termin_populate(); 
        }

        private void btn_nazad_Click(object sender, EventArgs e)
        {
            glavna frm_glavna = new glavna();
            frm_glavna.Show();
            this.Hide();
        }

        private void rezervacija_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    
}
