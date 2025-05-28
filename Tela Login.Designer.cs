namespace Projeto_Semestral___Cantina
{
    partial class Tela_Login
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
            btnTelaVendas = new Button();
            BtnCozinha = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnTelaVendas
            // 
            btnTelaVendas.Location = new Point(12, 195);
            btnTelaVendas.Name = "btnTelaVendas";
            btnTelaVendas.Size = new Size(175, 89);
            btnTelaVendas.TabIndex = 0;
            btnTelaVendas.Text = "Vendas";
            btnTelaVendas.UseVisualStyleBackColor = true;
            btnTelaVendas.Click += btnTelaVendas_Click;
            // 
            // BtnCozinha
            // 
            BtnCozinha.Location = new Point(613, 195);
            BtnCozinha.Name = "BtnCozinha";
            BtnCozinha.Size = new Size(175, 89);
            BtnCozinha.TabIndex = 1;
            BtnCozinha.Text = "Cozinha";
            BtnCozinha.UseVisualStyleBackColor = true;
            BtnCozinha.Click += BtnCozinha_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bolt;
            pictureBox1.Location = new Point(164, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(477, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(321, 195);
            button1.Name = "button1";
            button1.Size = new Size(175, 89);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Tela_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(BtnCozinha);
            Controls.Add(btnTelaVendas);
            Name = "Tela_Login";
            Text = "Tela_Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTelaVendas;
        private Button BtnCozinha;
        private PictureBox pictureBox1;
        private Button button1;
    }
}