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
            components = new System.ComponentModel.Container();
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            CantCardapio = new ListBox();
            CantCarrinho = new ListBox();
            label1 = new Label();
            CtnLblTotal = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            CantBtnAdd = new Guna.UI2.WinForms.Guna2Button();
            CantBtnRemover = new Guna.UI2.WinForms.Guna2Button();
            btnFinalizarPedido = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            btnVoltarMenu = new Guna.UI2.WinForms.Guna2Button();
            guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CantCardapio
            // 
            CantCardapio.BorderStyle = BorderStyle.None;
            CantCardapio.Font = new Font("Inter", 12F);
            CantCardapio.FormattingEnabled = true;
            CantCardapio.ItemHeight = 23;
            CantCardapio.Location = new Point(21, 96);
            CantCardapio.Name = "CantCardapio";
            CantCardapio.Size = new Size(369, 299);
            CantCardapio.TabIndex = 0;
            CantCardapio.SelectedIndexChanged += CantCardapio_SelectedIndexChanged;
            // 
            // CantCarrinho
            // 
            CantCarrinho.BorderStyle = BorderStyle.None;
            CantCarrinho.Font = new Font("Inter", 12F);
            CantCarrinho.FormattingEnabled = true;
            CantCarrinho.ItemHeight = 23;
            CantCarrinho.Location = new Point(420, 96);
            CantCarrinho.Name = "CantCarrinho";
            CantCarrinho.Size = new Size(481, 161);
            CantCarrinho.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(21, 57);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 4;
            label1.Text = "\U0001f956 Produtos";
            // 
            // CtnLblTotal
            // 
            CtnLblTotal.AutoSize = true;
            CtnLblTotal.BackColor = SystemColors.Window;
            CtnLblTotal.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CtnLblTotal.ForeColor = Color.Black;
            CtnLblTotal.Location = new Point(754, 366);
            CtnLblTotal.Name = "CtnLblTotal";
            CtnLblTotal.Size = new Size(69, 23);
            CtnLblTotal.TabIndex = 7;
            CtnLblTotal.Text = "R$0,00";
            CtnLblTotal.Click += CtnLblTotal_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bolt;
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Agrandir Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(164, 4);
            label3.Name = "label3";
            label3.Size = new Size(156, 50);
            label3.TabIndex = 18;
            label3.Text = "| Vendas";
            // 
            // CantBtnAdd
            // 
            CantBtnAdd.Animated = true;
            CantBtnAdd.BorderRadius = 15;
            CantBtnAdd.Cursor = Cursors.Hand;
            CantBtnAdd.CustomizableEdges = customizableEdges1;
            CantBtnAdd.DisabledState.BorderColor = Color.DarkGray;
            CantBtnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            CantBtnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CantBtnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CantBtnAdd.FillColor = SystemColors.Window;
            CantBtnAdd.Font = new Font("Inter", 12F, FontStyle.Bold);
            CantBtnAdd.ForeColor = Color.Black;
            CantBtnAdd.Image = Properties.Resources.adicionar;
            CantBtnAdd.Location = new Point(420, 279);
            CantBtnAdd.Name = "CantBtnAdd";
            CantBtnAdd.PressedColor = Color.FromArgb(230, 255, 0);
            CantBtnAdd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            CantBtnAdd.Size = new Size(221, 50);
            CantBtnAdd.TabIndex = 22;
            CantBtnAdd.Text = " Adicionar";
            CantBtnAdd.Click += CantBtnAdd_Click;
            // 
            // CantBtnRemover
            // 
            CantBtnRemover.Animated = true;
            CantBtnRemover.BorderRadius = 15;
            CantBtnRemover.Cursor = Cursors.Hand;
            CantBtnRemover.CustomizableEdges = customizableEdges3;
            CantBtnRemover.DisabledState.BorderColor = Color.DarkGray;
            CantBtnRemover.DisabledState.CustomBorderColor = Color.DarkGray;
            CantBtnRemover.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CantBtnRemover.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CantBtnRemover.FillColor = SystemColors.Window;
            CantBtnRemover.Font = new Font("Inter", 12F, FontStyle.Bold);
            CantBtnRemover.ForeColor = Color.Black;
            CantBtnRemover.Image = Properties.Resources.remover_carronhp;
            CantBtnRemover.Location = new Point(680, 279);
            CantBtnRemover.Name = "CantBtnRemover";
            CantBtnRemover.PressedColor = Color.FromArgb(230, 255, 0);
            CantBtnRemover.ShadowDecoration.CustomizableEdges = customizableEdges4;
            CantBtnRemover.Size = new Size(221, 50);
            CantBtnRemover.TabIndex = 23;
            CantBtnRemover.Text = " Remover";
            CantBtnRemover.Click += CantBtnRemov_Click;
            // 
            // btnFinalizarPedido
            // 
            btnFinalizarPedido.Animated = true;
            btnFinalizarPedido.BorderColor = SystemColors.Window;
            btnFinalizarPedido.BorderRadius = 15;
            btnFinalizarPedido.Cursor = Cursors.Hand;
            btnFinalizarPedido.CustomizableEdges = customizableEdges5;
            btnFinalizarPedido.DisabledState.BorderColor = Color.DarkGray;
            btnFinalizarPedido.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFinalizarPedido.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFinalizarPedido.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFinalizarPedido.FillColor = Color.FromArgb(230, 255, 0);
            btnFinalizarPedido.Font = new Font("Inter", 12F, FontStyle.Bold);
            btnFinalizarPedido.ForeColor = Color.Black;
            btnFinalizarPedido.Image = Properties.Resources.finalizaer;
            btnFinalizarPedido.Location = new Point(420, 352);
            btnFinalizarPedido.Name = "btnFinalizarPedido";
            btnFinalizarPedido.PressedColor = SystemColors.Control;
            btnFinalizarPedido.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnFinalizarPedido.Size = new Size(221, 48);
            btnFinalizarPedido.TabIndex = 24;
            btnFinalizarPedido.Text = " Meios de pagamento";
            btnFinalizarPedido.Click += CantBtnFin_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.Animated = true;
            guna2Button1.BorderRadius = 8;
            guna2Button1.Cursor = Cursors.Hand;
            guna2Button1.CustomizableEdges = customizableEdges7;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = SystemColors.Window;
            guna2Button1.Font = new Font("Inter", 12F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Image = Properties.Resources.apagar;
            guna2Button1.Location = new Point(719, 57);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.FromArgb(230, 255, 0);
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button1.Size = new Size(182, 33);
            guna2Button1.TabIndex = 25;
            guna2Button1.Text = " Limpar Carrinho";
            // 
            // btnVoltarMenu
            // 
            btnVoltarMenu.Animated = true;
            btnVoltarMenu.BorderRadius = 15;
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
            // guna2TextBox2
            // 
            guna2TextBox2.Animated = true;
            guna2TextBox2.BorderThickness = 0;
            guna2TextBox2.CausesValidation = false;
            guna2TextBox2.CustomizableEdges = customizableEdges11;
            guna2TextBox2.DefaultText = " Produtos";
            guna2TextBox2.DisabledState.BorderColor = SystemColors.Control;
            guna2TextBox2.DisabledState.FillColor = SystemColors.Control;
            guna2TextBox2.DisabledState.ForeColor = Color.Black;
            guna2TextBox2.DisabledState.PlaceholderForeColor = SystemColors.Control;
            guna2TextBox2.Enabled = false;
            guna2TextBox2.FillColor = SystemColors.Control;
            guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            guna2TextBox2.ForeColor = Color.Black;
            guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.IconLeft = Properties.Resources.hamburger_soda;
            guna2TextBox2.Location = new Point(21, 60);
            guna2TextBox2.Margin = new Padding(5);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PlaceholderForeColor = Color.Transparent;
            guna2TextBox2.PlaceholderText = "";
            guna2TextBox2.ReadOnly = true;
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2TextBox2.Size = new Size(248, 27);
            guna2TextBox2.TabIndex = 27;
            guna2TextBox2.TabStop = false;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.Animated = true;
            guna2TextBox1.BorderThickness = 0;
            guna2TextBox1.CausesValidation = false;
            guna2TextBox1.CustomizableEdges = customizableEdges13;
            guna2TextBox1.DefaultText = " Carrinho";
            guna2TextBox1.DisabledState.BorderColor = SystemColors.Control;
            guna2TextBox1.DisabledState.FillColor = SystemColors.Control;
            guna2TextBox1.DisabledState.ForeColor = Color.Black;
            guna2TextBox1.DisabledState.PlaceholderForeColor = SystemColors.Control;
            guna2TextBox1.Enabled = false;
            guna2TextBox1.FillColor = SystemColors.Control;
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            guna2TextBox1.ForeColor = Color.Black;
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.IconLeft = Properties.Resources.Carrinho;
            guna2TextBox1.Location = new Point(420, 60);
            guna2TextBox1.Margin = new Padding(5);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderForeColor = Color.Transparent;
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.ReadOnly = true;
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2TextBox1.Size = new Size(132, 27);
            guna2TextBox1.TabIndex = 28;
            guna2TextBox1.TabStop = false;
            // 
            // guna2TextBox3
            // 
            guna2TextBox3.BorderRadius = 15;
            guna2TextBox3.BorderThickness = 0;
            guna2TextBox3.CustomizableEdges = customizableEdges15;
            guna2TextBox3.DefaultText = "";
            guna2TextBox3.DisabledState.BorderColor = SystemColors.Control;
            guna2TextBox3.DisabledState.FillColor = Color.White;
            guna2TextBox3.DisabledState.ForeColor = Color.Black;
            guna2TextBox3.DisabledState.PlaceholderForeColor = SystemColors.Control;
            guna2TextBox3.Enabled = false;
            guna2TextBox3.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox3.Font = new Font("Inter", 12F, FontStyle.Bold);
            guna2TextBox3.ForeColor = Color.Black;
            guna2TextBox3.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox3.Location = new Point(680, 353);
            guna2TextBox3.Margin = new Padding(4);
            guna2TextBox3.Name = "guna2TextBox3";
            guna2TextBox3.PlaceholderText = "";
            guna2TextBox3.ReadOnly = true;
            guna2TextBox3.SelectedText = "";
            guna2TextBox3.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2TextBox3.Size = new Size(221, 47);
            guna2TextBox3.TabIndex = 29;
            guna2TextBox3.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(952, 471);
            Controls.Add(guna2TextBox1);
            Controls.Add(guna2TextBox2);
            Controls.Add(btnVoltarMenu);
            Controls.Add(guna2Button1);
            Controls.Add(btnFinalizarPedido);
            Controls.Add(CantBtnRemover);
            Controls.Add(CantBtnAdd);
            Controls.Add(pictureBox1);
            Controls.Add(CtnLblTotal);
            Controls.Add(label1);
            Controls.Add(CantCarrinho);
            Controls.Add(CantCardapio);
            Controls.Add(label3);
            Controls.Add(guna2TextBox3);
            ForeColor = Color.FromArgb(243, 241, 238);
            FormBorderStyle = FormBorderStyle.None;
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
        private Label CtnLblTotal;
        private PictureBox pictureBox1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button CantBtnAdd;
        private Guna.UI2.WinForms.Guna2Button CantBtnRemover;
        private Guna.UI2.WinForms.Guna2Button btnFinalizarPedido;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnVoltarMenu;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}
