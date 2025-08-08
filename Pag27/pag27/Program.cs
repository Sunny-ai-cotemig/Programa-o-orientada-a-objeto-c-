using pag27.models;
using System.Security;
//Exercicio 01
Console.WriteLine("insira um número para o primeiro valor");
int valorUm = int.Parse(Console.ReadLine());

Console.WriteLine("insira um número para o segundo valor");
int valorDois = int.Parse(Console.ReadLine());

divisao divisao = new();

Console.WriteLine(divisao.dividir(valorUm, valorDois));