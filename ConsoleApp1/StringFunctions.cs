using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    class StringFunctions
    {
        public static void Example()
        {
            string first_name = "Bro";
            string last_name = "Code";
            string full_name = first_name + " " + last_name;
            Console.WriteLine(full_name);
            
        }
        public static void Example1()
        {
            string name = "ALEX";
            string new_name = name.ToLower();   //convert to lower case letter
            Console.WriteLine(new_name);
            bool answare = name.StartsWith("A");    //check if it starts with 
            bool answare1 = name.EndsWith("X");     //check if it ends with
            bool answare2 = name.Contains("aex");   //check if contains 
            Console.WriteLine(answare);
            Console.WriteLine(answare1);
            Console.WriteLine(answare1);

        }
        public static void Example2 ()
        {
            string number = "123-456-789";
            string new_number = number.Replace("-", "/"); //replace - with / in string number
            Console.WriteLine(new_number);

            string userName = "Bromico";
            // string new_userName = userName.Insert(0,"$",2,"@");   //don't work
        }
        public static void RunExample()
        {
            //Example();
            //Example1();
            Example2();
            Console.ReadLine();
        }
        
    }
}
