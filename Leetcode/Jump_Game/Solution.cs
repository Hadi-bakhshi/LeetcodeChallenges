namespace Leetcode.Jump_Game;

public class JumpGameSolution
{
    public bool CanJump(int[] nums)
    {

        if (nums.Length == 1) return true;

        int maxReachable = 0;
        int lastIndex = nums.Length - 1;
        int currentIndex = 0;

        while (currentIndex <= maxReachable)
        {

            maxReachable = Math.Max(maxReachable, Jumper(currentIndex, nums[currentIndex]));


            if (maxReachable >= lastIndex)
            {
                return true;
            }

            currentIndex++;
        }

        return false;
    }

    public int Jumper(int currentIndex, int currentNum)
    {

        return currentNum == 0 ? currentIndex : currentIndex + currentNum;
    }
}