using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace KahiPan
{
    public partial class GridChaForm : System.Web.UI.Page
    {
        private string constr = "";
        public GridChaForm()
        {
            constr = ConfigurationManager.ConnectionStrings["Samy"].ConnectionString;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            SqlCommand com = new SqlCommand("select distinct Country from Customers", con); // table name 
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);  // fill dataset
            DropDownList1.DataTextField = ds.Tables[0].Columns["Country"].ToString();
            DropDownList1.DataValueField = ds.Tables[0].Columns["Country"].ToString();
            DropDownList1.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist
            DropDownList1.DataBind();

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Customers where Country = '" + DropDownList1.SelectedValue + "'", con);
            SqlDataAdapter Adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            Adpt.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            //Label1.Text = "record found";
        }

        protected void Unnamed3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}