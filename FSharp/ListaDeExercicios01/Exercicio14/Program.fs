// 14.	Entrar com as notas da PR1 e PR2 e imprimir a média final.

let media (pr1: double) (pr2:double) = (pr1+pr2)/2.0
System.Console.Write("Digite o valor da prova 1: ")

let pr1 = System.Double.Parse(System.Console.ReadLine())
System.Console.Write("Digite o valor da prova 2: ")

let pr2 = System.Double.Parse(System.Console.ReadLine())
System.Console.WriteLine("Sua média é {0}", media pr1 pr2)
