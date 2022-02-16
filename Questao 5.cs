using System;

namespace ConsoleApplicationVSCode
{
    class q5
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Entre com o numero 1: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o numero 2: ");
            b = double.Parse(Console.ReadLine());

            if (a % b == 0 || b % a == 0)
                Console.WriteLine("Os numeros " + a + " e " + b + " são múltiplos");
            else
                Console.WriteLine("Os numeros " + a + " e " + b + " não são múltiplos");




        }
    }
}