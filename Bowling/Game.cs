namespace Bowling;

public class Game
{
    private int _score = 0;

    public void Roll(int numberPins)
    {
        _score = numberPins;
    }

    public int Score()
    {
        return _score;
    }
}