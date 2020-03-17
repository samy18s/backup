using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Student
    {
        int StudentId;
        String studentName;

        public int SID
        {
            get
            {
                return StudentId;
            }
            set
            {
                StudentId = value;
            }
        }
        public string SName
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }
        }

        public void printDetails()
        {
            Console.WriteLine("Student id={0} ",SID);
            Console.WriteLine("Student Name= " + SName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s=new ConsoleApp12.Student();

            Console.Write("Enter student id ");
            s.SID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter name ");
            s.SName = Console.ReadLine();
            s.printDetails();
            Console.ReadKey();
        }
    }
}
