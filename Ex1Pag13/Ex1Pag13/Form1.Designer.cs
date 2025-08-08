namespace Ex1Pag13
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
            txtprimeiro = new TextBox();
            txtsegundo = new TextBox();
            cmbescolha = new ComboBox();
            lblresultado = new Label();
            btncalcular = new Button();
            lblresul = new Label();
            SuspendLayout();
            // 
            // txtprimeiro
            // 
            txtprimeiro.Location = new Point(94, 62);
            txtprimeiro.Multiline = true;
            txtprimeiro.Name = "txtprimeiro";
            txtprimeiro.Size = new Size(106, 32);
            txtprimeiro.TabIndex = 0;
            txtprimeiro.KeyPress += txtprimeiro_KeyPress;
            // 
            // txtsegundo
            // 
            txtsegundo.Location = new Point(94, 120);
            txtsegundo.Multiline = true;
            txtsegundo.Name = "txtsegundo";
            txtsegundo.Size = new Size(106, 34);
            txtsegundo.TabIndex = 1;
            txtsegundo.KeyPress += txtsegundo_KeyPress;
            // 
            // cmbescolha
            // 
            cmbescolha.FormattingEnabled = true;
            cmbescolha.Items.AddRange(new object[] { "Soma", "Subtração", "Multiplicação", "Divisão" });
            cmbescolha.Location = new Point(94, 195);
            cmbescolha.Name = "cmbescolha";
            cmbescolha.Size = new Size(119, 23);
            cmbescolha.TabIndex = 2;
            cmbescolha.Text = "Escolha a opreção";
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(95, 308);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(62, 15);
            lblresultado.TabIndex = 3;
            lblresultado.Text = "Resultado:";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(95, 250);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(95, 32);
            btncalcular.TabIndex = 4;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // lblresul
            // 
            lblresul.AutoSize = true;
            lblresul.Location = new Point(197, 308);
            lblresul.Name = "lblresul";
            lblresul.Size = new Size(13, 15);
            lblresul.TabIndex = 5;
            lblresul.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblresul);
            Controls.Add(btncalcular);
            Controls.Add(lblresultado);
            Controls.Add(cmbescolha);
            Controls.Add(txtsegundo);
            Controls.Add(txtprimeiro);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtprimeiro;
        private TextBox txtsegundo;
        private ComboBox cmbescolha;
        private Label lblresultado;
        private Button btncalcular;
        private Label lblresul;
    }
}
