using System;

namespace ConsoleApplicationVSCode
{
    class q1
    {
        static void Main(string[] args)
        {
            int a, b, c, x, y;
            double media;
            Console.WriteLine("Entre com a idade 1: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a idade 2: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a idade 3: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a idade 4: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a idade 5: ");
            y = int.Parse(Console.ReadLine());


            media = (a + b + c + x + y) / 5;
            Console.WriteLine("a média é " + media);


        }
    }
}