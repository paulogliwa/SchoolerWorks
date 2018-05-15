using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolerWorks
{
    public class Student : Person
    {
        private Dzienniczek dzienniczek;

        public Student(string name, string surname, Date dob) : base(name, surname, dob)
        {
            dzienniczek = new Dzienniczek();
        }

        public Dictionary<Courses, List<int>> Marks
        {
            get { return dzienniczek.Courses; }
            set { dzienniczek.Courses = value; }
        }

        public Dzienniczek Dziennicz
        {
            get { return dzienniczek; }
        }

        public string courseGradesAsString(Courses c)
        {
            return c.ToString() + ":" + dzienniczek.courseGradesAsString(c);
        }

        public double courseAvg(Courses c)
        {
            return dzienniczek.courseAvg(c);
        }

        public double avg()
        {
            return dzienniczek.avg();
        }

        public int fails()
        {
            return dzienniczek.fails();
        }

        public void addMark(Courses c, int mark)
        {
            dzienniczek.addMark(c, mark);
        }

        public void removeMark(Courses c, int mark)
        {
            dzienniczek.removeMark(c, mark);
        }

        public override string ToString()
        {
            return Name + " " + Surname + ", " + DOB.ToString();
        }
    }
}
