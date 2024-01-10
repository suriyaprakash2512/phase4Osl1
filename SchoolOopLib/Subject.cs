using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOopLib
{
    public class Subject
    {
        private string _subname;

        public string Name
        {
            get { return _subname; }
            set { _subname = value; }
        }

        private string _subCode;

        public string SubCode
        {
            get { return _subCode; }
            set { _subCode = value; }
        }

        //public Subject(string n, string c)
        //{
        //	Name = n;
        //	SubCode = c;

        //}

        public bool Search(string s)
        {
            List<Subject> sublist = new List<Subject>();

            sublist.Add(new Subject { Name = "Maths", SubCode = "512b" });
            sublist.Add(new Subject { Name = "Science", SubCode = "513b" });
            sublist.Add(new Subject { Name = "English", SubCode = "514b" });



            var isfound = sublist.Find(d => d.Name == s);
            return isfound != null;
        }
    }
}
