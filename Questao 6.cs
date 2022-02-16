using System;

namespace ConsoleApplicationVSCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int HI, HF, MI, MF, HD, HR, MR;
            Console.WriteLine("Entre com hora inicial: ");
            HI = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com minuto inicial: ");
            MI = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a hora final: ");
            HF = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a minuto final: ");
            MF = int.Parse(Console.ReadLine());

            HI = HI * 60 + MI;
            HF = HF * 60 + MF;
            MR = 0;

            if (HI < HF)
            {
                HD = HF - HI;
            }
            else
            {
                HD = HI - 1440 - (HF);
            }

            if (HD < 0)
            {
                HD = HD * (-1);
            }

            MR = 0;

            if (HD >= 60)
            {
                HR = HD / 60;
                MR = HD % 60;
            }
            else
            {
                HR = 0;
                MR = HD;
            }



            Console.WriteLine("O tempo total foi de:  " + HR + " horas e " + MR + " minutos.");


        }
    }


}