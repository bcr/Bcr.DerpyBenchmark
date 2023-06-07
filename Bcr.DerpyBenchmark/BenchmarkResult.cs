using System;

namespace Bcr.DerpyBenchmark
{
    public class BenchmarkResult
    {
        public string Name { get; private set; }
        public TimeSpan Elapsed { get; private set; }
        public int Iterations { get; private set; }

        public BenchmarkResult(string name, TimeSpan elapsed, int iterations)
        {
            Name = name;
            Elapsed = elapsed;
            Iterations = iterations;
        }
    }
}
