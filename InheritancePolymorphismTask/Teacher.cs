using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismTask
{
    public class Teacher: Person
    {
        public string TeacherName { get; set; }

        public string SubjectName { get; set; }

        public Teacher(string teacherName, string subjectName = "Math")
        {
            this.TeacherName = teacherName;
            this.SubjectName = subjectName;
        }

        public override void Breath()
        {
            Console.WriteLine("Teacher is breathing");
        }


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
            Console.ReadLine();
        }

    }
}
