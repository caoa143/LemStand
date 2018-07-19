using System;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {

            //new stuff__________________________________________

            LemonadeStand lemonadeStand = new LemonadeStand();




            //_______________________________________________
            Console.WriteLine("Hello !");
            Console.WriteLine("Enter the name of your lemonade stand");
            //string standName = Console.ReadLine();
            lemonadeStand.Name = Console.ReadLine();//************************

            Console.WriteLine("Your Lem Stand will be named: " + lemonadeStand.Name);//*************



            Console.WriteLine("How many cups will you sell?");
           // int numCups = Int32.Parse(Console.ReadLine());
           lemonadeStand.NumbCups = Int32.Parse(Console.ReadLine()); //*********


            Console.WriteLine("How many Customers do you predict?");
            int numCustomers = Int32.Parse(Console.ReadLine());

            Console.WriteLine("How much will you sell each cup for?");
            // int priceCups = Int32.Parse(Console.ReadLine());
            lemonadeStand.PriceCups = decimal.Parse(Console.ReadLine());//***************

            Console.WriteLine("How much will each cup cost to make? ");
            lemonadeStand.CostperCup = decimal.Parse(Console.ReadLine());

            //___________________
            decimal totalRevenue = lemonadeStand.NumbCups * lemonadeStand.PriceCups;
            decimal totalExpenses = lemonadeStand.NumbCups * lemonadeStand.CostperCup;
            decimal totalProfit = totalRevenue - totalExpenses;

            //__________________


           // int totalRevenue = numCups * priceCups;

            Console.WriteLine("Your total revennue would be"+totalRevenue);
            Console.WriteLine("Your total expenses would be" + totalExpenses);
            Console.WriteLine("Your total expenses would be" + totalProfit);

            Console.ReadLine();

        }
    }
}
