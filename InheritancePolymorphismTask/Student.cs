using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismTask
{
    public class Student : Person
    {
        public Student()
        {

            this.subjectsList = new Dictionary<string, int>();
        }

        public override void Breath()
        {
            Console.WriteLine("Student is breathing");
            //Console.ReadKey();
        }

        public void Study()
        {
            Console.WriteLine("Student studies");
            //Console.ReadKey();
        }

        public void Subjects()
        {
            Dictionary<string, int> subjects = new Dictionary<string, int>();
            subjects.Add("Physics", 95);
            subjects.Add("Analytic geometry", 86);
            subjects.Add("Linear algebra", 88);
            subjects.Add("Physical training", 61);
            subjects.Add("History", 76);

        }

        private readonly Dictionary<string, int> subjectsList;

        public Dictionary<string, int> SubjectsList
        {
            get
            {
                return subjectsList;
            }
        }

        public void PrintSubjects()
        {
            Console.WriteLine("Subjects and marks of the student:");
            foreach (var item in subjectsList)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
            Console.ReadKey();

        }

    }
}
