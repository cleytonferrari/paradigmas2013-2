//12.	Entrar com nome, sexo e idade de uma pessoa. Se a pessoa for do sexo 
//feminino e tiver menos que 25 anos, imprimir nome e a mensagem: ACEITA. Caso contrario, 
//imprimir nome e a mensagem: NÃO ACEITA

open System

Console.WriteLine ("Digite o Nome: ")
let nome = Console.ReadLine()
Console.WriteLine ("Informe o Sexo: ")
let sexo = Console.ReadLine()
Console.WriteLine ("Informe Idade: ")
let idade = Int32.Parse(Console.ReadLine())

if sexo = "F" && idade < 25 then
    Console.WriteLine("Aceito {0}", nome)
else
    Console.WriteLine("Não Aceito {0}", nome)