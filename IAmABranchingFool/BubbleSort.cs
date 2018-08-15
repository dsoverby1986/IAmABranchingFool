using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmABranchingFool
{
    public static class BubbleSort
    {
        public static void DoStuff()
        {
            List<int> nums = new List<int>();
            List<int> control;
            Random rdm = new Random();
            bool sorted = false;

            for (int i = 0; i <= 27; i++)
                nums.Add(rdm.Next(1, 28));

            control = nums;

            Console.WriteLine("Unsorted list, to be sorted:");

            for (int i = 0; i < nums.Count; i++)
                Console.Write($"{nums[i]}{(i == nums.Count - 1 ? "\n\n" : ", ")}");

            Console.WriteLine("Unsorted control list:");

            for (int i = 0; i < control.Count; i++)
                Console.Write($"{control[i]}{(i == control.Count - 1 ? "\n\n" : ", ")}");

            //Sorting list using my implementation of the Bubble Sort algorithm
            while (!sorted)
            {
                for (int i = 1; i < nums.Count; i++)
                    if (nums[i - 1] > nums[i])
                    {
                        int x = nums[i];
                        nums[i] = nums[i - 1];
                        nums[i - 1] = x;
                    }

                sorted = true;

                for (int i = 1; i < nums.Count; i++)
                    if (nums[i - 1] > nums[i])
                    {
                        sorted = false;
                        break;
                    }
            }

            Console.WriteLine("List sorted, using my implementation of the bubble sort:");

            for (int i = 0; i < nums.Count; i++)
                Console.Write($"{nums[i]}{(i == nums.Count - 1 ? string.Empty : ", ")}");

            //Sorting control list
            control.Sort();

            Console.WriteLine("\n\nControl list, sorted using <List>.Sort():");

            for (int i = 0; i < control.Count; i++)
                Console.Write($"{control[i]}{(i == control.Count - 1 ? "\n\n" : ", ")}");

            Console.ReadKey();
        }
    }
}
