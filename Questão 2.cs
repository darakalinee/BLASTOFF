using System;

namespace ConsoleApplicationVSCode
{
    class q2
    {
        static void Main(string[] args)
        {
            double a, b;
            double ConsumoMedio;
            Console.WriteLine("Entre com a distancia percorrida em km: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o combustível gasto em litros: ");
            b = double.Parse(Console.ReadLine());

            ConsumoMedio = a / b;

            Console.WriteLine("O consumo médio é: " + ConsumoMedio + " km/l");


        }
    }
}