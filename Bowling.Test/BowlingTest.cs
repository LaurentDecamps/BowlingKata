using FluentAssertions;

namespace Bowling.Test;

public class BowlingTest
{
    [Theory]
    [ClassData(typeof(BowlingOnePinsLessThanTenPinsTestData))]
    public void Make_Roll_of_Less_Than_Ten_Should_Give_A_Score_Of_Corresponding_Pins(int numberPins)
    {
        var game = new Game();

        game.Roll(numberPins);

        game.Score().Should().Be(numberPins);
    }

    [Theory]
    [ClassData(typeof(BowlingTwoRollsLessThanTenPinsTestData))]
    public void Make_Two_Rolls_Less_Than_Ten_Should_Give_A_Score_Of_Sum_Pins(int firstNumberPins, int secondNumberPins)
    {
        var game = new Game();

        game.Roll(firstNumberPins);
        game.Roll(secondNumberPins);

        game.Score().Should().Be(firstNumberPins + secondNumberPins);
    }
}