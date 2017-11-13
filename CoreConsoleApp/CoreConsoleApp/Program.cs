using NetStandardClassLib;
using System;
using System.Data;

namespace CoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet();

            var animal = new Animal();
            Console.WriteLine("NetStandard Animal created");
            Console.WriteLine(new Net461FrameworkClassLibrary.Zebra().ToString());
        }
    }
}
