/******************************************************************************************************
%  Code: 
%   Paridade.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #3 - Introdução a Linguagem de Programação: Estruturas Condicionais
%   'Escrever um programa para ler um número inteiro e identificar se  
%    ele é par ou impar, escrevendo a mensagem correspondente.'   
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
    class Paridade
	{
		public static void Main ()
		{
			// Declaração de Variáveis
			int num;

			// Entrada de Dados
			Console.Write ("Digite um número inteiro: ");
			num = int.Parse (Console.ReadLine ());

			// Condicional
            //o operador resto '%' irá retornar zero caso seja par
			if (num%2 == 0) {
				Console.WriteLine ("O número {0} é PAR.", num);
			} else {
				Console.WriteLine ("O número {0} é IMPAR.", num);
			}
		}
	}
}