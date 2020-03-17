using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace KahiPan
{
    public class DataLayer
    {
        private string constr = "";
        public DataLayer()
        {
            constr = ConfigurationManager.ConnectionStrings["Samy"].ConnectionString;
        }




    }
}