using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class FormOperation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);
            string name = TextBox2.Text;
            string designation = TextBox3.Text;
            string bu = TextBox4.Text;
            int sal = Convert.ToInt32(TextBox5.Text);
            Employee emp = new Employee { Emp_Id = id, Emp_Name = name, Emp_Desg = designation, Emp_BU = bu, Emp_Sal= sal};
            DataLayer ds = new DataLayer();
            ds.Insert(emp);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);
            string name = TextBox2.Text;
            string designation = TextBox3.Text;
            string bu = TextBox4.Text;
            int sal = Convert.ToInt32(TextBox5.Text);
            Employee emp = new Employee { Emp_Id = id, Emp_Name = name, Emp_Desg = designation, Emp_BU = bu, Emp_Sal = sal };
            DataLayer ds = new DataLayer();
            ds.Update(emp);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);
            
            Employee emp = new Employee { Emp_Id = id };
            DataLayer ds = new DataLayer();
            ds.Delete(emp);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);

            Employee emp = new Employee { Emp_Id = id };
            DataLayer ds = new DataLayer();
            //ds.Search(emp);
            var pdlst = ds.Search(emp);
            GridView2.DataSource = pdlst;
            GridView2.DataBind();
            
        }
    }
}