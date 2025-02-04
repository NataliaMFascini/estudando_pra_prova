string player1;
string player2;

var dado = new Random();
int valorP1;
int valorP2;
int rodadasTotal = 3;
int rodadas = 0;

Console.WriteLine("Digite o nome do primeiro jogador: ");
player1 = Console.ReadLine();
Console.WriteLine("Digite o nome do segundo jogador: ");
player2 = Console.ReadLine();

while(player1 == player2)
{
    Console.WriteLine("Não pode ser o mesmo nome.");
    Console.WriteLine("Digite o nome do segundo jogador: ");
    player2 = Console.ReadLine();
}

while(rodadas < rodadasTotal)
{
    
    valorP1 = dado.Next(1, 6);
    valorP2 = dado.Next(1, 6);

    if(valorP1 == valorP2)
    {
        Console.WriteLine($"{player1} tirou {valorP1}, {player2} tirou {valorP2}. Empate.");
    }else if(valorP1 < valorP2)
    {
        Console.WriteLine($"{player1} tirou {valorP1}, {player2} tirou {valorP2}. {player2} venceu rodada {rodadas + 1}.");
    }else
    {
        Console.WriteLine($"{player1} tirou {valorP1}, {player2} tirou {valorP2}. {player1} vendeu rodada {rodadas + 1}.");
    }
    rodadas++;
}
