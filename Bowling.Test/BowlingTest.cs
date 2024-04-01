using FluentAssertions;

namespace Bowling.Test;

public class BowlingTest
{
    #region Less than ten

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

    #endregion
    
    #region Exception Tests

    [Fact]
    public void Make_A_Roll_Negative_Should_Throw_An_ArgumentException()
    {
        var game = new Game();

        Action act = () => game.Roll(-1);

        act.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void Make_A_Roll_More_Than_Ten_Should_Throw_An_ArgumentException()
    {
        var game = new Game();

        Action act = () => game.Roll(11);

        act.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void Make_Two_Rolls_More_Than_Ten_Should_Throw_An_ArgumentException()
    {
        var game = new Game();

        game.Roll(9);
        Action act = () => game.Roll(2);

        act.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void Make_Three_Rolls_With_Two_Last_Sum_More_Than_Ten_Should_Not_Throw_An_ArgumentException()
    {
        var game = new Game();

        game.Roll(7);
        game.Roll(2);
        Action act = () => game.Roll(9);

        act.Should().NotThrow<ArgumentException>();
    }

    #endregion

    #region Spare Tests

    [Fact]
    public void Make_A_Spare_Should_Give_A_Score_Of_10_Plus_The_Next_Roll()
    {
        var game = new Game();

        game.Roll(5);
        game.Roll(5);
        game.Roll(3);

        game.Score().Should().Be(16);
    }

    #endregion
}