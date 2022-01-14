using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    public class List
    {
        public static void ExampleStrings()
        {
            var names = new List<string> { "Bill", "Kendra", "Jimmy", "Mike", "Julia" };

            names.Add ("Jill");     //add
            names.Add("Vanessa");   //add
            names.Remove("Jimmy");  //remove

            //Find the Index
            var index = names.IndexOf("Vanessa");
            Console.WriteLine($"Found {names[index]} at index {index}");

            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IdexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is a index {index}");
            }

            //Sort
            names.Sort();   // sort alphabetically 
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        public static void ExampleInt()
        {
            var fibonacciNumbers = new List<int> { 1, 1};

            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(previous+previous2);
            foreach (var item in fibonacciNumbers)
                  Console.WriteLine(item);
            
        }

        private static void Challenge()
        {
            var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }

            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);

        }

        public static void RunExample()
        {
            //ExampleStrings();
            //ExampleInt();
            Challenge();
        }
    }
}
