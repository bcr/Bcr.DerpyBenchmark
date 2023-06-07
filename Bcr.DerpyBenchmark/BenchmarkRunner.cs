namespace Bcr.DerpyBenchmark;

public class BenchmarkRunner
{
    public static void Run<T>()
    {
        var testMethods = typeof(T).GetMethods()
            .Where(method => method.IsStatic &&
                method.GetCustomAttributes(typeof(BenchmarkAttribute), true).Any());

        foreach (var testMethod in testMethods)
        {
        }
    }
}
