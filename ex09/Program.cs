//Criando uma tabuada com o método do

Console.WriteLine("Digite um numero para ver a tabuada");
int numero = Convert.ToInt32(Console.ReadLine());
int contador = 1;

do
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;
}
while ( contador <= 10 );