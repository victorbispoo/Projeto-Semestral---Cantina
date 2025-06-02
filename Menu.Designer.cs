namespace Projeto_Semestral___Cantina
{
    partial class Menu
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Guna.UI2.WinForms.Guna2Button();
            btnEstoque = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            BtnBalcao = new Guna.UI2.WinForms.Guna2Button();
            btnTelaVendas = new Guna.UI2.WinForms.Guna2Button();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bolt;
            pictureBox1.Location = new Point(302, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(353, 102);
            label1.Name = "label1";
            label1.Size = new Size(176, 39);
            label1.TabIndex = 7;
            label1.Text = "Menu Inicial";
            // 
            // button1
            // 
            button1.Animated = true;
            button1.BorderColor = SystemColors.Window;
            button1.BorderRadius = 15;
            button1.BorderThickness = 1;
            button1.Cursor = Cursors.Hand;
            button1.CustomizableEdges = customizableEdges1;
            button1.DisabledState.BorderColor = Color.DarkGray;
            button1.DisabledState.CustomBorderColor = Color.DarkGray;
            button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button1.FillColor = SystemColors.Window;
            button1.Font = new Font("Inter", 18F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(17, 25, 12);
            button1.Image = Properties.Resources.telão;
            button1.Location = new Point(574, 155);
            button1.Name = "button1";
            button1.PressedColor = Color.FromArgb(230, 255, 0);
            button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            button1.Size = new Size(275, 84);
            button1.TabIndex = 20;
            button1.Text = " Telão Pedidos";
            button1.Click += button1_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.Animated = true;
            btnEstoque.AnimatedGIF = true;
            btnEstoque.BackColor = Color.Transparent;
            btnEstoque.BorderColor = SystemColors.Window;
            btnEstoque.BorderRadius = 15;
            btnEstoque.BorderThickness = 1;
            btnEstoque.CausesValidation = false;
            btnEstoque.Cursor = Cursors.No;
            btnEstoque.CustomImages.HoveredImage = Properties.Resources._2356480_stock_photo_smiley;
            btnEstoque.CustomImages.ImageAlign = HorizontalAlignment.Center;
            btnEstoque.CustomImages.ImageSize = new Size(200, 200);
            btnEstoque.CustomizableEdges = customizableEdges3;
            btnEstoque.DisabledState.BorderColor = SystemColors.Window;
            btnEstoque.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEstoque.DisabledState.FillColor = Color.White;
            btnEstoque.DisabledState.ForeColor = Color.FromArgb(17, 25, 12);
            btnEstoque.DisabledState.Image = Properties.Resources._2356480_stock_photo_smiley;
            btnEstoque.FillColor = SystemColors.Window;
            btnEstoque.FocusedColor = Color.Red;
            btnEstoque.Font = new Font("Inter", 18F, FontStyle.Bold);
            btnEstoque.ForeColor = Color.FromArgb(17, 25, 12);
            btnEstoque.HoverState.Image = Properties.Resources._2356480_stock_photo_smiley;
            btnEstoque.Image = Properties.Resources.estoque;
            btnEstoque.Location = new Point(293, 277);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.PressedColor = Color.Red;
            btnEstoque.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEstoque.Size = new Size(275, 84);
            btnEstoque.TabIndex = 21;
            btnEstoque.Text = " Estoque";
            // 
            // guna2Button1
            // 
            guna2Button1.Animated = true;
            guna2Button1.BorderColor = SystemColors.Window;
            guna2Button1.BorderRadius = 15;
            guna2Button1.BorderThickness = 1;
            guna2Button1.Cursor = Cursors.Hand;
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = SystemColors.Window;
            guna2Button1.Font = new Font("Inter", 18F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.FromArgb(17, 25, 12);
            guna2Button1.Image = Properties.Resources.cozinha;
            guna2Button1.Location = new Point(293, 155);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.FromArgb(230, 255, 0);
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(275, 84);
            guna2Button1.TabIndex = 22;
            guna2Button1.Text = " Cozinha";
            guna2Button1.Click += BtnCozinha_Click;
            // 
            // BtnBalcao
            // 
            BtnBalcao.Animated = true;
            BtnBalcao.BorderColor = SystemColors.Window;
            BtnBalcao.BorderRadius = 15;
            BtnBalcao.BorderThickness = 1;
            BtnBalcao.Cursor = Cursors.Hand;
            BtnBalcao.CustomizableEdges = customizableEdges7;
            BtnBalcao.DisabledState.BorderColor = Color.DarkGray;
            BtnBalcao.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnBalcao.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnBalcao.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnBalcao.FillColor = SystemColors.Window;
            BtnBalcao.Font = new Font("Inter", 18F, FontStyle.Bold);
            BtnBalcao.ForeColor = Color.FromArgb(17, 25, 12);
            BtnBalcao.Image = Properties.Resources.Loja;
            BtnBalcao.Location = new Point(12, 155);
            BtnBalcao.Name = "BtnBalcao";
            BtnBalcao.PressedColor = Color.FromArgb(230, 255, 0);
            BtnBalcao.ShadowDecoration.CustomizableEdges = customizableEdges8;
            BtnBalcao.Size = new Size(275, 84);
            BtnBalcao.TabIndex = 23;
            BtnBalcao.Text = " Balcão";
            BtnBalcao.Click += BtnBalcao_Click;
            // 
            // btnTelaVendas
            // 
            btnTelaVendas.Animated = true;
            btnTelaVendas.BorderColor = SystemColors.Window;
            btnTelaVendas.BorderRadius = 15;
            btnTelaVendas.BorderThickness = 1;
            btnTelaVendas.Cursor = Cursors.Hand;
            btnTelaVendas.CustomizableEdges = customizableEdges9;
            btnTelaVendas.DisabledState.BorderColor = Color.DarkGray;
            btnTelaVendas.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTelaVendas.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTelaVendas.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTelaVendas.FillColor = SystemColors.Window;
            btnTelaVendas.Font = new Font("Inter", 18F, FontStyle.Bold);
            btnTelaVendas.ForeColor = Color.FromArgb(17, 25, 12);
            btnTelaVendas.Image = Properties.Resources.vendas;
            btnTelaVendas.Location = new Point(12, 277);
            btnTelaVendas.Name = "btnTelaVendas";
            btnTelaVendas.PressedColor = Color.FromArgb(230, 255, 0);
            btnTelaVendas.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnTelaVendas.Size = new Size(275, 84);
            btnTelaVendas.TabIndex = 24;
            btnTelaVendas.Text = " Vendas";
            btnTelaVendas.Click += btnTelaVendas_Click;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(862, 445);
            Controls.Add(btnTelaVendas);
            Controls.Add(BtnBalcao);
            Controls.Add(guna2Button1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnEstoque);
            ForeColor = Color.FromArgb(17, 25, 12);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button button1;
        private Guna.UI2.WinForms.Guna2Button btnEstoque;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button BtnBalcao;
        private Guna.UI2.WinForms.Guna2Button btnTelaVendas;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator guna2WinProgressIndicator1;
        private PictureBox pictureBox2;
    }
}