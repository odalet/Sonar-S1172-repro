using System;

namespace SonarIssue
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hello World!");
            var test = new TestClass();
            test.DoSomething();
        }
    }

    internal sealed class TestClass
    {
        public void DoSomething() => DoSomethingWithParameter(42);

        private void DoSomethingWithParameter(int value = 0)
        {
            var positive = value >= 0 ? "positive" : "negative";
            Console.WriteLine($"value is {positive}");
        }
    }
}
