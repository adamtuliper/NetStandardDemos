using System;

namespace MultiTargetingClassLib
{
    public class Class1
    {
#if NETSTANDARD2_0
        public void DoIt()
        {
            Console.WriteLine("Hello");
        }
#endif
    }
}
