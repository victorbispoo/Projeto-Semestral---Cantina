namespace Projeto_Semestral___Cantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            CantCardapio = new ListBox();
            CantCarrinho = new ListBox();
            CantBtnAdd = new Button();
            CantBtnRemov = new Button();
            label1 = new Label();
            CantBtnFin = new Button();
            label2 = new Label();
            CtnLblTotal = new Label();
            pictureBox1 = new PictureBox();
            CantLimparCarrinho = new Button();
            BtnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CantCardapio
            // 
            CantCardapio.Font = new Font("Agrandir Narrow", 14.2499981F, FontStyle.Bold);
            CantCardapio.FormattingEnabled = true;
            CantCardapio.ItemHeight = 25;
            CantCardapio.Location = new Point(21, 96);
            CantCardapio.Name = "CantCardapio";
            CantCardapio.Size = new Size(369, 304);
            CantCardapio.TabIndex = 0;
            CantCardapio.SelectedIndexChanged += CantCardapio_SelectedIndexChanged;
            // 
            // CantCarrinho
            // 
            CantCarrinho.Font = new Font("Agrandir Narrow", 14.2499981F, FontStyle.Bold);
            CantCarrinho.FormattingEnabled = true;
            CantCarrinho.ItemHeight = 25;
            CantCarrinho.Location = new Point(451, 96);
            CantCarrinho.Name = "CantCarrinho";
            CantCarrinho.Size = new Size(450, 204);
            CantCarrinho.TabIndex = 1;
            // 
            // CantBtnAdd
            // 
            CantBtnAdd.AutoSize = true;
            CantBtnAdd.BackColor = Color.White;
            CantBtnAdd.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold);
            CantBtnAdd.ForeColor = Color.FromArgb(17, 25, 12);
            CantBtnAdd.Location = new Point(451, 315);
            CantBtnAdd.Name = "CantBtnAdd";
            CantBtnAdd.Size = new Size(197, 37);
            CantBtnAdd.TabIndex = 2;
            CantBtnAdd.Text = "➕ Adicionar";
            CantBtnAdd.UseVisualStyleBackColor = false;
            CantBtnAdd.Click += CantBtnAdd_Click;
            // 
            // CantBtnRemov
            // 
            CantBtnRemov.AutoSize = true;
            CantBtnRemov.BackColor = Color.White;
            CantBtnRemov.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold);
            CantBtnRemov.ForeColor = Color.FromArgb(17, 25, 12);
            CantBtnRemov.Location = new Point(726, 315);
            CantBtnRemov.Name = "CantBtnRemov";
            CantBtnRemov.Size = new Size(175, 37);
            CantBtnRemov.TabIndex = 3;
            CantBtnRemov.Text = "❌ Remover";
            CantBtnRemov.UseVisualStyleBackColor = false;
            CantBtnRemov.Click += CantBtnRemov_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(21, 57);
            label1.Name = "label1";
            label1.Size = new Size(141, 30);
            label1.TabIndex = 4;
            label1.Text = "\U0001f956 Produtos";
            // 
            // CantBtnFin
            // 
            CantBtnFin.AutoSize = true;
            CantBtnFin.BackColor = Color.FromArgb(230, 255, 0);
            CantBtnFin.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold);
            CantBtnFin.ForeColor = Color.FromArgb(17, 25, 12);
            CantBtnFin.Location = new Point(451, 361);
            CantBtnFin.Name = "CantBtnFin";
            CantBtnFin.Size = new Size(197, 37);
            CantBtnFin.TabIndex = 5;
            CantBtnFin.Text = "💵 Meios de pagamento";
            CantBtnFin.UseVisualStyleBackColor = false;
            CantBtnFin.Click += CantBtnFin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(451, 57);
            label2.Name = "label2";
            label2.Size = new Size(135, 30);
            label2.TabIndex = 6;
            label2.Text = "\U0001f6d2 Carrinho";
            label2.Click += label2_Click;
            // 
            // CtnLblTotal
            // 
            CtnLblTotal.AutoSize = true;
            CtnLblTotal.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold);
            CtnLblTotal.ForeColor = Color.Black;
            CtnLblTotal.Location = new Point(726, 364);
            CtnLblTotal.Name = "CtnLblTotal";
            CtnLblTotal.Size = new Size(149, 30);
            CtnLblTotal.TabIndex = 7;
            CtnLblTotal.Text = "Total: R$0.00";
            CtnLblTotal.Click += CtnLblTotal_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bolt;
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // CantLimparCarrinho
            // 
            CantLimparCarrinho.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CantLimparCarrinho.ForeColor = Color.Black;
            CantLimparCarrinho.Location = new Point(779, 60);
            CantLimparCarrinho.Name = "CantLimparCarrinho";
            CantLimparCarrinho.Size = new Size(122, 30);
            CantLimparCarrinho.TabIndex = 9;
            CantLimparCarrinho.Text = "Limpar Carrinho";
            CantLimparCarrinho.UseVisualStyleBackColor = true;
            CantLimparCarrinho.Click += CantLimparCarrinho_Click;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVoltar.ForeColor = Color.Black;
            BtnVoltar.Location = new Point(21, 430);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(87, 29);
            BtnVoltar.TabIndex = 10;
            BtnVoltar.Text = "🔙 Voltar";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(952, 471);
            Controls.Add(BtnVoltar);
            Controls.Add(CantLimparCarrinho);
            Controls.Add(pictureBox1);
            Controls.Add(CtnLblTotal);
            Controls.Add(label2);
            Controls.Add(CantBtnFin);
            Controls.Add(label1);
            Controls.Add(CantBtnRemov);
            Controls.Add(CantBtnAdd);
            Controls.Add(CantCarrinho);
            Controls.Add(CantCardapio);
            ForeColor = Color.FromArgb(243, 241, 238);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Cantina BOLT";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox CantCardapio;
        private ListBox CantCarrinho;
        private Button CantBtnAdd;
        private Button CantBtnRemov;
        private Label label1;
        private Button CantBtnFin;
        private Label label2;
        private Label CtnLblTotal;
        private PictureBox pictureBox1;
        private Button CantLimparCarrinho;
        private Button BtnVoltar;
    }
}
