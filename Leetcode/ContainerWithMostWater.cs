namespace Leetcode;

/// <summary>
/// Microsoft Array Question Container with most water (Medium)
/// </summary>
public static class ContainerWithMostWater
{
    /// <summary>
    /// Time complexity: O(n²)
    /// Space complexity: O(1) constant
    /// </summary>
    /// <param name="height"></param>
    /// <returns></returns>
    public static int MaxAreaBruteForceSolution(int[] height)
    {
        int maxArea = 0;
        int heightsLength = height.Length;
        for (int i = 0; i < heightsLength; i++)
        {
            for (int j = i + 1; j < heightsLength; j++)
            {
                int length = Math.Min(height[i], height[j]);
                int width = j - i;
                int area = length * width;
                maxArea = Math.Max(maxArea, area);
            }
        }
        return maxArea;
    }

    /// <summary>
    /// Time complexity: O(n)
    /// Space complexity: O(1)
    /// </summary>
    /// <param name="heights"></param>
    /// <returns></returns>
    public static int MaxAreaOptimalSolution(int[] heights)
    {
        int left = 0;
        int right = heights.Length - 1;
        int maxArea = 0;

        while (left < right) 
        {
            maxArea = Math.Max(maxArea, Math.Min(heights[left], heights[right]) * (right - left));

            if (heights[left] < heights[right])
            {
                left++;
            } else
            {
                right--;
            }
        }
        return maxArea;
    }
}
