/******************************************************************************************************
%  Code: 
%   MatrizIdentidade.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #3 - Introdução a Linguagem de Programação: Matrizes e Vetores
IMPRIMIR MATRIZ Identidade.
  Para que uma matriz seja Identidade ela deverá ser uma matriz quadrada, com elementos da diagonal principal igual a 1 e os demais iguais a zero. 
%
%  Modified:
%   May 9 2022 10:00 
%
%  Author:
%   Aymar Schindler  <aymarschindler 'at' hotmail.com>
%
%  How to Compile/Execute:
%   vs code
%   replit.com
%
******************************************************************************************************/

using System;

namespace IntroCS
{ 
  public class RepositorioMatrizes
  {  
    
    /*MatrizAleatoria*/
    static void MatrizAleatoria(int[,] matriz, int n)
    {
      for(int linha = 0; linha < n; linha++)
        for(int coluna = 0; coluna < n; coluna++) 
           matriz[linha,coluna] = 1; 
           //valores da diagonal serão iguais a 1
    
    }
    
    /*ImprimirMatriz*/
    static void ImprimirMatriz(int[,] matriz, int n)
    {
        for(int linha = 0; linha < n; linha++){
          for(int coluna = 0; coluna < n; coluna++){   
            if(coluna == linha){ 
            //qdo é igual numero de indice de coluna com linha é igual a 1, ou seja, preenche só diagonal
            Console.Write("{0}\t", matriz[linha,coluna]);   
            }else{
            matriz[linha,coluna] = 0; 
            //qdo é diferente não é diagonal, então preenche com zero
            Console.Write("{0}\t", matriz[linha,coluna]);
            }
          }  
          Console.Write("\n");   
        }
        Console.Write("\n"); 
    }

    static void Main()
    {
      //recebimento do tamanho da matriz que tem que ser quadrada para existir diagonal
      Console.Write("Informe a dimensão da matriz quadrada que deseja ser gerada aleatoriamente: ");
      int n;
       n = int.Parse(Console.ReadLine());
      int[,] matriz = new int[n, n];
      Console.Write("\n");  

      Console.WriteLine ("Matriz Aleatória\n");  
      MatrizAleatoria(matriz, n);
      ImprimirMatriz(matriz, n);
    }/*main*/
   }
 }
