using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolerWorks
{
    public class Teacher : Person
    {
        private Boolean taken;

        public Teacher(string name, string surname, Date dob) : base(name, surname, dob)
        {
            taken = false;
        }

        public Boolean Taken
        {
            get { return taken; }
            set { taken = value; }
        }

        public override string ToString()
        {
            return Name + " " + Surname + (taken ? " (zajety)" : " (wolny)");
        }
    }
}
