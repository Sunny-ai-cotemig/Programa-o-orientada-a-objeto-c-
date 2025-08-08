using Ex9Pag34.Models;

Livro O_regressodo_Peregrinpo = new();

O_regressodo_Peregrinpo.TituloLivro = "O regresso do peregrino";
O_regressodo_Peregrinpo.Autor = "C.S.Lewis";
O_regressodo_Peregrinpo.NumerodePagina = 320;
O_regressodo_Peregrinpo.Editora = "Thomas Nelson Brasil";
O_regressodo_Peregrinpo.Status = true;

Livro Cartas_Para_Malcon = new();
Cartas_Para_Malcon.TituloLivro = "Cartas para Malcon";
Cartas_Para_Malcon.Autor = "C.S.Lewis";
Cartas_Para_Malcon.NumerodePagina = 320;
Cartas_Para_Malcon.Editora = "Thomas Nelson Brasil";
Cartas_Para_Malcon.Status = true;

//cliente

Cliente clienteL = new();
clienteL.Nome = "Lois";
Cliente clienteM = new();
clienteM.Nome = "Maria";

Biblioteca biblioteca = new();

biblioteca.emprestimolivro(clienteL, O_regressodo_Peregrinpo);
Console.WriteLine("Maria tenta pegar o livro");
biblioteca.emprestimolivro(clienteM, O_regressodo_Peregrinpo);
Console.WriteLine("Lois devolve o livro");
biblioteca.devolvidolivro(clienteL, O_regressodo_Peregrinpo);
Console.WriteLine("Maria volta para pegar o livro");
biblioteca.emprestimolivro(clienteM, O_regressodo_Peregrinpo);
Console.WriteLine("Lois pega o livro Cartas para Malcon");
biblioteca.emprestimolivro(clienteL, Cartas_Para_Malcon);