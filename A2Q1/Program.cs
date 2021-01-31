using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            double vectorA;
            double vectorB;
            double vectorAngle;
            double crossProduct;

            Console.WriteLine("Please enter the value of the first vector -");
            vectorA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the value of the second vector -");
            vectorB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the value of the angle between the two vectors -");
            vectorAngle = Convert.ToDouble(Console.ReadLine());

            crossProduct = vectorA * vectorB * Math.Sin(vectorAngle);  //based on the forumal a * b * Sin Omega

            Console.WriteLine("The cross product of the the two vectors is {0:F2}", crossProduct);
        }
    }
}
