using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    class For
    {
        public static void Example()
        {
            Console.Write("How many cool number do you want to Power of 2: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }
        }

        public static void Example2()
        {
            Console.Write("Eneter a number to count: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= count ; i++)
            {
                Console.WriteLine(i);
            }
        }
        private static void ForEachExample()
        {
            // Foreach loop = a simple way to iterate over a array, but it's less flexible

            string[] cars = { "Mercedes", "Bentley", "RollsRoys" };

            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }

        public static void RunExample()
        {
            //Example();
            //Example2();
            ForEachExample();
        }
    }
}
