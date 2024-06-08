









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
            btnVendas = new Button();
            btnProduto = new Button();
            btnFornecedor = new Button();
            btnCliente = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelViewChange = new Panel();
            panelLateral.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLateral
            // 
            panelLateral.AutoScroll = true;
            panelLateral.BackColor = Color.DarkSeaGreen;
            panelLateral.BackgroundImage = (Image)resources.GetObject("panelLateral.BackgroundImage");
            panelLateral.Controls.Add(btnVendas);
            panelLateral.Controls.Add(btnProduto);
            panelLateral.Controls.Add(btnFornecedor);
            panelLateral.Controls.Add(btnCliente);
            panelLateral.Controls.Add(panelLogo);
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Location = new Point(0, 0);
            panelLateral.Margin = new Padding(3, 2, 3, 2);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(200, 661);
            panelLateral.TabIndex = 0;
            // 
            // btnVendas
            // 
            btnVendas.BackColor = Color.DarkSeaGreen;
            btnVendas.BackgroundImage = (Image)resources.GetObject("btnVendas.BackgroundImage");
            btnVendas.Dock = DockStyle.Top;
            btnVendas.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnVendas.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btnVendas.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnVendas.FlatStyle = FlatStyle.Flat;
            btnVendas.Location = new Point(0, 224);
            btnVendas.Margin = new Padding(3, 2, 3, 2);
            btnVendas.Name = "btnVendas";
            btnVendas.Padding = new Padding(9, 0, 0, 0);
            btnVendas.Size = new Size(200, 34);
            btnVendas.TabIndex = 5;
            btnVendas.Text = "Vendas";
            btnVendas.TextAlign = ContentAlignment.MiddleLeft;
            btnVendas.UseVisualStyleBackColor = false;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = Color.DarkSeaGreen;
            btnProduto.BackgroundImage = (Image)resources.GetObject("btnProduto.BackgroundImage");
            btnProduto.Dock = DockStyle.Top;
            btnProduto.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnProduto.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btnProduto.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnProduto.FlatStyle = FlatStyle.Flat;
            btnProduto.Location = new Point(0, 190);
            btnProduto.Margin = new Padding(3, 2, 3, 2);
            btnProduto.Name = "btnProduto";
            btnProduto.Padding = new Padding(9, 0, 0, 0);
            btnProduto.Size = new Size(200, 34);
            btnProduto.TabIndex = 4;
            btnProduto.Text = "Produtos";
            btnProduto.TextAlign = ContentAlignment.MiddleLeft;
            btnProduto.UseVisualStyleBackColor = false;
            btnProduto.Click += btnProduto_Click;
            // 
            // btnFornecedor
            // 
            btnFornecedor.BackColor = Color.Black;
            btnFornecedor.BackgroundImage = (Image)resources.GetObject("btnFornecedor.BackgroundImage");
            btnFornecedor.Dock = DockStyle.Top;
            btnFornecedor.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnFornecedor.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btnFornecedor.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnFornecedor.FlatStyle = FlatStyle.Flat;
            btnFornecedor.Location = new Point(0, 156);
            btnFornecedor.Margin = new Padding(3, 2, 3, 2);
            btnFornecedor.Name = "btnFornecedor";
            btnFornecedor.Padding = new Padding(9, 0, 0, 0);
            btnFornecedor.Size = new Size(200, 34);
            btnFornecedor.TabIndex = 2;
            btnFornecedor.Text = "Fornecedores";
            btnFornecedor.TextAlign = ContentAlignment.MiddleLeft;
            btnFornecedor.UseVisualStyleBackColor = false;
            btnFornecedor.Click += btnFornecedor_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.Transparent;
            btnCliente.BackgroundImage = (Image)resources.GetObject("btnCliente.BackgroundImage");
            btnCliente.Dock = DockStyle.Top;
            btnCliente.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnCliente.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btnCliente.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Location = new Point(0, 122);
            btnCliente.Margin = new Padding(3, 2, 3, 2);
            btnCliente.Name = "btnCliente";
            btnCliente.Padding = new Padding(9, 0, 0, 0);
            btnCliente.Size = new Size(200, 34);
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
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 122);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 122);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelViewChange
            // 
            panelViewChange.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelViewChange.BackgroundImage = (Image)resources.GetObject("panelViewChange.BackgroundImage");
            panelViewChange.Location = new Point(200, 0);
            panelViewChange.Margin = new Padding(3, 2, 3, 2);
            panelViewChange.Name = "panelViewChange";
            panelViewChange.Size = new Size(982, 661);
            panelViewChange.TabIndex = 1;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(panelViewChange);
            Controls.Add(panelLateral);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FazendaSharpCity";
            panelLateral.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel panelLateral;
        private Button btnProduto;
        private Button btnFornecedor;
        private Button btnCliente;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Button btnVendas;
        private Panel panelViewChange;
    }
}
