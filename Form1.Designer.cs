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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            CantCardapio = new ListBox();
            CantCarrinho = new ListBox();
            label1 = new Label();
            label2 = new Label();
            CtnLblTotal = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            button1 = new Button();
            CantBtnAdd = new Guna.UI2.WinForms.Guna2Button();
            CantBtnRemover = new Guna.UI2.WinForms.Guna2Button();
            btnFinalizarPedido = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            btnVoltarMenu = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CantCardapio
            // 
            CantCardapio.Font = new Font("Agrandir Narrow", 12F, FontStyle.Bold);
            CantCardapio.FormattingEnabled = true;
            CantCardapio.ItemHeight = 21;
            CantCardapio.Location = new Point(21, 96);
            CantCardapio.Name = "CantCardapio";
            CantCardapio.Size = new Size(369, 298);
            CantCardapio.TabIndex = 0;
            CantCardapio.SelectedIndexChanged += CantCardapio_SelectedIndexChanged;
            // 
            // CantCarrinho
            // 
            CantCarrinho.Font = new Font("Agrandir Narrow", 12F, FontStyle.Bold);
            CantCarrinho.FormattingEnabled = true;
            CantCarrinho.ItemHeight = 21;
            CantCarrinho.Location = new Point(451, 96);
            CantCarrinho.Name = "CantCarrinho";
            CantCarrinho.Size = new Size(450, 193);
            CantCarrinho.TabIndex = 1;
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
            CtnLblTotal.BackColor = SystemColors.Window;
            CtnLblTotal.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold);
            CtnLblTotal.ForeColor = Color.Black;
            CtnLblTotal.Location = new Point(685, 364);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Inter Black", 22.25F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(157, 12);
            label3.Name = "label3";
            label3.Size = new Size(150, 43);
            label3.TabIndex = 18;
            label3.Text = "| Vendas";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = SystemColors.Window;
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(17, 25, 12);
            button1.Location = new Point(680, 360);
            button1.Name = "button1";
            button1.Size = new Size(221, 36);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = false;
            // 
            // CantBtnAdd
            // 
            CantBtnAdd.Animated = true;
            CantBtnAdd.BorderRadius = 8;
            CantBtnAdd.BorderThickness = 1;
            CantBtnAdd.Cursor = Cursors.Hand;
            CantBtnAdd.CustomizableEdges = customizableEdges1;
            CantBtnAdd.DisabledState.BorderColor = Color.DarkGray;
            CantBtnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            CantBtnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CantBtnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CantBtnAdd.FillColor = SystemColors.Window;
            CantBtnAdd.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold);
            CantBtnAdd.ForeColor = Color.Black;
            CantBtnAdd.Image = Properties.Resources.adicionar;
            CantBtnAdd.Location = new Point(451, 315);
            CantBtnAdd.Name = "CantBtnAdd";
            CantBtnAdd.PressedColor = Color.FromArgb(230, 255, 0);
            CantBtnAdd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            CantBtnAdd.Size = new Size(221, 37);
            CantBtnAdd.TabIndex = 22;
            CantBtnAdd.Text = " Adicionar";
            CantBtnAdd.Click += CantBtnAdd_Click;
            // 
            // CantBtnRemover
            // 
            CantBtnRemover.Animated = true;
            CantBtnRemover.BorderRadius = 8;
            CantBtnRemover.BorderThickness = 1;
            CantBtnRemover.Cursor = Cursors.Hand;
            CantBtnRemover.CustomizableEdges = customizableEdges3;
            CantBtnRemover.DisabledState.BorderColor = Color.DarkGray;
            CantBtnRemover.DisabledState.CustomBorderColor = Color.DarkGray;
            CantBtnRemover.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CantBtnRemover.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CantBtnRemover.FillColor = SystemColors.Window;
            CantBtnRemover.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold);
            CantBtnRemover.ForeColor = Color.Black;
            CantBtnRemover.Image = Properties.Resources.remover_carronhp;
            CantBtnRemover.Location = new Point(680, 315);
            CantBtnRemover.Name = "CantBtnRemover";
            CantBtnRemover.PressedColor = Color.FromArgb(230, 255, 0);
            CantBtnRemover.ShadowDecoration.CustomizableEdges = customizableEdges4;
            CantBtnRemover.Size = new Size(221, 37);
            CantBtnRemover.TabIndex = 23;
            CantBtnRemover.Text = " Remover";
            CantBtnRemover.Click += CantBtnRemov_Click;
            // 
            // btnFinalizarPedido
            // 
            btnFinalizarPedido.Animated = true;
            btnFinalizarPedido.BorderColor = SystemColors.Window;
            btnFinalizarPedido.BorderRadius = 8;
            btnFinalizarPedido.BorderThickness = 2;
            btnFinalizarPedido.Cursor = Cursors.Hand;
            btnFinalizarPedido.CustomizableEdges = customizableEdges5;
            btnFinalizarPedido.DisabledState.BorderColor = Color.DarkGray;
            btnFinalizarPedido.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFinalizarPedido.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFinalizarPedido.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFinalizarPedido.FillColor = Color.FromArgb(230, 255, 0);
            btnFinalizarPedido.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold);
            btnFinalizarPedido.ForeColor = Color.Black;
            btnFinalizarPedido.Image = Properties.Resources.finalizaer;
            btnFinalizarPedido.Location = new Point(451, 358);
            btnFinalizarPedido.Name = "btnFinalizarPedido";
            btnFinalizarPedido.PressedColor = SystemColors.Control;
            btnFinalizarPedido.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnFinalizarPedido.Size = new Size(223, 40);
            btnFinalizarPedido.TabIndex = 24;
            btnFinalizarPedido.Text = " Meios de pagamento";
            btnFinalizarPedido.Click += CantBtnFin_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.Animated = true;
            guna2Button1.BorderRadius = 8;
            guna2Button1.BorderThickness = 1;
            guna2Button1.Cursor = Cursors.Hand;
            guna2Button1.CustomizableEdges = customizableEdges7;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = SystemColors.Window;
            guna2Button1.Font = new Font("Inter SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Image = Properties.Resources.apagar;
            guna2Button1.Location = new Point(774, 57);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.FromArgb(230, 255, 0);
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button1.Size = new Size(127, 30);
            guna2Button1.TabIndex = 25;
            guna2Button1.Text = " Limpar Carrinho";
            // 
            // btnVoltarMenu
            // 
            btnVoltarMenu.Animated = true;
            btnVoltarMenu.BorderRadius = 5;
            btnVoltarMenu.Cursor = Cursors.Hand;
            btnVoltarMenu.CustomizableEdges = customizableEdges9;
            btnVoltarMenu.DisabledState.BorderColor = Color.DarkGray;
            btnVoltarMenu.DisabledState.CustomBorderColor = Color.DarkGray;
            btnVoltarMenu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnVoltarMenu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnVoltarMenu.FillColor = SystemColors.Window;
            btnVoltarMenu.Font = new Font("Inter", 12F, FontStyle.Bold);
            btnVoltarMenu.ForeColor = Color.Black;
            btnVoltarMenu.Image = (Image)resources.GetObject("btnVoltarMenu.Image");
            btnVoltarMenu.Location = new Point(21, 410);
            btnVoltarMenu.Name = "btnVoltarMenu";
            btnVoltarMenu.PressedColor = Color.FromArgb(230, 255, 0);
            btnVoltarMenu.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnVoltarMenu.Size = new Size(135, 36);
            btnVoltarMenu.TabIndex = 26;
            btnVoltarMenu.Text = " Voltar";
            btnVoltarMenu.Click += BtnVoltar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(952, 471);
            Controls.Add(btnVoltarMenu);
            Controls.Add(guna2Button1);
            Controls.Add(btnFinalizarPedido);
            Controls.Add(CantBtnRemover);
            Controls.Add(CantBtnAdd);
            Controls.Add(pictureBox1);
            Controls.Add(CtnLblTotal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CantCarrinho);
            Controls.Add(CantCardapio);
            Controls.Add(label3);
            Controls.Add(button1);
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
        private Label label1;
        private Label label2;
        private Label CtnLblTotal;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button1;
        private Guna.UI2.WinForms.Guna2Button CantBtnAdd;
        private Guna.UI2.WinForms.Guna2Button CantBtnRemover;
        private Guna.UI2.WinForms.Guna2Button btnFinalizarPedido;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnVoltarMenu;
    }
}
