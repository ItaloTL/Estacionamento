//Atividade Estacinamento Italo T. Lopes

Console.Clear();

string Tamanho, serviçoV, serviçoL;
int Tempo;
decimal Estacionamento = 0, valet = 0, lavagem = 0, total = 0;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("--- Estacionamento ---");
Console.ResetColor();
Console.Write("Tamanho do veículo: Digite (P) para pequeno e (G) para grande.....: ");
Tamanho = Console.ReadLine()!.ToUpper();

Console.Write("Quanto tempo ficará? (Em minutos)...: ");
Tempo = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Serviço de valet: digite (S) para sim e (N) para não.......: ");
serviçoV = Console.ReadLine()!.ToUpper();

Console.WriteLine("Serviço de lavagem: digite (S) para sim e (N) para não.....: ");
serviçoL = Console.ReadLine()!.ToUpper();

if (Tempo > 60)
{
    decimal x = (Tempo - 60) / 60;

    if (Tamanho == "P")
    {
        if (Tempo >= 300)
        {
            Estacionamento = 50;
        }
        else
        {
            Estacionamento = x * 10;
        }

        if (serviçoV == "S")
        {
            valet = Estacionamento / 5;
        }

        if (serviçoL == "S")
        {
            lavagem = 50;
        }

        total = Estacionamento + valet + lavagem;
    }
    else if (Tamanho == "G")
    {
        if (Tempo >= 300)
        {
            Estacionamento = 80;
        }
        else
        {
            Estacionamento = x * 20 + 20;
        }

        if (serviçoV == "S")
        {
            valet = Estacionamento / 5;
        }

        if (serviçoL == "S")
        {
            lavagem = 100;
        }

        total = Estacionamento + valet + lavagem;
    }

    Console.WriteLine(@$"--- Estacionamento ---

Tamanho do veículo (P/G).....: {Tamanho}
Tempo de permanência (min)...: {Tempo}
Serviço de valet (S/N).......: {serviçoV}
Serviço de lavagem (S/N).....: {serviçoL}

Estacionamento..:       R$ {Estacionamento:0.00}
Valet...........:        R$ {valet:0.00}
Lavagem.........:        R$ {lavagem:0.00}
--------------------------------
Total...........:        R$ {total:0.00}");
}

else if ((Tempo - 60) / 60 <= 0)
{
    Console.WriteLine("Não paga");
}
else
{
    Console.WriteLine("Não pode ter mais de 12 horas");
}
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Obrigado pela preferência!");
Console.ResetColor();