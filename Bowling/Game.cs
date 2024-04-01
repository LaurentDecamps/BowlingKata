namespace Bowling;

public class Game
{
    private int _score;
    private int _firstNumberPins;
    private int _secondNumberPins;
    private bool _isSpare;

    public void Roll(int numberPins)
    {
        if (numberPins is < 0 or > 10)
        {
            throw new ArgumentException("Number of pins must be positive and less than 10");
        }

        if (_firstNumberPins != 0)
        {
            HandleSecondPin(numberPins);
        }
        else
        {
            HandleFirstpin(numberPins);
        }

        _score += numberPins;
    }

    private void HandleFirstpin(int numberPins)
    {
        if (numberPins == 10)
        {
            _firstNumberPins = 0;
            return;
        }

        if (_isSpare)
        {
            _score += numberPins;
            _isSpare = false;
        }
        
        _firstNumberPins = numberPins;
    }

    private void HandleSecondPin(int numberPins)
    {
        if (_firstNumberPins + numberPins > 10)
        {
            throw new ArgumentException("The sum of the number of pins must be less than 10");
        }
        _secondNumberPins = numberPins;
        if (_firstNumberPins + _secondNumberPins == 10)
        {
            _isSpare = true;
        }

        _firstNumberPins = 0;
    }

    public int Score()
    {
        return _score;
    }
}