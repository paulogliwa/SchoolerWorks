using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolerWorks
{
    public class Person
    {
        private string name;
        private string surname;
        private Date dob;

        public Person(string name, string surname, Date dob)
        {
            this.name = name;
            this.surname = surname;
            this.dob = dob;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public Date DOB
        {
            get { return dob; }
            set { dob = value; }
        }
    }
}
