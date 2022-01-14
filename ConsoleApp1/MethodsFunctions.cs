using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    class MethodsFunctions  // Method or Function is the same thing in C#
    {
        static void SayHi(string name, int age) //we pass string and int but we have to specify in ()
        {
            Console.WriteLine("Hello " + name + " you have " + age + " years.");
        }

        public static int Multiply(int x, int y)
        {
            int answare = x * y;
            return answare;
        }

        //      #### Methods Overloading ####
        // Methods with same name but with diferent parameters
        //         name + paramethers = signature
        // Methods must have unique signature !!!

        public static int MethodOverloaded(int x, int y)
        {
            int answare = x * y;
            return answare;
        }
        public static int MethodOverloaded(int x, int y, int z)
        {
            int answare = x * y * z;
            return answare;
        }
        public static int MethodOverloaded(int x, int y, int z, int w)
        {
            int answare = x * y * z * w;
            return answare;
        }





        public static void MultiplySameName(int x, int y)
        {
            int answare = x * y;
            Console.WriteLine("Your answare is an int: " + answare);
        }

        public static void MultiplySameName(double a, double b, double c)
        {
            double answare = a * b * c;
            Console.WriteLine("Your answare is a double: " + answare);
        }

        public static void Greeting(string name)
        {
            Console.WriteLine("Hello, what's going on everybody, it's your " + name + " here." );
        }
        
        public static void Greeting2(string name, int number)
        {
            Console.WriteLine("Hello, what's going on everybody, it's your " + name + " here, who have " + number + " years.");
        }

        public static void InputName()
        {
            while (true)
	        {
                Console.Write("Please enter a name: ");
                string name = Console.ReadLine();
                Console.WriteLine("You entered " + name);
                Console.WriteLine("Is this correct ?!");
                string Bool = Console.ReadLine();
                if (Bool == "yes")
                {
                    Console.WriteLine("Is correct");
                }
                else if (Bool != "yes")
                {
                    Console.WriteLine("Please try again");
                }
	        }
            
        }


        public static void AddNumbers()
        {
            Console.WriteLine("Addition of two numbers.");
                Console.Write("Please type first number from 1 to 10: ");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x < 0 || x > 10)
                {
                    Console.WriteLine("You entered a bigger number, try again");
                while (x < 0 || x > 10)
                {
                    Console.Write("Please type a number from 1 to 10: ");
                     x = Convert.ToInt32(Console.ReadLine());
                }
            }
       
            Console.Write("Please type the second number also from 1 to 10: ");
            int y = Convert.ToInt32(Console.ReadLine());
            if(y < 0 || y > 10)
            {
                Console.WriteLine("You did it again, too big number again. Please retry.");
                while ( y < 0 || y > 10)
                {
                    Console.Write("Please type a number from 1 to 10: ");
                    y = Convert.ToInt32(Console.ReadLine());
                }
            }
            int result = x + y;
            Console.WriteLine("The addition of number " + x + " with " + y + " is " + result + ".");
        }

        string name = "Alex";
        int age = 37;
        public static void singHappyBirthday(string name, int age)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear "+ name +"!");
            Console.WriteLine("You are " + age+ "years!");
            Console.WriteLine("Happy birthday to you!");
        }
        public static void RunExample()
        {
            //SayHi("Alex", 36);      //we give our method SayHi string name and int age 
            //SayHi("Edi", 9);        //to be printed in the primary function Main
            //SayHi("Bianca", 34);

            //int result = Multiply(3, 7);
            //Console.WriteLine(result);
            //if(result % 2 == 0)
            //{
            //    Console.WriteLine(result + " is a even number");
            //}   //check to see if is an even number
            //else
            //{
            //    Console.WriteLine(result + " is a uneven number");
            //}                 //check to see if is an uneven number

            //MultiplySameName(2.7, 2.4, 6 );  //we enter here arguments

            /*
            Console.WriteLine("Please enter two numbers to multiply.");
            Console.Write("First ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second ");
            int y = Convert.ToInt32(Console.ReadLine());
            MultiplySameName(x, y);
            */

            //Console.Write("Please enter a name: ");
            //string name = Console.ReadLine();
            //Greeting(name);

            //Console.WriteLine("Enter your name and age:");
            //string name = Console.ReadLine();
            //int age = Convert.ToInt32(Console.ReadLine());
            //Greeting2(name, age);

            //InputName();

            //AddNumbers();

            

        }
    }
}
