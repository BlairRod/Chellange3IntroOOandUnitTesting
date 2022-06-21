namespace CLDiceGame;

public abstract class Game
{

    // List of dice.
    public List<Die> diceList = new List<Die>();

    // Abstract method.
    public abstract int RollAllDice();

    // Adds dice to diceList with its ammout of sides.
    public void AddDie(int sides)
    {
        diceList.Add(new Die(sides));
    }
}