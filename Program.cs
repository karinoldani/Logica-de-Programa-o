using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extremamente_Básico
{
    class Program
    {
        static void Main(string[] args)
        {
            string AT = Console.ReadLine();
            string BT = Console.ReadLine();

            int A = Convert.ToInt32(AT);
            int B = Convert.ToInt32(BT);

            int X = A + B;

            Console.WriteLine("X = " + X);
            Console.ReadKey();

        }
    }
}
