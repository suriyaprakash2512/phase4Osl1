using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOopLib
{
    public class Teacher
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private string _subject;

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        //public Teacher(string name, string subject)
        //{
        //	Name = name;
        //	Subject = subject;
        //}

        public bool Search(string s)
        {
            List<Teacher> teachlist = new List<Teacher>();

            teachlist.Add(new Teacher { Name = "Arun", Subject = "Maths" });
            teachlist.Add(new Teacher { Name = "Ram", Subject = "English" });
            teachlist.Add(new Teacher { Name = "Venkat", Subject = "Science" });

            var isfound = teachlist.Find(d => d.Name == s);
            return isfound != null;
        }
    }
}
