using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class Area
    {
        public static double x { get; set; }
        public static double y { get; set; }
        public static double Calculate(double num1,double num2)
        {
            x = num1;
            y = num2;                
            return x * y;
        }
    }
}
