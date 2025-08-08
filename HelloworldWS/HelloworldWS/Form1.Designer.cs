namespace HelloworldWS
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
            clckaqui = new Button();
            lbl_helloworld = new Label();
            SuspendLayout();
            // 
            // clckaqui
            // 
            clckaqui.Location = new Point(266, 56);
            clckaqui.Name = "clckaqui";
            clckaqui.Size = new Size(202, 109);
            clckaqui.TabIndex = 0;
            clckaqui.Text = "Clique aqui";
            clckaqui.UseVisualStyleBackColor = true;
            clckaqui.Click += clckaqui_Click;
            // 
            // lbl_helloworld
            // 
            lbl_helloworld.AutoSize = true;
            lbl_helloworld.Location = new Point(266, 183);
            lbl_helloworld.Name = "lbl_helloworld";
            lbl_helloworld.Size = new Size(0, 15);
            lbl_helloworld.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_helloworld);
            Controls.Add(clckaqui);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clckaqui;
        private Label lbl_helloworld;
    }
}
