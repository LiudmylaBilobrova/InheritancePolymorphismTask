using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismTask
{
    public class Student : Person
    {

        public override void Breath()
        {
            Console.WriteLine("Student is breathing");
        }

        public void Study()
        {
            Console.WriteLine("Student studies");
        }


        public Dictionary<string, int> subjects;


        public void PrintSubjects()
        {
            Console.WriteLine("Subjects and marks of the student:");
            foreach (var item in subjects)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }

        private double AvgMarks()
        {
            return subjects.Average(t => t.Value);
        }

        public void PrintAvgMarks()
        {
            Console.WriteLine($"Average mark of subjects: {AvgMarks()}");
        }

    }
}
