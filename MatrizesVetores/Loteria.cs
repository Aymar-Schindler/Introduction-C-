/******************************************************************************************************
%  Code: 
%   Loteria.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #1 - Introdução a Linguagem de Programação: Matrizes e Vetores
    O programa deverá ser capaz cumprir os seguintes requisitos:
• Ler as apostas referentes a 13 jogos;
• Permitir que o jogador aposte na vitória do primeiro time (coluna 1), no empate (coluna
2) e/ou na vitória do segundo time (coluna 3);
• Ler o resultado oficial dos jogos (simulação);
• Os valores 0 ou 1 devem ser utilizados para preencher (internamente) duas matrizes:
– Matriz de apostas realizadas (o valor 1 indica uma aposta realizada); 
– Matriz de resultados oficiais dos jogos (o valor 1 indica um resultado).
• Comparar o resultado oficial com as apostas realizadas;
• Informar quantos pontos o jogador fez (resultados acertados). 
%
%  Modified:
%   April 25 2022 10:00 
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
    public class Loteria
  {  
    static void Main()
    {
      int[,] matrix = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
      int linha, coluna, DIAGPRINC=0, SUB=0, SUPER=0;

      Console.Write("\n"); 

      /* Print matrix */
      for(linha = 0; linha < 4;linha++){
        for(coluna = 0; coluna < 4; coluna++){     
          Console.Write("{0}\t", matrix[linha,coluna]);   
        }
      Console.Write("\n"); 
      }

      /* Calculate add matrix */
      for(linha = 0; linha < 4;linha++){
        for(coluna = 0; coluna < 4; coluna++){ 
          
          if (linha == coluna)
               DIAGPRINC = DIAGPRINC + matrix[linha, coluna];
  
          if (linha == coluna - 1)
              SUB = SUB + matrix[linha, coluna];
  
          if (linha == coluna + 1)
              SUPER = SUPER + matrix[linha, coluna];     
    
        }  
      }    
    
      Console.Write("\n"); 

      /* Print Results */
      Console.WriteLine ("A soma da DIAGONAL PRINCIPAL Ã© {0}", DIAGPRINC);   
      Console.WriteLine ("A soma da SUBDIAGONAL Ã© {0}", SUB);   
      Console.WriteLine ("A soma da SUPERDIAGONAL Ã© {0}", SUPER);   

    }/*main*/
  }
}