//6.	Entrar com um número e imprimi-lo caso seja maior que 20tem


open System

Console.WriteLine ("Digite um numero")
let n = Int32.Parse(Console.ReadLine())

if n > 20 then
    Console.Write(n)

