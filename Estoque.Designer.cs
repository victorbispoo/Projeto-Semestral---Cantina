namespace Projeto_Semestral___Cantina
{
    partial class Estoque
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            listProdutosEstoque = new ListBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            btnRemover = new Guna.UI2.WinForms.Guna2Button();
            btnAlterar = new Guna.UI2.WinForms.Guna2Button();
            btnVoltarMenu = new Guna.UI2.WinForms.Guna2Button();
            btnEditar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // listProdutosEstoque
            // 
            listProdutosEstoque.BorderStyle = BorderStyle.None;
            listProdutosEstoque.Cursor = Cursors.Hand;
            listProdutosEstoque.DrawMode = DrawMode.OwnerDrawFixed;
            listProdutosEstoque.Font = new Font("Inter Medium", 12F, FontStyle.Bold);
            listProdutosEstoque.ForeColor = Color.FromArgb(17, 25, 12);
            listProdutosEstoque.FormattingEnabled = true;
            listProdutosEstoque.ItemHeight = 23;
            listProdutosEstoque.Location = new Point(39, 107);
            listProdutosEstoque.Name = "listProdutosEstoque";
            listProdutosEstoque.Size = new Size(593, 276);
            listProdutosEstoque.TabIndex = 0;
            listProdutosEstoque.DrawItem += listProdutosEstoque_DrawItem;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bolt;
            pictureBox1.Location = new Point(39, 36);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Agrandir Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(188, 34);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(172, 50);
            label3.TabIndex = 19;
            label3.Text = "| Estoque";
            // 
            // btnAdd
            // 
            btnAdd.Animated = true;
            btnAdd.BorderColor = SystemColors.Window;
            btnAdd.BorderRadius = 15;
            btnAdd.BorderThickness = 1;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.CustomizableEdges = customizableEdges9;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = SystemColors.Window;
            btnAdd.Font = new Font("Inter", 16F, FontStyle.Bold);
            btnAdd.ForeColor = Color.FromArgb(17, 25, 12);
            btnAdd.Image = Properties.Resources.add;
            btnAdd.Location = new Point(666, 107);
            btnAdd.Name = "btnAdd";
            btnAdd.PressedColor = Color.FromArgb(230, 255, 0);
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnAdd.Size = new Size(272, 84);
            btnAdd.TabIndex = 21;
            btnAdd.Text = " Adicionar item";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemover
            // 
            btnRemover.Animated = true;
            btnRemover.BorderColor = SystemColors.Window;
            btnRemover.BorderRadius = 15;
            btnRemover.BorderThickness = 1;
            btnRemover.Cursor = Cursors.Hand;
            btnRemover.CustomizableEdges = customizableEdges7;
            btnRemover.DisabledState.BorderColor = Color.DarkGray;
            btnRemover.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRemover.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRemover.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRemover.FillColor = SystemColors.Window;
            btnRemover.Font = new Font("Inter", 16F, FontStyle.Bold);
            btnRemover.ForeColor = Color.FromArgb(17, 25, 12);
            btnRemover.Image = Properties.Resources.trash;
            btnRemover.Location = new Point(667, 203);
            btnRemover.Name = "btnRemover";
            btnRemover.PressedColor = Color.FromArgb(230, 255, 0);
            btnRemover.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnRemover.Size = new Size(271, 84);
            btnRemover.TabIndex = 22;
            btnRemover.Text = " Remover item";
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Animated = true;
            btnAlterar.BorderColor = SystemColors.Window;
            btnAlterar.BorderRadius = 15;
            btnAlterar.BorderThickness = 1;
            btnAlterar.Cursor = Cursors.Hand;
            btnAlterar.CustomizableEdges = customizableEdges5;
            btnAlterar.DisabledState.BorderColor = Color.DarkGray;
            btnAlterar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAlterar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAlterar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAlterar.FillColor = SystemColors.Window;
            btnAlterar.Font = new Font("Inter", 16F, FontStyle.Bold);
            btnAlterar.ForeColor = Color.FromArgb(17, 25, 12);
            btnAlterar.Image = Properties.Resources.replace;
            btnAlterar.Location = new Point(955, 203);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.PressedColor = Color.FromArgb(230, 255, 0);
            btnAlterar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAlterar.Size = new Size(272, 84);
            btnAlterar.TabIndex = 23;
            btnAlterar.Text = " Alterar Quantidade";
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnVoltarMenu
            // 
            btnVoltarMenu.Animated = true;
            btnVoltarMenu.BorderRadius = 15;
            btnVoltarMenu.Cursor = Cursors.Hand;
            btnVoltarMenu.CustomizableEdges = customizableEdges3;
            btnVoltarMenu.DisabledState.BorderColor = Color.DarkGray;
            btnVoltarMenu.DisabledState.CustomBorderColor = Color.DarkGray;
            btnVoltarMenu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnVoltarMenu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnVoltarMenu.FillColor = SystemColors.Window;
            btnVoltarMenu.Font = new Font("Inter", 12F, FontStyle.Bold);
            btnVoltarMenu.ForeColor = Color.FromArgb(17, 25, 12);
            btnVoltarMenu.Image = (Image)resources.GetObject("btnVoltarMenu.Image");
            btnVoltarMenu.Location = new Point(39, 401);
            btnVoltarMenu.Margin = new Padding(4);
            btnVoltarMenu.Name = "btnVoltarMenu";
            btnVoltarMenu.PressedColor = Color.FromArgb(230, 255, 0);
            btnVoltarMenu.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnVoltarMenu.Size = new Size(124, 39);
            btnVoltarMenu.TabIndex = 24;
            btnVoltarMenu.Text = " Voltar";
            btnVoltarMenu.Click += btnVoltarMenu_Click;
            // 
            // btnEditar
            // 
            btnEditar.Animated = true;
            btnEditar.BorderColor = SystemColors.Window;
            btnEditar.BorderRadius = 15;
            btnEditar.BorderThickness = 1;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.CustomizableEdges = customizableEdges1;
            btnEditar.DisabledState.BorderColor = Color.DarkGray;
            btnEditar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditar.FillColor = SystemColors.Window;
            btnEditar.Font = new Font("Inter", 16F, FontStyle.Bold);
            btnEditar.ForeColor = Color.FromArgb(17, 25, 12);
            btnEditar.Image = Properties.Resources.text_box_edit;
            btnEditar.Location = new Point(956, 107);
            btnEditar.Name = "btnEditar";
            btnEditar.PressedColor = Color.FromArgb(230, 255, 0);
            btnEditar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEditar.Size = new Size(271, 84);
            btnEditar.TabIndex = 25;
            btnEditar.Text = " Editar item";
            btnEditar.Click += btnEditar_Click;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 469);
            Controls.Add(btnEditar);
            Controls.Add(btnVoltarMenu);
            Controls.Add(btnAlterar);
            Controls.Add(btnRemover);
            Controls.Add(btnAdd);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(listProdutosEstoque);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Estoque";
            Text = "Estoque";
            FormClosed += Estoque_FormClosed;
            Load += Estoque_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private ListBox listProdutosEstoque;
        private PictureBox pictureBox1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btnRemover;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnAlterar;
        private Guna.UI2.WinForms.Guna2Button btnVoltarMenu;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
    }
}