using System;
using System.Collections.Generic;

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
            lemonadeStand.CostperCup = decimal.Parse(Console.ReadLine()); //***************

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

            //_+________________________________________-

            LemonadeStand stand2 = new LemonadeStand();

            stand2.Name = Console.ReadLine();
            stand2.NumbCups= Int32.Parse(Console.ReadLine());
            stand2.PriceCups = decimal.Parse(Console.ReadLine());
            stand2.CostperCup = decimal.Parse(Console.ReadLine());
            stand2.NumCostumers= Int32.Parse(Console.ReadLine());

            decimal revenue2 = stand2.PriceCups * stand2.NumCostumers;
            decimal totalExpenses2 = stand2.NumbCups * stand2.CostperCup;
            decimal totalProfit2 = revenue2 - totalExpenses2;

            //________________________________3____________________________

            LemonadeStand stand3 = new LemonadeStand();

            stand3.Name = Console.ReadLine();
            stand3.NumbCups= Int32.Parse(Console.ReadLine());
            stand3.PriceCups= decimal.Parse(Console.ReadLine());
            stand3.CostperCup= decimal.Parse(Console.ReadLine());
            stand3.NumCostumers= Int32.Parse(Console.ReadLine());

            decimal revenue3 = stand3.PriceCups * stand3.NumCostumers;
            decimal totalExpenses3 = stand3.NumbCups * stand3.CostperCup;
            decimal totalProfit3 = revenue2 - totalExpenses2;

            // LIST VERSION++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            List<LemonadeStand> locations = new List<LemonadeStand>();

            for (int i = 0; i < 5; i++)     //5 Locations
            {
                locations.Add(new LemonadeStand());
            }

          
            foreach (LemonadeStand stand in locations) ///locations?
            {

                //properties_________
                stand.Name = Console.ReadLine();
                stand.NumbCups = Int32.Parse(Console.ReadLine());
                stand.PriceCups = decimal.Parse(Console.ReadLine());
                stand.CostperCup = decimal.Parse(Console.ReadLine());
                stand.NumCostumers = Int32.Parse(Console.ReadLine());

                decimal revenueALL = stand.PriceCups * stand.NumCostumers;
                decimal totalExpensesALL = stand.NumbCups * stand.CostperCup;
                decimal totalProfitALL = revenueALL - totalExpensesALL;
            }
            //+++++++++++++++++++++++++++++++=

        }
    }
}
