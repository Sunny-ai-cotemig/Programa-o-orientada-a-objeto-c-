using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7Pag34.Models
{
    internal class ContaBancaria
    {
        public void NumeroConta()
        {
            try
            {
                Console.WriteLine("Escreva o numero da conta");
                int NumConta = int.Parse(Console.ReadLine());
               
            }
            
            catch (FormatException)
            {
                Console.WriteLine("\nErro: Por favor coloca numeros não letras");
            }
        }
        public string NomeUsuario()
        {
            Console.WriteLine("Escreva seu nome");
            string Nome = Console.ReadLine();
            return Nome;
        }

        public void Clasificação()
        {
            Console.WriteLine("Escreva a classificação da sua conta 1 para 'Comum' e 2 para 'Especial' ");
            int Classificacao=int.Parse(Console.ReadLine());
            switch (Classificacao)
            {
                case 1:
                    Console.WriteLine("Sua conta é comum");

                break;
                case 2:
                    Console.WriteLine("Sua conta é especial");
                break;

            }
            
        }

        public void Saldo()
        {
            
            Console.WriteLine("Escreva o seu saldo");
            double Saldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Deseja sacar ou depositar? 1-Não, 2-Sacar, 3-Depositar");
            int Desejo = int.Parse(Console.ReadLine());
            switch (Desejo) {
                case 1:
                    Console.WriteLine("Programa fechando");
                    break;
                case 2:
                    Console.WriteLine("Quantos deseja sacar?");
                        double Saque = double.Parse(Console.ReadLine());
                    double SaldoAtualizado = Saldo - Saque;
                    break;
                case 3:
                    Console.WriteLine("Quantos deseja Depositar?");
                    double Deposito = double.Parse(Console.ReadLine());
                     SaldoAtualizado = Saldo + Deposito;
                    break;
            }

           
        }
 
    }
}
