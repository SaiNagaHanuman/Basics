﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class program2
    {
        static void Main(string[] args)
        {
            int n = 25;
            for (int i = 1; i <= 4; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(n + " " + n + " " + n + " " + n);
                else

                    Console.WriteLine(n + "" + n + "" + n + "" + n);
            }
            Console.ReadLine();
        }
    }
}

