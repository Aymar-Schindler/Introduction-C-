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
      //Declação da Matriz Resultados
      int[,] ResultadosOficiais = new int[13, 3];
      //Declação da Matriz Apostas
      int[,] ApostasRealizadas = new int[13, 3];
      //Variáveis Auxiliares
      int linha, coluna, pontuacao=0, aposta;
      //Variável auxiliar randômica
      var random = new Random();
  
      Console.Write("\n"); 

      //Entrada de Dados com insercao na matriz das apostas
      for(linha = 0; linha < 13;linha++){
      Console.Write("Para o jogo de número {0} digite '0' para vitória do primeiro time, '1' para empate ou '2' para vitória do segundo time: ", (linha + 1));
			aposta = int.Parse(Console.ReadLine ());
        switch(aposta) {
          //lançamento da aposta de vitória do primeiro time
          case 0:
            ApostasRealizadas[linha,0] = 1;
            ApostasRealizadas[linha,1] = 0;
            ApostasRealizadas[linha,1] = 0;
            break;
          //lançamento da aposta do empate  
          case 1:
            ApostasRealizadas[linha,0] = 0;
            ApostasRealizadas[linha,1] = 1;
            ApostasRealizadas[linha,1] = 0;
            break;
          //lançamento da aposta de vitória do segundo time
          case 2:
            ApostasRealizadas[linha,0] = 0;
            ApostasRealizadas[linha,1] = 0;
            ApostasRealizadas[linha,1] = 1;
            break;
          //inserção de valor inválido
          default:
            Console.WriteLine("Número inválido para inserir sua aposta!");
            break;
        }
      Console.Write("\n"); 
      }

      //Impressão de Apostas Realizadas
      Console.WriteLine("Segue abaixo o seu cartão de apostas: \n");
      for(linha = 0; linha < 13;linha++){
        for(coluna = 0; coluna < 3; coluna++){     
          Console.Write("{0}\t", ApostasRealizadas[linha,coluna]);   
        }
        Console.Write("\n"); 
      }
      Console.Write("\n");
      
      //Loop para randomizar os resultados
      for(linha = 0; linha < 13;linha++){
          coluna = random.Next()%3;   
          ResultadosOficiais[linha,coluna] = 1;
      }
      
      //Impressão dos Resultados Oficiais
      Console.WriteLine("O resultado saiu! Veja o cartão de Resultados Oficiais abaixo: \n");
      for(linha = 0; linha < 13;linha++){
        for(coluna = 0; coluna < 3; coluna++){     
          Console.Write("{0}\t", ResultadosOficiais[linha,coluna]);   
        }
        Console.Write("\n"); 
      }
      Console.Write("\n");
      
      //Comparação das Duas Matrizes
      for(linha = 0; linha < 13;linha++){
         for(coluna = 0; coluna < 3; coluna++){
            if(ResultadosOficiais[linha,coluna] == 1) {
               if(ResultadosOficiais[linha,coluna] == ApostasRealizadas[linha,coluna]) {
                  pontuacao++;
               }
            }
         }
      }
      Console.Write("\n");

      //Impressão dos pontos
      Console.WriteLine("PARABÉNS! Apostador, você conseguiu alcançar nas apostas acima {0} pontos \n!", pontuacao);
    }
  }
}