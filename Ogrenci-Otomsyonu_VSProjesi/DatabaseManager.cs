using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ogrenci_Otomsyonu_VSProjesi
{
    class DatabaseManager
    {
        private static string server = "localhost";
        private static string username = "root";
        private static string password = "1234";
        private static string database = "ogrenci_sistemi";

        public static void connectDB()
        {
            //SqlConnection con = new SqlConnection("server" + server + "user id = " + username + ";");
            MySqlConnection con2;
            try
            {
                string connectionString = $"Server={server};Database={database};UID={username};PWD={password};";
                //connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database2.mdf;Integrated Security=True";
                con2 = new MySqlConnection(connectionString);
                con2.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return;
            }
        } 
    }
}
