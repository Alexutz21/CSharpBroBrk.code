using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    class PassingObjectToFunction
    {
        private string name;
        private int age;

        public PassingObjectToFunction(string _name, int _age)
        {
            this.name = _name;
            this.age = _age;
        }
        public string Name  // property
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age  // property
        {
            get
            {
                return Age;
            }
            set
            {
                Age = value;
            }
        }

        public static void RunExample()
        {
            PassingObjectToFunction p1 = new PassingObjectToFunction("Jesse", 20);
            Console.WriteLine("Before :{0} {1}", p1.name, p1.age);
            ChangePerson(p1);
            Console.WriteLine("After :{0} {1}", p1.name, p1.age);

        }
        public static void ChangePerson(PassingObjectToFunction p1)
        {
            p1.name = "Jeff";
            p1.age = 50;
        }
    }
}
