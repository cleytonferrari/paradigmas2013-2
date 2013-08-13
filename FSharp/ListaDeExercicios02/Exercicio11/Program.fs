//11.	Entrar com um numero e imprimir uma das mensagens: maior do que 20, igual a 20 ou menor do que 20.


open System

Console.Write("Digite um numero: ")

let n1 = Int32.Parse(Console.ReadLine())






if n1 > 20 then 
    Console.WriteLine("o numero é maior que 20")

else
    if n1 < 20 then
        Console.WriteLine("o numero é menor que 20")
    else
        Console.WriteLine("o numero é 20")