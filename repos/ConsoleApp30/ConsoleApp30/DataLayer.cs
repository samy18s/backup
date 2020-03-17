using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp30
{
    class DataLayer
    {
      SqlConnection  con = new SqlConnection("Server=BLT220\\SQLEXPRESS; database=Emp_sal;integrated security=true");
      SqlCommand cmd;
        int emp_Id;
        string emp_Name;
        string emp_address;
        string emp_Bu;

        public void insert()
        {
            con.Open();

            Console.WriteLine("Enter Employee Id");
            emp_Id = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter Employee Name");
            emp_Name=Console.ReadLine();


            Console.WriteLine("Enter Employee Address");
            emp_address=Console.ReadLine();


            Console.WriteLine("Enter Employee Buisness Unit");
            emp_Bu =Console.ReadLine();
            cmd = new SqlCommand("Insert into emp values('" + emp_Id + "','" + emp_Name + "','" + emp_address + "','" + emp_Bu+ "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void update()
        {
            con.Open();
            Console.WriteLine("Enter Id ");
            emp_Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name to Update");
            emp_Name = Console.ReadLine();
            cmd = new SqlCommand("update emp set e_Name='" + emp_Name + "' where e_Id ='" + emp_Id + "'", con);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Updated");
            con.Close();

        }
        public void display()
        {
            con.Open();
            cmd = new SqlCommand("select * from emp", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine(reader.GetValue(i));
                }

            }
            con.Close();
        }
    }
}
