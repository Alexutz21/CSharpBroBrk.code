using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    class Arrays
    {
        private static void IntExample()
        {
            int[] luckNumber = { 2, 7, 17, 44, 28, 71 };
            //                  0  1   2   3   4   5        // we have 6 positions
            //              index position from array

            luckNumber[3] = 4;  //we can change the index position 3 to any number that we want.
            Console.WriteLine("Number from array [] luckNumber is " + luckNumber[2] + ".");
            Console.WriteLine("Number 44 from index 3 has changes to " + luckNumber[3] + ".");
        }
        private static void StringExample()
        {
            string[] friends = new string[3];
            friends[0] = "John";
            friends[1] = "Mike";
            friends[2] = "Frank";
            Console.WriteLine("My friend is " + friends[1] + ".");
        }
        private static void BrackeysArrayMovies()
        {
            string[] movies = { "Lord of the Rings", "Star Wars", "Harry Potter", "Pulp Fiction" };
            for (int i = 0; i < movies.Length ; i++)
            {
                int rank = i + 1;   //rank is used to write the number in front
                Console.WriteLine(rank + ". " + movies[i]);
            }
        }

        private static void BrackeysArrayMovies1()
        {
            string[] movies1 = new string[4];
            Console.WriteLine("Please enter your favorite movies.");
            for (int i = 0; i < movies1.Length; i++)
            {
                movies1[i] = Console.ReadLine();
            }

            //Console.WriteLine("You entered these movies as your favorites: " + movies1[0] + ", " + movies1[1] + ", " + movies1[2] + " and " + movies1[3]);
            
            Console.WriteLine("\nHere they are alphabetically: ");
            Array.Sort(movies1);
            
            for (int i = 0; i < movies1.Length; i++)
            {
                Console.WriteLine(movies1[i]);
            }
        }
        
         public static void RunExample()
        {
            //IntExample();
            //StringExample();
            //BrackeysArrayMovies();
            BrackeysArrayMovies1();
            

        }

    }
}
