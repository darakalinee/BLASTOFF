using System;

namespace ConsoleApplicationVSCode
{
    class Q10
    {
        static void Main(string[] args)
        {
            int a;
            int fat = 1;
            Console.WriteLine("de qual numero voce deseja saber o fatorial?");
            a = int.Parse(Console.ReadLine());
            while (a < 0)
            {
                Console.WriteLine("Número inválido, tente novamente");
            }
            while (a > 0)
            {
                fat = fat * a;
                a--;

            }

            Console.WriteLine("O resultado é: " + fat);



        }
    }
}