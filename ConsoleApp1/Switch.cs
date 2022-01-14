using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    class Switch
    {
        public static void Example()
        {
            Console.WriteLine("What day is today ?!");
            while (true)    // while true keep executing
            {
                Console.Write("Today is: ");
                string day = Convert.ToString(Console.ReadLine());
                switch(day)
                {
                    case "monday":
                        Console.WriteLine("Today is monday :(\n");
                        break;
                    case "tuesday":
                        Console.WriteLine("Today is tuesday :(\n");
                        break;
                    case "wednesday":
                        Console.WriteLine("It's wednesday :|\n");
                        break;
                    case "thursday":
                        Console.WriteLine("Today is thursday ... almost weekend ;)\n");
                        break;
                    case "friday":
                        Console.WriteLine("It's friday !!! :)\n");
                        break;
                    case "saturday":
                        Console.WriteLine("Saturday Bro !!!\n");
                        break;
                    case "sunday":
                        Console.WriteLine("Today is sunday chill & relax!\n");
                        break;
                    default:
                        Console.WriteLine("Not a regular day");
                        break;
                }
            }
            Console.ReadLine();
        }
        public static void Example1()
        {
            while (true)
            {
                Console.Write("Enter a number for day: ");
                int day = Convert.ToInt32(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Number " + day + " means Monday. :(");
                        break;
                    case 2:
                        Console.WriteLine("Number " + day + " means Tuesday. :(");
                        break;
                    case 3:
                        Console.WriteLine("Number " + day + " means Wednesday. :|");
                        break;
                    case 4:
                        Console.WriteLine("Number " + day + " means Thursday. :O");
                        break;
                    case 5:
                        Console.WriteLine("Number " + day + " means Friday. :)");
                        break;
                    case 6:
                        Console.WriteLine("Number " + day + " means Saturday ... chill");
                        break;
                    case 7:
                        Console.WriteLine("Number " + day + " means Sunday ... chill & relax");
                        break;
                    default:
                        Console.WriteLine("Number " + day + " is not a week day...\nPlease enter a number from 1 to 7 please.");
                        break;
            }   
            }
            Console.ReadLine();
        }
        
        public static void RunExample()
        {
            //Example();
            Example1();
            
        }
    }
}
