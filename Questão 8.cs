using System;
 
namespace ConsoleApplicationVSCode {
  class Q8 {
    static void Main(string[] args) {
      bool primo = true;

      int numero;
 
      Console.Write("Informe um número inteiro positivo: ");
      numero = int.Parse(Console.ReadLine());
 
      if (numero < 0) {
        Console.WriteLine("Número inválido.");
      }

      else if ((numero == 0) || (numero == 1)) {
        Console.WriteLine("Número válido, mas não é primo.");
      }
      else {
        for (int i = 2; i <= (numero / 2); i++) {
          // se passar no teste, não é primo
          if (numero % i == 0) {
            primo = false; // recebe false
              break;
          }
        }
 
        if (primo) {
          Console.WriteLine("O número informado é primo");
        }
        else {
          Console.WriteLine("O número informado não é primo");
        }
      }
 
    
    }
  }
}