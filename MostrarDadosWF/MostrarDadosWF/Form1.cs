using MostrarDadosWF.Models;

namespace MostrarDadosWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_dados_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            lbl_nome.Text = pessoa.Nome;
            lbl_idade.Text = pessoa.Idade.ToString();
            lbl_email.Text = pessoa.Email;
            lbl_cpf.Text = pessoa.Cpf;
            lbl_disciplina.Text = pessoa.Disciplina;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lbl_nome.Text = string.Empty;
            lbl_idade.Text = string.Empty;
            lbl_email.Text = string.Empty;
            lbl_cpf.Text = string.Empty;
            lbl_disciplina.Text = string.Empty;
        }
    }
}
