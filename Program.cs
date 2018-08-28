﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Área
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            a = a.Replace(",", "");
            a = a.Replace(".", ",");
            double A = Convert.ToDouble(a);

            string b = Console.ReadLine();
            b = b.Replace(",", "");
            b = b.Replace(".", ",");
            double B = Convert.ToDouble(b);

            string c = Console.ReadLine();
            c = c.Replace(",", "");
            c = c.Replace(".", ",");
            double C = Convert.ToDouble(c);

            double tri = (A * C) / 2;
            double cir = (C * C) * 3.14159;
            double tra = ((A + B) * C) / 2;
            double qua = B * B;
            double ret = A * B;


            string triangulo = Convert.ToDouble(tri).ToString("0.000");
            string circulo = Convert.ToDouble(cir).ToString("0.000");
            string trapezio = Convert.ToDouble(tra).ToString("0.000");
            string quadrado = Convert.ToDouble(qua).ToString("0.000");
            string retangulo = Convert.ToDouble(ret).ToString("0.000");

            triangulo = triangulo.Replace(".", "");
            triangulo = triangulo.Replace(",", ".");

            circulo = circulo.Replace(".", "");
            circulo = circulo.Replace(",", ".");

            trapezio = trapezio.Replace(".", "");
            trapezio = trapezio.Replace(",", ".");

            quadrado = quadrado.Replace(".", "");
            quadrado = quadrado.Replace(",", ".");

            retangulo = retangulo.Replace(".", "");
            retangulo = retangulo.Replace(",", ".");

            Console.WriteLine("TRIANGULO: " + triangulo);
            Console.WriteLine("CIRCULO: " + circulo);
            Console.WriteLine("TRAPEZIO: " + trapezio);
            Console.WriteLine("QUADRADO: " + quadrado);
            Console.WriteLine("RETANGULO: " + retangulo);
            Console.ReadKey();
        }
    }
}
