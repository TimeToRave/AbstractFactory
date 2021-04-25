using System;

namespace Abstract_Factory
{
    static class Program
    {
        public static void Main(string[] args)
        {
            int[] unsortedArray = new int[] {77, 22, 33, 11, 66, 55};

            SorterManager manager = new SorterManager();
            var sorter = manager.GetSorter("insertion");
            int[] resultArray = (int[]) sorter.Sort(unsortedArray);

            Console.WriteLine(String.Join(", ", resultArray));
        }
    }
}