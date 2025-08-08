namespace MinhaCalculadora
{
    internal class Calculadora
    {
        public int Soma { get; set; }
        public int Subtracao { get; set; }
        public int Multiplicacao { get; set; }
        public int Divisao { get; set; }

        public int Somar(int PrimeiroNum, int SegundoNum)
        {
            int resul= PrimeiroNum + SegundoNum;
            return resul;
        }

        public int Subtrair(int PrimeiroNum, int SegundoNum)
        {
            int resul = PrimeiroNum - SegundoNum;
            return resul;
        }

        public int Multiplicar (int PrimeiroNum, int SegundoNum)
        {
            int resul = 0;
           for (int i=0; i <= SegundoNum; i++)
            {

                resul = PrimeiroNum * i;  
            }
            return resul;
        }

        public int Dividir (int PrimeiroNum, int SegundoNum)
        {

            int resul = 0;
            if(PrimeiroNum == 0)
            {
                MessageBox.Show("Não da para dividir");
            }
            else
            {
                resul = PrimeiroNum / SegundoNum;
            }
            return resul;
        }
    } 
}
