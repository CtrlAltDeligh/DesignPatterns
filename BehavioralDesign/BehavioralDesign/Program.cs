using BehavioralDesign;
class Program
{
    /*
      Strategy pattern is a behavioral design pattern that defines 
      a family of algorithms, encapsulates each algorithm, and makes them 
      interchangeable. It allows a client to choose 
      the appropriate algorithm at runtime without modifying the client's code
     */
    static void Main()
    {
        int[] numbers = { 5, 2, 8, 1, 3 };

        // Create sorting strategies
        ISortingStrategy ascendingSort = new AscendingSort();
        ISortingStrategy descendingSort = new DescendingSort();

        // Create context with the default sorting strategy (ascending)
        SortingContext context = new SortingContext(ascendingSort);
       
        // Execute sort with the default strategy
        context.ExecuteSort(numbers);
        
        //You can also set the strategy
        context.setSortingContext(descendingSort);
        // Change strategy dynamically by instantiating or setting
       // context = new SortingContext(descendingSort);

        // Execute sort with the new strategy
        context.ExecuteSort(numbers);
    }
}