using System;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello !");
            Console.WriteLine("Enter the name of your lemonade stand");
            string standName = Console.ReadLine();

            Console.WriteLine("How many cups will you sell?");
            int numCups = Int32.Parse(Console.ReadLine());

            Console.WriteLine("How many Customers do you predict?");
            int numCustomers = Int32.Parse(Console.ReadLine());

            Console.WriteLine("How much does each cup cost?");
            int priceCups = Int32.Parse(Console.ReadLine());

            int totalRevenue = numCups * priceCups;

            Console.WriteLine("Your total revennue would be"+totalRevenue);

            Console.ReadLine();

        }
    }
}
