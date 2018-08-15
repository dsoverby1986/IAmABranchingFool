using System;
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
            Console.WriteLine("Select an option below:\n\n1.) Do triangle stuff");
            var option = Console.ReadLine();
            Console.Clear();
            if (option == "1")
            {
                TriangleStuff.DoStuff();
            }
        }
    }
}
