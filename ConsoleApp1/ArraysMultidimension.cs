using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    class ArraysMultidimension
    {
        private static void SimpleArray()
        {
            string[] names = new string[4] { "Masina", "Motocicleta", "Bicicleta", "Trotineta" };
            Console.WriteLine("Cel mai mult imi place cu " + names[0]);
        }
        private static void RectangularArray1()     // bidimensional[rand, coloana]
        {
            string callHim;
            Console.WriteLine("How do we call him ?!");
            callHim = Convert.ToString(Console.ReadLine());
            var nameslist = new string[4, 2]    //4 => columns      2 => pieces of data of a column
            {
                {"Johnny", "Bravo" },   // 1st column   (primul rand)           2 pieces(2 coloane)
                {"Wolf", "Mozzart" },   // 2nd column   (al doilea rand)        2 pieces(2 coloane)
                {"Jack", "Sparrow" },   // 3rd column   (al treilea rand)       2 pieces(2 coloane)
                {"Toby", "Zorro" }      // 4th column   (al patralea rand)      2 pieces(2 coloane)
            };
            Console.WriteLine("We call him " + callHim +" "+ nameslist[2, 1]);  
        }
        private static void RectangularArray2()
        {
            var nameslist1 = new string[2, 2, 3]
            {
                {
                    {"Jack", "Sparrow" ,"The Pirate" },
                    {"Johnny", "Bravo", "Cartoon Hero" }
                },
                {
                    {"Toby", "Elfy", "The Elf" },
                    {"Robin", "Robinson", "Teen Titans" }

                }
            };
            Console.WriteLine( nameslist1[1,1,2]);
        }
        private static void JaggedArray()   //Array Zimtat
        {
            var nameslist2 = new int[4][];
            nameslist2[0] = new int[2]; // in first array we will have [2] pieces of data
            nameslist2[1] = new int[3]; // in second array we will have [3] pieces of data
            nameslist2[2] = new int[2]; // in third array we will have [2] pieces of data
            nameslist2[3] = new int[4]; // in forth array we will have [4] pieces of data

            //first array
            nameslist2[0][0] = 7;
            nameslist2[0][1] = 3;
            //second array
            nameslist2[1][0] = 5;
            nameslist2[1][1] = 7;
            nameslist2[1][2] = 11;
            //third array
            nameslist2[2][0] = 2;
            nameslist2[2][1] = 9;
            //forth array
            nameslist2[3][0] = 5;
            nameslist2[3][1] = 3;
            nameslist2[3][2] = 21; 
            nameslist2[3][3] = 8;

            Console.WriteLine("Jagged Array " + nameslist2[1][1]);
            

        }

        public static void RunExample()
        {
            //SimpleArray();
            //RectangularArray1();
            //RectangularArray2();
            JaggedArray();
        }

    }

}
