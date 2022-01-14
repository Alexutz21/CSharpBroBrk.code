using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    class While
    {
        public static void Example ()
            {
            string answare = null;

                while (answare != "q" && answare != "Q")
                {
                
                Console.WriteLine("You are playing The Game!");
                Console.Write("Press 'q' to quit: ");
                answare = Convert.ToString(Console.ReadLine());
                if (answare == "q" || answare == "Q")
                {
                    Console.WriteLine("You finished the game because you pressed q !");
                }
                }

            Console.ReadLine();
            }

        public static void Example1()
        {
            Random numberGen = new Random();
            int roll = 0;
            int attempts = 0;
            Console.WriteLine("Press Enter to roll the dice.");

            while (roll != 6)
            {
                Console.ReadKey();
                roll = numberGen.Next(1, 7);
                Console.WriteLine("You rolled "+ roll);
                attempts++;
            }
            Console.WriteLine("It took you " + attempts + " attempts to roll a six");
            
            //numberGen.Next(0, 4);
        }
        public static void BroExample()
        {
            int i = 10;
            while (i >= 0)
            {
                Console.WriteLine(i);
                i--;
            }
            Console.WriteLine("Like a For Loop.");
        }
      
        public static void RollThe2Dice()
        {
            Random numberGenerator = new Random();
            int roll1 = 0;
            int roll2 = 0;
            int attempt1 = 0;
            Console.WriteLine("Press a key to roll the dices!");

            while (roll1 != 6 || roll2 != 6)
            {
                Console.ReadKey();
                roll1 = numberGenerator.Next(1, 7);
                roll2 = numberGenerator.Next(1, 7);
                Console.WriteLine("First dice rolled "+ roll1);
                Console.WriteLine("Second dice rolled "+ roll2);
                attempt1++;
            }
            Console.WriteLine("It took you " + attempt1 + " attempts to roll the dice 6/6");
        }

        public static void InfiniteLoopExample()
        {
            while( 1 == 1)      //infinit loop
            {
                Console.WriteLine("This is a infinite loop!");
            }
        }
        public static string DoWhileLoopExample1()
        {
            string name = null;
                  do
                    {
                        Console.Write("Please enter a name: ");
                        name = Console.ReadLine();
                        
                    } while (name == "");
                Console.WriteLine("Please type something.");

            return name;
        }
        public static void DoWhileLoopExample2()
        { 
            
        }
            
        
        public static void RunExample()       //not working
        {
            //Example();
            //Example1();
            BroExample();
            //RollThe2Dice();
            //InfiniteLoopExample();
            //DoWhileLoopExample1();
            //DoWhileLoopExample2();
        }
    }
}
