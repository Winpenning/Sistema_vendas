namespace Sistema_vendas
{
    partial class FMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            vendasToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            botaoclientes = new ToolStripButton();
            botaoprodutos = new ToolStripButton();
            botaofornecedores = new ToolStripButton();
            botaousuarios = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            botaovendas = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            botaosair = new ToolStripButton();
            tabControl1 = new TabControl();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, vendasToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, produtosToolStripMenuItem, fornecedoresToolStripMenuItem, usuáriosToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(88, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(181, 26);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(181, 26);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(181, 26);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(181, 26);
            usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // vendasToolStripMenuItem
            // 
            vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            vendasToolStripMenuItem.Size = new Size(70, 24);
            vendasToolStripMenuItem.Text = "Vendas";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(48, 24);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { botaoclientes, botaoprodutos, botaofornecedores, botaousuarios, toolStripSeparator1, botaovendas, toolStripSeparator2, botaosair });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 55);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // botaoclientes
            // 
            botaoclientes.DisplayStyle = ToolStripItemDisplayStyle.Image;
            botaoclientes.Image = (Image)resources.GetObject("botaoclientes.Image");
            botaoclientes.ImageScaling = ToolStripItemImageScaling.None;
            botaoclientes.ImageTransparentColor = Color.Magenta;
            botaoclientes.Name = "botaoclientes";
            botaoclientes.Size = new Size(52, 52);
            botaoclientes.Text = "toolStripButton1";
            botaoclientes.ToolTipText = "Cadastro de Clientes";
            botaoclientes.Click += botaoclientes_Click;
            // 
            // botaoprodutos
            // 
            botaoprodutos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            botaoprodutos.Image = (Image)resources.GetObject("botaoprodutos.Image");
            botaoprodutos.ImageScaling = ToolStripItemImageScaling.None;
            botaoprodutos.ImageTransparentColor = Color.Magenta;
            botaoprodutos.Name = "botaoprodutos";
            botaoprodutos.Size = new Size(52, 52);
            botaoprodutos.Text = "toolStripButton2";
            botaoprodutos.ToolTipText = "Cadastro de Produtos";
            // 
            // botaofornecedores
            // 
            botaofornecedores.DisplayStyle = ToolStripItemDisplayStyle.Image;
            botaofornecedores.Image = (Image)resources.GetObject("botaofornecedores.Image");
            botaofornecedores.ImageScaling = ToolStripItemImageScaling.None;
            botaofornecedores.ImageTransparentColor = Color.Magenta;
            botaofornecedores.Name = "botaofornecedores";
            botaofornecedores.Size = new Size(52, 52);
            botaofornecedores.Text = "toolStripButton3";
            botaofornecedores.ToolTipText = "Cadastro de Fornecedores";
            // 
            // botaousuarios
            // 
            botaousuarios.DisplayStyle = ToolStripItemDisplayStyle.Image;
            botaousuarios.Image = (Image)resources.GetObject("botaousuarios.Image");
            botaousuarios.ImageScaling = ToolStripItemImageScaling.None;
            botaousuarios.ImageTransparentColor = Color.Magenta;
            botaousuarios.Name = "botaousuarios";
            botaousuarios.Size = new Size(52, 52);
            botaousuarios.Text = "toolStripButton4";
            botaousuarios.ToolTipText = "Cadastro de Usuários";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 55);
            // 
            // botaovendas
            // 
            botaovendas.DisplayStyle = ToolStripItemDisplayStyle.Image;
            botaovendas.Image = (Image)resources.GetObject("botaovendas.Image");
            botaovendas.ImageScaling = ToolStripItemImageScaling.None;
            botaovendas.ImageTransparentColor = Color.Magenta;
            botaovendas.Name = "botaovendas";
            botaovendas.Size = new Size(52, 52);
            botaovendas.Text = "toolStripButton5";
            botaovendas.ToolTipText = "Registrar Vendas";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 55);
            // 
            // botaosair
            // 
            botaosair.DisplayStyle = ToolStripItemDisplayStyle.Image;
            botaosair.Image = (Image)resources.GetObject("botaosair.Image");
            botaosair.ImageScaling = ToolStripItemImageScaling.None;
            botaosair.ImageTransparentColor = Color.Magenta;
            botaosair.Name = "botaosair";
            botaosair.Size = new Size(52, 52);
            botaosair.Text = "toolStripButton6";
            botaosair.ToolTipText = "Sair";
            botaosair.Click += botaosair_Click;
            // 
            // tabControl1
            // 
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 83);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 367);
            tabControl1.TabIndex = 2;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // FMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FMenu";
            Text = "Form1";
            Load += FMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton botaoclientes;
        private ToolStripButton botaoprodutos;
        private ToolStripButton botaofornecedores;
        private ToolStripButton botaousuarios;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton botaovendas;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton botaosair;
        private TabControl tabControl1;
    }
}