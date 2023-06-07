namespace Bcr.DerpyBenchmark.Test;

public class BenchmarkRunnerTest
{
    private class TestClass
    {
        [Benchmark]
        static void FirstMethod() {}
    }

    [Fact]
    public void Runs()
    {
        BenchmarkRunner.Run<TestClass>();
    }
}
