using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    class NestedLoops
    {
        // Nested Loops is a loop insede another loop
        // Uses vary - Used a lot in sorting algorithms

        public static void Example1()
        {
            Console.Write("Enter a simbol to use: ");
            char symbol = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter the height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine("");
            }
        }
        private static void Example2()
        {
            Console.Write("Please enter a row: ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a column: ");
            int column = Convert.ToInt32(Console.ReadLine());

            Console.Write("Choose your symbol: ");
            string symbol = Console.ReadLine();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        public static void RunExample()
        {
            //Example1();
            Example2();
        }
    }
}
