/******************************************************************************************************
%  Code: 
%   OptNumero.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #7 - Introdução a Linguagem de Programação: Estruturas Condicionais
%   'Escreva um programa que pergunte 4 números inteiros,
%   referente a: Opção, Num1, Num2, Num3 respectivamente; e
%   mostre:
%   a) O valor de Num1 se a Opção for igual a 1.
%   b) O valor de Num2 se a Opção for igual a 2.
%   c) O valor de Num3 se a Opção for igual a 3.
%   Os únicos valores para Opção são 1, 2 e 3.'   
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
    class OptNumero
	{
		public static void Main ()
		{
			// Declaração de Variáveis
            int opcao, num1, num2, num3;

			// Entrada de Dados
			Console.WriteLine ("Digite três números inteiros em cada linha abaixo: ");
			num1 = int.Parse (Console.ReadLine ());
            num2 = int.Parse (Console.ReadLine ());
            num3 = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Respectivamente, os números acima são suas opções '1,2 e 3', qual opção você escolhe?");
            opcao = int.Parse (Console.ReadLine ());

			//Condicional
			switch (opcao)
            {
                case 1:
                 Console.WriteLine ("Então, o seu número escolhido foi: {0}", num1);
                 break;
                case 2:
                 Console.WriteLine ("Então, o seu número escolhido foi: {0}", num2);
                 break;
                case 3:
                 Console.WriteLine ("Então, o seu número escolhido foi: {0}", num3);
                 break;
			}
		}
	}
}