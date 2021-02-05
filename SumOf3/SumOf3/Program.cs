using System;

namespace SumOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            const Double MAGIC_NUMBER = 7.777;//local constant variable
            double number_1;
            double number_2;
            double number_3;
            double SUM;
            double Product;


            Console.WriteLine("Enter a number");
            number_1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            number_2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a third number");
            number_3 = Convert.ToDouble(Console.ReadLine());

            SUM = number_1 + number_2 + number_3;
            Console.WriteLine("The sum is" + SUM.ToString("N3"));

            Product = MAGIC_NUMBER * SUM;

            Console.WriteLine("The product is" + Product.ToString("N3"));
        }
    }
}
