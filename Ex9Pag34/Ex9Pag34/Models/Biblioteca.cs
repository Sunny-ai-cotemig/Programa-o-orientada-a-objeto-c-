using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Ex9Pag34.Models
{
    public class Biblioteca : Ibiblioteca
    {
        public bool devolvidolivro(Cliente cliente, Livro livro)
        {
            if(livro.Status == false)
            {
                Console.WriteLine($"Livro devolvido pelo cliente {cliente.Nome} com sucesso");
                livro.Status = true;
                return true;
            }
            else
            {
                Console.WriteLine("Não foi possivel a devolução, refaça");
                return false;
            }
 
        }
        

        public bool emprestimolivro(Cliente cliente, Livro livro)
        {
            if (livro.Status == true)
            {
                Console.WriteLine($"Livro emprestado para  {cliente.Nome} com sucesso");
                livro.Status = false;
                return false;
            }
            else
            {
                Console.WriteLine("Não foi possivel o emprestimo ja esta ocupado, espere");
                return true;
            }
        }
    }
}
