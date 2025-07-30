Console.WriteLine("Qual seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("Qual o momento do dia? \n 1 - Manhã \n 2 - Tarde \n 3 - Noite");
int momento = int.Parse(Console.ReadLine());

switch (momento)
{
    case 1:
        Console.WriteLine($"Bom dia, {nome}!");
        break;
    case 2:
        Console.WriteLine($"Boa tarde, {nome}!");
        break;
    case 3:
        Console.WriteLine($"Boa noite, {nome}!");
        break;
    default:
        Console.WriteLine("Momento do dia inválido. Por favor escolha entre as opções 1, 2 ou 3.");
        break;
}