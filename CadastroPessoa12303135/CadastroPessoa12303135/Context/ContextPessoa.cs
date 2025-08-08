using Microsoft.EntityFrameworkCore;
using CadastroPessoa12303135.Molds;
namespace CadastroPessoa12303135.Context
{
    public class PessoaContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public string DbPath { get; set; }
        public PessoaContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "pessoa.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)

          => options.UseSqlite($"Data Source = {DbPath}");
    }
}
