//Criando uma tabuada com o método laço for

//Solicitando um numero ao usuario
Console.WriteLine("Digite um numero para ver a tabuada");
int numero = Convert.ToInt32(Console.ReadLine());

//criando a tabuada
for (int contador = 1; contador < 11; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}