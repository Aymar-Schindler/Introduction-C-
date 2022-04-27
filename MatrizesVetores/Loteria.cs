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
    public class MenorValor
	{
		public static void Main ()
		{
    // Declaração de Variáveis
		int cont, maior = 0;
    do {
        cout << "digite um valor: ";
        cin >> cont;
        //Se o valor entrado for maior que o ultimo passa ele a ser o maior
        if(cont > maior)maior = cont;
    }while (cont != -1);
    cout << "o maior numero e: " << maior;
    return 0;
    }
  }    
}