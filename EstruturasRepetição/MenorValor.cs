/******************************************************************************************************
%  Code: 
%   MenorValor.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #3 - Introdução a Linguagem de Programação: Estruturas de Repetição
%   'Escrever um programa que, dado um conjunto de números
inteiros positivos, determine qual o menor valor do conjunto. O final do
conjunto de valores é conhecido através do valor zero (0), que não deve
ser considerado.'   
%
%  Modified:
%   April 08 2022 10:00 
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