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
            string EscolhaOpera�ao = cmbAritmetica.Text;
            
                
                switch (EscolhaOpera�ao)
                {
                    case "Soma":
                        resul = calculo.Somar(PrimeiroNUm, SegundoNUm);
                        Aplicacao.Add(resul);
                        lblResultado.Text = resul.ToString();
                        if (Aplicacao.Count >= 10)
                    {
                        MessageBox.Show("Voc� ja atingiu seu limite de aplica��o");
                        Application.Exit();
                        return;
                    }
                        break;
                    case "Subtra��o":
                        resul = calculo.Subtrair(PrimeiroNUm, SegundoNUm);
                        Aplicacao.Add(resul);
                        lblResultado.Text = resul.ToString();
                    if (Aplicacao.Count >= 10)
                    {
                        MessageBox.Show("Voc� ja atingiu seu limite de aplica��o");
                        Application.Exit();
                        return;
                    }
                    break;
                    case "Multiplica��o":
                        resul = calculo.Multiplicar(PrimeiroNUm, SegundoNUm);
                        Aplicacao.Add(resul);
                        lblResultado.Text = resul.ToString();
                    if (Aplicacao.Count >= 10)
                    {
                        MessageBox.Show("Voc� ja atingiu seu limite de aplica��o");
                        Application.Exit();
                        return;
                    }
                    break;

                    case "Divis�o":
                        resul = calculo.Dividir(PrimeiroNUm, SegundoNUm);
                        Aplicacao.Add(resul);
                        lblResultado.Text = resul.ToString();
                    if (Aplicacao.Count >= 10)
                    {
                        MessageBox.Show("Voc� ja atingiu seu limite de aplica��o");
                        Application.Exit();
                        return;
                    }
                    break;
                }
                contt++;
                lblNumrepeti.Text =  " De repeti��o";
               
            
        }
    }
}
