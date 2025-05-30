namespace Projeto_Semestral___Cantina
{
    partial class Cozinha
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cozinha));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            listBoxPedidos = new ListBox();
            labelPedidos = new Label();
            label1 = new Label();
            listBoxComanda = new ListBox();
            listPedidosProntos = new ListBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnFinalizarPedido = new Guna.UI2.WinForms.Guna2Button();
            btnPreparar = new Guna.UI2.WinForms.Guna2Button();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            btnVoltarMenu = new Guna.UI2.WinForms.Guna2Button();
            guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxPedidos
            // 
            listBoxPedidos.Cursor = Cursors.No;
            listBoxPedidos.Font = new Font("Agrandir Narrow", 12F, FontStyle.Bold);
            listBoxPedidos.FormattingEnabled = true;
            listBoxPedidos.ItemHeight = 21;
            listBoxPedidos.Location = new Point(37, 94);
            listBoxPedidos.Name = "listBoxPedidos";
            listBoxPedidos.Size = new Size(576, 193);
            listBoxPedidos.TabIndex = 0;
            listBoxPedidos.SelectedIndexChanged += listBoxPedidos_SelectedIndexChanged;
            // 
            // labelPedidos
            // 
            labelPedidos.AutoSize = true;
            labelPedidos.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPedidos.Location = new Point(37, 64);
            labelPedidos.Name = "labelPedidos";
            labelPedidos.Size = new Size(118, 27);
            labelPedidos.TabIndex = 2;
            labelPedidos.Text = "🛎️ Pedidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(673, 64);
            label1.Name = "label1";
            label1.Size = new Size(133, 27);
            label1.TabIndex = 3;
            label1.Text = "🗒️ Comanda";
            // 
            // listBoxComanda
            // 
            listBoxComanda.Cursor = Cursors.No;
            listBoxComanda.Font = new Font("Agrandir Narrow", 12F, FontStyle.Bold);
            listBoxComanda.FormattingEnabled = true;
            listBoxComanda.ItemHeight = 21;
            listBoxComanda.Location = new Point(673, 94);
            listBoxComanda.Name = "listBoxComanda";
            listBoxComanda.Size = new Size(346, 193);
            listBoxComanda.TabIndex = 4;
            listBoxComanda.SelectedIndexChanged += listBoxComanda_SelectedIndexChanged;
            // 
            // listPedidosProntos
            // 
            listPedidosProntos.Cursor = Cursors.No;
            listPedidosProntos.Font = new Font("Agrandir Narrow", 12F, FontStyle.Bold);
            listPedidosProntos.FormattingEnabled = true;
            listPedidosProntos.ItemHeight = 21;
            listPedidosProntos.Location = new Point(37, 320);
            listPedidosProntos.Name = "listPedidosProntos";
            listPedidosProntos.Size = new Size(576, 67);
            listPedidosProntos.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 290);
            label2.Name = "label2";
            label2.Size = new Size(196, 27);
            label2.TabIndex = 10;
            label2.Text = "✔️ Pedidos prontos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bolt;
            pictureBox1.Location = new Point(37, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Inter Black", 22.25F, FontStyle.Bold);
            label3.Location = new Point(161, 9);
            label3.Name = "label3";
            label3.Size = new Size(161, 43);
            label3.TabIndex = 18;
            label3.Text = "| Cozinha";
            // 
            // btnFinalizarPedido
            // 
            btnFinalizarPedido.Animated = true;
            btnFinalizarPedido.BorderColor = SystemColors.Window;
            btnFinalizarPedido.BorderRadius = 8;
            btnFinalizarPedido.Cursor = Cursors.Hand;
            btnFinalizarPedido.CustomizableEdges = customizableEdges1;
            btnFinalizarPedido.DisabledState.BorderColor = Color.DarkGray;
            btnFinalizarPedido.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFinalizarPedido.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFinalizarPedido.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFinalizarPedido.FillColor = Color.FromArgb(230, 255, 0);
            btnFinalizarPedido.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold);
            btnFinalizarPedido.ForeColor = Color.Black;
            btnFinalizarPedido.Image = Properties.Resources.check_positivo;
            btnFinalizarPedido.Location = new Point(673, 353);
            btnFinalizarPedido.Name = "btnFinalizarPedido";
            btnFinalizarPedido.PressedColor = SystemColors.Control;
            btnFinalizarPedido.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnFinalizarPedido.Size = new Size(346, 34);
            btnFinalizarPedido.TabIndex = 20;
            btnFinalizarPedido.Text = " Finalizar Pedido";
            btnFinalizarPedido.Click += BtnFinalizar_Click;
            // 
            // btnPreparar
            // 
            btnPreparar.Animated = true;
            btnPreparar.BorderRadius = 8;
            btnPreparar.Cursor = Cursors.Hand;
            btnPreparar.CustomizableEdges = customizableEdges3;
            btnPreparar.DisabledState.BorderColor = Color.DarkGray;
            btnPreparar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPreparar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPreparar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPreparar.FillColor = SystemColors.Window;
            btnPreparar.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold);
            btnPreparar.ForeColor = Color.Black;
            btnPreparar.Image = Properties.Resources.ampulheta;
            btnPreparar.Location = new Point(673, 321);
            btnPreparar.Name = "btnPreparar";
            btnPreparar.PressedColor = Color.FromArgb(230, 255, 0);
            btnPreparar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnPreparar.Size = new Size(173, 34);
            btnPreparar.TabIndex = 21;
            btnPreparar.Text = " Preparar Pedido";
            btnPreparar.Click += BtnPreparar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Animated = true;
            btnCancelar.BorderRadius = 8;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.CustomizableEdges = customizableEdges5;
            btnCancelar.DisabledState.BorderColor = Color.DarkGray;
            btnCancelar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelar.FillColor = SystemColors.Window;
            btnCancelar.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Image = Properties.Resources.cancelar;
            btnCancelar.Location = new Point(846, 321);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.PressedColor = Color.FromArgb(230, 255, 0);
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCancelar.Size = new Size(173, 34);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = " Cancelar Pedido";
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // btnVoltarMenu
            // 
            btnVoltarMenu.Animated = true;
            btnVoltarMenu.BorderRadius = 5;
            btnVoltarMenu.Cursor = Cursors.Hand;
            btnVoltarMenu.CustomizableEdges = customizableEdges7;
            btnVoltarMenu.DisabledState.BorderColor = Color.DarkGray;
            btnVoltarMenu.DisabledState.CustomBorderColor = Color.DarkGray;
            btnVoltarMenu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnVoltarMenu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnVoltarMenu.FillColor = SystemColors.Window;
            btnVoltarMenu.Font = new Font("Inter", 12F, FontStyle.Bold);
            btnVoltarMenu.ForeColor = Color.Black;
            btnVoltarMenu.Image = (Image)resources.GetObject("btnVoltarMenu.Image");
            btnVoltarMenu.Location = new Point(37, 402);
            btnVoltarMenu.Name = "btnVoltarMenu";
            btnVoltarMenu.PressedColor = Color.FromArgb(230, 255, 0);
            btnVoltarMenu.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnVoltarMenu.Size = new Size(135, 36);
            btnVoltarMenu.TabIndex = 23;
            btnVoltarMenu.Text = " Voltar";
            btnVoltarMenu.Click += button1_Click;
            // 
            // guna2TextBox2
            // 
            guna2TextBox2.Animated = true;
            guna2TextBox2.BorderThickness = 0;
            guna2TextBox2.CausesValidation = false;
            guna2TextBox2.CustomizableEdges = customizableEdges9;
            guna2TextBox2.DefaultText = " Pedidos ";
            guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.FillColor = SystemColors.Control;
            guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold);
            guna2TextBox2.ForeColor = Color.Black;
            guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.IconLeft = Properties.Resources.sino;
            guna2TextBox2.Location = new Point(37, 64);
            guna2TextBox2.Margin = new Padding(5);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PlaceholderForeColor = Color.Transparent;
            guna2TextBox2.PlaceholderText = "";
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2TextBox2.Size = new Size(248, 27);
            guna2TextBox2.TabIndex = 24;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderThickness = 0;
            guna2TextBox1.CustomizableEdges = customizableEdges11;
            guna2TextBox1.DefaultText = " Comanda";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FillColor = SystemColors.Control;
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold);
            guna2TextBox1.ForeColor = Color.Black;
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.IconLeft = Properties.Resources.Recibo;
            guna2TextBox1.Location = new Point(673, 64);
            guna2TextBox1.Margin = new Padding(5);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2TextBox1.Size = new Size(141, 27);
            guna2TextBox1.TabIndex = 25;
            // 
            // guna2TextBox3
            // 
            guna2TextBox3.BorderThickness = 0;
            guna2TextBox3.CustomizableEdges = customizableEdges13;
            guna2TextBox3.DefaultText = " Pedidos Prontos";
            guna2TextBox3.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox3.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox3.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox3.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox3.FillColor = SystemColors.Control;
            guna2TextBox3.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox3.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold);
            guna2TextBox3.ForeColor = Color.Black;
            guna2TextBox3.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox3.IconLeft = Properties.Resources.pedidos_prontos;
            guna2TextBox3.Location = new Point(37, 290);
            guna2TextBox3.Margin = new Padding(5);
            guna2TextBox3.Name = "guna2TextBox3";
            guna2TextBox3.PlaceholderText = "";
            guna2TextBox3.SelectedText = "";
            guna2TextBox3.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2TextBox3.Size = new Size(292, 27);
            guna2TextBox3.TabIndex = 26;
            // 
            // Cozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1099, 464);
            Controls.Add(guna2TextBox3);
            Controls.Add(guna2TextBox1);
            Controls.Add(guna2TextBox2);
            Controls.Add(btnVoltarMenu);
            Controls.Add(btnCancelar);
            Controls.Add(btnPreparar);
            Controls.Add(btnFinalizarPedido);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(listPedidosProntos);
            Controls.Add(listBoxComanda);
            Controls.Add(label1);
            Controls.Add(labelPedidos);
            Controls.Add(listBoxPedidos);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cozinha";
            Text = "Cozinha";
            Load += Cozinha_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxPedidos;
        private Label labelPedidos;
        private Label label1;
        private ListBox listBoxComanda;
        private ListBox listPedidosProntos;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btnFinalizarPedido;
        private Guna.UI2.WinForms.Guna2Button btnPreparar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnVoltarMenu;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
    }
}