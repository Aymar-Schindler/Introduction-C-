/******************************************************************************************************
%  Code: 
%   Tabuada.cs
%
%  Purpose:
%   Implements sample C# code 
%   Exercise #2 - Introdução a Linguagem de Programação: Estruturas de Repetição
%   'Escreva um programa que imprima todas as tabuadas (soma, subtração, divisão e multiplicação) de %    um número N lido.'   
%
%  Modified:
%   April 07 2022 10:00 
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
  public class Tabuada
	{
    //Criação de um novo metodo tabuada que recebe dois números int 
    static void tabuada(int numero, int operador)
    {   
     //Loop para tabuada, inicia em 1 devido a divisão por "0" não existir
     for (int x = 1; x <= 10; x++)
     {
       switch (operador)
       {
        //Multiplicação   
        case 1:  Console.WriteLine(numero + " * " + x + " = " + numero * x); 
        break;
        //Divisão
        case 2:  Console.WriteLine(x*numero + " / " + numero + " = " + (x*numero/ numero)); 
        break;
        //Soma   
        case 3:  Console.WriteLine(numero + " + " + x + " = " + (numero+x)); 
        break;
        //Subtração   
        case 4:  Console.WriteLine((x+numero) + " - " + numero + " = " + ((x+numero)-numero)); 
        break;
       }
      }  
    }

    public static void Main()
    {
        int numero, operador;
        string simbolo;

        Console.Write("Digite o númmero: ");
        numero = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o operador, sendo: ");
        Console.WriteLine("1 - Tabuada de multiplicação;");
        Console.WriteLine("2 - Tabuada de divisão;");
        Console.WriteLine("3 - Tabuada da adição;");
        Console.WriteLine("4 - Tabuada de subtração;");
        simbolo = Console.ReadLine();

        if(simbolo == "1"){
          Console.WriteLine("TABUADA DE MULTIPLICAÇÃO DE " + numero); 
          tabuada(numero, 1);
        }else if (simbolo == "2"){
           Console.WriteLine("TABUADA DE DIVISÃO DE " + numero);
           tabuada(numero, 2);
        }else if (simbolo == "3"){
           Console.WriteLine("TABUADA DA ADIÇÃO DE " + numero);
           tabuada(numero, 3);
        }else if (simbolo == "4"){
           Console.WriteLine("TABUADA DE SUBTRAÇÃO DE " + numero);
           tabuada(numero, 4);
        }
    }
  }
}
