namespace Bowling;

public class Game
{
    private int _score;

    public void Roll(int numberPins)
    {
        if (numberPins is < 0 or > 10)
        {
            throw new ArgumentException("Number of pins must be positive and less than 10");
        }
        _score += numberPins;
    }

    public int Score()
    {
        return _score;
    }
}