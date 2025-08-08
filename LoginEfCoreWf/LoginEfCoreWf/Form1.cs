using LoginEfCoreWf.Context;
using LoginEfCoreWf.Models;

namespace LoginEfCoreWf
{
    public partial class f_login : Form
    {
        public f_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //login: bah
            // senha: 1230

            var login = tb_login.Text.ToString();
            var senha = tb_login.Text.ToString();
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(senha))
            {
                using var db = new LoginContext();
                try
                {
                    db.Add(new Login { Nome = login, Senha = senha });
                    db.SaveChangesAsync();
                } 
                catch(Exception erro)
                {
                    MessageBox.Show($"Deu erro ao tentar entrar no banco de dados: {erro.Message}");
                }

                MessageBox.Show("Deu tudo certo!!! Dados cadastrado com sucesso. \n Logado com sucesso");
            }
            else
            {
                MessageBox.Show("Deu errado, tu é burro. \n Prencha os dois campos!!!");
            }
        }
    }
}
