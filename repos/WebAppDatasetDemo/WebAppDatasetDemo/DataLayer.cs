using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data; 
using System.Data.SqlClient;
using System.Configuration;

namespace WebAppDatasetDemo
{
    public class DataLayer
    {
        private string constr = "";
        public DataLayer()
        {
            constr = ConfigurationManager.ConnectionStrings["Samy"].ConnectionString;
        }
        public DataSet ShowData()
        {
            string selectquery = "select * from Student";
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(selectquery, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);//bridge between actual database and dataset
                    ada.Fill(ds);
                    ada.Update(ds);//update the changes in database
                }
               
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
                //Console.WriteLine()
            }
            return ds;
        }
        
        public string Insert(Product pr)
        {
            string insertquery=string.Format("insert into Student(StudNo, StudName, Course, CourseFee)"+"values('{0}','{1}','{2}','{3}');",pr.studNo,pr.studName,pr.course,pr.courseFee);
            DataSet ds = new DataSet();
            int i = 0;
            string msg="";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(insertquery, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);//bridge between actual database and dataset
                    ada.Fill(ds);
                    ada.Update(ds);//update the changes in database
                }
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                Console.WriteLine(ex.Message);
            }
            if(i>0)
            {
                msg= string.Format("One row inserted Successfully");
            }
            return msg;
        }
    }
}