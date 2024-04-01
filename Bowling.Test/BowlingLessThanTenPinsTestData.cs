using System.Collections;

namespace Bowling.Test;

public class BowlingLessThanTenPinsTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [1];
        yield return [2];
        yield return [3];
        yield return [4];
        yield return [5];
        yield return [6];
        yield return [7];
        yield return [8];
        yield return [9];
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}