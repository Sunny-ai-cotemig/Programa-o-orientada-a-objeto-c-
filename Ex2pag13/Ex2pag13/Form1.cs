namespace Ex2pag13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static int Somar(int a, int b)
        {
            return a + b;
        }

        private void btncalcu_Click(object sender, EventArgs e)
        {
            int n1, n2, resulsoma;

            n1 = int.Parse(txtprimeir.Text);
            n2 = int.Parse(txtsegund.Text);

            resulsoma = Somar(n1, n2);

            if (resulsoma % 2 == 0)
            {
                lblresul1.Text = "Numero é Par"; 
            }
            else
            {
                lblresul1.Text = "Numero é Impar";
            }

            if(resulsoma > 0)
            {
                lblresul2.Text = "Numero é positivo";
            }
            else
            {
                lblresul2.Text = "Numero é negativo";
            }

        }
    }
}
