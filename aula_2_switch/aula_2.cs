Console.WriteLine("\nMENU:");
Console.WriteLine("1 - Ver produtos");
Console.WriteLine("2 - Fazer pedido");
Console.WriteLine("0 - Sair do programa");
Console.WriteLine("Escolha uma opção: ");

int opcao = int.Parse(Console.ReadLine());


switch (opcao)
{
    case 1:
        Console.WriteLine("Pedido realizado");
        break;
    case 2:
        Console.WriteLine("Pedido realizado");
        break;
    case 0:
        Console.WriteLine("Saindo do programa...");
        break;
    default:
        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
        break;
}