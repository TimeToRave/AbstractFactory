using Abstract_Factory.Interfaces;

namespace Abstract_Factory.ConcreteFactories
{
    /// <summary>
    /// Конкретная фабрика для варианта сортировки выбором
    /// </summary>
    public class SelectionSorterFactory : ISorterAbstractFactory
    {
        /// <summary>
        /// Возвращает экземпляр класса сортировщика выбором 
        /// </summary>
        public ISorter CreateSorter()
        {
            return new SelectionSorter();
        }
    }
}