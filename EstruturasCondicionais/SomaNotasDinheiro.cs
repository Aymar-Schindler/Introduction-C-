/******************************************************************************************************
%  Code: 
%   SomaNotasDinheiro.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #8 - Introdução a Linguagem de Programação: Estruturas Condicionais
%   'Escreva um programa para contar dinheiro, que
%   pergunte dentro de um monte de dinheiro qual a quantidade de
%   notas de 1 real, 5 reais, 10 reais, 50 reais e 100 reais. Em seguida
%   imprima o valor total em dinheiro.'   
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
    class SomaNotasDinheiro
	{
		public static void Main ()
		{
			// Declaração de Variáveis
            int nota1, nota5, nota10, nota50, nota100;

			// Entrada de Dados
			Console.WriteLine ("Digite abaixo a quantidade de cada nota que possui, ao final terá o valor total em mãos: ");
			Console.Write ("Nota de 1 real: ");
            nota1 = int.Parse (Console.ReadLine ());
            Console.Write ("Nota de 5 reais: ");
            nota5 = int.Parse (Console.ReadLine ());
            Console.Write ("Nota de 10 reais: ");
            nota10 = int.Parse (Console.ReadLine ());
            Console.Write ("Nota de 50 reais: ");
            nota50 = int.Parse (Console.ReadLine ());
            Console.Write ("Nota de 100 reais: ");
            nota100 = int.Parse (Console.ReadLine ());

            //Saída com valor total que poderia ser feita também usando estruturas condicionais
            Console.WriteLine ("O valor total que possue em mãos é: {0}", nota1 + nota5*5 + nota10*10 + nota50*50 + nota100*100);	
		}
	}
}