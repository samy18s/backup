using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produt
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            //Product pr= Setdata();

            ProductDataLayer pd = new ProductDataLayer();

            int choice;
            do
            {
                Console.WriteLine("**************************MENU***********************************");
                Console.WriteLine("\n1.Insert Prodcut Details \n2.Delete Prodcut Details \n3.Update Product Details\n4.Search Product Details \n5.Display Product Details\n6.Exit");
                Console.WriteLine("\nEnter Your Choice");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("\n----------------------------------------------");
                        Console.WriteLine("Insert Reacord");
                        Console.WriteLine("\n----------------------------------------------");
                        Product pr = Setdata();
                        pd.InsertProduct(pr);
                        break;

                    case 2:
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("Delete Reacord");
                        Console.WriteLine("------------------------------------------------");
                        pd.DeleteProduct();

                        break;

                    case 3:
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("Update Reacords");
                        Console.WriteLine("-------------------------------------------------");
                        pd.UpdateProductPrice();
                        break;

                    case 4:
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("Search Record ");
                        Console.WriteLine("--------------------------------------------------");
                        pd.SearchDetails();
                        break;

                    case 5:
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("Display Records");
                        Console.WriteLine("--------------------------------------------------");
                        pd.ShowDetails();
                        break;

                    case 6:
                        break;

                    default:
                        Console.WriteLine("wrong input");
                        break;
                }
                Console.WriteLine("Do You Want to continue(1/0)");
                choice = Convert.ToInt32(Console.ReadLine());

            }
            while (choice == 1);
        }

        public static Product Setdata()
        {
            Console.WriteLine("Enter Product Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Product Category");
            string cat = Console.ReadLine();

            Console.WriteLine("Enter Product Price");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Product p = new Product();
            p.Id = id;
            p.Pname = name;
            p.Pcategory = cat;
            p.Pprice = price;

            return p;

        }
    }
}
