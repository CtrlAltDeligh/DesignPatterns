namespace BehavioralDesign;

public class DescendingSort: ISortingStrategy
{
    public void Sort(int[] array)
    {
        Array.Sort(array);
        Array.Reverse(array);
        Console.WriteLine("Descending Sort: " + string.Join(", ", array));
    }
}