using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PersonClient
    {
        static void Main()
        {
            Class_ObjectsEg person = new Class_ObjectsEg();
            person.name = "Maddy";
            person.age = 22;
            person.DisplayPerson();
            Console.Read();
        }
    }
}
