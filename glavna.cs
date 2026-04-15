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
     
        private void grid_populate()
        {
            SqlConnection veza = konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select klijenti.ime + ' ' + klijenti.prezime as klijent, recenzije.komentar, recenzije.broj_zvezdica from recenzije join klijenti on klijent_id=klijenti.id", veza);
            DataTable dt_recenzije = new DataTable();
            adapter.Fill(dt_recenzije);
            grid_recenzije.DataSource = dt_recenzije;
            grid_recenzije.ReadOnly = true;


        }

        private void glavna_Load(object sender, EventArgs e)
        {
            grid_populate();

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
    }
}
