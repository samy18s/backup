﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class FormView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                DataLayer d1 = new DataLayer();
                var pdlst = d1.ShowData();
                GridView1.DataSource = pdlst;
                GridView1.DataBind();

            }
        }
    }
}