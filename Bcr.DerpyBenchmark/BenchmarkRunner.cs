using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Bcr.DerpyBenchmark
{
    public class BenchmarkRunner
    {
        public static List<BenchmarkResult> Run<T>()
        {
            var returnValue = new List<BenchmarkResult>();

            var testMethods = typeof(T).GetMethods()
                .Where(method => method.IsStatic &&
                    method.GetCustomAttributes(typeof(BenchmarkAttribute), true).Any());

            foreach (var testMethod in testMethods)
            {
                int iterations = 100;

                var stopwatch = Stopwatch.StartNew();
                for (int iteration = 0;iteration < iterations;++iteration)
                {
                    testMethod.Invoke(null, null);
                }
                stopwatch.Stop();
                var result = new BenchmarkResult(testMethod.Name, stopwatch.Elapsed, iterations);
                returnValue.Add(result);
            }

            return returnValue;
        }
    }
}
