# Bcr.DerpyBenchmark -- Dead Simple Benchmarks in C#

## Usage

1. Make a class with one or more static methods that are the things to run
2. Mark those methods with the `[Benchmark]` attribute
3. At some point call `BenchmarkRunner.Run<T>` providing your class
4. Enjoy the `BenchmarkResult` list that has the results

Each test is run a total of 100 iterations and the total time is recorded.
