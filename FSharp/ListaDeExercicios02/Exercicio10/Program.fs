//10.	Construir um algoritmo que indique se o numero 
//digitado esta compreendido entre 20 e 90 ou não.

open System

Console.WriteLine("Digite um numero  :")
let n1 = Int32.Parse(Console.ReadLine())

if n1>20 && n1<90 then
    Console.WriteLine("O numero {0}{1}",n1," Está entre 20 e 90.")
else
    Console.WriteLine("o numero {0} nao esta entre 20 e 90",n1) 
