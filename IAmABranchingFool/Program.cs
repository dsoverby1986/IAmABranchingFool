﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmABranchingFool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an option below:\n\n1.) Do triangle stuff\n2.) Do bubble sort stuff");
            var option = Console.ReadLine();
            Console.Clear();
            if (option == "1")
            {
                TriangleStuff.DoStuff();
            }
            else if (option == "2")
            {
                BubbleSort.DoStuff();
            }
        }
    }
}
