using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net461FrameworkClassLibrary
{
    public class DAL
    {
        public void ConnectToDatabase()
        {
            using (var connection = new SqlConnection())
            {
                
            }
            
        }
    }
}
