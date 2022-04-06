/******************************************************************************************************
%  Code: 
%   CategoriaIdade.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #6 - Introdução a Linguagem de Programação: Estruturas Condicionais
%   'Escreva um algoritmo que, dada a idade de um nadador,
%   classifique-o em uma das seguintes categorias:
%   infantil B = 8 – 10 anos
%   juvenil A = 11- 13 anos
%   juvenil B = 14 – 17 anos
%   sênior = maiores de 18 anos.'   
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
    class CategoriaIdade
	{
		public static void Main ()
		{
			// Declaração de Variáveis
            int idade;

			// Entrada de Dados
			Console.Write ("Digite sua idade atual expressa em anos de forma inteira: ");
			idade = int.Parse (Console.ReadLine ());
                        
			//Condicional
			switch (idade)
            {
                case >18:
                 Console.WriteLine ("Sua Categoria é Sênior");
                 break;
                case >13:
                 Console.WriteLine ("Juvenil B");
                 break;
                case >10:
                 Console.WriteLine ("Juvenil A");
                 break;
                case >7:
                 Console.WriteLine ("Infantil B");
                 break;
                 break;
			}
		}
	}
}