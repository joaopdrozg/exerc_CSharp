/*bool conexaoAtiva = true;

if (conexaoAtiva)
{
    Console.WriteLine("Iniciando o jogo.");
}
else
{
    Console.WriteLine("Sem conexão.");
}
*/

double valorCompra = 245.00;
bool clienteVip = false;

if (valorCompra > 300.00 || clienteVip)
{
    double desconto = valorCompra * 0.10;
    Console.WriteLine($"Você ganhou R${desconto} em desconto!");
} else if (valorCompra > 200.00) {
    Console.WriteLine("Você ganhou um brinde!");


}
else
{
    double diferenca = 300.00 - valorCompra;
    Console.WriteLine($"Você precisa gastar mais R${diferenca} para ganhar desconto.");
    Console.WriteLine("Você não ganhou desconto.");
}