using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8Pag34.Models
{
    internal class Trapezio : FigurasGeometricas
    {
        public override double CalcularArea(int BaseMaior, int Altura, int BaseMenor, int Raio)
        {
            return (BaseMaior + BaseMenor) * Altura / 2;
        }
    }
}
