using FluentAssertions;

namespace Bowling.Test;

public class BowlingTest
{
    [Fact]
    public void Make_Roll_of_One_Should_Give_A_Score_Of_One()
    {
        var game = new Game();

        game.Roll(1);

        game.Score().Should().Be(1);
    }
}