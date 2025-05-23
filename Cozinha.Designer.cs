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
            SuspendLayout();
            // 
            // listBoxPedidos
            // 
            listBoxPedidos.Font = new Font("Agrandir Narrow", 12F, FontStyle.Bold);
            listBoxPedidos.FormattingEnabled = true;
            listBoxPedidos.ItemHeight = 21;
            listBoxPedidos.Location = new Point(37, 94);
            listBoxPedidos.Name = "listBoxPedidos";
            listBoxPedidos.Size = new Size(346, 298);
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
            listBoxComanda.FormattingEnabled = true;
            listBoxComanda.ItemHeight = 15;
            listBoxComanda.Location = new Point(518, 94);
            listBoxComanda.Name = "listBoxComanda";
            listBoxComanda.Size = new Size(346, 199);
            listBoxComanda.TabIndex = 4;
            // 
            // Cozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 464);
            Controls.Add(listBoxComanda);
            Controls.Add(label1);
            Controls.Add(labelPedidos);
            Controls.Add(listBoxPedidos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cozinha";
            Text = "Cozinha";
            Load += Cozinha_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxPedidos;
        private Label labelPedidos;
        private Label label1;
        private ListBox listBoxComanda;
    }
}