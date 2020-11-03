using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        string Name;
        int age;
        string degree;
        void Displaydetails()
        {
            Console.WriteLine("Name:{0}||Age:{1}||Degree:{2}", Name, age, degree);

        }
        static void Main()
        {
            Employee employee1 = new Employee();
            employee1.Name = "Mady";//Add one employee//
            employee1.age = 25;
            employee1.degree = "B.Tech";
            employee1.Displaydetails();//displays mani info
            Employee employee2 = new Employee();
            employee2.Name = "sasi";
            employee2.age = 25;
            employee2.degree = "law";
            employee2.Displaydetails();//displays sasi info
            Console.Read();

        }
    }
}
