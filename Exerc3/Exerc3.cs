Console.WriteLine("Informe a nota final do aluno: ");
double nota = double.Parse(Console.ReadLine());

if (nota >= 9.0 && nota <= 10.0)
{
    Console.WriteLine("O aluno recebeu a nota A.");
}
else if (nota >= 7.0 && nota < 9.0)
{
    Console.WriteLine("O aluno recebeu a nota B.");
}
else if (nota >= 5.0 && nota < 7.0)
{
    Console.WriteLine("O aluno recebeu a nota C.");
}
else if (nota < 5.0 && nota >= 0.0)
{
    Console.WriteLine("O aluno recebeu a nota D.");
}
else
{
    Console.WriteLine("Nota inválida. Por favor, insira uma nota entre 0.0 e 10.0.");
}