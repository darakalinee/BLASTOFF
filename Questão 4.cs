using System;

namespace ConsoleApplicationVSCode
{
    class q4
    {
        static void Main(string[] args)
        {
            int c;
            double TempEmF;
            Console.WriteLine("Entre com a temperatura C: ");
            c = int.Parse(Console.ReadLine());
            //a formula do enunciado seria pra pegar uma temperatura em F e transformar em C. 
            //Se eu tenho o valor de C e quero achar F, foi necessario realizar a manipulação da fórmula
            TempEmF = ((9 * c) / 5) + 32;

            Console.WriteLine("A temperatura convertida é: " + TempEmF + "F");


        }
    }
}