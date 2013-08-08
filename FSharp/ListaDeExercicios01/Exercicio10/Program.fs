//10.	Ler dois números inteiros e imprimir o produto.
let produto n1 n2 = n1*n2

System.Console.Write("Digite primeiro número: ")
let n1 = System.Int32.Parse(System.Console.ReadLine())

System.Console.Write("Digite segundo número: ")
let n2 = System.Int32.Parse(System.Console.ReadLine())

System.Console.WriteLine("O produto de n1 e n2 é :{0}" , produto n1 n2)