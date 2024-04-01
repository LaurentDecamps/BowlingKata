namespace Bowling;

public class Game
{
    private int _score;

    public void Roll(int numberPins)
    {
        if (numberPins < 0)
        {
            throw new ArgumentException("Number of pins must be positive");
        }
        _score += numberPins;
    }

    public int Score()
    {
        return _score;
    }
}