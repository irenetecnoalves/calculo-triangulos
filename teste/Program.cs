using System;
using System.Configuration;

namespace teste
{
    class Program
    {

        public static void Main()
        {
            string[] s = Console.ReadLine().Split(' ');
            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);

            //continue a solucao
            if ((b > a) && (b > c) && (c < a))
                Console.WriteLine("NAO FORMA TRIANGULO");

            else if ((b > a) && (b < c) && (c > a))
                Console.WriteLine("TRIANGULO RETANGULO");

            else if ((a == b) && (b < c) && (c > a))
                Console.WriteLine("TRIANGULO OBTUSANGULO");

            else if ((b <= a) && (b <= c) && (c == a))
                Console.WriteLine("TRIANGULO ACUTANGULO");

            if ((a == b) && (b == c) && (c == a))
                Console.WriteLine("TRIANGULO EQUILATERO");

            if ((a >= b) && (b < c ) && (c>= a))

                Console.WriteLine("TRIANGULO ISOSCELES");
            
            Console.ReadLine();
        }
    }
}

