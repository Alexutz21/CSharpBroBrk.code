using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    class ArraysOfObjects
    {
        /*
         * this is a regular array
         * int [] myArray = new int[2];
         * myArray[0] = 5;
         * myArray[1] = 10;
         */

        public static void PeopleArrayModel()
        {
            Person[] peopleArray = new Person[4];
            peopleArray[0] = new Person("Bob", 22);
            peopleArray[1] = new Person("Jill", 28);
            peopleArray[2] = new Person("Sophie", 29);
            peopleArray[3] = new Person("Pamela", 33);

            for (int i = 0; i < peopleArray.Length; i++)
            {
                Console.WriteLine("Name: {0}, Age: {1}", peopleArray[i].Name, peopleArray[i].Age);
            }
        }
    }
}
