//Em época de pouco dinheiro, os comerciantes estão procurando aumentar suas 
//vendas oferecendo desconto. Faça um algoritmo que possa entrar com o valor
// de um produto e imprima o novo valor tendo em vista que o desconto foi de 9%.

System.Console.WriteLine("Digite o valor: ")
let valor = System.Double.Parse(System.Console.ReadLine())
let valorComDesconto:double = valor*0.91

System.Console.WriteLine("O valor com Desconto de 9% = {0}", valorComDesconto)