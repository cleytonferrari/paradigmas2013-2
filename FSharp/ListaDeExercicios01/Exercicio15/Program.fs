//15.	Entrar com um nome e imprimir:
//  Todo o nome:
//  Primeiro Caractere:
//  Ultimo Caractere:
//  Do Primeiro ate o Terceiro:
//  Quarto Caractere:
//  Todos menos o Primeiro:
//  Os Dois Últimos:

open System

Console.Write("Informe o Nome: ")
let nome = System.Console.ReadLine()

Console.WriteLine("Todo Nome: {0}", nome)
Console.WriteLine("Primeiro Caracter: {0}", nome.ToString().Substring(0,1))
Console.WriteLine("Ultimo Caracter: {0}", nome.Substring(nome.Length-1, 1))
Console.WriteLine("Primeiro Caracter até o Terceiro: {0}", nome.ToString().Substring(0,3))
Console.WriteLine("Quarto Caracter: {0}", nome.ToString().Substring(3,1))
Console.WriteLine("Todos menos o Primero: {0}", nome.ToString().Substring(1))