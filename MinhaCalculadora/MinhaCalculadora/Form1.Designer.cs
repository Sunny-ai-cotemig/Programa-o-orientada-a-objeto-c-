namespace MinhaCalculadora
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
            txtPrimeiroNum = new TextBox();
            txtSegundoNum = new TextBox();
            cmbAritmetica = new ComboBox();
            btnCalcular = new Button();
            lblDiscri = new Label();
            lblResultado = new Label();
            lblDiscriopera = new Label();
            lblResultadoaplicados = new Label();
            lblRepi = new Label();
            lblNumrepeti = new Label();
            SuspendLayout();
            // 
            // txtPrimeiroNum
            // 
            txtPrimeiroNum.Location = new Point(113, 99);
            txtPrimeiroNum.Multiline = true;
            txtPrimeiroNum.Name = "txtPrimeiroNum";
            txtPrimeiroNum.Size = new Size(124, 32);
            txtPrimeiroNum.TabIndex = 0;
            txtPrimeiroNum.KeyPress += txtPrimeiroNum_KeyPress;
            // 
            // txtSegundoNum
            // 
            txtSegundoNum.Location = new Point(478, 99);
            txtSegundoNum.Multiline = true;
            txtSegundoNum.Name = "txtSegundoNum";
            txtSegundoNum.Size = new Size(111, 32);
            txtSegundoNum.TabIndex = 1;
            txtSegundoNum.KeyPress += txtSegundoNum_KeyPress;
            // 
            // cmbAritmetica
            // 
            cmbAritmetica.FormattingEnabled = true;
            cmbAritmetica.Items.AddRange(new object[] { "Soma", "Subtração", "Multiplicação", "Divisão" });
            cmbAritmetica.Location = new Point(280, 108);
            cmbAritmetica.Name = "cmbAritmetica";
            cmbAritmetica.Size = new Size(129, 23);
            cmbAritmetica.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(312, 210);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(118, 36);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblDiscri
            // 
            lblDiscri.AutoSize = true;
            lblDiscri.Location = new Point(113, 294);
            lblDiscri.Name = "lblDiscri";
            lblDiscri.Size = new Size(62, 15);
            lblDiscri.TabIndex = 4;
            lblDiscri.Text = "Resultado:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(219, 294);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(13, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "0";
            // 
            // lblDiscriopera
            // 
            lblDiscriopera.AutoSize = true;
            lblDiscriopera.Location = new Point(113, 350);
            lblDiscriopera.Name = "lblDiscriopera";
            lblDiscriopera.Size = new Size(146, 15);
            lblDiscriopera.TabIndex = 6;
            lblDiscriopera.Text = "Quantidades de aplicação:";
            // 
            // lblResultadoaplicados
            // 
            lblResultadoaplicados.AutoSize = true;
            lblResultadoaplicados.Location = new Point(291, 350);
            lblResultadoaplicados.Name = "lblResultadoaplicados";
            lblResultadoaplicados.Size = new Size(13, 15);
            lblResultadoaplicados.TabIndex = 7;
            lblResultadoaplicados.Text = "0";
            // 
            // lblRepi
            // 
            lblRepi.AutoSize = true;
            lblRepi.Location = new Point(114, 398);
            lblRepi.Name = "lblRepi";
            lblRepi.Size = new Size(195, 15);
            lblRepi.TabIndex = 8;
            lblRepi.Text = "Os numeros de repetição que ja fez:";
            // 
            // lblNumrepeti
            // 
            lblNumrepeti.AutoSize = true;
            lblNumrepeti.Location = new Point(351, 398);
            lblNumrepeti.Name = "lblNumrepeti";
            lblNumrepeti.Size = new Size(13, 15);
            lblNumrepeti.TabIndex = 9;
            lblNumrepeti.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNumrepeti);
            Controls.Add(lblRepi);
            Controls.Add(lblResultadoaplicados);
            Controls.Add(lblDiscriopera);
            Controls.Add(lblResultado);
            Controls.Add(lblDiscri);
            Controls.Add(btnCalcular);
            Controls.Add(cmbAritmetica);
            Controls.Add(txtSegundoNum);
            Controls.Add(txtPrimeiroNum);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrimeiroNum;
        private TextBox txtSegundoNum;
        private ComboBox cmbAritmetica;
        private Button btnCalcular;
        private Label lblDiscri;
        private Label lblResultado;
        private Label lblDiscriopera;
        private Label lblResultadoaplicados;
        private Label lblRepi;
        private Label lblNumrepeti;
    }
}
