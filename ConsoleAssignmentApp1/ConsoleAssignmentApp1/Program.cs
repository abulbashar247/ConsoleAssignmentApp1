using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAssignmentApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "";
            int Phone_Number;
            int Age;
            string Address = "";
            
            Console.WriteLine("Enter Your Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Your Phone Number:");
            Phone_Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Address:");
            Address = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Show My Details");
            Console.WriteLine("MY Name Is : " + Name);
            Console.WriteLine("My Phone Number : " + Phone_Number);
            Console.WriteLine("My Age : " + Age);
            Console.WriteLine("My Address is: " + Address);

            Console.ReadLine();
        }
    }
}
