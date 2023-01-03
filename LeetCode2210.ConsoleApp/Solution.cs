namespace LeetCode2210.ConsoleApp;



public class Solution
{
    public int CountHillValley(int[] nums)
    {
        int count = 0;

        int prevElement = nums[0];

        int currentIndex = 1;
        int currentElement;

        int nextElement;



        // Find the current element, non-equal to the previous element.
        currentIndex = FindNextNonEqualElementIndex(nums, currentIndex);
        if (currentIndex == -1)
        {
            return count;
        }

        currentElement = nums[currentIndex];




        for (int nextIndex = currentIndex + 1; nextIndex < nums.Length; nextIndex++)
        {
            // Find the next element, non-equal to the current one.
            nextIndex = FindNextNonEqualElementIndex(nums, nextIndex);
            if (nextIndex == -1)
            {
                return count;
            }

            nextElement = nums[nextIndex];



            if (
                (currentElement > prevElement && currentElement > nextElement)
                || (currentElement < prevElement && currentElement < nextElement)
            )
            {
                ++count;
            }

            // Switch around the elements.
            prevElement = currentElement;
            currentElement = nextElement;
        }

        return count;
    }



    private int FindNextNonEqualElementIndex(int[] nums, int nextIndex)
    {
        int prevElement = nums[nextIndex - 1];

        for (int i = nextIndex; i < nums.Length; i++)
        {
            if (nums[i] != prevElement)
            {
                return i;
            }
        }

        return -1;
    }
}