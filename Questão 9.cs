using System;
 
namespace ConsoleApplicationVSCode
{
    class Q9
    {
        static void Main(string[] args)
        {
           int a;
           Console.WriteLine("de qual numero voce deseja saber a tabuada?");
           a = int.Parse(Console.ReadLine());

           for (int i =0; i <= 10; i++) {
               Console.WriteLine( a + " x " + i + " = " +  a*i);

            }

        }
    }
}