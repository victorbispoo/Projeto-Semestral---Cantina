namespace Projeto_Semestral___Cantina
{
    partial class telaDeLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bypass = new Button();
            SuspendLayout();
            // 
            // bypass
            // 
            bypass.Font = new Font("Segoe UI", 20F);
            bypass.Location = new Point(275, 215);
            bypass.Name = "bypass";
            bypass.Size = new Size(208, 58);
            bypass.TabIndex = 0;
            bypass.Text = "bypass";
            bypass.UseVisualStyleBackColor = true;
            bypass.Click += bypass_Click;
            // 
            // telaDeLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(800, 450);
            Controls.Add(bypass);
            ForeColor = SystemColors.ControlText;
            Name = "telaDeLogin";
            Text = "telaDeLogin";
            ResumeLayout(false);
        }

        #endregion

        private Button bypass;
    }
}