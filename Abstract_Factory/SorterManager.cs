using Abstract_Factory.ConcreteFactories;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory
{
    public class SorterManager
    {
        /// <summary>
        /// Определяет алгоритм сортировки по ее названию
        /// </summary>
        /// <returns>Экземпляр класса-сортировщика</returns>
        public ISorter GetSorter(string sortingAlgorithmName)
        {
            ISorterAbstractFactory factory = GetSorterFactory(sortingAlgorithmName);
            ISorter sorter = factory.CreateSorter();
            return sorter;
        }

        /// <summary>
        /// Метод, возвращающий конкретную фабрику
        /// по названию алгоритма сортировки
        /// </summary>
        /// <param name="methodName"></param>
        /// <returns></returns>
        private ISorterAbstractFactory GetSorterFactory(string methodName)
        {
            if (methodName == "merge")
            {
                return new MergeSorterFactory();
            }

            if (methodName == "selection")
            {
                return new SelectionSorterFactory();
            }
            
            if (methodName == "insertion")
            {
                return new InsertionSorterFactory();
            }

            return new MergeSorterFactory();
        }
    }
}