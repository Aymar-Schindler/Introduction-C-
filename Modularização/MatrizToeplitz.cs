/******************************************************************************************************
%  Code: 
%   MatrizToeplitz.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #4 - Introdução a Linguagem de Programação: Matrizes e Vetores
IMPRIMIR Matriz de Toeplitz
   Uma matriz de Toeplitz ou matriz de diagonais constantes, chamada assim em homenagem a Otto Toeplitz, é uma matriz em que cada diagonal descendente da esquerda para a direita tem valor constante. 
%
%  Modified:
%   May 10 2022 10:00 
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
      
      Random randNum = new Random(); 
      //Criando o objeto randNum da classe Random
      for(int linha = 0; linha < n; linha++)
        for(int coluna = 0; coluna < n; coluna++) 
          //usando o método Next() que retorna um número inteiro aleatório.
           matriz[linha,coluna] = randNum.Next(1,10); 
           //Se cria um valor randomico entre 1 e 10, para fugir do zero na diagonal principal
    
    }
    
    /*Imprimir Matriz de Toeplitz*/
    static void ImprimirMatriz(int[,] matriz, int n)
    {
         for(int linha = 0; linha < n; linha++){
          for(int coluna = 0; coluna < n; coluna++){ 
            if (linha == 0){
              Console.Write("{0}\t", matriz[linha,coluna]);
            //Condição para formar apenas a primeira linha que será referencia para as demais  
            }else {
              //Se nao for linha 0, ou seja, primeira linha, faz a alteração do valor 
              matriz[linha, coluna] = matriz[linha - 1, Math.Abs(coluna - 1)];
              //abs (modulo) pq qd chega na segunda linha temos que evitar o (0-1)
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
      Console.Write("Informe a dimensão da matriz quadrada de Toeplitz que deseja ser gerada aleatoriamente: ");
      int n;
       n = int.Parse(Console.ReadLine());
      int[,] matriz = new int[n, n];
      Console.Write("\n");  

      Console.WriteLine ("Matriz de Toeplitz Aleatória: \n");  
      MatrizAleatoria(matriz, n);
      ImprimirMatriz(matriz, n);
    }/*main*/
   }
 }
