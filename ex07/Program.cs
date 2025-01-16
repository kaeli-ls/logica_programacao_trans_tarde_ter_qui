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

//Verificando a média e mostrando o status do aluno
if (media >= 7)
{
    Console.WriteLine("Aprovado!!");
}
else if (media >= 4 && media <= 6.9)
{
    Console.WriteLine("Em recuperação...");
}
else
{
    Console.WriteLine("Reprovado...");
}