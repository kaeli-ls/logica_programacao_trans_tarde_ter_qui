//Criando uma tabuada com o método laço for

Console.WriteLine("Digite um numero para ver a tabuada");
int numero = Convert.ToInt32(Console.ReadLine());

for (int contador = 1; contador < 11; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}