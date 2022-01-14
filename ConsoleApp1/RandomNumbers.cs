using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    class RandomNumbers
    {
        private static void ExampleRandom()
        {
            Random number = new Random();
            int answare = number.Next(1,7); //1 in included but 7 is exclusive and it won't be printed
            int answare1 = number.Next(20) + 1; //this will generate a number between 1 and 20
            Console.WriteLine("You rolled: " +answare+"\nYou rolled: " + answare1);
        }
        private static void ExampleRandom1()
        {
            while (true)
            {
                char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',

                    'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z'};

                Random letter = new Random();
                int answare1 = letter.Next(0, 24);
                int answare2 = letter.Next(0, 24);
                int answare3 = letter.Next(0, 24);
                int answare4 = letter.Next(0, 24);
                int answare5 = letter.Next(0, 24);
                int answare6 = letter.Next(0, 24);

                Console.Write(letters[answare1] + "" + letters[answare2] + "" 

                    + letters[answare3] + "" + letters[answare4] + "" 

                    + letters[answare5] + "" + letters[answare6]);

                Console.ReadKey();
            }
            
        }
        public static void RunExample()
        {
            //ExampleRandom();
            ExampleRandom1();
        }
        
    }
}
