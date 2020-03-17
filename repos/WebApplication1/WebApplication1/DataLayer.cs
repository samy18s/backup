using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
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
            string selectquery = "select * from Emp1";
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                //Console.WriteLine()
            }
            return ds;
        }

        public string Insert(Employee e)
        {
            string insertquery = string.Format("insert into Emp1(e_id, e_name, e_designation, e_bu,salary)" + "values('{0}','{1}','{2}','{3}','{4}');", e.Emp_Id,e.Emp_Name,e.Emp_Desg,e.Emp_BU,e.Emp_Sal);
            DataSet ds = new DataSet();
            int i = 0;
            string msg = "";
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
            if (i > 0)
            {
                msg = string.Format("One row inserted Successfully");
            }
            return msg;
        }

        public string Update(Employee e)
        {
            string updatequery = string.Format("update  Emp1 set  e_name='" + e.Emp_Name +"', e_designation='" + e.Emp_Desg + "', e_bu='"+e.Emp_BU+"',salary='"+ e.Emp_Sal + "' where e_id='"+e.Emp_Id+"'");
            DataSet ds = new DataSet();
            int i = 0;
            string msg = "";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(updatequery, con);
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
            if (i > 0)
            {
                msg = string.Format("One row updated Successfully");
            }
            return msg;
        }

        public string Delete(Employee e)
        {
            string deletequery = string.Format("delete  from  Emp1  where e_id='" + e.Emp_Id + "'");
            DataSet ds = new DataSet();
            int i = 0;
            string msg = "";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(deletequery, con);
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
            if (i > 0)
            {
                msg = string.Format("One row updated Successfully");
            }
            return msg;
        }

        public DataSet Search(Employee e)
        {
            string searchquery = string.Format("select *  from  Emp1  where e_id='" + e.Emp_Id + "'");
            DataSet ds = new DataSet();
           try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(searchquery, con);
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
            
            return ds;
        }


    }
}