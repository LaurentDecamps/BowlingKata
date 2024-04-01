using FluentAssertions;

namespace Bowling.Test;

public class BowlingTest
{
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public void Make_Roll_of_Zero_Should_Give_A_Score_Of_Zero(int numberPins)
    {
        var game = new Game();

        game.Roll(numberPins);

        game.Score().Should().Be(numberPins);
    }
}