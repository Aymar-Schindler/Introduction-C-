/******************************************************************************************************
%  Code: 
%   CarroMaisVeloz.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #10 - Introdução a Linguagem de Programação: Estruturas Condicionais
%   'Um autódromo necessita de um programa para
%   verificar qual o carro mais rápido em uma competição.
%   Considerando que dois carros participam da corrida, o programa
%   pergunta qual o comprimento da pista (em metros) e quanto tempo
%   (em segundos) cada um dos carros levou pra percorrer a pista, e
%   informa a velocidade do carro mais rápido. (Considere que em uma
%   corrida não existem dois carros com tempos de percurso
%   exatamente iguais).'   
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
    class CarroMaisVeloz
	{
		public static void Main ()
		{
			// Declaração de Variáveis
            float pista1, pista2, tempo1, tempo2, v1, v2;

			// Entrada de Dados
			Console.WriteLine ("Digite o tamanho da pista, em metros, que o primeiro carro percorreu: ");
            pista1 = float.Parse (Console.ReadLine ()); 
            Console.WriteLine ("Digite o tempo, em segundos, que o primeiro carro demorou para finalizar a pista: ");
            tempo1 = float.Parse (Console.ReadLine ());  
            Console.WriteLine ("Digite o tamanho da pista, em metros, que o segundo carro percorreu: ");
            pista2 = float.Parse (Console.ReadLine ()); 
            Console.WriteLine ("Digite o tempo, em segundos, que o segundo carro demorou para finalizar a pista: ");
            tempo2 = float.Parse (Console.ReadLine ());  
            v1 = pista1/tempo1;
            v2 = pista2/tempo2;
            
            // Condicional
			if (v1 > v2) {
				Console.WriteLine ("O primeiro carro é o mais veloz e sua velocidade em (m/s) é aproximadamente de: {0}", Math.Round(v1));
			} else {
				Console.WriteLine ("O segundo carro é o mais veloz e sua velocidade em (m/s) é aproximadamente de: {0}", Math.Round(v2));
			}



		}
	}
}