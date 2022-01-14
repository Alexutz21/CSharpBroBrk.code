using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    class IfElse
    {
        static void MiniConversatie()
        {
            string senzatie, name, detalii;

            Console.Write("Care este numele tau : ");
            name = Console.ReadLine();
            Console.WriteLine("Buna " + name + ".\nCum te simti astazi ?!");

            senzatie = Console.ReadLine();
            if (senzatie == "bine")
            {
                Console.WriteLine("Ma bucur sa aud ca esti " + senzatie);
            }
            else if (senzatie == "nu bine")
            {
                Console.WriteLine("Nu ma bucur sa aud ca " + senzatie);
            }
            else if (senzatie != "bine" || senzatie != "nu bine")
            {
                Console.WriteLine("Te rog da-mi mai multe detalii, nu inteleg ce inseamna " + senzatie + ".");
            }
            detalii = Console.ReadLine();
            Console.WriteLine("Te ascult.\nContinua.");
        }


        public static void Example1()
        {
            while (true)
            {
                Console.Write("Please enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age <= 18 && age >= 2)
                {
                    Console.WriteLine("You are still a junior.");
                }
                else if (age >= 18 && age <= 55)
                {
                    Console.WriteLine("You are an adult.");
                }
                else if (age >= 56)
                {
                    Console.WriteLine("You are old, but not too old.");
                }
                else if (age == 1)
                {
                    Console.WriteLine("You are a newborn <3.");
                }
                else if (age <= 0)
                {
                    Console.WriteLine("Your age can't be negative.");
                }
            }
        }
        public static void Example2()
        {
            while (true)
            {
                Console.Write("Please enter your name: ");
                string name = Console.ReadLine();
                if (String.IsNullOrEmpty(name))     // or we can use ! (not) operator to invert things
                {
                    Console.WriteLine("You din not enter your name.");
                }
                else if (name.Length == 2)
                {
                    Console.WriteLine("This is not a name. \nYour name is too short!");
                }
                else
                {
                    Console.WriteLine("Hello " + name + ", nice to meet you!");
                }
            }

        }
        public static void Example3Ticket()
        {
            Console.WriteLine("Welcome! Tickets are 5$. Please insert cash!");
            int cash = Convert.ToInt32(Console.ReadLine());
            if (cash < 5)
            {
                Console.WriteLine("That's not enough money");
            } else if (cash == 5)
            {
                Console.WriteLine("Here is you ticket");
            }
            else
            {
                int change = cash - 5;
                Console.WriteLine("Here is your ticket and " + change + " dollars in change.");
            }
        }
        public static void ExampleFunPark()
        {
            int age;
            int height;

            Console.Write("Please input your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please input your height (cm): ");
            height = Convert.ToInt32(Console.ReadLine());

            if( age <= 17 && height <= 149)
            {
                Console.WriteLine("We are sorry but you are not allowed.");
            }else if( age >= 18 && height >= 150)
            {
                Console.WriteLine("Have fun!");
            }
        }

        public static void LogicOperator()
        {
            Console.WriteLine("Temperature outside.");
            while (true)
            {
                Console.Write("Please enter the temperature: ");
                int temp = Convert.ToInt32(Console.ReadLine());

                if (temp > 30 && temp <= 54)
                {
                    Console.WriteLine("Australian temperature!");
                }
                else if (temp <= 30 && temp >= 20)
                {
                    Console.WriteLine("It is hot outside");
                }
                else if (temp < 20 && temp >= 15)
                {
                    Console.WriteLine("It is ok outside");
                }
                else if (temp < 15 && temp >= 1)
                {
                    Console.WriteLine("It is cold outside");
                }
                else if (temp <= 0 && temp >= -55) 
                {
                    Console.WriteLine("It's freezing time!");
                }
                else if(temp >= 55 || temp <= -55)
                {
                    Console.WriteLine("You are probably wrong!");
                }
            }
            
        }

        public static void RunExamples()
            {

            //MiniConversatie();

            //IfElseExample1();
            //IfElseExample2();
            //Example3Ticket();
            //ExampleFunPark();
            //LogicOperator();
        }
    }
}
