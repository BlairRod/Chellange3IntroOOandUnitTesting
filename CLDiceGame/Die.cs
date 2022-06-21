namespace CLDiceGame;

public class Die
{
    public int sides;

    // Parameterless constructor.
    public Die()
    {
        this.sides = 6;
    }

    // Consturctor.
    public Die(int sides)
    {
        this.sides = sides;
    }

    // Generate random number 1 to 6 for the dice roll.
    public int Roll()
    {
        var r = new Random();
        int n = r.Next(1, sides + 1);
        return n;
    }

}