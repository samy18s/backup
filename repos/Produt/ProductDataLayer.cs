﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Produt
{
    class ProductDataLayer
    {

        public string connection;

        public ProductDataLayer()
        {
            connection = "Server = BLT214\\SQLEXPRESS;  Database = Product; Integrated security=true";
        }

        public void InsertProduct(Product p)
        {
            string query = string.Format("insert into Product(pid,pname,pcategory,price)" + "values( '{0}','{1}','{2}','{3}');", p.Id, p.Pname, p.Pcategory, p.Pprice);

            using (SqlConnection con = new SqlConnection(connection))
            {
                int i = 0;
                con.Open();
                SqlCommand cmd;

                try
                {
                    cmd = new SqlCommand(query, con);
                    i = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                if (i > 0)
                    Console.WriteLine("Product Details Inserted");
            }
        }

        public void DeleteProduct()
        {
            int id;
            int i = 0;
            Console.WriteLine("Enter Product ID to be deleted");
            id = Convert.ToInt32(Console.ReadKey());
            string query = "Delete from Product where pid=" + id;

            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    i = cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                if (i > 0)
                {
                    Console.WriteLine("Product Details Deleted");
                }

            }
        }

        public void UpdateProductPrice()
        {
            int id;
            decimal price;

            Console.WriteLine("Enter Product Id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter New Product price");
            price = Convert.ToDecimal(Console.ReadLine());


            string query = "update Product set price=" + "'" + price + "'" + " where pid=" + id;

            int i = 0;

            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    i = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                if (i > 0)
                {
                    Console.WriteLine("Product Details Updated");
                }
            }

        }

        public void ShowDetails()
        {
            string query = "Select * from Product";
            
            using (SqlConnection con = new SqlConnection(connection))
            try
            {
                    con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dreader = cmd.ExecuteReader();

                while (dreader.Read())
                {
                    for (int i = 0; i < dreader.FieldCount; i++)
                    {
                        Console.WriteLine(dreader.GetValue(i));

                    }
                    Console.WriteLine();
                }

                dreader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }

        public void SearchDetails()
        {
            int id;

            Console.WriteLine("Enter Product Id");
            id = Convert.ToInt32(Console.ReadLine());

            string query = "Select * from Product where pid=" +id;

            using (SqlConnection con = new SqlConnection(connection))
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dreader = cmd.ExecuteReader();

                    while (dreader.Read())
                    {
                        for (int i = 0; i < dreader.FieldCount; i++)
                        {
                            Console.WriteLine(dreader.GetValue(i));

                        }
                        Console.WriteLine();
                    }

                    dreader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);

                }
        }




    }
}
        






