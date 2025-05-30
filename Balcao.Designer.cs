namespace Projeto_Semestral___Cantina
{
    partial class Balcao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balcao));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            listBoxPedidospraEntrega = new ListBox();
            listBoxComanda = new ListBox();
            listBoxPedidosEntregues = new ListBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnVoltarMenu = new Guna.UI2.WinForms.Guna2Button();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            btnFinalizarPedido = new Guna.UI2.WinForms.Guna2Button();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxPedidospraEntrega
            // 
            listBoxPedidospraEntrega.BackColor = SystemColors.Window;
            listBoxPedidospraEntrega.Font = new Font("Agrandir Narrow", 12F, FontStyle.Bold);
            listBoxPedidospraEntrega.FormattingEnabled = true;
            listBoxPedidospraEntrega.ItemHeight = 21;
            listBoxPedidospraEntrega.Location = new Point(33, 105);
            listBoxPedidospraEntrega.Name = "listBoxPedidospraEntrega";
            listBoxPedidospraEntrega.SelectionMode = SelectionMode.MultiSimple;
            listBoxPedidospraEntrega.Size = new Size(546, 193);
            listBoxPedidospraEntrega.TabIndex = 1;
            listBoxPedidospraEntrega.DrawItem += listBoxPedidospraEntrega_DrawItem;
            listBoxPedidospraEntrega.SelectedIndexChanged += listBoxPedidospraEntrega_SelectedIndexChanged;
            // 
            // listBoxComanda
            // 
            listBoxComanda.BackColor = SystemColors.Window;
            listBoxComanda.Cursor = Cursors.No;
            listBoxComanda.Font = new Font("Agrandir Narrow", 12F, FontStyle.Bold);
            listBoxComanda.FormattingEnabled = true;
            listBoxComanda.ItemHeight = 21;
            listBoxComanda.Location = new Point(608, 105);
            listBoxComanda.Name = "listBoxComanda";
            listBoxComanda.Size = new Size(428, 193);
            listBoxComanda.TabIndex = 5;
            // 
            // listBoxPedidosEntregues
            // 
            listBoxPedidosEntregues.BackColor = SystemColors.Window;
            listBoxPedidosEntregues.Cursor = Cursors.No;
            listBoxPedidosEntregues.Font = new Font("Agrandir Narrow", 12F, FontStyle.Bold);
            listBoxPedidosEntregues.FormattingEnabled = true;
            listBoxPedidosEntregues.ItemHeight = 21;
            listBoxPedidosEntregues.Location = new Point(33, 335);
            listBoxPedidosEntregues.Name = "listBoxPedidosEntregues";
            listBoxPedidosEntregues.Size = new Size(546, 67);
            listBoxPedidosEntregues.TabIndex = 10;
            listBoxPedidosEntregues.DrawItem += listBoxPedidosEntregues_DrawItem;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bolt;
            pictureBox1.Location = new Point(33, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Inter Black", 22.25F, FontStyle.Bold);
            label3.Location = new Point(142, 9);
            label3.Name = "label3";
            label3.Size = new Size(139, 43);
            label3.TabIndex = 17;
            label3.Text = "| Balcão";
            // 
            // btnVoltarMenu
            // 
            btnVoltarMenu.Animated = true;
            btnVoltarMenu.BorderRadius = 5;
            btnVoltarMenu.Cursor = Cursors.Hand;
            btnVoltarMenu.CustomizableEdges = customizableEdges1;
            btnVoltarMenu.DisabledState.BorderColor = Color.DarkGray;
            btnVoltarMenu.DisabledState.CustomBorderColor = Color.DarkGray;
            btnVoltarMenu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnVoltarMenu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnVoltarMenu.FillColor = SystemColors.Window;
            btnVoltarMenu.Font = new Font("Inter", 12F, FontStyle.Bold);
            btnVoltarMenu.ForeColor = Color.Black;
            btnVoltarMenu.Image = (Image)resources.GetObject("btnVoltarMenu.Image");
            btnVoltarMenu.Location = new Point(33, 423);
            btnVoltarMenu.Name = "btnVoltarMenu";
            btnVoltarMenu.PressedColor = Color.FromArgb(230, 255, 0);
            btnVoltarMenu.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnVoltarMenu.Size = new Size(135, 36);
            btnVoltarMenu.TabIndex = 18;
            btnVoltarMenu.Text = " Voltar";
            btnVoltarMenu.Click += btnVoltarMenu_Click;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnFinalizarPedido
            // 
            btnFinalizarPedido.Animated = true;
            btnFinalizarPedido.BorderColor = SystemColors.Window;
            btnFinalizarPedido.BorderRadius = 8;
            btnFinalizarPedido.BorderThickness = 1;
            btnFinalizarPedido.Cursor = Cursors.Hand;
            btnFinalizarPedido.CustomizableEdges = customizableEdges7;
            btnFinalizarPedido.DisabledState.BorderColor = Color.DarkGray;
            btnFinalizarPedido.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFinalizarPedido.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFinalizarPedido.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFinalizarPedido.FillColor = Color.FromArgb(230, 255, 0);
            btnFinalizarPedido.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold);
            btnFinalizarPedido.ForeColor = Color.Black;
            btnFinalizarPedido.Image = (Image)resources.GetObject("btnFinalizarPedido.Image");
            btnFinalizarPedido.Location = new Point(608, 335);
            btnFinalizarPedido.Name = "btnFinalizarPedido";
            btnFinalizarPedido.PressedColor = SystemColors.Control;
            btnFinalizarPedido.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnFinalizarPedido.Size = new Size(428, 67);
            btnFinalizarPedido.TabIndex = 19;
            btnFinalizarPedido.Text = " Entregar Pedido";
            btnFinalizarPedido.Click += button1_Click;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderThickness = 0;
            guna2TextBox1.CustomizableEdges = customizableEdges5;
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
            guna2TextBox1.Location = new Point(608, 70);
            guna2TextBox1.Margin = new Padding(5);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2TextBox1.Size = new Size(141, 27);
            guna2TextBox1.TabIndex = 20;
            // 
            // guna2TextBox2
            // 
            guna2TextBox2.Animated = true;
            guna2TextBox2.BorderThickness = 0;
            guna2TextBox2.CausesValidation = false;
            guna2TextBox2.CustomizableEdges = customizableEdges9;
            guna2TextBox2.DefaultText = " Pedidos pra entregar";
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
            guna2TextBox2.Location = new Point(33, 70);
            guna2TextBox2.Margin = new Padding(5);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PlaceholderForeColor = Color.Transparent;
            guna2TextBox2.PlaceholderText = "";
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2TextBox2.Size = new Size(248, 27);
            guna2TextBox2.TabIndex = 21;
            // 
            // guna2TextBox3
            // 
            guna2TextBox3.BorderThickness = 0;
            guna2TextBox3.CustomizableEdges = customizableEdges3;
            guna2TextBox3.DefaultText = " Últimos pedidos entregues";
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
            guna2TextBox3.Location = new Point(33, 306);
            guna2TextBox3.Margin = new Padding(5);
            guna2TextBox3.Name = "guna2TextBox3";
            guna2TextBox3.PlaceholderText = "";
            guna2TextBox3.SelectedText = "";
            guna2TextBox3.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBox3.Size = new Size(292, 27);
            guna2TextBox3.TabIndex = 22;
            // 
            // Balcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 490);
            Controls.Add(guna2TextBox3);
            Controls.Add(guna2TextBox1);
            Controls.Add(btnFinalizarPedido);
            Controls.Add(btnVoltarMenu);
            Controls.Add(pictureBox1);
            Controls.Add(listBoxPedidosEntregues);
            Controls.Add(listBoxComanda);
            Controls.Add(listBoxPedidospraEntrega);
            Controls.Add(label3);
            Controls.Add(guna2TextBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Balcao";
            Text = "Balcao";
            Load += Balcao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxPedidospraEntrega;
        private ListBox listBoxComanda;
        private ListBox listBoxPedidosEntregues;
        private PictureBox pictureBox1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btnVoltarMenu;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnFinalizarPedido;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
    }
}