using NUnit.Framework;
using SchoolOopLib;


namespace UnitTestProject1
{
    [TestFixture]
    public class SchoolDataTests
    {
       
        Student s = new Student();

        Subject sub = new Subject();

        Teacher ts = new Teacher();

        [TestCase("Sathish", ExpectedResult = true)]
        [TestCase("Abdul", ExpectedResult = false)]
        [TestCase("ganga", ExpectedResult = false)]
        [TestCase("Sri", ExpectedResult = true)]
        [TestCase("guna", ExpectedResult = false)]
        public bool IsName(string search)
        {

            return s.Search(search);

        }

        [TestCase("Maths", ExpectedResult = true)]
        [TestCase("Science", ExpectedResult = true)]
        [TestCase("Biology", ExpectedResult = false)]
        [TestCase("English", ExpectedResult = true)]
        public bool IsSubject(string subj)
        {

            return sub.Search(subj);

        }

        [TestCase("Ram", ExpectedResult = true)]
        [TestCase("Arun", ExpectedResult = true)]
        [TestCase("Venkat", ExpectedResult = true)]
        [TestCase("malaiyan", ExpectedResult = false)]
        public bool IsTeacher(string t)
        {

            return ts.Search(t);

        }

    }
}
