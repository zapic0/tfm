using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.Util
{
    public static class Configuration
    {

        /// <summary>
        /// Gets the connection string.
        /// </summary>
        /// <returns></returns>
        public static string GetConnectionString()
        {
            return @"Data Source=;Initial Catalog=XareuDB;Integrated Security=True";

            //System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/");
            //return rootWebConfig.ConnectionStrings.ConnectionStrings[0].ConnectionString;
        }

    }
}
