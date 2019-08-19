using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class ConnectionHelper
    {
        public static string getConnectionString()
        {
            return "Data Source=.;Initial Catalog=DB_Employee_Work_Hours;Integrated Security=True";
        }
    }
}
