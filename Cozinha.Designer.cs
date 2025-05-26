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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cozinha));
            listBoxPedidos = new ListBox();
            labelPedidos = new Label();
            label1 = new Label();
            listBoxComanda = new ListBox();
            button1 = new Button();
            BtnPreparar = new Button();
            BtnCancelar = new Button();
            BtnFinalizar = new Button();
            listPedidosProntos = new ListBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxPedidos
            // 
            listBoxPedidos.Font = new Font("Agrandir Narrow", 12F, FontStyle.Bold);
            listBoxPedidos.FormattingEnabled = true;
            listBoxPedidos.ItemHeight = 21;
            listBoxPedidos.Location = new Point(37, 94);
            listBoxPedidos.Name = "listBoxPedidos";
            listBoxPedidos.Size = new Size(415, 193);
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
            label1.Location = new Point(518, 64);
            label1.Name = "label1";
            label1.Size = new Size(133, 27);
            label1.TabIndex = 3;
            label1.Text = "🗒️ Comanda";
            // 
            // listBoxComanda
            // 
            listBoxComanda.Font = new Font("Agrandir Narrow", 12F, FontStyle.Bold);
            listBoxComanda.FormattingEnabled = true;
            listBoxComanda.ItemHeight = 21;
            listBoxComanda.Location = new Point(518, 94);
            listBoxComanda.Name = "listBoxComanda";
            listBoxComanda.Size = new Size(346, 193);
            listBoxComanda.TabIndex = 4;
            listBoxComanda.SelectedIndexChanged += listBoxComanda_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(37, 424);
            button1.Name = "button1";
            button1.Size = new Size(90, 28);
            button1.TabIndex = 5;
            button1.Text = "🔙 Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnPreparar
            // 
            BtnPreparar.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold);
            BtnPreparar.Location = new Point(518, 320);
            BtnPreparar.Name = "BtnPreparar";
            BtnPreparar.Size = new Size(173, 35);
            BtnPreparar.TabIndex = 6;
            BtnPreparar.Text = "⏳ Preparar Pedido";
            BtnPreparar.UseVisualStyleBackColor = true;
            BtnPreparar.Click += BtnPreparar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold);
            BtnCancelar.Location = new Point(690, 320);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(174, 35);
            BtnCancelar.TabIndex = 7;
            BtnCancelar.Text = "❌ Cancelar Pedido";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.BackColor = Color.FromArgb(230, 255, 0);
            BtnFinalizar.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold);
            BtnFinalizar.Location = new Point(518, 353);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(346, 34);
            BtnFinalizar.TabIndex = 8;
            BtnFinalizar.Text = "✔️ Finalizar Pedido";
            BtnFinalizar.UseVisualStyleBackColor = false;
            BtnFinalizar.Click += BtnFinalizar_Click;
            // 
            // listPedidosProntos
            // 
            listPedidosProntos.Font = new Font("Agrandir Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listPedidosProntos.FormattingEnabled = true;
            listPedidosProntos.ItemHeight = 17;
            listPedidosProntos.Location = new Point(37, 315);
            listPedidosProntos.Name = "listPedidosProntos";
            listPedidosProntos.Size = new Size(415, 72);
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
            pictureBox1.Size = new Size(118, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Cozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 464);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(listPedidosProntos);
            Controls.Add(BtnFinalizar);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnPreparar);
            Controls.Add(button1);
            Controls.Add(listBoxComanda);
            Controls.Add(label1);
            Controls.Add(labelPedidos);
            Controls.Add(listBoxPedidos);
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
        private Button button1;
        private Button BtnPreparar;
        private Button BtnCancelar;
        private Button BtnFinalizar;
        private ListBox listPedidosProntos;
        private Label label2;
        private PictureBox pictureBox1;
    }
}