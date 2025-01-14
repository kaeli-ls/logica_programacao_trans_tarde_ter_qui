// Solicitar as notas do aluno
using System.Runtime.InteropServices;

Console.WriteLine("Digte um numero: ");
float nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite um numero: ");
float nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digte um numero: ");
float nota3 = float.Parse(Console.ReadLine());

//calcular a média
float media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine($"Sua média é de {media}");

if (media >= 7)
{
    Console.WriteLine("Aprovado!!");
}
if (media >= 4)
{
    Console.WriteLine("Em recuperação...");
}
if (media <= 4)
{
    Console.WriteLine("Reprovado...");
}