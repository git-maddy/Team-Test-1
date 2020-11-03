using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Mobile
    {
        internal static string companyname; //class variable
        internal string Modelname; //object variable

        //non static method can access both static and non static information
        void DisplayModel()
        {
            Console.WriteLine("companyname:{0}||Modelname{1}", companyname, Modelname);
        }
        
        // Static method can access only static variables cant access not non static variable
        internal static void Getdata()
        {
            int isbn = 1900;
            Console.WriteLine("companyname:{0}||Modelname{1}", companyname /* Modelname*/);
        }
    }

    class StaticEg2
    {
        float f = 34.90f;
        internal static void Info()
        {
            Console.WriteLine("static method");
        }
        static void Main()
        {
            //error
            //f=f+f;
            int age, pincode;
            Mobile mobile = new Mobile();
            mobile.Modelname = "moto g4 plus";
            Mobile.companyname = "motorolla";
            Mobile.Getdata();
            //info method and static method in same class.class name is not required
            Info();
            Console.Read();
        }
    }
}
