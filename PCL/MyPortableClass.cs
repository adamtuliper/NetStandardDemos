using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCL
{
    public class MyPortableClass
    {
        public string GetMeSomeone()
        {
            string name = "Jane Doe";
            int age = 35;
            return $"Name:{name} Age:{age}";

        }
        public string GetMeSomeoneWhileImWaiting()
        {
            string name = "John Doe";
            int age = 42;
            
            return $"Name:{name} Age:{age}";
        }
    }
}
