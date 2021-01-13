using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismTask
{
    class Student : Person
    {
        public override void Breath()
        {
            Console.WriteLine("Student is breathing");
            Console.ReadKey();
        }
    }
}
