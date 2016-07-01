﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class TriangleSurfaceByThreeSides
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double p = (a + b + c) / 2;
            double res = Math.Sqrt(p*(p - a)*(p - b)*(p - c));
            Console.WriteLine("{0:F2}",res);
        }
    }
}
