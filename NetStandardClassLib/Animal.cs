using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Threading;

namespace NetStandardClassLib
{
    public class Animal
    {
        public Animal()
        {
            //https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.append--1?view=netstandard-1.6
            //Note the Append API added in 1.6
            //https://github.com/dotnet/standard/blob/master/docs/versions/netstandard1.6_diff.md
            var list = new List<int>();
            var bip = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Testing");
            //THIS was added in .NET Standard 1.6
#if NETSTANDARD1_6
            Enumerable.Append<int>(bip, 10);
#endif
            //No app domain in .net core!
            //string callingDomainName = Thread.GetDomain().FriendlyName;

        }
        public string GetName()
        {
            return "Fred";
        }
    }
}
