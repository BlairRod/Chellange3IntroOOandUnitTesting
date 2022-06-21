using Xunit;
using CLDiceGame;
using System.Linq;

namespace CLDiceGameTests;

public class GameTests
{

    // Test for ClGame GetTotal().
    [Theory]
    [InlineData(new int[] { 2, 7, 3, 11, 2, 2 }, 27)]
    [InlineData(new int[] { 18, 4, 6, 12, 19 }, 59)]
    [InlineData(new int[] { 5 }, 5)]
    [InlineData(new int[] { }, 0)]
    public void GetTotalTest(int[] rolls, int expected)
    {
        ClGame g = new ClGame();
        g.results = rolls.ToList();
        int actual = g.GetTotal();
        Assert.Equal(actual, expected);
    }

    // Test for ClGame GetAverage().
    [Theory]
    [InlineData(new int[] { 2, 7, 3, 11, 2, 2 }, 4.50)]
    [InlineData(new int[] { 18, 4, 6, 12, 19 }, 11.80)]
    [InlineData(new int[] { 5 }, 5)]
    [InlineData(new int[] { }, 0)]
    public void GetAverageTest(int[] rolls, double expected)
    {
        ClGame g = new ClGame();
        g.results = rolls.ToList();
        double actual = g.GetAverage();
        Assert.Equal(actual, expected);
    }

}