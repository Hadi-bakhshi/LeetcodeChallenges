namespace Leetcode.Shopping_Offers;


/// <summary>
/// n == price.length == needs.length
/// 1 <= n <= 6
/// 0 <= price[i], needs[i] <= 10
/// 1 <= special.length <= 100
/// special[i].length == n + 1
/// 0 <= special[i][j] <= 50
/// The input is generated that at least one of special[i][j] is non-zero for 0 <= j <= n - 1.
/// </summary>
public class ShoppingOfferSolution
{
    /// <summary>
    /// price = [2,5], special = [[3,0,5],[1,2,10]], needs = [3,2]
    /// => output = 14
    /// </summary>
    /// <param name="price"></param>
    /// <param name="special"></param>
    /// <param name="needs"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public int ShoppingOffers(IList<int> price, IList<IList<int>> special, IList<int> needs)
    {
        var n = price.Count;
        var priceWithoutSpecial = 0;
        for (int i = 0; i < needs.Count; i++)
        {
            var itemPrice = price[i] * needs[i];
            priceWithoutSpecial += itemPrice;
        }
        for (int i = 0; i < special.Count; i++)
        {
            var oneS = special[i];
            for (int j = 0; j < oneS.Count; j++)
            {
                var jItem = oneS[j];
                if(jItem > needs[i])
                {
                    continue;
                }

            }

        }

        throw new NotImplementedException();
    }
}