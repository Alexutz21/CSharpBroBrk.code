using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    class Variable
    {
        public static void Example()
        {
            int number = 7;
            string name = "Numarul";
            bool availability = true;
            const char letter = 'O';    //const we can't change the value of constant
            Console.WriteLine(number + " " + name + " " + availability + " " + letter);

            name = "Nr"; //we change the value of string number but we do not have to
            //write the variable type because C# already knows that this is a string
            //and we write only the variable name (name)
        }
        public static void Example1()
        {
            string litera1 = "AR";
            int numar = 30;
            string numar2 = "ZZI";
            Console.WriteLine(litera1 + " " + numar + " " + numar2);

        }
        public static void VariableRunExample()
        {
            //Example();    //comentam deoarece nu dorim sa afisam
            Example1();
        }
    }

}
