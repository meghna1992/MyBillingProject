using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace CoreProject.Manage
{
  
    public static class DBConnection
    {
        public static string Connectionstring
        {
            get { return ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString; }
        }

    }
}
