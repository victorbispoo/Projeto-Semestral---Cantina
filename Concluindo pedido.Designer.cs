namespace Projeto_Semestral___Cantina
{
    partial class Concluindo_pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Concluindo_pedido));
            label1 = new Label();
            ListaTipoPedido = new Label();
            pagDinheiro = new RadioButton();
            pagDebito = new RadioButton();
            pagPix = new RadioButton();
            pagCredito = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 77);
            label1.Name = "label1";
            label1.Size = new Size(260, 23);
            label1.TabIndex = 2;
            label1.Text = "Selecione a forma de pagamento";
            // 
            // ListaTipoPedido
            // 
            ListaTipoPedido.AutoSize = true;
            ListaTipoPedido.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListaTipoPedido.Location = new Point(380, 77);
            ListaTipoPedido.Name = "ListaTipoPedido";
            ListaTipoPedido.Size = new Size(212, 23);
            ListaTipoPedido.TabIndex = 3;
            ListaTipoPedido.Text = "Selecione o tipo de pedido";
            // 
            // pagDinheiro
            // 
            pagDinheiro.AutoSize = true;
            pagDinheiro.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            pagDinheiro.Location = new Point(6, 22);
            pagDinheiro.Name = "pagDinheiro";
            pagDinheiro.Size = new Size(120, 27);
            pagDinheiro.TabIndex = 4;
            pagDinheiro.TabStop = true;
            pagDinheiro.Text = "💵 Dinheiro";
            pagDinheiro.UseVisualStyleBackColor = true;
            pagDinheiro.CheckedChanged += pagDinheiro_CheckedChanged;
            // 
            // pagDebito
            // 
            pagDebito.AutoSize = true;
            pagDebito.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            pagDebito.Location = new Point(6, 58);
            pagDebito.Name = "pagDebito";
            pagDebito.Size = new Size(106, 27);
            pagDebito.TabIndex = 5;
            pagDebito.TabStop = true;
            pagDebito.Text = "💳 Débito";
            pagDebito.UseVisualStyleBackColor = true;
            // 
            // pagPix
            // 
            pagPix.AutoSize = true;
            pagPix.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            pagPix.Location = new Point(148, 22);
            pagPix.Name = "pagPix";
            pagPix.Size = new Size(72, 27);
            pagPix.TabIndex = 6;
            pagPix.TabStop = true;
            pagPix.Text = "❖ Pix";
            pagPix.UseVisualStyleBackColor = true;
            // 
            // pagCredito
            // 
            pagCredito.AutoSize = true;
            pagCredito.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            pagCredito.Location = new Point(148, 58);
            pagCredito.Name = "pagCredito";
            pagCredito.Size = new Size(112, 27);
            pagCredito.TabIndex = 7;
            pagCredito.TabStop = true;
            pagCredito.Text = "💳 Crédito";
            pagCredito.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(6, 26);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(200, 27);
            radioButton5.TabIndex = 8;
            radioButton5.TabStop = true;
            radioButton5.Text = "🏪 Consumo imediato";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.BackColor = Color.White;
            radioButton6.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton6.Location = new Point(6, 59);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(148, 27);
            radioButton6.TabIndex = 9;
            radioButton6.TabStop = true;
            radioButton6.Text = "✈️ Para viagem";
            radioButton6.UseVisualStyleBackColor = false;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(pagCredito);
            groupBox1.Controls.Add(pagPix);
            groupBox1.Controls.Add(pagDinheiro);
            groupBox1.Controls.Add(pagDebito);
            groupBox1.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(22, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 101);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(380, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(212, 101);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bolt;
            pictureBox1.Location = new Point(18, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(230, 255, 0);
            button1.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(380, 227);
            button1.Name = "button1";
            button1.Size = new Size(212, 41);
            button1.TabIndex = 13;
            button1.Text = "Finalizar pedido";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Concluindo_pedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(604, 280);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(ListaTipoPedido);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Concluindo_pedido";
            Text = "Conclusão Pedido";
            Load += Concluindo_pedido_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label ListaTipoPedido;
        private RadioButton pagDinheiro;
        private RadioButton pagDebito;
        private RadioButton pagPix;
        private RadioButton pagCredito;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private Button button1;
    }
}