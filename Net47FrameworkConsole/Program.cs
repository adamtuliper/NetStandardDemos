using NetStandardClassLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net47FrameworkConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Any dataset code in here would go to
            //newobj     instance void [netstandard]System.Data.DataSet::.ctor()
            var animal = new Animal();
            Console.WriteLine("NetStandard Animal created");

            //This dataset goes 'direct' to system.data
            //newobj instance void [System.Data]System.Data.DataSet::.ctor()

            DataSet ds = new DataSet();
        }
    }
}
