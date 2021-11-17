using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calculator
    {
        public double Topla(double number1, double number2)
        {
            double sonuc = number1 + number2;
            return sonuc;
        }
        public double Cikar(double number1, double number2)
        {
            double sonuc = number1 - number2;
            return sonuc;
        }
        public double Carp(double number1, double number2)
        {
            double sonuc = number1 * number2;
            return sonuc;
        }
        public double Bol(double number1, double number2)
        {
            double sonuc = number1 / number2;
            return sonuc;
        }
    }
}
