using MySql.Data.MySqlClient;
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
    public partial class Student_Form : Form
    {
        public Student student;
        public Student_Form(Student s)
        {
            student = s;
            InitializeComponent();

            StudentName_Label.Text = student.name;
            StudentSurname_Label.Text = student.surName;
            for(int i = 1; i<=Int32.Parse(student.year); i++)
                YearSelection_ListBox.Items.Add(i);
        }

        private void GradeList_Button_Click(object sender, EventArgs e)
        {
            MySqlConnection con2 = DatabaseManager.ConnectDB();
        }

        private void Grade_Tab_Click(object sender, EventArgs e)
        {

        }
    }
}
