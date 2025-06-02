
Console.Write("Digite um número para saber sua tabuada: ");

int numero = int.Parse(Console.ReadLine()!);

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}
