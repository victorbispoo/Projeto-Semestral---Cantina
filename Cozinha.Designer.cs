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
            components = new System.ComponentModel.Container();
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
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnFinalizarPedido = new Guna.UI2.WinForms.Guna2Button();
            btnPreparar = new Guna.UI2.WinForms.Guna2Button();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            btnVoltarMenu = new Guna.UI2.WinForms.Guna2Button();
            guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxPedidos
            // 
            listBoxPedidos.BorderStyle = BorderStyle.None;
            listBoxPedidos.Cursor = Cursors.Hand;
            listBoxPedidos.Font = new Font("Inter", 12F, FontStyle.Bold);
            listBoxPedidos.ForeColor = Color.FromArgb(17, 25, 12);
            listBoxPedidos.FormattingEnabled = true;
            listBoxPedidos.ItemHeight = 19;
            listBoxPedidos.Location = new Point(37, 94);
            listBoxPedidos.Name = "listBoxPedidos";
            listBoxPedidos.Size = new Size(576, 171);
            listBoxPedidos.TabIndex = 0;
            listBoxPedidos.SelectedIndexChanged += listBoxPedidos_SelectedIndexChanged;
            // 
            // labelPedidos
            // 
            labelPedidos.AutoSize = true;
            labelPedidos.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPedidos.Location = new Point(37, 64);
            labelPedidos.Name = "labelPedidos";
            labelPedidos.Size = new Size(114, 24);
            labelPedidos.TabIndex = 2;
            labelPedidos.Text = "🛎️ Pedidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(673, 64);
            label1.Name = "label1";
            label1.Size = new Size(121, 24);
            label1.TabIndex = 3;
            label1.Text = "🗒️ Comanda";
            // 
            // listBoxComanda
            // 
            listBoxComanda.BorderStyle = BorderStyle.None;
            listBoxComanda.Cursor = Cursors.No;
            listBoxComanda.Font = new Font("Inter", 12F, FontStyle.Bold);
            listBoxComanda.ForeColor = Color.FromArgb(17, 25, 12);
            listBoxComanda.FormattingEnabled = true;
            listBoxComanda.ItemHeight = 19;
            listBoxComanda.Location = new Point(673, 94);
            listBoxComanda.Name = "listBoxComanda";
            listBoxComanda.Size = new Size(346, 171);
            listBoxComanda.TabIndex = 4;
            listBoxComanda.SelectedIndexChanged += listBoxComanda_SelectedIndexChanged;
            // 
            // listPedidosProntos
            // 
            listPedidosProntos.BorderStyle = BorderStyle.None;
            listPedidosProntos.Cursor = Cursors.No;
            listPedidosProntos.Font = new Font("Inter", 12F, FontStyle.Bold);
            listPedidosProntos.ForeColor = Color.FromArgb(17, 25, 12);
            listPedidosProntos.FormattingEnabled = true;
            listPedidosProntos.ItemHeight = 19;
            listPedidosProntos.Location = new Point(37, 308);
            listPedidosProntos.Name = "listPedidosProntos";
            listPedidosProntos.Size = new Size(576, 76);
            listPedidosProntos.TabIndex = 9;
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
            label3.Font = new Font("Inter", 23.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(17, 25, 12);
            label3.Location = new Point(160, 12);
            label3.Name = "label3";
            label3.Size = new Size(160, 37);
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
            btnFinalizarPedido.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizarPedido.ForeColor = Color.FromArgb(17, 25, 12);
            btnFinalizarPedido.Image = Properties.Resources.check_positivo;
            btnFinalizarPedido.Location = new Point(673, 348);
            btnFinalizarPedido.Name = "btnFinalizarPedido";
            btnFinalizarPedido.PressedColor = SystemColors.Control;
            btnFinalizarPedido.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnFinalizarPedido.Size = new Size(346, 40);
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
            btnPreparar.Font = new Font("Inter", 9.75F, FontStyle.Bold);
            btnPreparar.ForeColor = Color.FromArgb(17, 25, 12);
            btnPreparar.Image = Properties.Resources.ampulheta;
            btnPreparar.Location = new Point(673, 308);
            btnPreparar.Name = "btnPreparar";
            btnPreparar.PressedColor = Color.FromArgb(230, 255, 0);
            btnPreparar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnPreparar.Size = new Size(159, 34);
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
            btnCancelar.Font = new Font("Inter", 9.75F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(17, 25, 12);
            btnCancelar.Image = Properties.Resources.cancelar;
            btnCancelar.Location = new Point(858, 308);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.PressedColor = Color.FromArgb(230, 255, 0);
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCancelar.Size = new Size(161, 34);
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
            btnVoltarMenu.ForeColor = Color.FromArgb(17, 25, 12);
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
            guna2TextBox2.DisabledState.BorderColor = SystemColors.Control;
            guna2TextBox2.DisabledState.FillColor = SystemColors.Control;
            guna2TextBox2.DisabledState.ForeColor = Color.Black;
            guna2TextBox2.DisabledState.PlaceholderForeColor = SystemColors.Control;
            guna2TextBox2.Enabled = false;
            guna2TextBox2.FillColor = SystemColors.Control;
            guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Font = new Font("Inter", 14.25F, FontStyle.Bold);
            guna2TextBox2.ForeColor = Color.FromArgb(17, 25, 12);
            guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.IconLeft = Properties.Resources.sino;
            guna2TextBox2.Location = new Point(37, 62);
            guna2TextBox2.Margin = new Padding(9, 8, 9, 8);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PlaceholderForeColor = Color.Transparent;
            guna2TextBox2.PlaceholderText = "";
            guna2TextBox2.ReadOnly = true;
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2TextBox2.Size = new Size(135, 28);
            guna2TextBox2.TabIndex = 24;
            guna2TextBox2.TabStop = false;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderThickness = 0;
            guna2TextBox1.CustomizableEdges = customizableEdges11;
            guna2TextBox1.DefaultText = " Comanda";
            guna2TextBox1.DisabledState.BorderColor = SystemColors.Control;
            guna2TextBox1.DisabledState.FillColor = SystemColors.Control;
            guna2TextBox1.DisabledState.ForeColor = Color.Black;
            guna2TextBox1.DisabledState.PlaceholderForeColor = SystemColors.Control;
            guna2TextBox1.Enabled = false;
            guna2TextBox1.FillColor = SystemColors.Control;
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Inter", 14.25F, FontStyle.Bold);
            guna2TextBox1.ForeColor = Color.FromArgb(17, 25, 12);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.IconLeft = Properties.Resources.Recibo;
            guna2TextBox1.Location = new Point(673, 62);
            guna2TextBox1.Margin = new Padding(9, 8, 9, 8);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.ReadOnly = true;
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2TextBox1.Size = new Size(133, 26);
            guna2TextBox1.TabIndex = 25;
            guna2TextBox1.TabStop = false;
            // 
            // guna2TextBox3
            // 
            guna2TextBox3.BackColor = Color.Transparent;
            guna2TextBox3.BorderThickness = 0;
            guna2TextBox3.CustomizableEdges = customizableEdges13;
            guna2TextBox3.DefaultText = " Pedidos Prontos";
            guna2TextBox3.DisabledState.BorderColor = SystemColors.Control;
            guna2TextBox3.DisabledState.FillColor = SystemColors.Control;
            guna2TextBox3.DisabledState.ForeColor = Color.Black;
            guna2TextBox3.DisabledState.PlaceholderForeColor = SystemColors.Control;
            guna2TextBox3.Enabled = false;
            guna2TextBox3.FillColor = SystemColors.Control;
            guna2TextBox3.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox3.Font = new Font("Inter", 14.25F, FontStyle.Bold);
            guna2TextBox3.ForeColor = Color.FromArgb(17, 25, 12);
            guna2TextBox3.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox3.IconLeft = Properties.Resources.pedidos_prontos;
            guna2TextBox3.Location = new Point(37, 277);
            guna2TextBox3.Margin = new Padding(9, 8, 9, 8);
            guna2TextBox3.Name = "guna2TextBox3";
            guna2TextBox3.PlaceholderText = "";
            guna2TextBox3.ReadOnly = true;
            guna2TextBox3.SelectedText = "";
            guna2TextBox3.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2TextBox3.Size = new Size(200, 26);
            guna2TextBox3.TabIndex = 26;
            guna2TextBox3.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Cozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(1099, 464);
            Controls.Add(guna2TextBox3);
            Controls.Add(guna2TextBox1);
            Controls.Add(guna2TextBox2);
            Controls.Add(btnVoltarMenu);
            Controls.Add(btnCancelar);
            Controls.Add(btnPreparar);
            Controls.Add(btnFinalizarPedido);
            Controls.Add(pictureBox1);
            Controls.Add(listPedidosProntos);
            Controls.Add(listBoxComanda);
            Controls.Add(label1);
            Controls.Add(labelPedidos);
            Controls.Add(listBoxPedidos);
            Controls.Add(label3);
            ForeColor = Color.FromArgb(17, 25, 12);
            FormBorderStyle = FormBorderStyle.None;
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
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}