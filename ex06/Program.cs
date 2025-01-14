
Console.WriteLine("Digte um numero: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um numero: ");
int n2 = int.Parse(Console.ReadLine());

Console.Clear();

Console.WriteLine("Vamos calcular as seguintes operações: +, x, - e \\ ");
Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
Console.WriteLine($"{n1} x {n2} = {n1 * n2}");
Console.WriteLine($"{n1} - {n2} = {n1 - n2}");

if (n2 != 0)
{
    Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
}
else
{
    Console.WriteLine("Divisão por zero não permitida");
}


Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.WriteLine($"Os numeros são iguais? {n1 == n2}");
Console.WriteLine($"O numero 1 é maior que o numero 2? {n1 > n2}");
Console.WriteLine($"O numero 1 é menor que o numero 2? {n1 < n2}");
Console.WriteLine($"O numero 1 é maior ou igual o numero 2? {n1 >= n2}");
Console.WriteLine($"O numero 1 é menor ou igual o numero 2? {n1 <= n2}");