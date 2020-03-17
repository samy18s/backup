using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewWebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected string GetCity()
        {
            string[] cities = { "London", "New York", "Paris" };
            return cities[2];
        }
        public string[] GetCities()
        {
            return new[] { "London", "New York", "Paris", "<input/>" };
        }

    }
}