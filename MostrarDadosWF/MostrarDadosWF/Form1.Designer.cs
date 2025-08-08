namespace MostrarDadosWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_nome = new Label();
            lbl_idade = new Label();
            lbl_email = new Label();
            lbl_cpf = new Label();
            lbl_disciplina = new Label();
            btn_dados = new Button();
            btn_limpar = new Button();
            lblnome = new Label();
            lblidade = new Label();
            lblemail = new Label();
            lblcpf = new Label();
            lbldisciplina = new Label();
            SuspendLayout();
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(239, 47);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(0, 15);
            lbl_nome.TabIndex = 0;
            // 
            // lbl_idade
            // 
            lbl_idade.AutoSize = true;
            lbl_idade.Location = new Point(239, 89);
            lbl_idade.Name = "lbl_idade";
            lbl_idade.Size = new Size(0, 15);
            lbl_idade.TabIndex = 1;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(239, 136);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(0, 15);
            lbl_email.TabIndex = 2;
            // 
            // lbl_cpf
            // 
            lbl_cpf.AutoSize = true;
            lbl_cpf.Location = new Point(239, 180);
            lbl_cpf.Name = "lbl_cpf";
            lbl_cpf.Size = new Size(0, 15);
            lbl_cpf.TabIndex = 3;
            // 
            // lbl_disciplina
            // 
            lbl_disciplina.AutoSize = true;
            lbl_disciplina.Location = new Point(239, 224);
            lbl_disciplina.Name = "lbl_disciplina";
            lbl_disciplina.Size = new Size(0, 15);
            lbl_disciplina.TabIndex = 4;
            // 
            // btn_dados
            // 
            btn_dados.Location = new Point(98, 328);
            btn_dados.Name = "btn_dados";
            btn_dados.Size = new Size(197, 87);
            btn_dados.TabIndex = 5;
            btn_dados.Text = "Buscar Dados";
            btn_dados.UseVisualStyleBackColor = true;
            btn_dados.Click += btn_dados_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(466, 339);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(168, 76);
            btn_limpar.TabIndex = 6;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(98, 47);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(43, 15);
            lblnome.TabIndex = 7;
            lblnome.Text = "Nome:";
            // 
            // lblidade
            // 
            lblidade.AutoSize = true;
            lblidade.Location = new Point(98, 89);
            lblidade.Name = "lblidade";
            lblidade.Size = new Size(36, 15);
            lblidade.TabIndex = 8;
            lblidade.Text = "Idade";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(98, 136);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(36, 15);
            lblemail.TabIndex = 9;
            lblemail.Text = "Email";
            // 
            // lblcpf
            // 
            lblcpf.AutoSize = true;
            lblcpf.Location = new Point(98, 180);
            lblcpf.Name = "lblcpf";
            lblcpf.Size = new Size(28, 15);
            lblcpf.TabIndex = 10;
            lblcpf.Text = "CPF";
            // 
            // lbldisciplina
            // 
            lbldisciplina.AutoSize = true;
            lbldisciplina.Location = new Point(98, 224);
            lbldisciplina.Name = "lbldisciplina";
            lbldisciplina.Size = new Size(58, 15);
            lbldisciplina.TabIndex = 11;
            lbldisciplina.Text = "Disciplina";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbldisciplina);
            Controls.Add(lblcpf);
            Controls.Add(lblemail);
            Controls.Add(lblidade);
            Controls.Add(lblnome);
            Controls.Add(btn_limpar);
            Controls.Add(btn_dados);
            Controls.Add(lbl_disciplina);
            Controls.Add(lbl_cpf);
            Controls.Add(lbl_email);
            Controls.Add(lbl_idade);
            Controls.Add(lbl_nome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nome;
        private Label lbl_idade;
        private Label lbl_email;
        private Label lbl_cpf;
        private Label lbl_disciplina;
        private Button btn_dados;
        private Button btn_limpar;
        private Label lblnome;
        private Label lblidade;
        private Label lblemail;
        private Label lblcpf;
        private Label lbldisciplina;
    }
}
