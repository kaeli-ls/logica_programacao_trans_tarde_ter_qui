//Criando uma tabuada com o método Do

//Solicitando um numero ao usuario
Console.WriteLine("Digite um numero para ver a tabuada");
int numero = Convert.ToInt32(Console.ReadLine());
int contador = 1;

//criando a tabuada
do
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;
}
while ( contador <= 10 );