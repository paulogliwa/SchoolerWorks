using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolerWorks
{
    class SchoolFactory
    {
        private School s;
        private string path;

        public SchoolFactory(School s, string path)
        {
            this.s = s;
            this.path = path;

        }

        public SchoolFactory(string path)
        {
            this.path = path;
        }

        public School Open()
        {
            string[] linesS = File.ReadAllLines(path + "/school.sfw");
            string[] linesC = File.ReadAllLines(path + "/classes.sfw");
            string[] linesSt = File.ReadAllLines(path + "/students.sfw");
            string[] linesCo = File.ReadAllLines(path + "/dzienniczek.sfw");
            string[] x;

            
            foreach (string str in linesS)
            {
                x = str.Split(';');
                s = new School(x[0], x[1]);
            }
            foreach (string str in linesC)
            {
                x = str.Split(';');
                s.addClass(new Classes(int.Parse(x[0]),x[1],x[2]));
            }
            foreach (string str in linesSt)
            {
                x = str.Split(';');

                Classes theone = null;
                foreach (Classes c in s.Classes)
                {
                    if ((c.Year + c.Type) == x[0])
                        theone = c;
                }

                theone.addStudent(new Student(x[1],x[2],new Date(x[3])));
            }
            string[] i;
            foreach (string str in linesCo)
            {
                x = str.Split(';');
                Student theone = null;
                foreach (Classes c in s.Classes)
                {
                    foreach(Student sg in c.Students)
                    {
                        if((sg.Name+sg.Surname) == x[0])
                        {
                            theone = sg;
                        }
                    }
                }
                i = x[2].Split(',');
                foreach(string grade in i)
                {
                    Courses co;
                    Enum.TryParse(x[1], out co);
                    theone.addMark(co,int.Parse(grade));
                }
            }

            return s;
        }

        public bool Save()
        {
            var dir = new DirectoryInfo(path + "/" + s.Name);
            if(dir.Exists)
                dir.Delete(true);
            dir.Create();

            StreamWriter sw;
            sw = File.AppendText(dir.FullName + "/school.sfw");
            sw.WriteLine(s.Name+";"+s.City);
            sw.Close();

            StreamWriter swC = File.AppendText(dir.FullName + "/classes.sfw");
            StreamWriter swS = File.AppendText(dir.FullName + "/students.sfw");
            StreamWriter swD = File.AppendText(dir.FullName + "/dzienniczek.sfw");
            foreach (Classes c in s.Classes)
            {
                swC.WriteLine(c.Year+";"+c.Type+";"+c.Profile);
                foreach (Student s in c.Students)
                {
                    swS.WriteLine(c.Year + c.Type + ";" + s.Name + ";" + s.Surname + ";" + s.DOB.ToString());
                    foreach(Courses co in s.Dziennicz.Courses.Keys)
                    {
                        swD.WriteLine(s.Name+s.Surname+";"+co.ToString()+";"+s.Dziennicz.courseGradesAsString(co));
                    }
                }
            }
            swC.Close();
            swS.Close();
            swD.Close();

            return true;
        }
    }
}
