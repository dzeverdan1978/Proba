using System;

namespace BinarySearchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] {0, 1, 10, 23, 34, 45, 67};
            Console.WriteLine("Non recursive");
            Console.Write("Enter the search key:");
            int key = int.Parse(Console.ReadLine());
            int resIterative = -1;
            
            resIterative= BinarySearchHelper.BinarySearchIterative(input, key);
            if (resIterative>=0)
            {
                Console.WriteLine("Result is " + resIterative);
            }
            else
            {
                Console.WriteLine("Invalid key value");
            }

            Console.WriteLine("Recursive");
            Console.Write("Enter the search key:");
            key = int.Parse(Console.ReadLine());
            Console.Write("Enter the search min value:");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter the search max value:");
            int max = int.Parse(Console.ReadLine());
            int resRecursive = -1;

            resRecursive= BinarySearchHelper.BinarySearchRecursive(input, key, min, max);

            if (resRecursive>=0)
            {
                Console.WriteLine("Result is " + resRecursive);
            }
            else
            {
                if (resRecursive==-2)
                    Console.WriteLine("Invalid min and max values");

                if (resRecursive == -3)
                    Console.WriteLine("Index out of range of the array");

            }

            

;        }
    }
}
