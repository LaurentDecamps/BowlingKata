using FluentAssertions;

namespace Bowling.Test;

public class BowlingTest
{
    [Fact]
    public void Make_Roll_of_Zero_Should_Give_A_Score_Of_Zero()
    {
        var game = new Game();

        game.Roll(0);

        game.Score().Should().Be(0);
    }

    [Fact]
    public void Make_Roll_of_One_Should_Give_A_Score_Of_One()
    {
        var game = new Game();

        game.Roll(1);

        game.Score().Should().Be(1);
    }

    [Fact]
    public void Make_Roll_of_Two_Should_Give_A_Score_Of_Two()
    {
        var game = new Game();

        game.Roll(2);

        game.Score().Should().Be(2);
    }
}