using System;
#if NETSTANDARD2_0
using System.Data;
#endif
using System.Threading;
namespace NetStandardClassLib
{
    public static class MathCalcs
    {

        public static int Fibonacci(int x)
        {
            if (x < 0) throw new ArgumentException("Less negativity please!", nameof(x));
            #if NETSTANDARD2_0
              var ds = new DataSet();
              ds.Tables.Add(new DataTable());
              ds.Tables[0].Columns.Add("Id", typeof(int));
            #endif
            
            //Note this is a value on the tuple
            return Fib(x).current;

            (int current, int previous) Fib(int i)
            {
                if (i == 0) return (1, 0);
                Console.WriteLine($"Calling with {i - 1}");
                var (p, pp) = Fib(i - 1);
                Console.WriteLine((p + pp, p));
                return (p + pp, p);
            }

        }

    }
}
