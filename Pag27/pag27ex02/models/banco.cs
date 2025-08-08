using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pag27ex02.models
{
    class banco
    {
        public double valor { get; set; }
        public double valorconta { get; set; }


        public double depositar(double valor, double valorconta)
        {
            return valorconta = valorconta + valor;
        }

        public double verificarsaldo(double valorconta)
        {
            return valorconta;
        }

        public double sacar(double valor, double valorconta)
        {
            try
            {
                if (valor > valorconta)
                {
                    throw new InvalidOperationException("saldo insuficiente para realizar o saque.");
                }
                return valorconta - valor;
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("erro");
                return valorconta;
            }
        }
    }
}
