/******************************************************************************************************
%  Code: 
%   SomaImpares.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #1 - Introdução a Linguagem de Programação: Estruturas de Repetição
%   'Escreva um algoritmo que efetue a soma de todos os números
%    ímpares num intervalo (a,b) dado.'   
%
%  Modified:
%   April 06 2022 10:00 
%
%  Author:
%   Aymar Schindler  <aymarschindler 'at' hotmail.com>
%
%  How to Compile/Execute:
%   vs code
%   replit.com
%
******************************************************************************************************/

using System;

namespace IntroCS
{
    public class SomaImpares
	{
		public static void Main ()
		{
		
    // Declaração de Variáveis
		int n, m, i;
    int maior, menor; 
    int soma = 0;
    int op = 0;
    Console.Write ("Digite o limite inferior do seu intervalo: ");
			n = int.Parse (Console.ReadLine ());
      
    Console.Write ("Digite o limite superior do seu intervalo: ");
			m = int.Parse (Console.ReadLine ());

    // Condicional para reconhecer se o intervalo é crescente ou decrescente
    // Intervalo decrescente
    if(n > m){
     maior = n;
     menor = m;
     op = 1;
    // Intervalo crescente
    }else {
     maior = m;
     menor = n;
     op = 0;
    }

    //Chamada para enumeração dos números ímpares do intervalo
   	Console.WriteLine ("Seguem abaixo o(s) número(s) ímpar(es) do intervalo {0} a {1}:", n, m);

    //Loop para o intervalo crescente
    if (op != 1){
     for(i = menor; i <= maior; i++){ //incremento i++
       
       if (i % 2 != 0){ //reconhece numeros impares
     
        soma += i;
        Console.WriteLine (i);
      }
     
     }
		 Console.WriteLine ("A soma dos números ímpares é igual a: {0}" , soma);

     //Loop para o intervalo decrescente  
    }else {
      for(i = maior; i >= menor; i--){ //decremento i--
    
       if (i % 2 != 0){ //reconhece numeros impares
     
        soma += i;  
		    Console.WriteLine (i);
      }
     }
	   Console.WriteLine ("A soma dos números ímpares é igual a: {0}" , soma);	
    }
   }
  } 
}