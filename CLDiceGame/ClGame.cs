namespace CLDiceGame;

public class ClGame : Game
{
    // Unused variable.
    private string? name;

    // List of dice rolls.
    public List<int> results = new List<int>();

    // Get the total of the dice rolls in results list.
    public int GetTotal()
    {
        int total = 0;
        foreach (int i in results) total += i;
        return total;
    }

    // Get the average of dice rolls in results list, using GetTotal().
    public double GetAverage()
    {
        if (results.Count == 0) return 0;
        double count = results.Count;
        double total = GetTotal();
        return total / count;
    }

    // Roll all the dice n diceList and store the rolls in results.
    public override int RollAllDice()
    {
        foreach (Die d in diceList) results.Add(d.Roll());
        return 1;
    }
}