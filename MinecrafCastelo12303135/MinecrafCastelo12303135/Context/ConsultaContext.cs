using MinecrafCastelo12303135.Models;
using Microsoft.EntityFrameworkCore;
using MinecrafCastelo12303135.Enum;

namespace MinecrafCastelo12303135.Context;

public class ConsultaContext : DbContext
{
    public DbSet<Consulta> Consultas { get; set; }
    public string DbPath { get; set; }

    public ConsultaContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);

        DbPath = System.IO.Path.Join(path, "consulta.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)

      => options.UseSqlite($"Data Source = {DbPath}");
}
