/******************************************************************************************************
%  Code: 
%   NotasMinimasDinheiro.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #9 - Introdução a Linguagem de Programação: Estruturas Condicionais
%   'Escreva um programa que faça o inverso da questão
%    anterior, ou seja, solicite ao usuário um valor (total) em dinheiro, e
%    informe quantas notas de 1 real, 5 reais, 10 reais, 50 reais e 100
%    reais são necessárias para compor este valor, de forma que sejam
%    utilizadas o menor número de notas possível..'   
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
    class NotasMinimasDinheiro
	{
		public static void Main ()
		{
			// Declaração de Variáveis
            double vt, nota1, nota5, nota10, nota50, nota100;

			// Entrada de Dados
			Console.WriteLine ("Digite abaixo o valor total em mãos: ");
            vt = double.Parse (Console.ReadLine ());  
            nota100 = Math.Truncate(vt/100); 
            nota50 = Math.Truncate((vt - nota100*100)/50);
            nota10 = Math.Truncate((vt - nota100*100 - nota50*50)/10);
            nota5 = Math.Truncate((vt - nota100*100 - nota50*50 - nota10*10)/5);
            nota1 = Math.Truncate(vt - nota100*100 - nota50*50 - nota10*10 - nota5*5);
            Console.WriteLine ("Notas de 100 reais: {0}", nota100);
            Console.WriteLine ("Notas de 50 reais: {0}", nota50);
            Console.WriteLine ("Notas de 10 reais: {0}", nota10);
            Console.WriteLine ("Notas de 5 reais: {0}", nota5);
            Console.WriteLine ("Notas de 1 real: {0}", nota1);	
		}
	}
}