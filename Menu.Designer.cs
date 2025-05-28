namespace Projeto_Semestral___Cantina
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btnTelaVendas = new Button();
            pictureBox1 = new PictureBox();
            BtnBalcao = new Button();
            BtnCozinha = new Button();
            BtnEstoque = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnTelaVendas
            // 
            btnTelaVendas.BackColor = Color.White;
            btnTelaVendas.Font = new Font("Inter SemiBold", 18F, FontStyle.Bold);
            btnTelaVendas.Location = new Point(133, 277);
            btnTelaVendas.Name = "btnTelaVendas";
            btnTelaVendas.Size = new Size(275, 84);
            btnTelaVendas.TabIndex = 1;
            btnTelaVendas.Text = "💵 Vendas";
            btnTelaVendas.UseVisualStyleBackColor = false;
            btnTelaVendas.Click += btnTelaVendas_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bolt;
            pictureBox1.Location = new Point(280, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // BtnBalcao
            // 
            BtnBalcao.BackColor = Color.White;
            BtnBalcao.Font = new Font("Inter SemiBold", 18F, FontStyle.Bold);
            BtnBalcao.Location = new Point(133, 155);
            BtnBalcao.Name = "BtnBalcao";
            BtnBalcao.Size = new Size(275, 84);
            BtnBalcao.TabIndex = 4;
            BtnBalcao.Text = "🏪 Balcão";
            BtnBalcao.UseVisualStyleBackColor = false;
            BtnBalcao.Click += BtnBalcao_Click;
            // 
            // BtnCozinha
            // 
            BtnCozinha.BackColor = Color.White;
            BtnCozinha.Font = new Font("Inter SemiBold", 18F, FontStyle.Bold);
            BtnCozinha.Location = new Point(433, 155);
            BtnCozinha.Name = "BtnCozinha";
            BtnCozinha.Size = new Size(275, 84);
            BtnCozinha.TabIndex = 5;
            BtnCozinha.Text = "👨‍🍳 Cozinha";
            BtnCozinha.UseVisualStyleBackColor = false;
            BtnCozinha.Click += BtnCozinha_Click;
            // 
            // BtnEstoque
            // 
            BtnEstoque.BackColor = Color.White;
            BtnEstoque.Font = new Font("Inter SemiBold", 18F, FontStyle.Bold);
            BtnEstoque.Location = new Point(433, 277);
            BtnEstoque.Name = "BtnEstoque";
            BtnEstoque.Size = new Size(275, 84);
            BtnEstoque.TabIndex = 6;
            BtnEstoque.Text = "📦 Estoque";
            BtnEstoque.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, 102);
            label1.Name = "label1";
            label1.Size = new Size(154, 36);
            label1.TabIndex = 7;
            label1.Text = "Menu Inicial";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 445);
            Controls.Add(label1);
            Controls.Add(BtnEstoque);
            Controls.Add(BtnCozinha);
            Controls.Add(BtnBalcao);
            Controls.Add(pictureBox1);
            Controls.Add(btnTelaVendas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTelaVendas;
        private PictureBox pictureBox1;
        private Button BtnBalcao;
        private Button BtnCozinha;
        private Button BtnEstoque;
        private Label label1;
    }
}