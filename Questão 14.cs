using System;
using System.Linq;

namespace ConsoleApplicationVSCode
{
    class Q14
    {
        public static bool checkPalindrome(string mainString)
        {
            string firstHalf = mainString.Substring(0, mainString.Length / 2);
            char[] arr = mainString.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string secondHalf = temp.Substring(0, temp.Length / 2);

            return firstHalf.Equals(secondHalf);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com uma palavra palindrome");
            string palavra;
            palavra = Console.ReadLine();
            bool palindrome = checkPalindrome(palavra);
            Console.WriteLine(palindrome);
        }
    }
}