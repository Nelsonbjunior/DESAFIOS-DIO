/*

Faça um algoritmo para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo. 
O último dado, que não entrará nos cálculos, contém o valor de idade negativa. Calcular e imprimir a idade média deste grupo de indivíduos.

Entrada

A entrada contém um número indeterminado de inteiros. A entrada será encerrada quando um valor negativo for lido.

Saída

A saída contém um valor correspondente à média de idade dos indivíduos.
A média deve ser impressa com dois dígitos após o ponto decimal.


*/

import java.util.Scanner;

public class Idades 
{

  public static void main(String[] args) 
  {

    Scanner input = new Scanner(System.in);
    int n;
    int count=0;
    double s = 0.0;

      n = input.nextInt();

          while(true) 
          {
                if(n > 0 ) 
                {
                  s += n;
                  count++;
                }
              else
                  break;
          
          n = input.nextInt();
            
          }

     System.out.println(String.format("%.2f", s / count));

  }

}