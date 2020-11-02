using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectsEg
{
    class CourseDetails
    {
        int cid;
        string cname;
        internal static  string institution;

        internal CourseDetails(int cid, string cname)
        {
            this.cid = cid;
            this.cname = cname;
        }
        internal void display()
        {
            Console.WriteLine("courseid is {0}||coursename is {1}|| institution{2}", cid, cname,institution);
        }
        static int collegeid = 2334;
        internal static int Displaycollegeid()
        {
            return collegeid;
        }

    }
    class Day3practice
    {
        static void Main()
        {
            Console.WriteLine("enter institution name");
            CourseDetails.institution = Console.ReadLine();
            Console.WriteLine("how many no of courses u wnat to enter");
            int size = Convert.ToInt32(Console.ReadLine());
            CourseDetails[] cousedetails = new CourseDetails[size];

            for (int i = 0; i < cousedetails.Length; i++)
            {
                Console.WriteLine("enter courseid and coursename");
                int courseid = Convert.ToInt32(Console.ReadLine());
                string coursename = Console.ReadLine();
                cousedetails[i] = new CourseDetails(courseid, coursename);
            }

            for (int i = 0; i < cousedetails.Length; i++)
            {
                cousedetails[i].display();
            }
            Console.WriteLine("collegeid :", CourseDetails.Displaycollegeid());
            Console.WriteLine("rough line for the purpose of jenkins")
            Console.Read();
        }
    }
}
