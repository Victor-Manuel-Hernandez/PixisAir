using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PixisAirVictor
{

        internal class DataHelper
        {
            public static string ConnectionValue(string name)
            {
                return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            }
        }
    
}
