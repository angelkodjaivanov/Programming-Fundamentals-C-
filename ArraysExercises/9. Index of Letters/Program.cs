﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("{0} -> {1} ", input[i] ,input[i] - 97);
            }
        }
    }
}
