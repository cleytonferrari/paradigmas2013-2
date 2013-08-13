//14.	Criar um algoritmo que leia dois números e imprimir uma mensagem dizendo se
// são iguais ou diferentes.
open System

Console.WriteLine("Digite dois numeros para comparalos: ")
let n1 = Int32.Parse(Console.ReadLine())
let n2 = Int32.Parse(Console.ReadLine())

if n1 = n2 then
    Console.WriteLine("Os numeros são iguais")


else
    Console.WriteLine("Os numeros não são iguais")