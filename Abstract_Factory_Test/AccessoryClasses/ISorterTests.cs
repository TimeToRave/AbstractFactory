using System.Linq;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory_Test
{
    public static class ISorterTests
    {
        public static bool ISorter_Sort_Three_Elements_Array(ISorter sorter)
        {
            int[] etalonArray  = new int[] {2, 5, 6};
            int[] initialArray = new int[] {6, 5, 2};

            var sortedArray = sorter.Sort(initialArray);
    
            return etalonArray.SequenceEqual(sortedArray);
        }
        
        public static bool ISorter_Sort_Zero_Elements_Array(ISorter sorter)
        {
            int[] etalonArray  = new int[] {};
            int[] initialArray = new int[] {};

            var sortedArray = sorter.Sort(initialArray);
    
            return etalonArray.SequenceEqual(sortedArray);
        }

        public static bool ISorter_Sort_Array_With_Negative_Elements(ISorter sorter)
        {
            int[] etalonArray  = new int[] {-6, -5, 0, 2};
            int[] initialArray = new int[] {0, -6, 2, -5};

            var sortedArray = sorter.Sort(initialArray);
    
            return etalonArray.SequenceEqual(sortedArray);
        }
    }
}