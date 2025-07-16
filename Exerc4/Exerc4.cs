Console.WriteLine("Informe a senha de acesso: ");
int senha = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o nível de acesso: ");
int nivelAcesso = int.Parse(Console.ReadLine());

if (senha == 42 && nivelAcesso >= 5)
{
    Console.WriteLine("Acesso permitido.");
}
else
{
    Console.WriteLine("Acesso negado.");
}