//7.	Construir um algoritmo que leia dois valores numéricos inteiros e efetue 
//a adição; caso o resultado seja maior que 10, apresentá-lo.

open System

Console.WriteLine("digite dois numeros: ")
let n1 = Int32.Parse(Console.ReadLine())
let n2 = Int32.Parse(Console.ReadLine()) 

if n1+n2 > 10 then
    Console.WriteLine(" o resultado é {0}",n1+n2)
    