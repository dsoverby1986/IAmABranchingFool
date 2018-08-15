using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmABranchingFool
{
    public static class TriangleStuff
    {
        private static int InputSize { get; set; }

        public static void DoStuff()
        {
            Console.WriteLine("In this exercise, I will draw a triangle, based on user input.\nPress any key to continue...\n");
            Console.ReadKey();
            Console.Clear();

            int triangleSize = (int)GetTriangleSize(0);
            InputSize = triangleSize;
            DrawTriangle(triangleSize);
            Console.ReadKey();
        }

        private static object GetTriangleSize(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input is invalid. Try again.\n");

            Console.WriteLine("Enter a positive whole number greater than or equal to three...\n");
            string response = Console.ReadLine();

            int num;

            if (Int32.TryParse(response, out num) && num >= 3)
                return num;

            return GetTriangleSize(++attempts);
        }

        private static void DrawTriangle(int size)
        {
            Console.WriteLine();

            if (size < InputSize)
                for (int i = 0; i < (InputSize - size) / 2; i++)
                    Console.Write(" ");

            for (int i = 0; i < size; i++)
                Console.Write("*");

            if (size > 0)
                DrawTriangle(size - 2);
            else
                MirrorTriangle(InputSize % 2 == 0 ? 2 : 1);
        }

        private static void MirrorTriangle(int size)
        {
            Console.WriteLine();

            if (size < InputSize)
                for (int i = 0; i < (InputSize - size) / 2; i++)
                    Console.Write(" ");

            for (int i = 0; i < size; i++)
                Console.Write("*");

            if (size < InputSize)
                MirrorTriangle(size + 2);
        }
    }
}
