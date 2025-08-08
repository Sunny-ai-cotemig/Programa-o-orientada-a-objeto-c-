using MinecrafCastelo12303135.Models;
using MinecrafCastelo12303135.Enum;
using MinecrafCastelo12303135.Context;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Tempo gasto com cada tipo de material: \n Madeira 100h; \n Ouro 50h; \n Diamante 25h" );

using var db = new ConsultaContext();
Console.WriteLine("Escolha o tipo de material a ser utilizado no castelo: \n 1 - Madeira; \n 2 - Ouro; \n 3 - Diamente");
string MaterialSld = Console.ReadLine();
Console.WriteLine("Quantidade de jogadores");
int Quantidade = int.Parse(Console.ReadLine());


switch (MaterialSld) 
{
    case  "1":
        Console.WriteLine("Escolha material 1");
        double Tempo = 100;
        for (int i = 1; i < Quantidade; i++)
        {
            Tempo = Tempo / 2;

        }
        db.Add(new Consulta { Material = Material.Madeira, QuantidadeJoga = Quantidade, TempoGasto = Tempo });
        await db.SaveChangesAsync();
        break;
    case "2":
        Console.WriteLine("Escolha material 2");
        double Tempo2 = 50;
        for (int i = 1; i < Quantidade; i++)
        {
            Tempo2 = Tempo2 / 2;

        }
        db.Add(new Consulta { Material = Material.Ouro, QuantidadeJoga = Quantidade, TempoGasto = Tempo2 });
        await db.SaveChangesAsync();
        break;
    case "3":
        Console.WriteLine("Escolha material 3");
        double Tempo3 = 25;
        for (int i = 1; i < Quantidade; i++)
        {
           Tempo3 = Tempo3 / 2;

        }
        db.Add(new Consulta { Material = Material.Madeira, QuantidadeJoga = Quantidade, TempoGasto = Tempo3 }); ;
        await db.SaveChangesAsync();
        break;
}
Console.WriteLine("Lendo um a cadastro: ");
var Consultas = await db.Consultas
    .OrderBy(b => b.ConsultaId)
    .LastAsync();

Console.WriteLine("Lendo a consulta: ");
Console.WriteLine("Id; " + Consultas.ConsultaId);
Console.WriteLine("Material; " + Consultas.Material);
Console.WriteLine("Quantidade jogador; " + Consultas.QuantidadeJoga);
Console.WriteLine("Tempo gasto; " + Consultas.TempoGasto);



