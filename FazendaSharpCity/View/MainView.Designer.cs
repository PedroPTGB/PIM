









namespace FazendaSharpCity
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            panelLateral = new Panel();
            panelSubMenuProduto = new Panel();
            btnCadastraProduto = new Button();
            btnListaProduto = new Button();
            btnProduto = new Button();
            panelSubMenuFornecedor = new Panel();
            btnCadastraFornecedor = new Button();
            btnListaFornecedor = new Button();
            btnFornecedor = new Button();
            panelSubMenuCliente = new Panel();
            btnCadastraCliente = new Button();
            btnListaCliente = new Button();
            btnCliente = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelLateral.SuspendLayout();
            panelSubMenuProduto.SuspendLayout();
            panelSubMenuFornecedor.SuspendLayout();
            panelSubMenuCliente.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLateral
            // 
            panelLateral.AutoScroll = true;
            panelLateral.BackColor = Color.DarkSeaGreen;
            panelLateral.Controls.Add(panelSubMenuProduto);
            panelLateral.Controls.Add(btnProduto);
            panelLateral.Controls.Add(panelSubMenuFornecedor);
            panelLateral.Controls.Add(btnFornecedor);
            panelLateral.Controls.Add(panelSubMenuCliente);
            panelLateral.Controls.Add(btnCliente);
            panelLateral.Controls.Add(panelLogo);
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Location = new Point(0, 0);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(250, 673);
            panelLateral.TabIndex = 0;
            // 
            // panelSubMenuProduto
            // 
            panelSubMenuProduto.Controls.Add(btnCadastraProduto);
            panelSubMenuProduto.Controls.Add(btnListaProduto);
            panelSubMenuProduto.Dock = DockStyle.Top;
            panelSubMenuProduto.Location = new Point(0, 478);
            panelSubMenuProduto.Name = "panelSubMenuProduto";
            panelSubMenuProduto.Size = new Size(250, 90);
            panelSubMenuProduto.TabIndex = 5;
            // 
            // btnCadastraProduto
            // 
            btnCadastraProduto.BackColor = Color.DarkSeaGreen;
            btnCadastraProduto.Dock = DockStyle.Top;
            btnCadastraProduto.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnCadastraProduto.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btnCadastraProduto.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnCadastraProduto.FlatStyle = FlatStyle.Flat;
            btnCadastraProduto.Location = new Point(0, 45);
            btnCadastraProduto.Name = "btnCadastraProduto";
            btnCadastraProduto.Padding = new Padding(35, 0, 0, 0);
            btnCadastraProduto.Size = new Size(250, 45);
            btnCadastraProduto.TabIndex = 1;
            btnCadastraProduto.Text = "Cadastrar Produtos";
            btnCadastraProduto.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastraProduto.UseVisualStyleBackColor = false;
            btnCadastraProduto.Click += btnCadastraProduto_Click;
            // 
            // btnListaProduto
            // 
            btnListaProduto.BackColor = Color.DarkSeaGreen;
            btnListaProduto.Dock = DockStyle.Top;
            btnListaProduto.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnListaProduto.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btnListaProduto.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnListaProduto.FlatStyle = FlatStyle.Flat;
            btnListaProduto.Location = new Point(0, 0);
            btnListaProduto.Name = "btnListaProduto";
            btnListaProduto.Padding = new Padding(35, 0, 0, 0);
            btnListaProduto.Size = new Size(250, 45);
            btnListaProduto.TabIndex = 0;
            btnListaProduto.Text = "Listar Produtos";
            btnListaProduto.TextAlign = ContentAlignment.MiddleLeft;
            btnListaProduto.UseVisualStyleBackColor = false;
            btnListaProduto.Click += btnListaProduto_Click;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = Color.DarkSeaGreen;
            btnProduto.Dock = DockStyle.Top;
            btnProduto.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnProduto.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btnProduto.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnProduto.FlatStyle = FlatStyle.Flat;
            btnProduto.Location = new Point(0, 433);
            btnProduto.Name = "btnProduto";
            btnProduto.Padding = new Padding(10, 0, 0, 0);
            btnProduto.Size = new Size(250, 45);
            btnProduto.TabIndex = 4;
            btnProduto.Text = "Produtos";
            btnProduto.TextAlign = ContentAlignment.MiddleLeft;
            btnProduto.UseVisualStyleBackColor = false;
            btnProduto.Click += btnProduto_Click;
            // 
            // panelSubMenuFornecedor
            // 
            panelSubMenuFornecedor.Controls.Add(btnCadastraFornecedor);
            panelSubMenuFornecedor.Controls.Add(btnListaFornecedor);
            panelSubMenuFornecedor.Dock = DockStyle.Top;
            panelSubMenuFornecedor.Location = new Point(0, 343);
            panelSubMenuFornecedor.Name = "panelSubMenuFornecedor";
            panelSubMenuFornecedor.Size = new Size(250, 90);
            panelSubMenuFornecedor.TabIndex = 3;
            // 
            // btnCadastraFornecedor
            // 
            btnCadastraFornecedor.BackColor = Color.DarkSeaGreen;
            btnCadastraFornecedor.Dock = DockStyle.Top;
            btnCadastraFornecedor.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnCadastraFornecedor.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btnCadastraFornecedor.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnCadastraFornecedor.FlatStyle = FlatStyle.Flat;
            btnCadastraFornecedor.Location = new Point(0, 45);
            btnCadastraFornecedor.Name = "btnCadastraFornecedor";
            btnCadastraFornecedor.Padding = new Padding(35, 0, 0, 0);
            btnCadastraFornecedor.Size = new Size(250, 45);
            btnCadastraFornecedor.TabIndex = 1;
            btnCadastraFornecedor.Text = "Cadastrar Fornecedor";
            btnCadastraFornecedor.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastraFornecedor.UseVisualStyleBackColor = false;
            btnCadastraFornecedor.Click += btnCadastraFornecedor_Click;
            // 
            // btnListaFornecedor
            // 
            btnListaFornecedor.BackColor = Color.DarkSeaGreen;
            btnListaFornecedor.Dock = DockStyle.Top;
            btnListaFornecedor.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnListaFornecedor.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btnListaFornecedor.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnListaFornecedor.FlatStyle = FlatStyle.Flat;
            btnListaFornecedor.Location = new Point(0, 0);
            btnListaFornecedor.Name = "btnListaFornecedor";
            btnListaFornecedor.Padding = new Padding(35, 0, 0, 0);
            btnListaFornecedor.Size = new Size(250, 45);
            btnListaFornecedor.TabIndex = 0;
            btnListaFornecedor.Text = "Listar Fornecedores";
            btnListaFornecedor.TextAlign = ContentAlignment.MiddleLeft;
            btnListaFornecedor.UseVisualStyleBackColor = false;
            btnListaFornecedor.Click += btnListaFornecedor_Click;
            // 
            // btnFornecedor
            // 
            btnFornecedor.BackColor = Color.DarkSeaGreen;
            btnFornecedor.Dock = DockStyle.Top;
            btnFornecedor.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnFornecedor.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btnFornecedor.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnFornecedor.FlatStyle = FlatStyle.Flat;
            btnFornecedor.Location = new Point(0, 298);
            btnFornecedor.Name = "btnFornecedor";
            btnFornecedor.Padding = new Padding(10, 0, 0, 0);
            btnFornecedor.Size = new Size(250, 45);
            btnFornecedor.TabIndex = 2;
            btnFornecedor.Text = "Fornecedores";
            btnFornecedor.TextAlign = ContentAlignment.MiddleLeft;
            btnFornecedor.UseVisualStyleBackColor = false;
            btnFornecedor.Click += btnFornecedor_Click;
            // 
            // panelSubMenuCliente
            // 
            panelSubMenuCliente.Controls.Add(btnCadastraCliente);
            panelSubMenuCliente.Controls.Add(btnListaCliente);
            panelSubMenuCliente.Dock = DockStyle.Top;
            panelSubMenuCliente.Location = new Point(0, 208);
            panelSubMenuCliente.Name = "panelSubMenuCliente";
            panelSubMenuCliente.Size = new Size(250, 90);
            panelSubMenuCliente.TabIndex = 1;
            // 
            // btnCadastraCliente
            // 
            btnCadastraCliente.BackColor = Color.DarkSeaGreen;
            btnCadastraCliente.Dock = DockStyle.Top;
            btnCadastraCliente.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnCadastraCliente.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btnCadastraCliente.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnCadastraCliente.FlatStyle = FlatStyle.Flat;
            btnCadastraCliente.Location = new Point(0, 45);
            btnCadastraCliente.Name = "btnCadastraCliente";
            btnCadastraCliente.Padding = new Padding(35, 0, 0, 0);
            btnCadastraCliente.Size = new Size(250, 45);
            btnCadastraCliente.TabIndex = 1;
            btnCadastraCliente.Text = "Cadastrar Cliente";
            btnCadastraCliente.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastraCliente.UseVisualStyleBackColor = false;
            btnCadastraCliente.Click += btnCadastraCliente_Click;
            // 
            // btnListaCliente
            // 
            btnListaCliente.BackColor = Color.DarkSeaGreen;
            btnListaCliente.Dock = DockStyle.Top;
            btnListaCliente.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnListaCliente.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btnListaCliente.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnListaCliente.FlatStyle = FlatStyle.Flat;
            btnListaCliente.Location = new Point(0, 0);
            btnListaCliente.Name = "btnListaCliente";
            btnListaCliente.Padding = new Padding(35, 0, 0, 0);
            btnListaCliente.Size = new Size(250, 45);
            btnListaCliente.TabIndex = 0;
            btnListaCliente.Text = "Listar Clientes";
            btnListaCliente.TextAlign = ContentAlignment.MiddleLeft;
            btnListaCliente.UseVisualStyleBackColor = false;
            btnListaCliente.Click += btnListaCliente_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.DarkSeaGreen;
            btnCliente.Dock = DockStyle.Top;
            btnCliente.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnCliente.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btnCliente.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Location = new Point(0, 163);
            btnCliente.Name = "btnCliente";
            btnCliente.Padding = new Padding(10, 0, 0, 0);
            btnCliente.Size = new Size(250, 45);
            btnCliente.TabIndex = 0;
            btnCliente.Text = "Clientes";
            btnCliente.TextAlign = ContentAlignment.MiddleLeft;
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.DarkSeaGreen;
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 163);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(34, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 171);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panelLateral);
            MinimumSize = new Size(1280, 720);
            Name = "MainView";
            Text = "FazendaSharpCity";
            panelLateral.ResumeLayout(false);
            panelSubMenuProduto.ResumeLayout(false);
            panelSubMenuFornecedor.ResumeLayout(false);
            panelSubMenuCliente.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel panelLateral;
        private Panel panelSubMenuProduto;
        private Button btnCadastraProduto;
        private Button btnListaProduto;
        private Button btnProduto;
        private Panel panelSubMenuFornecedor;
        private Button btnCadastraFornecedor;
        private Button btnListaFornecedor;
        private Button btnFornecedor;
        private Panel panelSubMenuCliente;
        private Button btnCadastraCliente;
        private Button btnListaCliente;
        private Button btnCliente;
        private Panel panelLogo;
        private PictureBox pictureBox1;
    }
}
