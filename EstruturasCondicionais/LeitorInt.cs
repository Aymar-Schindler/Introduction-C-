/******************************************************************************************************
%  Code: 
%   LeitorInt.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #1 - Introdução a Linguagem de Programação: Estruturas Condicionais
%   'O número 3025 tem uma propriedade interessante: 30 + 25 = 55  e  (55)2  = 3025. 
%   Escreva um programa que lê um número inteiro e determinar se ele possui ou não 
%   essa propriedade.'   
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
	class LeitorInt
	{
		public static void Main ()
		{
			// Declaração de Variáveis
			int num;
			int part1;
			int part2;

			// Entrada de Dados
			Console.WriteLine ("Digite abaixo um número inteiro de 4 dígitos: ");
			num = int.Parse (Console.ReadLine ());

			// Separação dos dígitos
			part1 = num / 100;
			part2 = num - (part1 * 100);

			Console.WriteLine ("Primeira parte do número é: " + part1);
			Console.WriteLine ("Segunda parte do número é: " + part2);

			// Condicional
            // Poderia usar também (part1 + part2)*(part1 + part2) 
            // Em CS não há operador específico para expoente
			if (Math.Pow (part1 + part2, 2) == num) {
				Console.WriteLine ("O número {0} possui a propriedade.", num);
			} else {
				Console.WriteLine ("O número {0} não possui a propriedade.", num);
			}
	
		}

	}
}
