using Bcr.DerpyBenchmark;

namespace Bcr.DerpyBenchmark.Test;

public class BenchmarkAttributeTest
{
    private class TestClass
    {
        [Benchmark]
        static void FirstMethod() {}
    }
    [Fact]
    public void Benchmark_Annotation()
    {
        Assert.True(true);
    }
}