using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task_day_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SmallCarpets = 25;
            int LargeCarpets = 35;
            double TaxRate = 0.06;

            Console.WriteLine("Welcome to Islam's Carpet Cleaning Service!");
            Console.WriteLine();                                   

            Console.WriteLine("Estimate for carpet cleaning service");

            Console.WriteLine("Number of small carpets:");
            int numS = Convert.ToInt32(Console.ReadLine());         //numS --> number of small carpets

            Console.WriteLine("Number of large carpets:");
            int numL = Convert.ToInt32(Console.ReadLine());         //numL --> number of large carpets

            Console.WriteLine($"Price per small carpet : ${SmallCarpets }" );
            Console.WriteLine($"Price per large carpet : ${LargeCarpets }" );

            int Cost = (numS * SmallCarpets) + (numL * LargeCarpets);
            Console.WriteLine($"Cost : ${Cost} ");

            double Tax = (Cost *  TaxRate);
            Console.WriteLine($"Tax : ${Tax:F1} ");                 // F1 --> لاقرب رقم عشري واحد 

            Console.WriteLine("==============================================");

            Console.WriteLine($"Total estimate: ${Cost + Tax} ");
            Console.WriteLine();

            Console.WriteLine("This estimate is valid for 30 days");

        }
    }
}