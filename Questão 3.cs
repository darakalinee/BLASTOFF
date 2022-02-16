using System;

namespace ConsoleApplicationVSCode
{
    class q3
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int menor = 999999999;
            Console.WriteLine("Entre com o primeiro num: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o segundo num:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o terceiro num:");
            c = int.Parse(Console.ReadLine());

            if (a < b && a < c)
                menor = a;
            else if(b < a && b < c)
                menor = b;
            else
                menor = c;

            Console.WriteLine("o menor num é " + menor);


        }
    }
}