/******************************************************************************************************
%  Code: 
%   OrdCrescente.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #2 - Introdução a Linguagem de Programação: Estruturas Condicionais
%   'Escrever um programa para ler 2 números e imprimi-los em ordem ascendente.'   
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
	class OrdCrescente
	{
		public static void Main ()
		{
			// Declaração de Variáveis
			int num1;
			int num2;

			// Entrada de Dados
			Console.Write ("Digite o primeiro número: ");
			num1 = int.Parse (Console.ReadLine ());

			Console.Write ("Digite o segundo número: ");
			num2 = int.Parse (Console.ReadLine ());

			// Estrutura Condicional
			if (num1 <= num2) {
				Console.WriteLine ("{0} {1}", num1, num2);
			} else {
				Console.WriteLine ("{0} {1}", num2, num1);
			}
		}

	}
}