using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolerWorks
{
    public class School
    {
        private List<Classes> classes;
        private List<Teacher> teachers;
        private string name;
        private string city;
        
        public School(string name, string city)
        {
            this.name = name;
            this.city = city;
            classes = new List<Classes>();
            teachers = new List<Teacher>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public List<Classes> Classes
        {
            get { return classes; }
        }

        public List<Teacher> Teachers
        {
            get { return teachers; }
        }

        public List<Student> Students
        {
            get
            {
                List<Student> s = new List<Student>();
                foreach(Classes c in classes)
                {
                    s.AddRange(c.Students);
                }
                return s;
            }
        }

        public int countClasses()
        {
            return classes.Count;
        }

        public int countStudents()
        {
            int sum = 0;
            foreach(Classes c in classes)
            {
                sum += c.Students.Count;
            }
            return sum;
        }

        public int countTeachers()
        {
            return teachers.Count;
        }

        public void addClass(Classes c)
        {
            classes.Add(c);
        }

        public void addTeacher(Teacher t)
        {
            teachers.Add(t);
        }
    }
}
