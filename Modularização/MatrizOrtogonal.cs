/******************************************************************************************************
%  Code: 
%   MatrizOrtogonal.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #5 - Introdução a Linguagem de Programação: Matrizes e Vetores

Verificar se a Matriz é Ortogonal
O determinante de uma matriz ortogonal é +1 ou -1. Para simplificar o exemplo, simulamos uma matriz quadrada 2x2, em que o determinante é dado pelo produto dos elementos da diagonal principal menos o produto dos elementos da diagonal secundária.

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
           matriz[linha,coluna] = randNum.Next(-10,10); 
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
        int diagonalP = 1, diagonalS = 1;   
        for(int coluna = 0; coluna < nColuna; coluna++){   
          for(int linha = 0; linha < nLinha; linha++){ 
             if (linha == coluna){
              diagonalP = diagonalP * matriz[linha,coluna];
                    
   
              }if (coluna == (nColuna - 1 - linha)){
                diagonalS = diagonalS * matriz[linha,coluna];
                    
              }
            }
          Console.Write("\n");   
        }
        Console.Write("o valor do produto da diagonal principal é: "); 
        Console.WriteLine(diagonalP);
        Console.Write("\n");
        Console.Write("o valor do produto da diagonal secundária é: "); 
        Console.WriteLine(diagonalS); 
        Console.Write("\n");
        Console.WriteLine("o valor da determinante é: {0} \n", (diagonalP - diagonalS));
        if ((diagonalP - diagonalS) == 1  || (diagonalP - diagonalS) == -1 ){
           Console.Write("A matriz é Ortogonal, já que sua determinante é 1 ou -1");
        } else{
           Console.Write("A matriz não é Ortogonal, já que sua determinante é diferente 1 ou -1");
        }
    }

    static void Main()
    {
      int nLinha=2;
      int nColuna=2;
       int[,] matriz = new int[nLinha, nColuna];

 
      MatrizAleatoria(matriz, nLinha, nColuna);
      ImprimirMatriz(matriz, nLinha, nColuna);
    }/*main*/
   }
 }
