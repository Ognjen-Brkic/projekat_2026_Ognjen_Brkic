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
        public rezervacija()
        {
            InitializeComponent();
        }

        private void rezervacija_Load(object sender, EventArgs e)
        {
            cmb_frizer_populate();
        }

        private void cmb_frizer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_frizer.IsHandleCreated && cmb_frizer.Focused)
            {
             

              
                    grid_cenovnik_populate();

                
                

            }
        }
    }
}
