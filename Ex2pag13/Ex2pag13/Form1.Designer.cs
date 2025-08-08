namespace Ex2pag13
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
            lblresul1 = new Label();
            btncalcu = new Button();
            txtprimeir = new TextBox();
            txtsegund = new TextBox();
            lblresul2 = new Label();
            SuspendLayout();
            // 
            // lblresul1
            // 
            lblresul1.AutoSize = true;
            lblresul1.Location = new Point(331, 288);
            lblresul1.Name = "lblresul1";
            lblresul1.Size = new Size(13, 15);
            lblresul1.TabIndex = 1;
            lblresul1.Text = "0";
            // 
            // btncalcu
            // 
            btncalcu.Location = new Point(312, 222);
            btncalcu.Name = "btncalcu";
            btncalcu.Size = new Size(100, 37);
            btncalcu.TabIndex = 2;
            btncalcu.Text = "Calcular";
            btncalcu.UseVisualStyleBackColor = true;
            btncalcu.Click += btncalcu_Click;
            // 
            // txtprimeir
            // 
            txtprimeir.Location = new Point(312, 91);
            txtprimeir.Name = "txtprimeir";
            txtprimeir.Size = new Size(100, 23);
            txtprimeir.TabIndex = 3;
            // 
            // txtsegund
            // 
            txtsegund.Location = new Point(312, 161);
            txtsegund.Name = "txtsegund";
            txtsegund.Size = new Size(100, 23);
            txtsegund.TabIndex = 4;
            // 
            // lblresul2
            // 
            lblresul2.AutoSize = true;
            lblresul2.Location = new Point(331, 339);
            lblresul2.Name = "lblresul2";
            lblresul2.Size = new Size(13, 15);
            lblresul2.TabIndex = 5;
            lblresul2.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblresul2);
            Controls.Add(txtsegund);
            Controls.Add(txtprimeir);
            Controls.Add(btncalcu);
            Controls.Add(lblresul1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblresul1;
        private Button btncalcu;
        private TextBox txtprimeir;
        private TextBox txtsegund;
        private Label lblresul2;
    }
}
