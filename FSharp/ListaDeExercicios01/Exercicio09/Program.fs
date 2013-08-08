// 9.	Ler dois números inteiros e imprimir a soma. Antes do resultado, deverá aparecer a mensagem: Soma.

let soma n1 n2 = n1+n2

System.Console.Write("Digite o primeiro número: ")
let n1 = System.Int32.Parse(System.Console.ReadLine())

System.Console.Write("Digite o segundo número:")
let n2 = System.Int32.Parse(System.Console.ReadLine())

System.Console.WriteLine("A soma de {0} + {1} = {2}", n1, n2, soma n1 n2)