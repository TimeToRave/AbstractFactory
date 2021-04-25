using System;
using System.Linq;

namespace Abstract_Factory
{
    static class Program
    {
        public static void Main(string[] args)
        {
            string inputFilePath = "input.txt";
            string outputFilePath = "output.txt";

            FileOperator fileOperator = new FileOperator();
            
            string fileContent = fileOperator.ReadTextFromFile(inputFilePath);
            int[] unsortedArray = fileContent.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

            SorterManager manager = new SorterManager();
            var sorter = manager.GetSorter("insertion");
            int[] resultArray = (int[]) sorter.Sort(unsortedArray);

            string resultArrayAsString = String.Join(", ", resultArray);
            fileOperator.WriteTextToFile(outputFilePath, resultArrayAsString);
        }
    }
}