using System.Collections;

namespace Bowling.Test;

public class BowlingTwoRollsLessThanTenPinsTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [0, 0];
        yield return [0, 1];
        yield return [1, 0];
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}