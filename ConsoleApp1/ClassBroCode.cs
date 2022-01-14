using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    public class ClassBroCode
    {
        // Class = A bundle of related code / Un pachet de coduri conexe
        //         Can be used as a blueprint to create objects (OOP)

            public static void Hello()
            {
                Console.WriteLine("Hello, welcome to the program.");
            }
            public static void Waiting()
            {
                Console.WriteLine("I am waiting for something");
            }
            public static void Bye()
            {
                Console.WriteLine("Bye! Thanks you for advice.");
            }

    }  
    public class Humans
    {
        // Objects = An instance of the class
        //           Objects can have fields and methods (characteristics & actions)

        public string name;             //fields
        public int age;                 //fields
        public char gender;             //fields

        public Humans(string _name, int _age, char _gender)     // Constructor
        {
            this.name = _name;
            this.age = _age;
            this.gender = _gender;
        }
        public void eat()               //method
        {
            Console.WriteLine(name + " is eating.");
        }
        public void sleep()            //method
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
    // Constructors = A special method in a class
    //                Same as the class name
    //                Can be used to assign arguments to fields when creating an object

    // Static = Modifier to declare a static member, whitch belongs to the class itself
    //          rather then to any specific object
}
