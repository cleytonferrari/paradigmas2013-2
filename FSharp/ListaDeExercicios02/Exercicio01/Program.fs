//1.	Antes do racionamento de energia ser decretado, quase ninguém 
//falava em quilowatts; mas, agora, todos incorporaram essa 
//palavra em seu vocabulário. Sabendo-se que 100 quilowatts de energia custa 
//um sétimo do salário mínimo, fazer um algoritmo que receba o valor do 
//salário mínimo e a quantidade de quilowatts gasta por uma residência e calcule. 
//Imprima:
//•	O valor em reais de cada quilowatt
//•	O valor em reais a ser pago
//•	O novo valor a ser pago por essa residência com um desconto de 10%



System.Console.WriteLine("Digite o valor do salario minimo")
let salarioMinimo = System.Double.Parse(System.Console.ReadLine())

let Q = salarioMinimo / 700.0

System.Console.WriteLine("Digite o gasto de quilowatts")
let gastoWatt = System.Double.Parse(System.Console.ReadLine())

let valorPago = gastoWatt * Q
let valorComDesconto = valorPago * 0.9
System.Console.WriteLine("O valor pago por cada Kilowatts = {0}",Q)
System.Console.WriteLine("O valor pago pelo quilowatts da residencia = {0}",valorPago)
System.Console.WriteLine("O valor pago com desconto = {0}", valorComDesconto )