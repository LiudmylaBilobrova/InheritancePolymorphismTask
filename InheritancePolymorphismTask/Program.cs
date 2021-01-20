using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> subjects = new Dictionary<string, int>();
            subjects.Add("Physics", 95);
            subjects.Add("Analytic geometry", 86);
            subjects.Add("Linear algebra", 88);
            subjects.Add("Physical training", 61);
            subjects.Add("History", 76);

            Student student = new Student();

            Teacher teacher1 = new Teacher("Visiliy Petrovich", "Geography");


            student.subjects = subjects;

            student.Breath();
            teacher1.Breath();

            student.Study();

            student.PrintSubjects();

            student.PrintAvgMarks();

            teacher1.Explain();

            teacher1.Reverse();

            teacher1.Argue();
        }
    }
}
