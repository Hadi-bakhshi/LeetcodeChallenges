namespace Leetcode.Two_Sum;

public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int holdNum = 0;
        int holdIndex = 0;
        int currentIndex = 0;
        bool shouldIterate = true;
        int[] result = [];
        while (shouldIterate)
        {
            if (currentIndex == 0)
            {
                holdNum = nums[holdIndex];
                currentIndex++;
                continue;
            }

            if (holdIndex != currentIndex && holdNum + nums[currentIndex] == target)
            {
                shouldIterate = false;
                result = [holdIndex, currentIndex];
            }
            else
            {
                if (currentIndex + 1 == nums.Length && holdIndex + 1 != nums.Length)
                {
                    currentIndex = holdIndex + 1;
                    holdIndex = holdIndex + 1;
                    holdNum = nums[holdIndex];
                    continue;
                }
                if (currentIndex + 1 != nums.Length && holdIndex + 1 != nums.Length)
                {
                    currentIndex++;
                }
                continue;
            }
        }
        return result;
    }
    public int[] TwoSum2(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        // Iterate through the array
        for (int i = 0; i < nums.Length; i++)
        {
            // Calculate the complement
            int complement = target - nums[i];

            // Check if the complement exists in the dictionary
            if (map.ContainsKey(complement))
            {
                // Return the indices of the complement and the current number
                return new int[] { map[complement], i };
            }

            // Add the current number and its index to the dictionary
            map[nums[i]] = i;
        }
        throw new Exception("No two sum solution");
    }
}
