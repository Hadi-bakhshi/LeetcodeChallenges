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
        var priceWithoutSpecial = 0;
        var compareInfo = new List<CompareInfo>();
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
                var lastIndex = oneS.Count - 1;
                if (j != lastIndex && jItem > needs[j])
                {
                    break;
                }
                if (j != lastIndex && jItem == needs[j])
                {
                    compareInfo.Add(new CompareInfo
                    {
                        Index = j,
                        IsCountEqualTo = true,
                        ItemCount = jItem,
                        OfferIndex = i,
                        OfferPrice = oneS.Last(),
                        ItemPrice = price[j],
                        NeededCount = null
                    });


                }
                if (j != lastIndex && jItem < needs[j])
                {
                    compareInfo.Add(new CompareInfo
                    {
                        Index = j,
                        IsCountEqualTo = false,
                        ItemCount = jItem,
                        OfferIndex = i,
                        OfferPrice = oneS.Last(),
                        NeededCount = needs[j] - jItem,
                        ItemPrice = price[j]
                    });
                }

            }

        }

        if (compareInfo.Count == 0 || priceWithoutSpecial == 0)
        {
            return priceWithoutSpecial;
        }

        var offersTotal = new List<int>();

        compareInfo
            .GroupBy(item => item.OfferIndex)
            .Select(gp =>
            {
                var offerPrice = gp.First().OfferPrice;
               
                if (offerPrice == 0)
                {
                    if(gp.Where(item => !item.IsCountEqualTo).Count() >= 1)
                    {
                        var sum = gp.Sum(item => item.NeededCount * item.ItemPrice);
                        
                        offersTotal.Add(sum.Value);
                        return sum;
                    }
                    if (gp.All(item => item.IsCountEqualTo))
                    {
                        offersTotal.Add(priceWithoutSpecial);
                        return priceWithoutSpecial;
                    }
                    offersTotal.Add(0);
                    return 0;
                }
                else
                {
                    var sum = gp
                        .Where(item => !item.IsCountEqualTo)
                        .Sum(item => item.NeededCount * item.ItemPrice);

                    var totalPriceWithOffer = sum + offerPrice;
                    offersTotal.Add(totalPriceWithOffer.Value);
                    return totalPriceWithOffer;

                }

            })
            .ToList();

        return offersTotal.Min();

    }
}


public class CompareInfo
{
    public int Index { get; set; }
    public bool IsCountEqualTo { get; set; }
    public int ItemCount { get; set; }
    public int OfferIndex { get; set; }
    public int OfferPrice { get; set; }
    public int ItemPrice { get; set; }
    public int? NeededCount { get; set; }

}