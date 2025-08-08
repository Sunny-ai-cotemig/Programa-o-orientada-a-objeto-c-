using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1pag27.Models
{
    internal class Calculadora
    {
        public void Realizacaooperacao()
        {
            try
            {
                double num1, num2;
                Console.WriteLine("Digite dois numeros para dividir");
                num1 = double.Parse(Console.ReadLine());
                num2 = double.Parse(Console.ReadLine());

                if(num2 == 0)
                {
                    throw new DivideByZeroException("Não é possivel dividir por 0");

                }
                double resultado = num1 / num2;
                Console.Write("O resultado é " + resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nErro: Por avor insira apenas válores numericos validos!");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"\nErro: {ex.Message}");
            }
        }
    }
}
