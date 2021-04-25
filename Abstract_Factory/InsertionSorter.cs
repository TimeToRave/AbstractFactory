using System.Collections.Generic;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory
{
    /// <summary>
    /// Реализация сортировки вставкой
    /// </summary>
    public class InsertionSorter : ISorter
    {
        /// <summary>
        /// Сортирует массив чисел вставкой по возрастанию
        /// </summary>
        /// <param name="unsortedArray">Массив неотсортированных чисел</param>
        /// <returns>Отсортированный массив чисел</returns>
        public IEnumerable<int> Sort(int[] unsortedArray)
        {
            for (int i = 1; i < unsortedArray.Length; ++i)
            {
                int key = unsortedArray[i];
                int j = i - 1;

                while (j >= 0 && unsortedArray[j] > key)
                {
                    unsortedArray[j + 1] = unsortedArray[j];
                    j = j - 1;
                }

                unsortedArray[j + 1] = key;
            }

            return unsortedArray;
        }
    }
}