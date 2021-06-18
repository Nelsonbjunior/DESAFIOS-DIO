/*

Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa 
o maior dos 3 lados. A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, 
sempre escrevendo uma mensagem adequada:

    se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
    se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
    se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
    se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
    se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
    se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES

Entrada

A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C (0 < C).

Saída

Imprima todas as classificações do triângulo especificado na entrada.

*/

using System;

namespace TiposTriângulos
{
	internal static class Program
	{
		private static void Main()
		{
			string[] entrada = Console.ReadLine().Split(' ');
			double.TryParse(entrada[0], out double lado1);
			double.TryParse(entrada[1], out double lado2);
			double.TryParse(entrada[2], out double lado3);
			double a, b, c;

			//verifica o maior lado
			if ((lado1 > lado2) && (lado1 > lado3))
			{
				a = lado1;
				if (lado2 > lado3)
				{
					b = lado2;
					c = lado3;
				}
				else
				{
					c = lado2;
					b = lado3;
				}
			}
			else if ((lado2 > lado1) && (lado2 > lado3))
			{
				a = lado2;
				if (lado1 > lado3)
				{
					b = lado1;
					c = lado3;
				}
				else
				{
					c = lado1;
					b = lado3;
				}
			}
			else
			{
				a = lado3;
				if (lado1 > lado2)
				{
					b = lado1;
					c = lado2;
				}
				else
				{
					c = lado1;
					b = lado2;
				}
			}

			//classifica o triângulo
			if (a >= b + c)
			{
				Console.WriteLine("NAO FORMA TRIANGULO");
			}
			else
			{
				if (a * a == (b * b) + (c * c))
				{
					Console.WriteLine("TRIANGULO RETANGULO");
				}
				else if (a * a > (b * b) + (c * c))
				{
					Console.WriteLine("TRIANGULO OBTUSANGULO");
				}
				else if (a * a < (b * b) + (c * c))
				{
					Console.WriteLine("TRIANGULO ACUTANGULO");
				}

				if ((a == b) && (b == c))
				{
					Console.WriteLine("TRIANGULO EQUILATERO");
				}
				else if ((a == b) ^ (b == c))
				{
					Console.WriteLine("TRIANGULO ISOSCELES");
				}
			}
		}
	}
}