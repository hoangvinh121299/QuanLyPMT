using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    static class connectionString
    {
        public static string connectionstring = "Data Source=" + Dns.GetHostName() + ";Initial Catalog=QLPMT;Integrated Security=True";
        public static SqlConnection GetConnect()
        {
            return new SqlConnection(connectionstring);
        }
    }
}
