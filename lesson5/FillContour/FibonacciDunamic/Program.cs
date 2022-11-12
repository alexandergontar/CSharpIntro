using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciDunamic
{
    class Program
    {
        public static long Fibonacci(long n)
        {
            if (n <= 1)
            {
                return n;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private static Dictionary<long, long> _memos =
        new Dictionary<long, long> { { 0, 0 }, { 1, 1 } };
        public static long MemoFib(long n)
        {
            if (!_memos.ContainsKey(n))
            {
                _memos[n] = MemoFib(n - 1) + MemoFib(n - 2);
            }
            return _memos[n];
        }

        public static void TimedFibonacci(long n)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            long result = Fibonacci(n);
            //long result = MemoFib(n);
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            Console.WriteLine($"Fibonacci of {n}: {result}");
            Console.WriteLine($"RunTime: {ts.Hours:00}:{ts.Minutes:00}:{ ts.Seconds:00}.{ ts.Milliseconds / 10:00}");
}
        static void Main(string[] args)
        {
            TimedFibonacci(40);
            Console.ReadKey();
        }
    }
}
