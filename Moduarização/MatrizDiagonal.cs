/******************************************************************************************************
%  Code: 
%   MatrizDiagonal.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #2 - Introdução a Linguagem de Programação: Matrizes e Vetores
IMPRIMIR MATRIZ DIAGONAL.
  Para que uma matriz seja diagonal ela deverá ser uma matriz quadrada, então uma matriz diagonal é uma matriz quadrada onde os elementos que não pertencem à diagonal principal são obrigatoriamente iguais a zero. 
%
%  Modified:
%   May 05 2022 10:00 
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
    
    /*ImprimirMatriz*/
    static void ImprimirMatriz(int[,] matriz, int n)
    {
        for(int linha = 0; linha < n; linha++){
          for(int coluna = 0; coluna < n; coluna++){   
            if(coluna == linha){ 
            //qdo é igual numero é aleatorio, ou seja, preenche só diagonal
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
