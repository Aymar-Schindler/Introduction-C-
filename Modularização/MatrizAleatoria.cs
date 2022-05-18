/******************************************************************************************************
%  Code: 
%   MatrizAleatoria.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #1 - Introdução a Linguagem de Programação: Modularizacao
%   Matriz Aleatória de números
%
%  Modified:
%   May 01 2022 10:00 
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
    static void MatrizAleatoria(int[,] matriz, int n)
    {

      for(int linha = 0; linha < n; linha++)
        for(int coluna = 0; coluna < n; coluna++)    
           matriz[linha,coluna] =  linha + coluna;   
    
    }/*MatrizAleatoria*/

    static void ImprimirMatriz(int[,] matriz, int n)
    {
        for(int linha = 0; linha < n; linha++){
          for(int coluna = 0; coluna < n; coluna++){    
            Console.Write("{0}\t", matriz[linha,coluna]);   
          }
          Console.Write("\n");   
        }
  
       Console.Write("\n"); 

    }/*ImprimirMatriz*/



    static void Main()
    {

      int[,] matriz = new int[4, 4];
      int n = 4;

      Console.WriteLine ("Matriz Aleatoria");  
      MatrizAleatoria(matriz, n);
      ImprimirMatriz(matriz, n);


    }/*main*/
    
  }
}
