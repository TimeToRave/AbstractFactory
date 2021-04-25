using System.Collections.Generic;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory
{
    /// <summary>
    /// Реализация сортировки выбором
    /// </summary>
    public class SelectionSorter : ISorter
    {
        /// <summary>
        /// Сортирует массив чисел выбором по возрастанию
        /// </summary>
        /// <param name="unsortedArray">Массив неотсортированных чисел</param>
        /// <returns>Отсортированный массив чисел</returns>
        public IEnumerable<int> Sort(int[] unsortedArray)
        {
            int arrayLength = unsortedArray.Length;

            for (int i = 0; i < arrayLength - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (unsortedArray[j] < unsortedArray[min])
                    {
                        min = j;
                    }
                }

                var temp = unsortedArray[min];
                unsortedArray[min] = unsortedArray[i];
                unsortedArray[i] = temp;
            }

            return unsortedArray;
        }
    }
}