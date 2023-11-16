namespace BehavioralDesign;

public class AscendingSort : ISortingStrategy
{
    public void Sort(int[] array)
    {
        Array.Sort(array);
        Console.WriteLine("Ascending Sort: " + string.Join(", ", array));
    }
}