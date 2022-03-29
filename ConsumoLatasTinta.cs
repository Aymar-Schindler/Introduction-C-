/******************************************************************************************************
%  Code: 
%   ConsumoLatasTinta.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #3 - Introdução a Linguagem de Programação: Entradas e Saídas
%   'Faça um programa que calcule a quantidade necessária de latas de tinta para 
%     pintar uma parede. O programa pergunta a medida de largura e altura da parede 
%     em metros e imprima o resultado (em latas de tintas). Considere que o consumo 
%     de tinta é de 300 ml por metro quadrado e a quantidade de tinta por lata e 
%     de 2 litros.'
%
%
%  Modified:
%   Mar 25 2022 12:00 
%
%  Author:
%    Murilo Boratto <muriloboratto 'at' uneb.br>
%    Leandro Correia  <leandro.correia 'at' gmail.com>
%    Aymar Schindler  <aymarschindler 'at' hotmail.com>
%
%  How to Compile:
%   mcs code.cs -o object 
%
%  How to Execute: 
%   mono object
%   vs code
%
%*****************************************************************************************/

using System;

namespace IntroCS
{ 
  class ConsumoLatasTinta
  {
    
    static void Main()
    {
/*
 *  ---------------------------------------------------------------------
 *   VARIAVEIS
 *  ---------------------------------------------------------------------
 */
     double altura, largura, areaParede, litrosTinta, numeroLatasTinta;
     
/*
 *  ---------------------------------------------------------------------
 *   ENTRADA DE DADOS
 *  ---------------------------------------------------------------------
 */     

     Console.WriteLine ("Bem Vindo ao Programa de consumo de latas de tintas!");
     Console.WriteLine ("Digite a Altura da Parede:");
     altura = double.Parse(Console.ReadLine());
   
     Console.WriteLine ("Digite a Largura da Parede:");
     largura = double.Parse(Console.ReadLine());
     
/*
 *  ---------------------------------------------------------------------
 *   PROCESSAMENTO
 *  ---------------------------------------------------------------------
 */     
    
     areaParede        = altura * largura;    
     litrosTinta       = areaParede * 0.3;    
     numeroLatasTinta  = litrosTinta / 2;
                                                 
/*
 *  ---------------------------------------------------------------------
 *   SAIDA DE DADOS
 *  ---------------------------------------------------------------------
 */     
      
     Console.WriteLine ("Número de Latas de Tinta: {0} ", numeroLatasTinta );
       
        
    }
  }
}
