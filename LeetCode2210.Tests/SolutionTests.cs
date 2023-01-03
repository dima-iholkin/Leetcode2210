using LeetCode2210.ConsoleApp;



namespace LeetCode2210.Tests;



public class SolutionTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        Solution sol = new Solution();

        int[] nums = new int[] { 2, 4, 1, 1, 6, 5 };



        // Act
        int count = sol.CountHillValley(nums);



        // Assert
        Assert.Equal(3, count);
    }



    [Fact]
    public void Example2()
    {
        // Arrange
        Solution sol = new Solution();

        int[] nums = new int[] { 6, 6, 5, 5, 4, 1 };



        // Act
        int count = sol.CountHillValley(nums);



        // Assert
        Assert.Equal(0, count);
    }
}