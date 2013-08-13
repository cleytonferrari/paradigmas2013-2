//4.	Todo restaurante, embora por lei não possa obrigar o 
//cliente a pagar, cobra 10% para o garçom. Fazer um algoritmo 
//que leia o valor gasto com despesas realizadas em um restaurante e 
//imprima o valor total com gorjeta

System.Console.WriteLine("Valor da Fatura: ")
let valorDaFatura = System.Double.Parse(System.Console.ReadLine())

let valorTotal = valorDaFatura*1.1

System.Console.WriteLine("Valor da Conta com 10% é {0}", valorTotal)

