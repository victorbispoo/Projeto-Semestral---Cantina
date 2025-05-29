namespace Projeto_Semestral___Cantina
{
    partial class TelaoRetirada
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
            label1 = new Label();
            listPedidosProntos = new ListBox();
            listPedidosPreparo = new ListBox();
            label2 = new Label();
            listPedidosEntregues = new ListBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter ExtraBold", 17.75F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(454, 133);
            label1.Name = "label1";
            label1.Size = new Size(286, 35);
            label1.TabIndex = 1;
            label1.Text = "✔️ PEDIDOS PRONTOS";
            // 
            // listPedidosProntos
            // 
            listPedidosProntos.FormattingEnabled = true;
            listPedidosProntos.ItemHeight = 15;
            listPedidosProntos.Location = new Point(445, 171);
            listPedidosProntos.Name = "listPedidosProntos";
            listPedidosProntos.Size = new Size(314, 334);
            listPedidosProntos.TabIndex = 2;
            // 
            // listPedidosPreparo
            // 
            listPedidosPreparo.FormattingEnabled = true;
            listPedidosPreparo.ItemHeight = 15;
            listPedidosPreparo.Location = new Point(875, 171);
            listPedidosPreparo.Name = "listPedidosPreparo";
            listPedidosPreparo.Size = new Size(315, 334);
            listPedidosPreparo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter ExtraBold", 17.75F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(866, 133);
            label2.Name = "label2";
            label2.Size = new Size(324, 35);
            label2.TabIndex = 4;
            label2.Text = "🕔 PEDIDOS EM PREPARO";
            // 
            // listPedidosEntregues
            // 
            listPedidosEntregues.FormattingEnabled = true;
            listPedidosEntregues.ItemHeight = 15;
            listPedidosEntregues.Location = new Point(19, 171);
            listPedidosEntregues.Name = "listPedidosEntregues";
            listPedidosEntregues.Size = new Size(313, 334);
            listPedidosEntregues.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter ExtraBold", 17.75F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(19, 133);
            label3.Name = "label3";
            label3.Size = new Size(313, 35);
            label3.TabIndex = 6;
            label3.Text = "🛎️ PEDIDOS ENTREGUES";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bolt;
            pictureBox1.Location = new Point(416, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // TelaoRetirada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1215, 563);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(listPedidosEntregues);
            Controls.Add(label2);
            Controls.Add(listPedidosPreparo);
            Controls.Add(listPedidosProntos);
            Controls.Add(label1);
            Name = "TelaoRetirada";
            Text = "TelaoRetirada";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ListBox listPedidosProntos;
        private ListBox listPedidosPreparo;
        private Label label2;
        private ListBox listPedidosEntregues;
        private Label label3;
        private PictureBox pictureBox1;
    }
}