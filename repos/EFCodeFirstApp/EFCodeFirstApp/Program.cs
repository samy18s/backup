using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace EFCodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class ProductDBContext : DbContext
        {
            public ProductDBContext() : base("ProductDBContext ")
            {

            }
            public DbSet<Product> Products
            {
                get;
                set;
            }
        }
    }
    class Product
    {
        public int ProductID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public double Price
        {
            get;
            set;
        }
    }
}
