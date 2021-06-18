/*

Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. 
Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, 
caso haja uma divisão por 0 ou raiz de numero negativo.

Entrada

Leia três valores de ponto flutuante (double) A, B e C.

Saída

Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular". 
Caso contrário, imprima o resultado das raízes com 5 dígitos após o ponto, com uma mensagem correspondente 
conforme exemplo abaixo. Imprima sempre o final de linha após cada mensagem.

*/

using System;

class bhaskara
{
    static void Main(string[] args)
    {
      string[] entrada = Console.ReadLine().Split();    
      double a, b, c, delta, r1, r2;
      
      a = Convert.ToDouble(entrada[0]);
      b = Convert.ToDouble(entrada[1]);
      c = Convert.ToDouble(entrada[2]);

      delta = b * b - 4 * a * c;
      r1 = (-b + Math.Sqrt(delta)) / (2 * a);
      r2 = (-b - Math.Sqrt(delta)) / (2 * a);

      if (a == 0 || delta < 0 )
      {
        Console.WriteLine("Impossivel calcular");
      }
      else
      {
        Console.WriteLine("R1 = {0}", Math.Round(r1,5));
        Console.WriteLine("R2 = {0}", Math.Round(r2,5));
      }
         
    }
}