using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Otomsyonu_VSProjesi
{
    public class Student : User
    {
        public String name;
        public String surName;
        public String department;
        public String year;

        public Student(string userName, string password, string name, string surName, string year, string department) : base(userName, password)
        {
            this.name = name;
            this.surName = surName;
            this.department = department;
            this.year = year;
        }
    }
}
