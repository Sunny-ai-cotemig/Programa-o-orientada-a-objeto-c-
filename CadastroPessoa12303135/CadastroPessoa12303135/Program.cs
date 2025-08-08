using Microsoft.EntityFrameworkCore;
using CadastroPessoa12303135.Molds;
using CadastroPessoa12303135.Context;

using var db = new PessoaContext();
Console.WriteLine($"Local do Banco: {db.DbPath}");
Console.WriteLine("Inserindo uma nova matricula: ");
db.Add(new Pessoa { Nome = "Lucas", Cpf = "123.354.786.10", Sexo = "Masculino", Celular = "31 98657-7894", ClienteAtivo = true });
await db.SaveChangesAsync();

Console.WriteLine("Lendo um a matricula: ");
var pessoa = await db.Pessoas
    .OrderBy(b => b.PessoaId)
    .FirstAsync();
Console.WriteLine("Id; "+pessoa.PessoaId);
Console.WriteLine("Nome; " +pessoa.Nome);
Console.WriteLine("Cpf; " + pessoa.Cpf);
Console.WriteLine("Sexo; " + pessoa.Sexo);
Console.WriteLine("Celular; " + pessoa.Celular);
Console.WriteLine("Cliente Ativo; " + pessoa.ClienteAtivo);