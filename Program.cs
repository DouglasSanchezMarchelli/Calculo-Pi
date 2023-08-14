using System;

namespace CalcularPi
{
 class Program
 {
 static void Main(string[] args)
 {
  int n = 1000000; // Número de términos en la serie (puedes ajustar este valor)
  double pi = CalculatePi(n);

  Console.WriteLine($"Valor calculado de π: {pi}");
  }

  static double CalculatePi(int n)
   {
   double pi = 0.0;

   for (int i = 0; i < n; i++)
   {
   double termino = 4.0 / (2 * i + 1);

    if (i % 2 == 0)
    {
    pi += termino;
     }
    else
     {
     pi -= termino;
    }
   }

 return pi;
   }
  }
}

