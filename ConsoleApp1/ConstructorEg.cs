using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
        class Pen
        {
            public string brand;
            internal string color;
            //constructor--special method,by default private
            //initialize the value for the variables
            internal Pen(string b, string color)
            {
                brand = b;
                //refers to current class instance--->pen
                this.color = color;
            }
            internal void DisplayPen()
            {
                Console.WriteLine("brand:{0}|| color:{1}", brand, color);
            }
        }

        class ConstructorEg
        {
            static void Main()
            {
                Pen pen = new Pen("parker", "blue");
                //constructor
                /*pen.brand="parker";
                 * pen.color="blue";*/
                pen.DisplayPen();
                Console.Read();
            }
        }
}
