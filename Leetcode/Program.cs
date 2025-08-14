using Leetcode.Container_With_Most_Water;
using Leetcode.Jump_Game;
using Leetcode.Shopping_Offers;
using Leetcode.Two_Sum;

namespace Leetcode;

public static class Solutions
{
    static void Main(string[] args)
    {

        // Microsoft Array Question Container with most water
        // -----------------------------------------------------------
        int maxArea = ContainerWithMostWaterSolution.MaxAreaBruteForceSolution([9, 4, 1, 6, 3]);
        int maxAreaOptimal = ContainerWithMostWaterSolution.MaxAreaOptimalSolution([1, 8, 6, 2, 5, 7]);

        Console.WriteLine("The max area is : {0}", maxArea);
        Console.WriteLine("The max area optimal is : {0}", maxAreaOptimal);
        // -----------------------------------------------------------

        Console.WriteLine("End of the Execution");


        // Two sum
        // -----------------------------------------------------------
        var s = new TwoSumSolution();
        var res = s.TwoSum2([2, 5, 5, 11], 10);
        Console.WriteLine("first index is {0} and second index is {1}", res[0], res[1]);
        // -----------------------------------------------------------

        // Jump Game
        // -----------------------------------------------------------
        var sol = new JumpGameSolution();
        var jumpRes = sol.CanJump([1, 2, 3]);
        Console.WriteLine(jumpRes);
        // -----------------------------------------------------------
        // Shopping Offers
        // -----------------------------------------------------------
        var shoppingOfferSolution = new ShoppingOfferSolution();
        shoppingOfferSolution.ShoppingOffers(
            [2, 5],
            [[3, 0, 5], [1, 2, 10]],
            [3, 2]
        );
        // -----------------------------------------------------------

    }
}