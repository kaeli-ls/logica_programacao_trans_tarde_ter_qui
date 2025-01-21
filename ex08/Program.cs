//Criando uma tabuada com While

//Solicitando um numero ao usuario
Console.WriteLine("Digite um numero para ver a tabuada");
int numero = Convert.ToInt32(Console.ReadLine());
int contador = 1;

//criando a tabuada
while (contador <= 10)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;
}