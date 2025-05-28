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
            listBoxPedidospraEntrega = new ListBox();
            listBoxComanda = new ListBox();
            listBoxPedidosEntregues = new ListBox();
            labelPedidos = new Label();
            label1 = new Label();
            label2 = new Label();
            btnFinalizarPedido = new Button();
            pictureBox1 = new PictureBox();
            btnVoltarMenu = new Button();
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
            listBoxPedidospraEntrega.Size = new Size(415, 193);
            listBoxPedidospraEntrega.TabIndex = 1;
            listBoxPedidospraEntrega.SelectedIndexChanged += listBoxPedidospraEntrega_SelectedIndexChanged;
            // 
            // listBoxComanda
            // 
            listBoxComanda.Font = new Font("Agrandir Narrow", 12F, FontStyle.Bold);
            listBoxComanda.FormattingEnabled = true;
            listBoxComanda.ItemHeight = 21;
            listBoxComanda.Location = new Point(497, 105);
            listBoxComanda.Name = "listBoxComanda";
            listBoxComanda.Size = new Size(346, 193);
            listBoxComanda.TabIndex = 5;
            // 
            // listBoxPedidosEntregues
            // 
            listBoxPedidosEntregues.Font = new Font("Agrandir Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxPedidosEntregues.FormattingEnabled = true;
            listBoxPedidosEntregues.ItemHeight = 17;
            listBoxPedidosEntregues.Location = new Point(33, 335);
            listBoxPedidosEntregues.Name = "listBoxPedidosEntregues";
            listBoxPedidosEntregues.Size = new Size(415, 72);
            listBoxPedidosEntregues.TabIndex = 10;
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
            label1.Location = new Point(497, 75);
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
            btnFinalizarPedido.Location = new Point(497, 335);
            btnFinalizarPedido.Name = "btnFinalizarPedido";
            btnFinalizarPedido.Size = new Size(346, 72);
            btnFinalizarPedido.TabIndex = 14;
            btnFinalizarPedido.Text = "📤 Entregar Pedido";
            btnFinalizarPedido.UseVisualStyleBackColor = false;
            btnFinalizarPedido.Click += btnFinalizarPedido_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bolt;
            pictureBox1.Location = new Point(33, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 39);
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
            // Balcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 474);
            Controls.Add(btnVoltarMenu);
            Controls.Add(pictureBox1);
            Controls.Add(btnFinalizarPedido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelPedidos);
            Controls.Add(listBoxPedidosEntregues);
            Controls.Add(listBoxComanda);
            Controls.Add(listBoxPedidospraEntrega);
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
    }
}