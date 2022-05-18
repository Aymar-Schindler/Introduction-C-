/******************************************************************************************************
%  Code: 
%   MatrizTransposta.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #8 - Introdução a Linguagem de Programação: Matrizes e Vetores

IMPRIMIR Matriz Transposta
A transposta de uma matriz A é uma matriz que apresenta os mesmos elementos de A, só que colocados em uma posição diferente. Ela é obtida transportando-se ordenadamente os elementos das linhas de A para as colunas da transposta.

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
    static void MatrizAleatoria(int[,] matriz, int nLinha, int nColuna)
    {
      
      Random randNum = new Random(); 
      //Criando o objeto randNum da classe Random
      for(int linha = 0; linha < nLinha; linha++)
        for(int coluna = 0; coluna < nColuna; coluna++) 
          //usando o método Next() que retorna um número inteiro aleatório.
           matriz[linha,coluna] = randNum.Next(1,10); 
           //Se cria um valor randomico entre 1 e 10, para fugir do zero na diagonal principal
    
    }
    
    /*Imprimir Matrizes*/
    static void ImprimirMatriz(int[,] matriz, int nLinha, int nColuna)
    {
        //Impressão da matriz aleatoria      
        Console.WriteLine("Esta é a sua matriz aleatoria de dimensão {0} x {1}: \n", nLinha, nColuna);
        for(int linha = 0; linha < nLinha; linha++){
          for(int coluna = 0; coluna < nColuna; coluna++){   
            Console.Write("{0}\t", matriz[linha,coluna]);
          }
          Console.Write("\n");   
        }
        Console.Write("\n"); 

        //Impressão da matriz transposta
        Console.WriteLine("Esta é a Matriz Transposta de dimensão {0} x {1}: \n", nColuna, nLinha);
        for(int coluna = 0; coluna < nColuna; coluna++){   
          for(int linha = 0; linha < nLinha; linha++){ 
            Console.Write("{0}\t", matriz[linha,coluna]);
          }
          Console.Write("\n");   
        }
        Console.Write("\n"); 
      
    }

    static void Main()
    {
      Console.Write("Informe a quantidade de linhas que deseja da matriz aleatoria: ");
      int nLinha;
       nLinha = int.Parse(Console.ReadLine());
      Console.Write("\n"); 
      
      Console.Write("Informe a quantidade de colunas que deseja da matriz aleatoria: ");
      int nColuna;
       nColuna = int.Parse(Console.ReadLine());
      Console.Write("\n"); 
       int[,] matriz = new int[nLinha, nColuna];

 
      MatrizAleatoria(matriz, nLinha, nColuna);
      ImprimirMatriz(matriz, nLinha, nColuna);
    }/*main*/
   }
 }

