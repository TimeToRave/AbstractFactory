using System;
using System.Linq;

namespace Abstract_Factory
{
    static class Program
    {
        public static void Main(string[] args)
        {
            // Получает название метода сортировки
            string sortingAlgorithm = args.Length > 0 && args[0].Length > 0 ? args[0].ToLower() : "insertion";
            // Получает название файла, из которого будет производиться чтение
            string inputFilePath = (args.Length > 1 && args[1].Length > 0) ? args[1] :"input.txt";
            // Получает название файла, в который будет производиться запись
            string outputFilePath = (args.Length > 2 && args[2].Length > 0) ? args[2] : "output.txt";

            FileOperator fileOperator = new FileOperator();
            
            string fileContent = fileOperator.ReadTextFromFile(inputFilePath);
            int[] unsortedArray = fileContent.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            
            // Определение алгоритма сортировки
            SorterManager manager = new SorterManager();
            var sorter = manager.GetSorter(sortingAlgorithm);
            // Сортировка массива
            int[] resultArray = (int[]) sorter.Sort(unsortedArray);

            // Запись отсортированного массива в файл
            string resultArrayAsString = String.Join(", ", resultArray);
            fileOperator.WriteTextToFile(outputFilePath, resultArrayAsString);
        }
    }
}