using System.Globalization;

Console.WriteLine("Digite o código da recompensa: DOBRAR, CURAR, OURO, ESPECIAL)");
string codigo = Console.ReadLine().ToUpper();

string mensagem = codigo switch
{
    "DOBRAR" => "Você ganhou 2x EXP por 1 hora!",
    "CURAR" => "Você ganhou uma poção de cura!",
    "OURO" => "Você ganhou 1000 moedas de ouro!",
    "ESPECIAL" => "Você ganhou um item lendário!",
    _ => "Código inválido. Tente novamente."

};

Console.WriteLine(mensagem);