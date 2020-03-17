using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewWebForm
{
    public class Books
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime DateOfRelease { get; set; }


        public static List<Books> GetPagedBooks(int StartRowIndex, int maximum)
        {
            List<Books> list = new List<Books>();
            list.Add(new Books
            {
                ID = "1",
                Title = "CPP",
                Price = 444,
                DateOfRelease = Convert.ToDateTime("2020-12-10")
            });

            list.Add(new Books
            {
                ID = "2",
                Title = "Java Programming",
                Price = 700.63m,
                DateOfRelease = Convert.ToDateTime("2001-02-18")
            });

            list.Add(new Books
            {
                ID = "3",
                Title = "Dot Net --Book",
                Price = 850.3m,
                DateOfRelease = Convert.ToDateTime("2012-01-10")
            });
            list.Add(new Books
            {
                ID = "4",
                Title = "Data Structure",
                Price = 500.0m,
                DateOfRelease = Convert.ToDateTime("2019-12-10")
            });
            list.Add(new Books
            {
                ID = "5",
                Title = "Computer Network",
                Price = 444,
                DateOfRelease = Convert.ToDateTime("2020-12-10")
            });
            return list.Skip(StartRowIndex).Take(maximum).ToList();
        }

        public int GetCount()
        {
            return 5;
        }
    }
      

    
}