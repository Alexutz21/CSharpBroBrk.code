using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    class UsefulFunctions
    {
        public static void Example()
        {            
            Console.WriteLine("#### Ceiling ####");
            Console.Write("Please insert a double with decimal number: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double answare = Math.Ceiling(x);
            Console.WriteLine("The Ceiling number of " + x + " is: " + answare);


            Console.WriteLine("#### Round up or down ####");
            Console.WriteLine("0.49 down or up 0.5");
            Console.Write("Please insert a double with decimal number: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double answare1 = Math.Round(x1); //Rounds down because is not over .50
            Console.WriteLine("the Round number of " + x1 + " is: " + answare1);
            

            Console.WriteLine("#### Round decimal ####");
            Console.Write("Please insert a number with al least 5/6 decimals: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Round number with how many decimals: ");
            int round;
            double answare2 = Math.Round(x2, round = Convert.ToInt32(Console.ReadLine())); //,2=25      ,3=257     ,5=25753
          //double answare2 = Math.Round(x2, 2)     ,2=25  ,3=257  ,5=25753 ...etc...
            Console.WriteLine("The Round number with decimal of " + x2 +" with " + round + " decimals " + " is: " + answare2);
            

            Console.WriteLine("#### Absolute ####");
            Console.Write("Please insert a negative number with a decimals to find the absolute of the number: ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            double answare3 = Math.Abs(x3); //returns the absolute value of x3  //inversul numarului
            Console.WriteLine("The Abs number of " + x3 + " is: " + answare3);
            

            Console.WriteLine("#### Power ####");
            Console.Write("Please insert a number: ");
            double x4 = Convert.ToDouble(Console.ReadLine());  //Pow = numar la puterea ...
            int power;
            Console.Write("At what power ");
            double answare4 = Math.Pow(x4, power =Convert.ToInt32(Console.ReadLine())); //return x to power 2 (la puterea ,4/,5 cat vrem noi dupa virgula)
            Console.WriteLine("The number " + x4 + " at power " + power + " is: " + answare4);

            Console.WriteLine("#### Max/Min value number ####");
            Console.WriteLine("Let's find the min and max value of two numbers.");
            Console.Write("Please insert a number: ");
            double x5 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please insert another number: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double answare5 = Math.Max(x5,y);
            Console.WriteLine("The Max(largest) numbers between " + x5 + " and " + y + " is: " + answare5);
            double answare6 = Math.Min(x5, y);
            Console.WriteLine("The Min(smallest) numbers between " + x5 + " and " + y + " is: " + answare6);

            Console.WriteLine("#### Square Number ####");
            Console.Write("Please insert a number: ");
            int x6 = Convert.ToInt32(Console.ReadLine());
            double answare7 = Math.Sqrt(x6);    //Square root (radacina patrata)
            Console.WriteLine("The Square root of number " + x6 + " is: " + answare7);

            Console.Write("Please insert a number to find out the square of it : ");    //ask for a number
            int squareNumber = Convert.ToInt32(Console.ReadLine());     //read our number
            double answare8 = Math.Sqrt(squareNumber);                  //formula for square number
            Console.WriteLine("The square root of number " + squareNumber + " is " + answare8);
            
            Console.WriteLine();

        }
        public static void RunExample()
        {
            Example();
        }
    }
}
