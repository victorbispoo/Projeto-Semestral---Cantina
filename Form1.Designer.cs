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
            SuspendLayout();
            // 
            // CantCardapio
            // 
            CantCardapio.Font = new Font("Agrandir Narrow", 8.999999F, FontStyle.Bold);
            CantCardapio.FormattingEnabled = true;
            CantCardapio.Location = new Point(23, 37);
            CantCardapio.Name = "CantCardapio";
            CantCardapio.Size = new Size(323, 324);
            CantCardapio.TabIndex = 0;
            CantCardapio.SelectedIndexChanged += CantCardapio_SelectedIndexChanged;
            // 
            // CantCarrinho
            // 
            CantCarrinho.Font = new Font("Agrandir Narrow", 8.999999F, FontStyle.Bold);
            CantCarrinho.FormattingEnabled = true;
            CantCarrinho.Location = new Point(422, 37);
            CantCarrinho.Name = "CantCarrinho";
            CantCarrinho.Size = new Size(356, 228);
            CantCarrinho.TabIndex = 1;
            // 
            // CantBtnAdd
            // 
            CantBtnAdd.AutoSize = true;
            CantBtnAdd.Font = new Font("Agrandir Narrow", 12F, FontStyle.Bold);
            CantBtnAdd.ForeColor = Color.FromArgb(17, 25, 12);
            CantBtnAdd.Location = new Point(422, 271);
            CantBtnAdd.Name = "CantBtnAdd";
            CantBtnAdd.Size = new Size(158, 37);
            CantBtnAdd.TabIndex = 2;
            CantBtnAdd.Text = "➕ Adicionar";
            CantBtnAdd.UseVisualStyleBackColor = true;
            // 
            // CantBtnRemov
            // 
            CantBtnRemov.AutoSize = true;
            CantBtnRemov.Font = new Font("Agrandir Narrow", 12F, FontStyle.Bold);
            CantBtnRemov.ForeColor = Color.FromArgb(17, 25, 12);
            CantBtnRemov.Location = new Point(605, 271);
            CantBtnRemov.Name = "CantBtnRemov";
            CantBtnRemov.Size = new Size(153, 37);
            CantBtnRemov.TabIndex = 3;
            CantBtnRemov.Text = "❌ Remover";
            CantBtnRemov.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Agrandir Narrow", 14.2499981F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(230, 225, 0);
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 4;
            label1.Text = "\U0001f956 Produtos";
            // 
            // CantBtnFin
            // 
            CantBtnFin.AutoSize = true;
            CantBtnFin.BackColor = Color.FromArgb(230, 225, 0);
            CantBtnFin.Font = new Font("Agrandir Narrow", 12F, FontStyle.Bold);
            CantBtnFin.ForeColor = Color.FromArgb(17, 25, 12);
            CantBtnFin.Location = new Point(422, 314);
            CantBtnFin.Name = "CantBtnFin";
            CantBtnFin.Size = new Size(158, 37);
            CantBtnFin.TabIndex = 5;
            CantBtnFin.Text = "💵 Finalizar Pedido";
            CantBtnFin.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Agrandir Narrow", 14.2499981F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(230, 225, 0);
            label2.Location = new Point(422, 9);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 6;
            label2.Text = "\U0001f6d2 Carrinho";
            // 
            // CtnLblTotal
            // 
            CtnLblTotal.AutoSize = true;
            CtnLblTotal.Font = new Font("Inter", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CtnLblTotal.ForeColor = Color.FromArgb(230, 225, 0);
            CtnLblTotal.Location = new Point(605, 316);
            CtnLblTotal.Name = "CtnLblTotal";
            CtnLblTotal.Size = new Size(174, 35);
            CtnLblTotal.TabIndex = 7;
            CtnLblTotal.Text = "Total: R$0.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 12, 12);
            ClientSize = new Size(800, 450);
            Controls.Add(CtnLblTotal);
            Controls.Add(label2);
            Controls.Add(CantBtnFin);
            Controls.Add(label1);
            Controls.Add(CantBtnRemov);
            Controls.Add(CantBtnAdd);
            Controls.Add(CantCarrinho);
            Controls.Add(CantCardapio);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
    }
}
