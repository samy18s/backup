using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDatasetDemo
{
    public partial class WebFormInsertWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int studId = Convert.ToInt32(TextBox1.Text);
            string sName = TextBox2.Text;
            string scourse = TextBox3.Text;
            int scourseFee = Convert.ToInt32(TextBox4.Text);
            Product prd = new Product { studNo = studId, studName = sName, course = scourse, courseFee = scourseFee };
            DataLayer ds = new DataLayer();
            ds.Insert(prd);
        }
    }
}