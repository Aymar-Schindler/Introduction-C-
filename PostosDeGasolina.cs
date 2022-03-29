/******************************************************************************************************
%  Code: 
%   PostosDeGasolina.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #1 - Introdução a Linguagem de Programação: Entradas e Saídas
%   'Escreva um programa capaz de calcular o preço médio da gasolina considerando três postos de 
%    combustível de Salvador. Solicitando ao usuário que informe o nome e o valor da gasolina em cada
%    um dos três postos.'
%
%  Modified:
%   Mar 29 2022 09:00 
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
  class ValorGasolina
  {
    static void Main()
    {
        float valorPosto1, valorPosto2, valorPosto3, mediaReaisPrecosGasolinas;

        Console.WriteLine ("Bem vindo ao programa de media de gasolinas de 03 postos!");  
        Console.WriteLine ("Insira o valor da Gasolina do Posto 1:");
        valorPosto1 = float.Parse(Console.ReadLine());  

        Console.WriteLine ("Insira o valor da Gasolina do Posto 2:");
        valorPosto2 = float.Parse(Console.ReadLine()); 

        Console.WriteLine ("Insira o valor da Gasolina do Posto 3:");
        valorPosto3 = float.Parse(Console.ReadLine()); 

        mediaReaisPrecosGasolinas = (valorPosto1 + valorPosto2 + valorPosto3)/3;

        Console.WriteLine ("Valor Médio da Gasolina é (R$): {0}",  mediaReaisPrecosGasolinas);     
    }
  }
}
