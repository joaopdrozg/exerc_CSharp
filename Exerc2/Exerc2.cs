Console.Write("Digite o código do produto (1 ou 2): ");
int codigo = int.Parse(Console.ReadLine());

if (codigo == 1)
{
    Console.WriteLine("O produto é perecível.");
}
else if (codigo == 2)
{
    Console.WriteLine("O produto não é perecível.");
}
else
{
    Console.WriteLine("Código inválido.");
}