/******************************************************************************************************
%  Code: 
%   ConvertMoedas.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #5 - Introdução a Linguagem de Programação: Estruturas Condicionais
%   'Escreva um programa que lê um valor em reais e um tipo de
%    moeda (1-dólar, 2-libra ou 3-euro) e faz a conversão do valor para a moeda
%    solicitada, sabendo que
%    dólar = R$ 4,00 1 libra = R$ 6,15 1 euro = R$ 4,72.'   
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
    class ConvertMoedas
	{
		public static void Main ()
		{
			// Declaração de Variáveis
			double dolar = 4.00, libra = 6.15, euro = 4.72, real;
            int moeda;

			// Entrada de Dados
			Console.Write ("Digite o valor em reais a ser convertido: ");
			real = double.Parse (Console.ReadLine ());
            Console.WriteLine ("Digite o número correspondente a conversão que deseja: ");
            Console.WriteLine ("'1' para: dólar = R$ 4,00");
            Console.WriteLine ("'2' para: libra = R$ 6,15");
            Console.WriteLine ("'3' para: euro = R$ 4,72");
			moeda = int.Parse (Console.ReadLine ());
            
			//Condicional
			switch (moeda)
            {
                case 1:
                 Console.WriteLine ("O valor em dólar é: R$ {0}", real*dolar);
                 break;
                case 2:
                 Console.WriteLine ("O valor em libra é: R$ {0}", real*libra);
                 break;
                case 3:
                 Console.WriteLine ("O valor em euro é: R$ {0}", real*euro);
                 break;
			}
		}
	}
}