using System;
using System.Collections.Generic;

namespace ConsoleApplicationVSCode
{
    class Q7
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>();
            int numeros, NumList;

            Console.WriteLine("Quantos valores deseja adcionar a lista?");
            numeros = int.Parse(Console.ReadLine());
            for (int i = 0; i < numeros; i++)
            {
                Console.WriteLine("Digite o valor " + i);

                NumList = int.Parse(Console.ReadLine());
                valores.Add(NumList);

            }

            for(int i = 0; i<numeros; i++)
            {
                if(valores[i]/2 == 0)
                    Console.WriteLine(valores[i]);

            }





        }
    }
}