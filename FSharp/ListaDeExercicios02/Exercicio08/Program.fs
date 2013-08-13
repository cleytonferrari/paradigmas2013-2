//8.	Construir um algoritmo que leia dois números e efetue
// a adição. Caso o valor somado seja maior que 20, este devera 
// ser apresentado somando-se a ele mais 8; caso o valor somado 
// seja menor ou igual a 20, este devera ser apresentado subtraindo-se 5.

open System

Console.WriteLine("Insira dois Números")
let n1 = Int32.Parse(Console.ReadLine())
let n2 = Int32.Parse(Console.ReadLine())


if (n1+n2) > 20 then
    Console.WriteLine("O Resultado é: {0}", n1+n2)