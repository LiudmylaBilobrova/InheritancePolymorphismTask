using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismTask
{
    public class Teacher: Person
    {
        public override void Breath()
        {
            Console.WriteLine("Teacher is breathing");
        }

        public Teacher()
        {
            SubjectName = "Math";
        }

        public string SubjectName { get; set; }


        public void Explain()
        {
            Console.WriteLine($"Teacher explains: {SubjectName}");
        }

        public void Reverse()
        {
            Console.WriteLine(string.Concat(SubjectName.Reverse()));
        }

        public void Argue()
        {
            Console.WriteLine(SubjectName.ToUpper());
        }

    }
}
