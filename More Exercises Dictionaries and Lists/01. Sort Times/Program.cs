﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').OrderBy(p => p).ToList();
            Console.WriteLine(String.Join(", ", input));
        }
    }
}
