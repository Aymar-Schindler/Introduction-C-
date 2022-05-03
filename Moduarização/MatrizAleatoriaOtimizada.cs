/******************************************************************************************************
%  Code: 
%   MatrizAleatoriaOtimizada.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #2 - Introdução a Linguagem de Programação: Modularizacao
%   Otimizar o código de Matriz Aleatória de números do Ex1
%
%  Modified:
%   May 02 2022 10:00 
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
    static void MatrizAleatoriaOtimazada(int[,] matriz)
    {
      for(int linha = 0; linha < matriz.GetLength(0); linha++)
        for(int coluna = 0; coluna < matriz.GetLength(1); coluna++)    
           matriz[linha,coluna] =  linha + coluna;   
    
    }/*MatrizAleatoria*/

    static void ImprimirMatriz(int[,] matriz)
    {
        for(int linha = 0; linha < matriz.GetLength(0); linha++){
          for(int coluna = 0; coluna < matriz.GetLength(1); coluna++){    
            Console.Write("{0}\t", matriz[linha,coluna]);   
          }
          Console.Write("\n");   
        }
  
       Console.Write("\n"); 

    }/*ImprimirMatriz*/



    static void Main()
    {

      int[,] matriz = new int[4, 4];

      Console.WriteLine ("Matriz Aleatoria");  
      MatrizAleatoriaOtimazada(matriz);
      ImprimirMatriz(matriz);

    } 
  }
}
