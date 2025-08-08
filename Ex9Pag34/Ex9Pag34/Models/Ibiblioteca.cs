using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9Pag34.Models
{
    public interface Ibiblioteca
    {
        public bool emprestimolivro(Cliente cliente, Livro livro);
        public bool devolvidolivro(Cliente cliente, Livro livro);
    }
    
    
}
