//Criando uma tabuada com While

Console.WriteLine("Digite um numero para ver a tabuada");
int numero = Convert.ToInt32(Console.ReadLine());
int contador = 1;

while (contador <= 10)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;
}