using Abstract_Factory;
using Abstract_Factory.Interfaces;
using NUnit.Framework;

namespace Abstract_Factory_Test
{
    [TestFixture]
    public class SorterManagerTests
    {
        /// <summary>
        /// Проверяет создание сортировщика слиянием посредством фабрики
        /// </summary>
        [Test]
        public void GetMergeSorter()
        {
            var sorterManager = new SorterManager();
            ISorter sorter = sorterManager.GetSorter("merge");
            
            Assert.IsTrue(typeof(MergeSorter)  == sorter.GetType());
        }
        
        /// <summary>
        /// Проверяет создание сортировщика вставкой посредством фабрики
        /// </summary>
        [Test]
        public void GetInsertionSorter()
        {
            var sorterManager = new SorterManager();
            ISorter sorter = sorterManager.GetSorter("insertion");
            
            Assert.IsTrue(typeof(InsertionSorter)  == sorter.GetType());
        }
        
        
        /// <summary>
        /// Проверяет создание сортировщика выбором посредством фабрик
        /// </summary>
        [Test]
        public void GetSelectionSorter()
        {
            var sorterManager = new SorterManager();
            ISorter sorter = sorterManager.GetSorter("selection");
            
            Assert.IsTrue(typeof(SelectionSorter)  == sorter.GetType());
        }
        
        /// <summary>
        /// Проверяет создание явно некорректного сортировщика
        /// </summary>
        [Test]
        public void GetIncorrectSorter()
        {
            var sorterManager = new SorterManager();
            ISorter sorter = sorterManager.GetSorter("insertion");
            
            Assert.IsFalse(typeof(SelectionSorter)  == sorter.GetType());
        }
        
        /// <summary>
        /// Проверяет создание сортировщика по умолчанию
        /// </summary>
        [Test]
        public void GetDefaultSorter()
        {
            var sorterManager = new SorterManager();
            ISorter sorter = sorterManager.GetSorter("randomstring");
            
            Assert.IsTrue(typeof(MergeSorter)  == sorter.GetType());
        }
    }
}