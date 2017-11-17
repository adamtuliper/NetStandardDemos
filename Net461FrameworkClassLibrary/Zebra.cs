using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Net461FrameworkClassLibrary
{
    public class Zebra 
    {
        public Zebra()
        {
            string callingDomainName = Thread.GetDomain().FriendlyName;
            Console.WriteLine(callingDomainName);


            var ds = new DataSet();
            ds.Tables.Add(new DataTable());
            ds.Tables[0].Columns.Add("Id", typeof(int));



            //This assembly will add OK to a .NET Core application even
            //though its compiled with .net 4.6.1 HOWEVER
            //when you get to execute this line of code it will give an exception
            //because .net core doesn't know about this library (it doesn't exist in .net core)
            var bitmap = new System.Drawing.Bitmap("anypath.bmp");

            WebClient wc = new WebClient();

         }
    }
}
