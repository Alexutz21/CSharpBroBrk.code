using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    class ClassCalebCurry
    {
        public ClassCalebCurry()    // constructor
        {
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName +"-"+ LastName;
            }
        }

        public string GetFullName()
        {
            return FirstName +" "+ LastName;
        }

        public static void RunExample()
        {
            ClassCalebCurry Person1 = new ClassCalebCurry();
            Person1.FirstName = "Alexandru";
            Person1.LastName = "Lungu";
            Console.WriteLine(Person1.GetFullName());       // we use () because it it a method
            Console.WriteLine(Person1.FullName);     // we don't use () because it is a property
            Console.WriteLine();
        }
    }
}
