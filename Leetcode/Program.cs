using Leetcode.Container_With_Most_Water;
using Leetcode.Jump_Game;
using Leetcode.Shopping_Offers;
using Leetcode.Two_Sum;
using Leetcode.Top_K;

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
        var min = shoppingOfferSolution.ShoppingOffers(
             [1, 1, 1],
             [[1, 1, 0, 0], [2, 2, 1, 9]],
             [1, 1, 0]
         );
        //var min = shoppingOfferSolution.ShoppingOffers(
        //     [1, 1, 1],
        //     [[1, 1, 0, 0], [2, 2, 1, 0]],
        //     [1, 1, 1]
        // );
        //var min = shoppingOfferSolution.ShoppingOffers(
        //     [1, 1, 1],
        //     [[1, 1, 1, 0], [2, 2, 1, 1]],
        //     [1, 1, 0]
        // );
        Console.WriteLine(min);
        // -----------------------------------------------------------

        var kFre = new Solution();
        var frequents = kFre.TopKFrequent([1], 1);
        var frequent2 = kFre.TopKFrequentV2([3, 0, 1, 0], 1);
        Console.WriteLine(string.Join(", ", frequents));
        Console.WriteLine(string.Join(", ", frequent2));

    }
}