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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balcao));
            listBoxPedidospraEntrega = new ListBox();
            listBoxComanda = new ListBox();
            listBoxPedidosEntregues = new ListBox();
            labelPedidos = new Label();
            label1 = new Label();
            label2 = new Label();
            btnFinalizarPedido = new Button();
            pictureBox1 = new PictureBox();
            btnVoltarMenu = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxPedidospraEntrega
            // 
            listBoxPedidospraEntrega.Font = new Font("Agrandir Narrow", 12F, FontStyle.Bold);
            listBoxPedidospraEntrega.FormattingEnabled = true;
            listBoxPedidospraEntrega.ItemHeight = 21;
            listBoxPedidospraEntrega.Location = new Point(33, 105);
            listBoxPedidospraEntrega.Name = "listBoxPedidospraEntrega";
            listBoxPedidospraEntrega.Size = new Size(546, 193);
            listBoxPedidospraEntrega.TabIndex = 1;
            listBoxPedidospraEntrega.DrawItem += listBoxPedidospraEntrega_DrawItem;
            listBoxPedidospraEntrega.SelectedIndexChanged += listBoxPedidospraEntrega_SelectedIndexChanged;
            // 
            // listBoxComanda
            // 
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
            listBoxPedidosEntregues.Font = new Font("Agrandir Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxPedidosEntregues.FormattingEnabled = true;
            listBoxPedidosEntregues.ItemHeight = 17;
            listBoxPedidosEntregues.Location = new Point(33, 335);
            listBoxPedidosEntregues.Name = "listBoxPedidosEntregues";
            listBoxPedidosEntregues.Size = new Size(546, 72);
            listBoxPedidosEntregues.TabIndex = 10;
            listBoxPedidosEntregues.DrawItem += listBoxPedidosEntregues_DrawItem;
            // 
            // labelPedidos
            // 
            labelPedidos.AutoSize = true;
            labelPedidos.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPedidos.Location = new Point(33, 75);
            labelPedidos.Name = "labelPedidos";
            labelPedidos.Size = new Size(239, 27);
            labelPedidos.TabIndex = 11;
            labelPedidos.Text = "🛎️ Pedidos pra entregar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(608, 75);
            label1.Name = "label1";
            label1.Size = new Size(133, 27);
            label1.TabIndex = 12;
            label1.Text = "🗒️ Comanda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 305);
            label2.Name = "label2";
            label2.Size = new Size(292, 27);
            label2.TabIndex = 13;
            label2.Text = "✔️ Últimos pedidos entregues";
            // 
            // btnFinalizarPedido
            // 
            btnFinalizarPedido.BackColor = Color.FromArgb(230, 255, 0);
            btnFinalizarPedido.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold);
            btnFinalizarPedido.Location = new Point(608, 335);
            btnFinalizarPedido.Name = "btnFinalizarPedido";
            btnFinalizarPedido.Size = new Size(428, 72);
            btnFinalizarPedido.TabIndex = 14;
            btnFinalizarPedido.Text = "📤 Entregar Pedido";
            btnFinalizarPedido.UseVisualStyleBackColor = false;
            btnFinalizarPedido.Click += btnFinalizarPedido_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bolt;
            pictureBox1.Location = new Point(33, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnVoltarMenu
            // 
            btnVoltarMenu.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltarMenu.Location = new Point(33, 424);
            btnVoltarMenu.Name = "btnVoltarMenu";
            btnVoltarMenu.Size = new Size(89, 25);
            btnVoltarMenu.TabIndex = 16;
            btnVoltarMenu.Text = "↩️  Voltar";
            btnVoltarMenu.UseVisualStyleBackColor = true;
            btnVoltarMenu.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Inter Black", 22.25F, FontStyle.Bold);
            label3.Location = new Point(142, 32);
            label3.Name = "label3";
            label3.Size = new Size(139, 43);
            label3.TabIndex = 17;
            label3.Text = "| Balcão";
            // 
            // Balcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 490);
            Controls.Add(btnVoltarMenu);
            Controls.Add(pictureBox1);
            Controls.Add(btnFinalizarPedido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelPedidos);
            Controls.Add(listBoxPedidosEntregues);
            Controls.Add(listBoxComanda);
            Controls.Add(listBoxPedidospraEntrega);
            Controls.Add(label3);
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
        private Label labelPedidos;
        private Label label1;
        private Label label2;
        private Button btnFinalizarPedido;
        private PictureBox pictureBox1;
        private Button btnVoltarMenu;
        private Label label3;
    }
}