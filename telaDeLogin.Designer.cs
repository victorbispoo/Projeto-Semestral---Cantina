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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            bypass = new Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2WinProgressIndicator1 = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            SuspendLayout();
            // 
            // bypass
            // 
            bypass.AllowDrop = true;
            bypass.AutoSize = true;
            bypass.BackColor = SystemColors.Control;
            bypass.Cursor = Cursors.Hand;
            bypass.FlatAppearance.BorderSize = 0;
            bypass.FlatStyle = FlatStyle.System;
            bypass.Font = new Font("Inter", 15.75F, FontStyle.Bold);
            bypass.Location = new Point(161, 195);
            bypass.Name = "bypass";
            bypass.Size = new Size(293, 58);
            bypass.TabIndex = 0;
            bypass.Text = "Abrir menu";
            bypass.TextImageRelation = TextImageRelation.ImageAboveText;
            bypass.UseVisualStyleBackColor = false;
            bypass.Click += bypass_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Agrandir Narrow", 27.75F, FontStyle.Bold);
            guna2HtmlLabel1.Location = new Point(203, 41);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(208, 52);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Tela de login";
            // 
            // guna2WinProgressIndicator1
            // 
            guna2WinProgressIndicator1.AnimationSpeed = 80;
            guna2WinProgressIndicator1.AutoStart = true;
            guna2WinProgressIndicator1.BackColor = Color.Transparent;
            guna2WinProgressIndicator1.Location = new Point(249, 99);
            guna2WinProgressIndicator1.Name = "guna2WinProgressIndicator1";
            guna2WinProgressIndicator1.ProgressColor = Color.Black;
            guna2WinProgressIndicator1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2WinProgressIndicator1.Size = new Size(90, 90);
            guna2WinProgressIndicator1.TabIndex = 3;
            // 
            // telaDeLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources._2356480_stock_photo_smiley;
            ClientSize = new Size(606, 398);
            Controls.Add(guna2WinProgressIndicator1);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(bypass);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "telaDeLogin";
            Text = "telaDeLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bypass;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator guna2WinProgressIndicator1;
    }
}