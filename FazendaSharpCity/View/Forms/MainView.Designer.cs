









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
            pictureBox2 = new PictureBox();
            panelLateral.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(229, 881);
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
            btnVendas.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVendas.Location = new Point(0, 283);
            btnVendas.Name = "btnVendas";
            btnVendas.Padding = new Padding(10, 0, 0, 0);
            btnVendas.Size = new Size(229, 40);
            btnVendas.TabIndex = 5;
            btnVendas.Text = "Vendas";
            btnVendas.TextAlign = ContentAlignment.MiddleLeft;
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
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
            btnProduto.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduto.Location = new Point(0, 243);
            btnProduto.Name = "btnProduto";
            btnProduto.Padding = new Padding(10, 0, 0, 0);
            btnProduto.Size = new Size(229, 40);
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
            btnFornecedor.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFornecedor.Location = new Point(0, 203);
            btnFornecedor.Name = "btnFornecedor";
            btnFornecedor.Padding = new Padding(10, 0, 0, 0);
            btnFornecedor.Size = new Size(229, 40);
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
            btnCliente.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCliente.Location = new Point(0, 163);
            btnCliente.Name = "btnCliente";
            btnCliente.Padding = new Padding(10, 0, 0, 0);
            btnCliente.Size = new Size(229, 40);
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
            panelLogo.Size = new Size(229, 163);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 163);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(224, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1128, 881);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 881);
            Controls.Add(pictureBox2);
            Controls.Add(panelLateral);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MinimumSize = new Size(1371, 928);
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FazendaSharpCity";
            panelLateral.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
    }
}
