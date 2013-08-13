//3.	Criar um algoritmo que efetue o calculo do salário liquido de um professor. 
//Os dados fornecidos serão: valor da hora aula, numero de aulas dadas no mês e
// percentual de desconto do INSS.
open System

Console.Write("Digite o valor da hora aula: ")
let valorHora = Double.Parse(Console.ReadLine())

Console.Write("Digite a quantidade de horas dadas: ")
let horasDadas = Double.Parse(Console.ReadLine())

Console.Write("Digite o percentual de desconto do INSS: ")
let desconto = Double.Parse(Console.ReadLine())

let inss = desconto / 100.0
let salarioLiquido = horasDadas * valorHora
let final = salarioLiquido-(salarioLiquido*inss)

Console.WriteLine("O valor do salário líquido é = {0}", final)