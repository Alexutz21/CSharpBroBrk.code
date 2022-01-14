using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    public class ReturnKeyword
    {
        // Return = returns data back to the place where a method is invoked
        public static double Example(double x, double y)
        {
            double z = x * y;
            return z;
        }
        //public static double RunExample( double x, double y)
        //{
        //    Example( z);
        //}
    }
}
