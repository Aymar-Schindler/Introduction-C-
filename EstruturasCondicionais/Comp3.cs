/******************************************************************************************************
%  Code: 
%   Comp3.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #4 - Introdução a Linguagem de Programação: Estruturas Condicionais
%   'Escrever um programa para ler 3 números inteiros e imprimir o
%    maior deles.'   
%
%  Modified:
%   April 05 2022 10:00 
%
%  Author:
%   Aymar Schindler  <aymarschindler 'at' hotmail.com>
%
%  How to Compile/Execute:
%   vs code
%
******************************************************************************************************/

using System;

namespace IntroCS
{
    class Comp3
	{
		public static void Main ()
		{
			// Declaração de Variáveis
			int num1;
            int num2;
            int num3;

			// Entrada de Dados
			Console.Write ("Digite o primeiro número inteiro: ");
			num1 = int.Parse (Console.ReadLine ());
            Console.Write ("Digite o segundo número inteiro: ");
			num2 = int.Parse (Console.ReadLine ());
            Console.Write ("Digite o terceiro número inteiro: ");
			num3 = int.Parse (Console.ReadLine ());

			//Condicional
			if (Math.Max (num1, num2) >= num3) {
				Console.WriteLine ("O número {0} é o maior dos três digitados.", Math.Max (num1, num2));
			} else {
				Console.WriteLine ("O número {0} é o maior dos três digitados.", num3);
			}
		}
	}
}