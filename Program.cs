string[] lista = {
    "Michael Jordan (Armador)",
    "LeBron James (Ala)",
    "Kareem Abdul Jabbar (Pivô)",
    "Magic Johnson (Armador)",
    "Wilt Chamberlain (Pivô)",
    "Bill Russell (Pivô)",
    "Larry Bird (Ala)",
    "Tim Duncan (Ala-pivô)",
    "Oscar Robertson (Armador)",
    "Kobe Bryant (Armador)",
    "Shaquille O’Neal (Pivô)",
    "Kevin Durant (Ala)",
    "Hakeem Olajuwon (Pivô)",
    "Julius Erving (Ala)",
    "Moses Malone (Pivô)",
    "Stephen Curry (Armador)",
    "Dirk Nowitzki (Ala-pivô)",
    "Giannis Antetokounmpo (Ala-pivô)",
    "Jerry West (Armador)",
    "Elgin Baylor (Ala)",

};

Console.Clear();
Console.Write("---Dream Team da NBA---\n");
Console.WriteLine("");

int[] jogadores = new int[5];

Console.WriteLine("Os 20 Melhores Jogadores da NBA de Todos os Tempos\n");
for (int m = 0; m < 20; m++)
{
    Console.WriteLine($"{m + 1,2} - {lista[m]}");
}

Console.WriteLine("");
int quantidadeJogador = 5;

Console.WriteLine();
int[] time = new int[quantidadeJogador];

for (int m = 0; m < quantidadeJogador; m++)
{
    while (true)
    {

        Console.Write($"{m} jogador(es) selecionados. Adicionar o Top # ");
        int jogadorselecionado = Convert.ToInt32(Console.ReadLine());

        if (time.ToList().Any(f => f == jogadorselecionado))
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Esse atleta já pertence ao seu time.");
            Console.ResetColor();
            continue;
        }

        if (jogadorselecionado < 1 || jogadorselecionado > 20)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("jogador não encontrado.");
            Console.ResetColor();
            continue;
        }

        Console.WriteLine($"{lista[jogadorselecionado - 1]} foi o jogador selecionado... ");

        time[m] = jogadorselecionado;

        Console.WriteLine($"\nSeu time dos sonhos é:\n");

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        List<int> timeList = time.ToList(); //converte a matriz em lista
        timeList.Sort(); //ordena a lista
        timeList.FindAll(t => t > 0) // Busca todos os jogadores já adicionados
                .ForEach(t => Console.WriteLine($"\t{t} - {lista[t - 1]}"));    //Exibe cada (Foreach) elemento (t)
        Console.ResetColor();
        break;
    }

}

Console.Write("\nPressione uma tecla para finalizar...");
Console.ReadKey();

Console.WriteLine();
