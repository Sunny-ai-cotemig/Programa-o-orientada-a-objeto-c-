using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2pag27.Models
{
    internal class Banco
    {
        public double valor { get; set; }
        public double saldo { get; set; }
        
        public double Depositar (double saldo, double valor)
        {
            return saldo + valor;
        }

        public double Sacar(double saldo, double valor)
        {
            try
            {
                if (saldo > valor)
                {
                    throw new InvalidOperationException("Voc~e não tem saldo suficiente para sacar");
                }
            }
            finally { }
            return saldo - valor;
        }
        public double VerificacaoSaldo(double saldo, double valor)
        {
            Se
        }
    }
}
