using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    public class ConstructorOverloadedBroCode
    {
        public string bread;
        public string sauce;
        public string cheese;
        public string topping;

        public ConstructorOverloadedBroCode(string _bread, string _sauce, string _cheese, string _topping)
        {
            this.bread = _bread;
            this.sauce = _sauce;
            this.cheese = _cheese;
            this.topping = _topping;
            Console.WriteLine("Salami");
        }
        public ConstructorOverloadedBroCode(string _bread, string _sauce, string _cheese)
        {
            this.bread = _bread;
            this.sauce = _sauce;
            this.cheese = _cheese;
            Console.WriteLine("QuatroFromaggi");
        }
    }
}
