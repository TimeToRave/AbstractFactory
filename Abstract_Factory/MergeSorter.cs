using System.Collections.Generic;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory
{
    public class MergeSorter : ISorter
    {
        /// <summary>
        /// Сортирует массив чисел слиянием по возрастанию
        /// </summary>
        /// <param name="unsortedArray">Массив неотсортированных чисел</param>
        /// <returns>Отсортированный массив чисел</returns>
        public IEnumerable<int> Sort(int[] unsortedArray)
        {
            return Sort(unsortedArray, 0, unsortedArray.Length - 1);
        }

        /// <summary>
        /// Сортирует массив чисел слиянием по возрастанию
        /// </summary>
        /// <param name="array">Массив неотсортированных чисел</param>
        /// <param name="lowIndex">Левая граница массива</param>
        /// <param name="highIndex">Правая граница массива</param>
        /// <returns>Отсортированный массив чисел</returns>
        private int[] Sort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                Sort(array, lowIndex, middleIndex);
                Sort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }

        /// <summary>
        /// Выполняет слияние двух массивов
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="lowIndex">Левая граница массива</param>
        /// /// <param name="cursor">Курсор</param>
        /// <param name="highIndex">Правая граница массива</param>
        private void Merge(int[] array, int lowIndex, int cursor, int highIndex)
        {
            int left = lowIndex;
            int right = cursor + 1;
            int[] tempArray = new int[highIndex - lowIndex + 1];
            int index = 0;

            while ((left <= cursor) && (right <= highIndex))
            {
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= cursor; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }
    }
}