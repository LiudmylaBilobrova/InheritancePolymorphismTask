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

            //this.subjectsList = new Dictionary<string, int>();
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


        public Dictionary<string, int> subjectsList;

        /*public Dictionary<string, int> SubjectsList
        {
            get
            {
                return subjectsList;
            }
        }
        */

        /*public void AddToSubjects(string subjectName, int studentMark)
        {
            subjectsList.Add(subjectName, studentMark);
        }*/

        public void PrintSubjects()
        {
            Console.WriteLine("Subjects and marks of the student:");
            foreach (var item in subjectsList)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
                Console.ReadKey();
            }
        }

        public double AvgMarks()
        {
            return subjectsList.Average(t => t.Value);
        }

        public void ReturnAvgMarks()
        {
            Console.WriteLine($"Average mark of subjects: {AvgMarks()}");
            Console.ReadKey();
        }


    }
}
