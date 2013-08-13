//13.	Entrar com a sigla do estado de uma pessoa imprimir uma das mensagens:
//•	Carioca
//•	Paulista
//•	Mineiro
//•	Outros estados


open System

Console.WriteLine("Digite a sigla (uf) do seu Estado:")
let uf:string = (Console.ReadLine())


if uf = "SP" then
    Console.WriteLine("Paulista")
else
     if uf = "RJ" then
        Console.WriteLine("Carioca")
     else 
        if uf = "MG" then
            Console.WriteLine("Mineiro")
        else



            Console.WriteLine("Outros estados")