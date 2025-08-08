using System.Runtime.Serialization;

namespace MinhaCalculadora
{
    public partial class Form1 : Form
    {

        List<int> Aplicacao = [];

        public Form1()
        {
            InitializeComponent();
        }

        Calculadora calculo = new Calculadora();

        private void txtPrimeiroNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSegundoNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resul, contt=0;
            int PrimeiroNUm = int.Parse(txtPrimeiroNum.Text);
            int SegundoNUm = int.Parse(txtSegundoNum.Text);
            string EscolhaOperaçao = cmbAritmetica.Text;
            
                
                switch (EscolhaOperaçao)
                {
                    case "Soma":
                        resul = calculo.Somar(PrimeiroNUm, SegundoNUm);
                        Aplicacao.Add(resul);
                        lblResultado.Text = resul.ToString();
                        if (Aplicacao.Count >= 10)
                    {
                        MessageBox.Show("Você ja atingiu seu limite de aplicação");
                        Application.Exit();
                        return;
                    }
                        break;
                    case "Subtração":
                        resul = calculo.Subtrair(PrimeiroNUm, SegundoNUm);
                        Aplicacao.Add(resul);
                        lblResultado.Text = resul.ToString();
                    if (Aplicacao.Count >= 10)
                    {
                        MessageBox.Show("Você ja atingiu seu limite de aplicação");
                        Application.Exit();
                        return;
                    }
                    break;
                    case "Multiplicação":
                        resul = calculo.Multiplicar(PrimeiroNUm, SegundoNUm);
                        Aplicacao.Add(resul);
                        lblResultado.Text = resul.ToString();
                    if (Aplicacao.Count >= 10)
                    {
                        MessageBox.Show("Você ja atingiu seu limite de aplicação");
                        Application.Exit();
                        return;
                    }
                    break;

                    case "Divisão":
                        resul = calculo.Dividir(PrimeiroNUm, SegundoNUm);
                        Aplicacao.Add(resul);
                        lblResultado.Text = resul.ToString();
                    if (Aplicacao.Count >= 10)
                    {
                        MessageBox.Show("Você ja atingiu seu limite de aplicação");
                        Application.Exit();
                        return;
                    }
                    break;
                }
                contt++;
                lblNumrepeti.Text =  " De repetição";
               
            
        }
    }
}
