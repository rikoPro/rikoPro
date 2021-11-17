using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Sayıyı Giriniz : ");
            string n1 = Console.ReadLine();
            
            double number1 = Convert.ToDouble(n1);
            Type t = number1.GetType();
            if (t.Equals(typeof(double)))
            {

            }
            else
            {
                Console.WriteLine("Lütfen bir sayı giriniz!");
            }
            
            {

            }

        }
    }
}
