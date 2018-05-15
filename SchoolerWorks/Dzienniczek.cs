using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolerWorks
{
    public class Dzienniczek
    {
        private Dictionary<Courses, List<int>> courses;

        public Dzienniczek()
        {
            courses = new Dictionary<Courses, List<int>>();
            foreach(Courses c in Enum.GetValues(typeof(Courses))) {
                courses.Add(c,new List<int>());
            }
        }

        public Dictionary<Courses, List<int>> Courses
        {
            get { return courses; }
            set { courses = value; }
        }

        public string courseGradesAsString(Courses c)
        {
            string s = "";
            if(courses[c].Count > 0)
            {
                foreach (int i in courses[c])
                {
                    s += i.ToString() + ",";
                }
                s = s.Remove(s.Length - 1);
            }
            return s;
        }

        public double courseAvg(Courses c)
        {
            int sum = 0;
            foreach (int i in courses[c])
            {
                sum += i;
            }
            
            return Math.Round((double)sum / courses[c].Count, 2);
        }

        public double avg()
        {
            double sum = 0;
            foreach(Courses c in courses.Keys)
            {
                sum += courseAvg(c);
            }
            
            return Math.Round(sum / courses.Keys.Count, 2);
        }

        public int fails()
        {
            int sum = 0;
            foreach (Courses c in courses.Keys)
            {
                if (courseAvg(c) < 2.0)
                    sum++;
            }
            return sum;
        }

        public void addMark(Courses c, int mark)
        {
            courses[c].Add(mark);
        }

        public void removeMark(Courses c, int mark)
        {
            courses[c].Remove(mark);
        }
    }
}
