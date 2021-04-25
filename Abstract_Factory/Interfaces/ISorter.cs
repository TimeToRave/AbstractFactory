using System.Collections.Generic;

namespace Abstract_Factory.Interfaces
{
    public interface ISorter {
        IEnumerable<int> Sort (int[] unsortedArray);
    }
}