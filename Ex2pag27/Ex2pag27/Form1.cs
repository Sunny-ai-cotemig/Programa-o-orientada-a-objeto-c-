namespace Ex2pag27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbescolha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbescolha.SelectedItem != null)
            {
                btnpegar.Text = cmbescolha.SelectedItem.ToString();
            }
        }

        private void btnpegar_Click(object sender, EventArgs e)
        {
            double saldo, valor;
            
            
        }
    }
}
