//7.	Ler um número inteiro e imprimir seu sucessor e seu antecessor

System.Console.Write("Digite um número  :")
let n1 = System.Int32.Parse(System.Console.ReadLine())

let sucessor = n1+1
let antecessor = n1-1

System.Console.WriteLine(sucessor)
System.Console.WriteLine(antecessor)
