/******************************************************************************************************
%  Code: 
%   DiasDeVida.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #2 - Introdução a Linguagem de Programação: Entradas e Saídas
%   'Escreva um programa que pergunte o nome e a idade de um individuo 
%    e imprima (aproximadamente) quantos dias de vida ele possui.'
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
  class DiasDeVida
  {  
    static void Main()
    {
        string nome;
        int idade, numeroDiasDeVida;
        
        Console.WriteLine("Bem vindo ao programa para saber quantos dias de vida vc tem!");
        Console.Write("Digite o seu nome completo: ");
        nome = Console.ReadLine();
 
        Console.Write("Digite a sua idade atual: ");
        idade = int.Parse(Console.ReadLine());
 
        numeroDiasDeVida = idade * 365;  
  
        Console.WriteLine("{0}  você tem  {1} dias de vida na terra", nome, numeroDiasDeVida);      
    }
  }
}
