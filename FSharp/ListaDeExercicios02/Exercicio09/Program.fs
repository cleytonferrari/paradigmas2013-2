//9.	A prefeitura do Rio de Janeiro abriu uma linha de
// crédito para os funcionários estatutários. O valor Maximo 
// da prestação não poderá ultrapassar 30% do salário bruto. 
// Fazer um programa que permita entrar com o salário bruto e
//  o valor da prestação e informa se o empréstimo pode ou não ser concedido

open System

Console.WriteLine("Digite o valor do salário bruto:")
let n1 = Double.Parse(Console.ReadLine())

Console.WriteLine("Digite o valor da Prestação:")
let n2 = Double.Parse(Console.ReadLine())

if (n1*0.3) < n2 then
    Console.WriteLine("Credito nao liberado")
else
    Console.WriteLine("Credito Liberado")
