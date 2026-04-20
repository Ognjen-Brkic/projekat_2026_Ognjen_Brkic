using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekat_2026_Ognjen_Brkic
{
    internal static class Program

    {
        static public int user_id = -1;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SqlConnection veza = konekcija.Connect();
            SqlCommand komanda = new SqlCommand("exec generisanje_termina", veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            Application.Run(new Login());
        }
    }
}
