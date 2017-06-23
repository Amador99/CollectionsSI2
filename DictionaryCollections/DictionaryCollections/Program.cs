﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var lookup = new Dictionary<int, string>();
            lookup[0] = "Zero";
            lookup[1] = "One";
            lookup[2] = "Two";
            lookup[3] = "Three";
            lookup[4] = "Four";
            lookup[5] = "Five";
            lookup[6] = "Six";
            lookup[7] = "Seven";
            lookup[8] = "Eight";
            lookup[9] = "Nine";

            string ourNumber = "888-555-1212";

            foreach(char c in ourNumber)
            {
                int digit = (int)(c - '0');
                if (lookup.ContainsKey(digit))
                {
                    Console.WriteLine(lookup[digit]);
                }

            }
            Console.ReadKey();

        }
    }
}
