using Abstract_Factory.Interfaces;

namespace Abstract_Factory.ConcreteFactories
{
    /// <summary>
    /// Конкретная фабрика для варианта сортировки слиянием
    /// </summary>
    public class MergeSorterFactory : ISorterAbstractFactory
    {
        /// <summary>
        /// Возвращает экземпляр класса сортировщика слиянием 
        /// </summary>
        public ISorter CreateSorter()
        {
            return new MergeSorter();
        }
    }
}