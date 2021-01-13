using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismTask
{
    class Teacher: Person
    {
        public override void Breath()
        {
            Console.WriteLine("Teacher is breathing");
            Console.ReadKey();
        }
    }
}
