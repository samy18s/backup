using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewWebForm
{
    public partial class WebBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                List<Books> books = Books.GetPagedBooks(1,3);
                GridView1.DataSource = books;
                GridView1.DataBind();
            }
        }
    }
}