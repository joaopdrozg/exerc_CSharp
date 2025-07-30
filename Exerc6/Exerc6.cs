Console.WriteLine("Digite a operação (+, -, *, /):");
string operacao = Console.ReadLine();

Console.WriteLine("Digite o primeiro número:");
double numero1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
double numero2 = double.Parse(Console.ReadLine());

switch (operacao)
{
    case "+":
        Console.WriteLine($"O resultado da soma é: {numero1 + numero2}");
        break;
    case "-":
        Console.WriteLine($"O resultado da subtração é: {numero1 - numero2}");
        break;
    case "*":
        Console.WriteLine($"O resultado da multiplicação é: {numero1 * numero2}");
        break;
    case "/":
        Console.WriteLine($"O resultado da divisão é: {numero1 / numero2}");
        break;
    default:
        Console.WriteLine("Operação inválida. Por favor escolha uma operação válida (+, -, *, /).");
        break;
}