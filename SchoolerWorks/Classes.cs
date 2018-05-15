using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolerWorks
{
    public class Classes
    {
        private List<Student> students;
        private Teacher teacher;
        private int year;
        private string type;
        private string profile;

        public Classes(int year, string type, string profile)
        {
            this.year = year;
            this.type = type;
            this.profile = profile;
            this.teacher = null;
            students = new List<Student>();
        }

        public int Year {
            get { return year; }
            set { year = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Profile
        {
            get { return profile; }
            set { profile = value; }
        }

        public Teacher Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }

        public List<Student> Students
        {
            get { return students; }
        }

        public Double avg()
        {
            double sum = 0;
            foreach(Student s in students)
            {
                sum += s.avg();
            }
            return Math.Round(sum/students.Count,2);
        }

        public int failers()
        {
            int i = 0;
            foreach (Student s in students)
            {
                if (s.fails() > 0)
                    i++;
            }
            return i;
        }

        public Double avgLowest()
        {
            double avg = 6.0;
            foreach(Student s in students)
            {
                if (s.avg() <= avg)
                    avg = s.avg();
            }
            return Math.Round(avg, 2);
        }

        public Double avgHighest()
        {
            double avg = 0.0;
            foreach (Student s in students)
            {
                if (s.avg() >= avg)
                    avg = s.avg();
            }

            return Math.Round(avg, 2);
        }

        public override string ToString()
        {
            return year + type + " - " + profile;
        }

        public void addStudent(Student s)
        {
            students.Add(s);
        }

        public void removeStudent(Student s)
        {
            students.Remove(s);
        }
    }
}
