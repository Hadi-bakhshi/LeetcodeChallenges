using Leetcode;

public static class Solutions
{
    static void Main(string[] args)
    {

        // Microsoft Array Question Container with most water
        // -----------------------------------------------------------
        int maxArea = ContainerWithMostWater.MaxAreaBruteForceSolution([9, 4, 1, 6, 3]);
        int maxAreaOptimal = ContainerWithMostWater.MaxAreaOptimalSolution([1, 8, 6, 2, 5, 7]);

        Console.WriteLine("The max area is : {0}", maxArea);
        Console.WriteLine("The max area optimal is : {0}", maxAreaOptimal);
        // -----------------------------------------------------------

        Console.WriteLine("End of the Execution");
    }
}