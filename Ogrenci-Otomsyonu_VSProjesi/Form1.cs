using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Form studentForm = new Student_Form();
            studentForm.Show();
            DatabaseManager.connectDB();
        }
    }
}
