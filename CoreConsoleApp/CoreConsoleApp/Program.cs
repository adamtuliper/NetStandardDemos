using Net461FrameworkClassLibrary;
using NetStandardClassLib;
using System;
using System.Data;

namespace CoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var dal = new DAL();
            dal.ConnectToDatabase();
            //For analyzer
            //Install-Package Microsoft.DotNet.Analyzers.Compatibility -Version 0.1.2-alpha
            //https://github.com/dotnet/standard/blob/master/docs/faq.md#why-do-you-include-apis-that-dont-work-everywhere
            AppDomain.CreateDomain("Test");


            int i = 5;
            DataSet ds = new DataSet();
            
            var animal = new Animal();

            Console.WriteLine("NetStandard Animal created - note System.Drawing.Bitmap doesn't exist in .NET Standard 2");

            Console.WriteLine("We're about to cause an exception because System.Drawing.Bitmap isn't in .NET Standard");
            Console.ReadLine();
            Console.WriteLine(new Net461FrameworkClassLibrary.Zebra().ToString());

            
        }
    }
}
