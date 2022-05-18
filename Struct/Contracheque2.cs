/****************************************************************************80
*  Code: 
*   Contracheque2.cs
*
*  Purpose:
*   Uma empresa faz a folha mensal de pagamentos de seus empregos baseada no seguinte esquema. Considere que o salário referente às horas extras é calculado acrescentando 30% ao salário-hora normal. O desconto do INSS é de 11% do salário bruto (salário correspondente às horas normais trabalhadas + salário correspondente às horas extras). Para o cálculo do salário, considerar que existem duas classes de funcionários, a classe 1, cujo salário é 1.3 vezes o salário de referência, e a classe 2, cujo salário é 1.9 vezes o salário de referência.  
Implementar um algoritmo que crie para APENAS 1 funcionário por vez, do contracheque, no seguinte formato:
*
*  Modified:
*   May 15 2022  
*
*  Author:
*    Aymar Schindler  < aymarschindler@hotmail.com >
*
*  HowtoCompile:
*    Vs Code 
*   
*  HowtoExecute:
*    Vs Code
*
*******************************************************************************/

using System;



struct Funcionario
{ 
public int numeroInscricao;
public string nome;
public double salarioHorasNormais;
public double salarioHorasExtras;
public double deducaoINSS;
public double salarioLiquido;
}

namespace myApp
{
  class ImprimeStructure 
  {
     static void Main() 
     {
       
      int salarioReferencia = 1000;

      Funcionario[] FuncionarioUNEB = new Funcionario[4];
      
      FuncionarioUNEB[0].salarioHorasNormais = 1.3*salarioReferencia;  
      FuncionarioUNEB[0].salarioHorasExtras = FuncionarioUNEB[0].salarioHorasNormais*0.3;
      FuncionarioUNEB[0].deducaoINSS = 0.11*(FuncionarioUNEB[0].salarioHorasNormais +  FuncionarioUNEB[0].salarioHorasExtras);
      FuncionarioUNEB[0].salarioLiquido = (FuncionarioUNEB[0].salarioHorasNormais +  FuncionarioUNEB[0].salarioHorasExtras) - FuncionarioUNEB[0].deducaoINSS;
       
      /*0*/           
      FuncionarioUNEB[0].numeroInscricao            = 305356885;
      FuncionarioUNEB[0].nome                       = "Cicrano da Silva";
   

      Console.WriteLine("\nNúmero de Inscrição: " + FuncionarioUNEB[0].numeroInscricao);
      Console.WriteLine("Nome: "                  + FuncionarioUNEB[0].nome);
      Console.WriteLine("Salário Horas Normais: R$ " + FuncionarioUNEB[0].salarioHorasNormais); 
      Console.WriteLine("Salário Horas Extras: R$ "  + FuncionarioUNEB[0].salarioHorasExtras); 
      Console.WriteLine("Deducação INSS: R$ "        + FuncionarioUNEB[0].deducaoINSS);
      Console.WriteLine("Salário Líquido: R$ "       + FuncionarioUNEB[0].salarioLiquido);

      /*1*/
      //
      //
      //

      Funcionario[] Funcionario2UNEB = new Funcionario[4];
      
      Funcionario2UNEB[0].salarioHorasNormais = 1.9*salarioReferencia;  
      Funcionario2UNEB[0].salarioHorasExtras = Funcionario2UNEB[0].salarioHorasNormais*0.3;
      Funcionario2UNEB[0].deducaoINSS = 0.11*(Funcionario2UNEB[0].salarioHorasNormais +  Funcionario2UNEB[0].salarioHorasExtras);
      Funcionario2UNEB[0].salarioLiquido = (Funcionario2UNEB[0].salarioHorasNormais +  Funcionario2UNEB[0].salarioHorasExtras) - Funcionario2UNEB[0].deducaoINSS;
       
      /*0*/           
      Funcionario2UNEB[0].numeroInscricao            = 304455889;
      Funcionario2UNEB[0].nome                       = "Vivaldo Rocha";
   

      Console.WriteLine("\nNúmero de Inscrição: " + Funcionario2UNEB[0].numeroInscricao);
      Console.WriteLine("Nome: "                  + Funcionario2UNEB[0].nome);
      Console.WriteLine("Salário Horas Normais: R$ " + Funcionario2UNEB[0].salarioHorasNormais); 
      Console.WriteLine("Salário Horas Extras: R$ "  + Funcionario2UNEB[0].salarioHorasExtras); 
      Console.WriteLine("Deducação INSS: R$ "        + Funcionario2UNEB[0].deducaoINSS);
      Console.WriteLine("Salário Líquido: R$ "       + Funcionario2UNEB[0].salarioLiquido);

      /*1*/
      //
      //
      //
     }
  }
}