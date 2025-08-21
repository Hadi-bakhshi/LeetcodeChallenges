namespace Leetcode.Top_K;

/// <summary>
/// Input: nums = [1,1,1,2,2,3], k = 2
/// Output: [1, 2]
/// </summary>

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var hashed = new HashSet<int>(nums);

        if (hashed.Count == 1)
        {
            return hashed.ToArray();
        }

        List<int[]> frequencyOfNums = [];
        while (nums.Length > 0)
        {
            int current = nums[0];
            frequencyOfNums.Add(SameNumber(current, nums));
            nums = nums.Where(x => x != current).ToArray();
        }

        frequencyOfNums = frequencyOfNums.OrderByDescending(x => x[1]).ToList();

        return frequencyOfNums
            .Take(k)
            .Select(x => x[0])
            .ToArray();

    }

    private int[] SameNumber(int number, int[] values)
    {
        int count = 0;
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] == number)
            {
                count++;
            }
        }
        return [number, count];
    }

    public int[] TopKFrequentV2(int[] nums, int k)
    {
        var hashed = new HashSet<int>(nums);

        if (hashed.Count == 1)
        {
            return hashed.ToArray();
        }
        var frequencyOfNums = new List<int>();
        double nesbat = (double)k / nums.Length * 100;
        if(nesbat == 100)
        {
            return nums;
        }
        for (int i = 0; i < hashed.Count; i++)
        {
            var number = hashed.ElementAt(i);
            int count = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == number)
                {
                    count++;
                }
            }
            
            double ratio = (double)count / nums.Length * 100; 
            if (ratio > nesbat)
            {
                frequencyOfNums.Add(number);
            }
        }
        return frequencyOfNums.ToArray();
    }

}



//public class Solution
//{
//    public int[] TopKFrequent(int[] nums, int k)
//    {
//        var hashed = new HashSet<int>(nums);

//        if (hashed.Count == 1)
//        {
//            return hashed.ToArray();
//        }

//        List<int[]> frequencyOfNums = [];
//        while (nums.Length > 0)
//        {
//            int current = nums[0];
//            frequencyOfNums.Add(SameNumber(current, nums));
//            nums = nums.Where(x => x != current).ToArray();
//        }

//        frequencyOfNums = frequencyOfNums.OrderByDescending(x => x[1]).ToList();

//        return frequencyOfNums
//            .Take(k)
//            .Select(x => x[0])
//            .ToArray();

//    }

//    private int[] SameNumber(int number, int[] values)
//    {
//        int count = 0;
//        for (int i = 0; i < values.Length; i++)
//        {
//            if (values[i] == number)
//            {
//                count++;
//            }
//        }
//        return [number, count];
//    }

//}