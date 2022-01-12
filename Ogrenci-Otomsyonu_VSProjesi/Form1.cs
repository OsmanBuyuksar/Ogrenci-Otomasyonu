using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ogrenci_Otomsyonu_VSProjesi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void Login_Button_Click(object sender, EventArgs e)
        {
            MySqlConnection con = DatabaseManager.ConnectDB();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;
            cmd.Connection = con;


            char[] no = new char[Username_TextB.Text.Length - 1];
            Array.Copy(Username_TextB.Text.ToCharArray(), 1, no, 0, Username_TextB.Text.Length - 1);
            if(!(Password_TextB.Text == "Şifrenizi giriniz"  || Password_TextB.Text == "") && !(Username_TextB.Text == "Kullanıcı adını giriniz"  || Username_TextB.Text == ""))
            switch (Username_TextB.Text[0])
            {
                case 's':
                    Console.WriteLine("Select * from student where student_no = " + string.Join("", no) + " and student_password = " + Password_TextB.Text + ";");
                    cmd.CommandText = "Select * from student where student_no = " + string.Join("", no) + " and student_password = " + Password_TextB.Text + ";";
                    break;
                case 't':
                    cmd.CommandText = "Select * from teacher;";
                    Console.WriteLine("Öğretmen girişi");
                    break;
                case 'o':
                    cmd.CommandText = "Select * from officer;";
                    Console.WriteLine("Memur girişi");
                    break;
            }

            try
            {
                reader = cmd.ExecuteReader();
                reader.Read();

                if(!reader.HasRows)
                {
                    MessageBox.Show("Kullanıcı bulunamadı lütfen şifrenizi ve kullanıcı adınızı kontrol ediniz.");
                }
                else
                {
                    string[] s = new string[reader.FieldCount];
                    reader.Read();
                    for (int i = 0; i < reader.FieldCount; i++)
                        s[i] = reader.GetValue(i).ToString();

                    Student std = new Student(s[0], s[1], s[2], s[3], s[4], s[5]);

                    MessageBox.Show("Hoşgeldiniz");

                    Student_Form sf = new Student_Form(std);
                    sf.Show();
                }

            }
            catch(Exception error)
            {
                Console.WriteLine("Sql komutu çalıştırılırken hata:" + error.ToString());
            }
            finally{
                
            }

            
            
        }

        private void Username_TextB_MouseClick(object sender, MouseEventArgs e)
        {
            Username_TextB.Text = "";
        }

        private void Password_TextB_MouseClick(object sender, MouseEventArgs e)
        {
            Password_TextB.Text = "";
        }
    }
}
