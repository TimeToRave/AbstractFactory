using Abstract_Factory;
using Abstract_Factory.Interfaces;
using NUnit.Framework;

namespace Abstract_Factory_Test
{
    public class InsertionSorterTests
    {
        /// <summary>
        /// Проверяет корректность работы алгоритма
        /// сортировки вставкой на массивах
        /// </summary>
        [Test]
        public void Sort_Three_Elements_Array()
        {
            ISorter sorter = new InsertionSorter();
            bool result = ISorterTests.ISorter_Sort_Three_Elements_Array(sorter);
            Assert.IsTrue(result);
        }
        
        /// <summary>
        /// Проверяет корректность работы алгоритма
        /// сортировки вставкой на пустых массивах
        /// </summary>
        [Test]
        public void Sort_Zero_Elements_Array()
        {
            ISorter sorter = new InsertionSorter();
            bool result = ISorterTests.ISorter_Sort_Zero_Elements_Array(sorter);
            Assert.IsTrue(result);
        }
        
        /// <summary>
        /// Проверяет корректность работы алгоритма
        /// сортировки вставкой на массивах с
        /// отрицательными элементами 
        /// </summary>
        [Test]
        public void Sort_Array_With_Negative_Elements()
        {
            ISorter sorter = new InsertionSorter();
            bool result = ISorterTests.ISorter_Sort_Array_With_Negative_Elements(sorter);
            Assert.IsTrue(result);
        }
    }
}