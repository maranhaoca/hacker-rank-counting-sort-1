using System.Collections.Generic;
using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        var arr = new List<int>{1, 1, 3, 2, 1};

        var expected = new List<int>{0, 3, 1, 1};

        var actual = Result.countingSort(arr);

        Assert.Equal(expected, actual);
    }
}