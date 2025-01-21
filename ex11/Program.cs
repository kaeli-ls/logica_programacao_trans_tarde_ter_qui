/*
Crie um programa que peça ao usuário para inserir um número inteiro positivo e então conte de 1 até esse número,
exibindo cada número. O programa deve implementar essa contagem usando while, do while e for. 
*/

//Solicitando um numero ao usuario e convertendo para Int
Console.WriteLine("Digite um numero positivo: ");
int numero = Convert.ToInt32(Console.ReadLine());


//Criando o programa de contagem com While <---------------->
Console.WriteLine("------Usando WHILE------>");
int contador_while = 1;

while (contador_while <= numero)
{
    Console.WriteLine(contador_while);
    contador_while++;
}


//Criando o programa de contagem com Do <---------------->
Console.WriteLine("<------Usando DO------>");
int contador_do = 1;

do
{
    Console.WriteLine(contador_do);
    contador_do++;
}
while (contador_do <= numero) ;


//Criando o programa de contagem com For <---------------->
Console.WriteLine("<------Usando FOR------>");

for (int contador = 1; contador <= numero; contador++)
{
    Console.WriteLine(contador);
}
