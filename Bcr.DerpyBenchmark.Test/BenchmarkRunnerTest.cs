namespace Bcr.DerpyBenchmark.Test;

public class BenchmarkRunnerTest
{
    private class TestClass
    {
        [Benchmark]
        public static void FirstMethod() {}
        [Benchmark]
        public static void SecondMethod() {}
        public static void ThirdMethod() {}
    }

    [Fact]
    public void Runs()
    {
        var actual = BenchmarkRunner.Run<TestClass>(100);
        Assert.Equal(2, actual.Count);
        Assert.Equal("FirstMethod", actual[0].Name);
        Assert.Equal("SecondMethod", actual[1].Name);
    }
}
