using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarDadosWF.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Disciplina { get; set; }

        public Pessoa()
        {
            Nome = "Louis Arthus";
            Idade = 17;
            Email = "louisarthus67@gamil.com";
            Cpf = "145.598.145-20";
            Disciplina = "Poo";
        }

     
    }
}
