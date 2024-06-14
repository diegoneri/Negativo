Console.Clear();
int numero;

Console.Write("Digite um número: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero < 0)
{
    Console.WriteLine("Você digitou um número negativo.");
}

Console.Write("\nPressione uma tecla para finalizar...");
Console.ReadKey();

Console.WriteLine();