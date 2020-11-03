using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salary;

namespace CalDLLEg
{
    
    class Employee
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Addition:{0}", calculator.Addition(5, 6));
            Console.Read();
        }
    }
}
