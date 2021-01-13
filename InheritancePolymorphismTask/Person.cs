using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismTask
{
    abstract class Person
    {
        public virtual void Breath()
        {
            Console.WriteLine("Person is breathing");
            Console.ReadKey();
        }
    }
}
