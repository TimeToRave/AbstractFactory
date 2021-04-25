using Abstract_Factory.Interfaces;

namespace Abstract_Factory.ConcreteFactories
{
    /// <summary>
    /// Конкретная фабрика для варианта сортировки вставкой
    /// </summary>
    public class InsertionSorterFactory : ISorterAbstractFactory
    {
        /// <summary>
        /// Возвращает экземпляр класса сортировщика вставкой 
        /// </summary>
        public ISorter CreateSorter()
        {
            return new InsertionSorter();
        }
    }
}