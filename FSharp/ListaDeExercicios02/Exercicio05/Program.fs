//5.	Uma pessoa resolveu fazer uma aplicação em uma poupança
// programada. Para calcular seu rendimento, ela devera fornecer
//  o valor constante da aplicação mensal, a taxa e o número de meses.
//   Sabendo-se que a formula usada para este calculo é:
//Valor acumulado = P * ((1+i)n -1)/i
//i = taxa
//P = aplicação mensal
//n = número de meses

open System

Console.Write("digite o valor constante da aplicacao mensal: ")
let p = Double.Parse(Console.ReadLine())

Console.Write("digite o valor da taxa: ")
let i = Double.Parse(Console.ReadLine()) / 100.0

Console.Write("digite o Numero de meses: ")
let n = Double.Parse(Console.ReadLine())

let valorAcumulado = p* (Math.Pow(1.0+i,n)-1.0)/i

Console.WriteLine("O Valor acumulado da paupança programada é {0}", valorAcumulado)