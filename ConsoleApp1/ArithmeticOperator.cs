using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    class ArithmeticOperator
    {
        public static void Example()
        {
            int x = 10;
            int y = 3;
            int x1 = 0;
            x1 = x1 + 2;    //Console.Write(x1);  = 2
            x1++;           ////Console.Write(x1);  = 2
            x1 += 2;    //Console.Write(x1);  = 2
            x1 -= 2;    //Console.Write(x1);  = -2

            double z = (double)x / y;
            int z1 = x % y;             //modulus

            Console.WriteLine(z);
            Console.WriteLine(z1);

            Console.ReadLine();
        }
        public static void RunExample()
        {
            Example();
            
        }




            
        
        
    }
}
