using System.IO.IsolatedStorage;

namespace BehavioralDesign;

public class SortingContext
{
    private ISortingStrategy sortingStrategy;

    public SortingContext(ISortingStrategy strategy)
    {
        sortingStrategy = strategy;
    }

    public void setSortingContext(ISortingStrategy strategy)
    {
        sortingStrategy = strategy;
    }

    public void ExecuteSort(int[] array)
    {
        sortingStrategy.Sort(array);
    }
}