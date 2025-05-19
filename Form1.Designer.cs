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
            CantCardapio = new ListBox();
            CantCarrinho = new ListBox();
            CantBtnAdd = new Button();
            CantBtnRemov = new Button();
            label1 = new Label();
            CantBtnFin = new Button();
            label2 = new Label();
            CtnLblTotal = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CantCardapio
            // 
            CantCardapio.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold);
            CantCardapio.FormattingEnabled = true;
            CantCardapio.ItemHeight = 18;
            CantCardapio.Location = new Point(21, 90);
            CantCardapio.Name = "CantCardapio";
            CantCardapio.Size = new Size(323, 310);
            CantCardapio.TabIndex = 0;
            CantCardapio.SelectedIndexChanged += CantCardapio_SelectedIndexChanged;
            // 
            // CantCarrinho
            // 
            CantCarrinho.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold);
            CantCarrinho.FormattingEnabled = true;
            CantCarrinho.ItemHeight = 18;
            CantCarrinho.Location = new Point(382, 90);
            CantCarrinho.Name = "CantCarrinho";
            CantCarrinho.Size = new Size(394, 220);
            CantCarrinho.TabIndex = 1;
            // 
            // CantBtnAdd
            // 
            CantBtnAdd.AutoSize = true;
            CantBtnAdd.BackColor = Color.White;
            CantBtnAdd.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold);
            CantBtnAdd.ForeColor = Color.FromArgb(17, 25, 12);
            CantBtnAdd.Location = new Point(382, 324);
            CantBtnAdd.Name = "CantBtnAdd";
            CantBtnAdd.Size = new Size(173, 37);
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
            CantBtnRemov.Location = new Point(604, 324);
            CantBtnRemov.Name = "CantBtnRemov";
            CantBtnRemov.Size = new Size(172, 37);
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
            CantBtnFin.Location = new Point(382, 367);
            CantBtnFin.Name = "CantBtnFin";
            CantBtnFin.Size = new Size(173, 37);
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
            label2.Location = new Point(420, 57);
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
            CtnLblTotal.Location = new Point(604, 370);
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
            pictureBox1.Size = new Size(141, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(800, 450);
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
            Name = "Form1";
            Text = "Form1";
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
    }
}
