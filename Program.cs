﻿using System;
using System.Linq;

namespace Linq_queries_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            //method syntax
            var query = array.Where(x => x % 2 == 0).OrderByDescending(x => x);

            //query syntax
            var query2 = from something in array
                         where something % 2 == 0


            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}