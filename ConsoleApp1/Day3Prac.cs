using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Coursedetails
    {
        int cid,fees;
        string cname;

        internal Coursedetails(int cid, int fees, string cname)
        {
            this.cid = cid;
            this.cname = cname;
            this.fees = fees;
        }

        static void DisplayCourse(int cid, int fees, string cname)
        {
            Console.WriteLine("Course id:{0} || coursename:{1} || course fees:{2}", cid, cname, fees);
        }

        internal void DisplayCoursedetails()
        {
            throw new NotImplementedException();
        }
    }
    class Day3Prac
    {
        static void Main()
        {
            Coursedetails[] course = new Coursedetails[3];
            int cid, fees;
            string cname;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter the values of courseid and fees and coursename");
                cid = Convert.ToInt32(Console.ReadLine());
                fees = Convert.ToInt32(Console.ReadLine());
                cname = Console.ReadLine();
                course[i] = new Coursedetails(cid, fees, cname);

            }
            for (int i = 0; i < 3; i++)
            {
                course[i].DisplayCoursedetails();
            }
            Console.Read();
        }
    }
}
