using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    class ExceptionHandling
    {
        private static void Example()
        {
            Console.Write("Please enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 / num2);
            Console.ReadLine();
        }
        public static void RunExample()
        {
            Example();
        }
    }
}
