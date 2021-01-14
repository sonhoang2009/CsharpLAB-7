using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class StudentDetails
    {
        string _studName = "Alexander";
        int _studID = 30;
        public StudentDetails()
        {
            Console.WriteLine("Students Name : " + _studName);
            Console.WriteLine("Students ID : " + _studID);
        }
    }
}

namespace Examination
{
    class ScoreReport
    {
        public string Suject = "Science";
        public int Marks = 60;
        static void Main(string[] args)
        {
            Students.StudentDetails studentDetails = new Students.StudentDetails();
            ScoreReport objReport = new ScoreReport();
            Console.WriteLine("Subject : " + objReport.Suject);
            Console.WriteLine("MarkS : " + objReport.Marks);
            Console.ReadKey();
        }
    }
}
