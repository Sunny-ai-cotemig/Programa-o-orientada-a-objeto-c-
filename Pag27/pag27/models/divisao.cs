using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pag27.models
{
    class divisao
    {
        public int valorUm { get; set; }
        public int valorDois { get; set; }

        public int dividir(int valorUm, int valorDois)
        {
            try
            {
                return valorUm / valorDois;
            }
            catch (DivideByZeroException)
            {
                
                Console.WriteLine("\n o usúario não pode dividir um número por zero");
                return -1;                
            }
        }
    }
}
