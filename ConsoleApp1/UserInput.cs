using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    class UserInput
    {
        public static void Example()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "\nNice to meet you.");

            Console.WriteLine("What is your age ?");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("What is the temp outside (C) ?");
            double temp = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("What is your ocupation ?");
            string ocupation = Console.ReadLine();
            Console.WriteLine("I can se that you are a " + ocupation);
            Console.WriteLine("Let me tell you something...");
            Console.WriteLine("At " + age + " years is just good to be a " + ocupation + ".");
            
            Console.WriteLine("What mark of car do you like ?");
            string markCar = Console.ReadLine();
            Console.WriteLine("I can see that you like " + markCar);

            Console.WriteLine("Is all this information corect ? (True/False)");
            bool info = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("I'm happy that all the info is " + info + ".");
            
            while (true)
            {   
                Console.WriteLine("What is your dream location ?");
                string location = Console.ReadLine();
                if (location == "Australia")
                {
                    Console.WriteLine("May God help you go there\nAnd Live your life");
                }else if (location == "Canada")
                {
                    Console.WriteLine("You liked Canada once!");
                }
                else 
                {
                    Console.WriteLine("May God help you live your life\nBut keep in mind to travel a lot.");
                }
                Console.ReadLine();
            }
            

            
        }
        public static void RunExample()
        {
            Example();
        }
    }
}
