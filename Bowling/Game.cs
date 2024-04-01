namespace Bowling;

public class Game
{
    private int _score;
    private int _firstNumberPins;
    private int _SecondNumberPins;

    public void Roll(int numberPins)
    {
        if (numberPins is < 0 or > 10)
        {
            throw new ArgumentException("Number of pins must be positive and less than 10");
        }

        if (_firstNumberPins != 0)
        {
            if (_firstNumberPins + numberPins > 10)
            {
                throw new ArgumentException("The sum of the number of pins must be less than 10");
            }
            _SecondNumberPins = numberPins;
            _firstNumberPins = 0;
        }
        else
        {
            _firstNumberPins = numberPins;
        }

        _score += numberPins;
    }

    public int Score()
    {
        return _score;
    }
}