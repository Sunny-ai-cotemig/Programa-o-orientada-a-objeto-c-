namespace Ex1Pag13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int n1, n2, soma, subtra, multi, divi;

            string a = cmbescolha.SelectedItem.ToString();
            n1 = int.Parse(txtprimeiro.Text);
            n2 = int.Parse(txtsegundo.Text);
            
            
            if(a == "Soma")
            {
                soma = n1 + n2;
                lblresul.Text = soma.ToString();
            }
            else if(a== "Subtração")
            {
                subtra = n1 - n2;
                lblresul.Text = subtra.ToString();
            }
            else if(a== "Multiplicação")
            {
                multi = n1 * n2;
                lblresul.Text = multi.ToString();
            }
            else if (a == "Divisão")
            {
                if(n1==0 || n2 == 0)
                {
                    lblresul.Text = "Não é possivel a operação";
                }
                else
                {
                    divi = n1 / n2;
                    lblresul.Text = divi.ToString();
                }
            }
        }

        private void txtprimeiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            MessageBox.Show("este campo aceita somente numero e virgula");
            
        }

        private void txtsegundo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            MessageBox.Show("este campo aceita somente numero e virgula");
            
        }
    }
}
