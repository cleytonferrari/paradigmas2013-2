// 12.	Entrar com dois números reais e imprimir a média aritmética com a mensagem “Média” antes do resultado.

let media n1 n2 = (n1+n2)/2.0 

System.Console.Write("Digite o primeiro número: ")
let n1 = System.Double.Parse(System.Console.ReadLine())

System.Console.Write("Digite o segundo número: ")
let n2 = System.Double.Parse(System.Console.ReadLine())

System.Console.WriteLine ("A média de {0} e {1} = {2}", n1, n2, media n1 n2 )