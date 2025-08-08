namespace Ex2pag27
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
            lblbanco = new Label();
            label2 = new Label();
            cmbescolha = new ComboBox();
            label3 = new Label();
            txtinserir = new TextBox();
            btnpegar = new Button();
            SuspendLayout();
            // 
            // lblbanco
            // 
            lblbanco.AutoSize = true;
            lblbanco.Location = new Point(363, 62);
            lblbanco.Name = "lblbanco";
            lblbanco.Size = new Size(40, 15);
            lblbanco.TabIndex = 0;
            lblbanco.Text = "Banco";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 108);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 1;
            label2.Text = "Selecina operação";
            // 
            // cmbescolha
            // 
            cmbescolha.FormattingEnabled = true;
            cmbescolha.Items.AddRange(new object[] { "Depositar", "Sacar" });
            cmbescolha.Location = new Point(318, 151);
            cmbescolha.Name = "cmbescolha";
            cmbescolha.Size = new Size(121, 23);
            cmbescolha.TabIndex = 2;
            cmbescolha.SelectedIndexChanged += cmbescolha_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 214);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 3;
            label3.Text = "Insira o valor";
            // 
            // txtinserir
            // 
            txtinserir.Location = new Point(328, 264);
            txtinserir.Name = "txtinserir";
            txtinserir.Size = new Size(100, 23);
            txtinserir.TabIndex = 4;
            // 
            // btnpegar
            // 
            btnpegar.Location = new Point(328, 349);
            btnpegar.Name = "btnpegar";
            btnpegar.Size = new Size(111, 32);
            btnpegar.TabIndex = 5;
            btnpegar.Text = "button1";
            btnpegar.UseVisualStyleBackColor = true;
            btnpegar.Click += btnpegar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnpegar);
            Controls.Add(txtinserir);
            Controls.Add(label3);
            Controls.Add(cmbescolha);
            Controls.Add(label2);
            Controls.Add(lblbanco);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblbanco;
        private Label label2;
        private ComboBox cmbescolha;
        private Label label3;
        private TextBox txtinserir;
        private Button btnpegar;
    }
}
