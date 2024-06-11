namespace FazendaSharpCity.View.Forms
{
    partial class RelatoriosView
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
            tabPageFornecedores = new TabPage();
            btnPesquisarFornecedores = new Button();
            txtPesquisaFornecedores = new TextBox();
            tabFornecedores = new DataGridView();
            btnExportarFornecedores = new Button();
            tabClientes = new DataGridView();
            btnExportarClientes = new Button();
            tabPageClientes = new TabPage();
            btnPesquisarClientes = new Button();
            txtPesquisaClientes = new TextBox();
            tabControllerRelatorios = new TabControl();
            tabPageProdutos = new TabPage();
            btnPesquisarProdutos = new Button();
            txtPesquisaProdutos = new TextBox();
            tabProdutos = new DataGridView();
            btnExportarProdutos = new Button();
            tabPageVendas = new TabPage();
            btnPesquisaVendas = new Button();
            lblDataVenda = new Label();
            dtPickerVendas = new DateTimePicker();
            tabVendas = new DataGridView();
            btnExportarVendas = new Button();
            tabPageFuncionarios = new TabPage();
            btnPesquisarFuncionarios = new Button();
            txtPesquisaFuncionarios = new TextBox();
            tabFuncionarios = new DataGridView();
            btnExportarFuncionarios = new Button();
            tabPageFornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabFornecedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabClientes).BeginInit();
            tabPageClientes.SuspendLayout();
            tabControllerRelatorios.SuspendLayout();
            tabPageProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabProdutos).BeginInit();
            tabPageVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabVendas).BeginInit();
            tabPageFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // tabPageFornecedores
            // 
            tabPageFornecedores.BackColor = Color.LightSlateGray;
            tabPageFornecedores.Controls.Add(btnPesquisarFornecedores);
            tabPageFornecedores.Controls.Add(txtPesquisaFornecedores);
            tabPageFornecedores.Controls.Add(tabFornecedores);
            tabPageFornecedores.Controls.Add(btnExportarFornecedores);
            tabPageFornecedores.Location = new Point(4, 29);
            tabPageFornecedores.Margin = new Padding(3, 4, 3, 4);
            tabPageFornecedores.Name = "tabPageFornecedores";
            tabPageFornecedores.Padding = new Padding(3, 4, 3, 4);
            tabPageFornecedores.Size = new Size(1019, 549);
            tabPageFornecedores.TabIndex = 1;
            tabPageFornecedores.Text = "Relatórios - Fornecedores";
            // 
            // btnPesquisarFornecedores
            // 
            btnPesquisarFornecedores.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisarFornecedores.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisarFornecedores.Location = new Point(883, 7);
            btnPesquisarFornecedores.Name = "btnPesquisarFornecedores";
            btnPesquisarFornecedores.Size = new Size(128, 27);
            btnPesquisarFornecedores.TabIndex = 19;
            btnPesquisarFornecedores.Text = "Pesquisar";
            btnPesquisarFornecedores.UseVisualStyleBackColor = true;
            btnPesquisarFornecedores.Click += btnPesquisarFornecedores_Click;
            // 
            // txtPesquisaFornecedores
            // 
            txtPesquisaFornecedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisaFornecedores.Location = new Point(8, 7);
            txtPesquisaFornecedores.Name = "txtPesquisaFornecedores";
            txtPesquisaFornecedores.Size = new Size(869, 27);
            txtPesquisaFornecedores.TabIndex = 18;
            txtPesquisaFornecedores.KeyDown += txtPesquisaFornecedores_KeyDown;
            // 
            // tabFornecedores
            // 
            tabFornecedores.AllowUserToAddRows = false;
            tabFornecedores.AllowUserToDeleteRows = false;
            tabFornecedores.AllowUserToResizeColumns = false;
            tabFornecedores.AllowUserToResizeRows = false;
            tabFornecedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabFornecedores.BackgroundColor = Color.LightGray;
            tabFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabFornecedores.Location = new Point(8, 55);
            tabFornecedores.MultiSelect = false;
            tabFornecedores.Name = "tabFornecedores";
            tabFornecedores.ReadOnly = true;
            tabFornecedores.RowHeadersWidth = 51;
            tabFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabFornecedores.Size = new Size(1003, 427);
            tabFornecedores.TabIndex = 17;
            // 
            // btnExportarFornecedores
            // 
            btnExportarFornecedores.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportarFornecedores.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarFornecedores.Location = new Point(420, 488);
            btnExportarFornecedores.Name = "btnExportarFornecedores";
            btnExportarFornecedores.Size = new Size(126, 53);
            btnExportarFornecedores.TabIndex = 16;
            btnExportarFornecedores.Text = "Exportar Relatório";
            btnExportarFornecedores.UseVisualStyleBackColor = true;
            btnExportarFornecedores.Click += btnExportarFornecedores_Click;
            // 
            // tabClientes
            // 
            tabClientes.AllowUserToAddRows = false;
            tabClientes.AllowUserToDeleteRows = false;
            tabClientes.AllowUserToResizeColumns = false;
            tabClientes.AllowUserToResizeRows = false;
            tabClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabClientes.BackgroundColor = Color.LightGray;
            tabClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabClientes.Location = new Point(8, 55);
            tabClientes.MultiSelect = false;
            tabClientes.Name = "tabClientes";
            tabClientes.ReadOnly = true;
            tabClientes.RowHeadersWidth = 51;
            tabClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabClientes.Size = new Size(1003, 427);
            tabClientes.TabIndex = 15;
            // 
            // btnExportarClientes
            // 
            btnExportarClientes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportarClientes.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarClientes.Location = new Point(420, 488);
            btnExportarClientes.Name = "btnExportarClientes";
            btnExportarClientes.Size = new Size(126, 53);
            btnExportarClientes.TabIndex = 14;
            btnExportarClientes.Text = "Exportar Relatório";
            btnExportarClientes.UseVisualStyleBackColor = true;
            btnExportarClientes.Click += btnExportarClientes_Click;
            // 
            // tabPageClientes
            // 
            tabPageClientes.BackColor = Color.LightSlateGray;
            tabPageClientes.Controls.Add(btnPesquisarClientes);
            tabPageClientes.Controls.Add(txtPesquisaClientes);
            tabPageClientes.Controls.Add(tabClientes);
            tabPageClientes.Controls.Add(btnExportarClientes);
            tabPageClientes.Location = new Point(4, 29);
            tabPageClientes.Margin = new Padding(3, 4, 3, 4);
            tabPageClientes.Name = "tabPageClientes";
            tabPageClientes.Padding = new Padding(3, 4, 3, 4);
            tabPageClientes.Size = new Size(1019, 549);
            tabPageClientes.TabIndex = 0;
            tabPageClientes.Text = "Relatórios - Clientes";
            // 
            // btnPesquisarClientes
            // 
            btnPesquisarClientes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisarClientes.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisarClientes.Location = new Point(883, 7);
            btnPesquisarClientes.Name = "btnPesquisarClientes";
            btnPesquisarClientes.Size = new Size(128, 27);
            btnPesquisarClientes.TabIndex = 17;
            btnPesquisarClientes.Text = "Pesquisar";
            btnPesquisarClientes.UseVisualStyleBackColor = true;
            btnPesquisarClientes.Click += btnPesquisarClientes_Click;
            // 
            // txtPesquisaClientes
            // 
            txtPesquisaClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisaClientes.Location = new Point(8, 7);
            txtPesquisaClientes.Name = "txtPesquisaClientes";
            txtPesquisaClientes.Size = new Size(869, 27);
            txtPesquisaClientes.TabIndex = 16;
            txtPesquisaClientes.KeyDown += txtPesquisaClientes_KeyDown;
            // 
            // tabControllerRelatorios
            // 
            tabControllerRelatorios.Controls.Add(tabPageClientes);
            tabControllerRelatorios.Controls.Add(tabPageFornecedores);
            tabControllerRelatorios.Controls.Add(tabPageProdutos);
            tabControllerRelatorios.Controls.Add(tabPageVendas);
            tabControllerRelatorios.Controls.Add(tabPageFuncionarios);
            tabControllerRelatorios.Dock = DockStyle.Fill;
            tabControllerRelatorios.Location = new Point(0, 0);
            tabControllerRelatorios.Margin = new Padding(3, 4, 3, 4);
            tabControllerRelatorios.Name = "tabControllerRelatorios";
            tabControllerRelatorios.SelectedIndex = 0;
            tabControllerRelatorios.Size = new Size(1027, 582);
            tabControllerRelatorios.TabIndex = 1;
            // 
            // tabPageProdutos
            // 
            tabPageProdutos.BackColor = Color.LightSlateGray;
            tabPageProdutos.Controls.Add(btnPesquisarProdutos);
            tabPageProdutos.Controls.Add(txtPesquisaProdutos);
            tabPageProdutos.Controls.Add(tabProdutos);
            tabPageProdutos.Controls.Add(btnExportarProdutos);
            tabPageProdutos.Location = new Point(4, 29);
            tabPageProdutos.Name = "tabPageProdutos";
            tabPageProdutos.Padding = new Padding(3);
            tabPageProdutos.Size = new Size(1019, 549);
            tabPageProdutos.TabIndex = 2;
            tabPageProdutos.Text = "Relatórios - Produtos";
            // 
            // btnPesquisarProdutos
            // 
            btnPesquisarProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisarProdutos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisarProdutos.Location = new Point(878, 6);
            btnPesquisarProdutos.Name = "btnPesquisarProdutos";
            btnPesquisarProdutos.Size = new Size(128, 27);
            btnPesquisarProdutos.TabIndex = 21;
            btnPesquisarProdutos.Text = "Pesquisar";
            btnPesquisarProdutos.UseVisualStyleBackColor = true;
            btnPesquisarProdutos.Click += btnPesquisarProdutos_Click;
            // 
            // txtPesquisaProdutos
            // 
            txtPesquisaProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisaProdutos.Location = new Point(8, 6);
            txtPesquisaProdutos.Name = "txtPesquisaProdutos";
            txtPesquisaProdutos.Size = new Size(864, 27);
            txtPesquisaProdutos.TabIndex = 20;
            txtPesquisaProdutos.KeyDown += txtPesquisaProdutos_KeyDown;
            // 
            // tabProdutos
            // 
            tabProdutos.AllowUserToAddRows = false;
            tabProdutos.AllowUserToDeleteRows = false;
            tabProdutos.AllowUserToResizeColumns = false;
            tabProdutos.AllowUserToResizeRows = false;
            tabProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabProdutos.BackgroundColor = Color.LightGray;
            tabProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabProdutos.Location = new Point(8, 55);
            tabProdutos.MultiSelect = false;
            tabProdutos.Name = "tabProdutos";
            tabProdutos.ReadOnly = true;
            tabProdutos.RowHeadersWidth = 51;
            tabProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabProdutos.Size = new Size(1003, 427);
            tabProdutos.TabIndex = 19;
            // 
            // btnExportarProdutos
            // 
            btnExportarProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportarProdutos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarProdutos.Location = new Point(420, 488);
            btnExportarProdutos.Name = "btnExportarProdutos";
            btnExportarProdutos.Size = new Size(126, 53);
            btnExportarProdutos.TabIndex = 18;
            btnExportarProdutos.Text = "Exportar Relatório";
            btnExportarProdutos.UseVisualStyleBackColor = true;
            btnExportarProdutos.Click += btnExportarProdutos_Click;
            // 
            // tabPageVendas
            // 
            tabPageVendas.BackColor = Color.LightSlateGray;
            tabPageVendas.Controls.Add(btnPesquisaVendas);
            tabPageVendas.Controls.Add(lblDataVenda);
            tabPageVendas.Controls.Add(dtPickerVendas);
            tabPageVendas.Controls.Add(tabVendas);
            tabPageVendas.Controls.Add(btnExportarVendas);
            tabPageVendas.Location = new Point(4, 29);
            tabPageVendas.Name = "tabPageVendas";
            tabPageVendas.Padding = new Padding(3);
            tabPageVendas.Size = new Size(1019, 549);
            tabPageVendas.TabIndex = 3;
            tabPageVendas.Text = "Relatórios - Vendas";
            // 
            // btnPesquisaVendas
            // 
            btnPesquisaVendas.Location = new Point(380, 21);
            btnPesquisaVendas.Name = "btnPesquisaVendas";
            btnPesquisaVendas.Size = new Size(94, 29);
            btnPesquisaVendas.TabIndex = 22;
            btnPesquisaVendas.Text = "Pesquisar";
            btnPesquisaVendas.UseVisualStyleBackColor = true;
            btnPesquisaVendas.Click += btnPesquisaVendas_Click;
            // 
            // lblDataVenda
            // 
            lblDataVenda.AutoSize = true;
            lblDataVenda.Location = new Point(36, 25);
            lblDataVenda.Name = "lblDataVenda";
            lblDataVenda.Size = new Size(128, 20);
            lblDataVenda.TabIndex = 21;
            lblDataVenda.Text = "Data do Relatório";
            // 
            // dtPickerVendas
            // 
            dtPickerVendas.CustomFormat = "dd/MMMM/yyyy";
            dtPickerVendas.Format = DateTimePickerFormat.Custom;
            dtPickerVendas.Location = new Point(170, 20);
            dtPickerVendas.Name = "dtPickerVendas";
            dtPickerVendas.Size = new Size(177, 27);
            dtPickerVendas.TabIndex = 20;
            // 
            // tabVendas
            // 
            tabVendas.AllowUserToAddRows = false;
            tabVendas.AllowUserToDeleteRows = false;
            tabVendas.AllowUserToResizeColumns = false;
            tabVendas.AllowUserToResizeRows = false;
            tabVendas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabVendas.BackgroundColor = Color.LightGray;
            tabVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabVendas.Location = new Point(8, 59);
            tabVendas.MultiSelect = false;
            tabVendas.Name = "tabVendas";
            tabVendas.ReadOnly = true;
            tabVendas.RowHeadersWidth = 51;
            tabVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabVendas.Size = new Size(1003, 423);
            tabVendas.TabIndex = 19;
            // 
            // btnExportarVendas
            // 
            btnExportarVendas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportarVendas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarVendas.Location = new Point(420, 488);
            btnExportarVendas.Name = "btnExportarVendas";
            btnExportarVendas.Size = new Size(126, 53);
            btnExportarVendas.TabIndex = 18;
            btnExportarVendas.Text = "Exportar Relatório";
            btnExportarVendas.UseVisualStyleBackColor = true;
            btnExportarVendas.Click += btnExportarVendas_Click;
            // 
            // tabPageFuncionarios
            // 
            tabPageFuncionarios.BackColor = Color.LightSlateGray;
            tabPageFuncionarios.Controls.Add(btnPesquisarFuncionarios);
            tabPageFuncionarios.Controls.Add(txtPesquisaFuncionarios);
            tabPageFuncionarios.Controls.Add(tabFuncionarios);
            tabPageFuncionarios.Controls.Add(btnExportarFuncionarios);
            tabPageFuncionarios.Location = new Point(4, 29);
            tabPageFuncionarios.Name = "tabPageFuncionarios";
            tabPageFuncionarios.Padding = new Padding(3);
            tabPageFuncionarios.Size = new Size(1019, 549);
            tabPageFuncionarios.TabIndex = 4;
            tabPageFuncionarios.Text = "Relatórios - Funcionários";
            // 
            // btnPesquisarFuncionarios
            // 
            btnPesquisarFuncionarios.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisarFuncionarios.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisarFuncionarios.Location = new Point(883, 6);
            btnPesquisarFuncionarios.Name = "btnPesquisarFuncionarios";
            btnPesquisarFuncionarios.Size = new Size(128, 27);
            btnPesquisarFuncionarios.TabIndex = 21;
            btnPesquisarFuncionarios.Text = "Pesquisar";
            btnPesquisarFuncionarios.UseVisualStyleBackColor = true;
            btnPesquisarFuncionarios.Click += btnPesquisarFuncionarios_Click;
            // 
            // txtPesquisaFuncionarios
            // 
            txtPesquisaFuncionarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisaFuncionarios.Location = new Point(8, 6);
            txtPesquisaFuncionarios.Name = "txtPesquisaFuncionarios";
            txtPesquisaFuncionarios.Size = new Size(869, 27);
            txtPesquisaFuncionarios.TabIndex = 20;
            txtPesquisaFuncionarios.KeyDown += txtPesquisaFuncionarios_KeyDown;
            // 
            // tabFuncionarios
            // 
            tabFuncionarios.AllowUserToAddRows = false;
            tabFuncionarios.AllowUserToDeleteRows = false;
            tabFuncionarios.AllowUserToResizeColumns = false;
            tabFuncionarios.AllowUserToResizeRows = false;
            tabFuncionarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabFuncionarios.BackgroundColor = Color.LightGray;
            tabFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabFuncionarios.Location = new Point(8, 55);
            tabFuncionarios.MultiSelect = false;
            tabFuncionarios.Name = "tabFuncionarios";
            tabFuncionarios.ReadOnly = true;
            tabFuncionarios.RowHeadersWidth = 51;
            tabFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabFuncionarios.Size = new Size(1003, 427);
            tabFuncionarios.TabIndex = 19;
            // 
            // btnExportarFuncionarios
            // 
            btnExportarFuncionarios.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportarFuncionarios.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarFuncionarios.Location = new Point(420, 488);
            btnExportarFuncionarios.Name = "btnExportarFuncionarios";
            btnExportarFuncionarios.Size = new Size(126, 53);
            btnExportarFuncionarios.TabIndex = 18;
            btnExportarFuncionarios.Text = "Exportar Relatório";
            btnExportarFuncionarios.UseVisualStyleBackColor = true;
            btnExportarFuncionarios.Click += btnExportarFuncionarios_Click;
            // 
            // RelatoriosView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 582);
            Controls.Add(tabControllerRelatorios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RelatoriosView";
            Text = "RelatoriosView";
            tabPageFornecedores.ResumeLayout(false);
            tabPageFornecedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabFornecedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabClientes).EndInit();
            tabPageClientes.ResumeLayout(false);
            tabPageClientes.PerformLayout();
            tabControllerRelatorios.ResumeLayout(false);
            tabPageProdutos.ResumeLayout(false);
            tabPageProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabProdutos).EndInit();
            tabPageVendas.ResumeLayout(false);
            tabPageVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabVendas).EndInit();
            tabPageFuncionarios.ResumeLayout(false);
            tabPageFuncionarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabFuncionarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtFormaPag;
        private TextBox txtQtd;
        private Label lblFormaPag;
        private TextBox txtPrecoUnit;
        private Label lblPrecoUnit;
        private DateTimePicker dtPickerDataVenda;
        private TextBox txtTotal;
        private Label lblTotal;
        private Button btnListar;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox txtId;
        private Button btnCalcular;
        private Panel panel3;
        private TabPage tabPageCadastro;
        private Label lblId;
        private Panel panel2;
        private Panel panel1;
        private Label lblQtd;
        private TabPage tabPageFornecedores;
        private DataGridView tabClientes;
        private Button btnExportarClientes;
        private TabPage tabPageClientes;
        private TabControl tabControllerRelatorios;
        private DataGridView tabFornecedores;
        private Button btnExportarFornecedores;
        private TabPage tabPageProdutos;
        private DataGridView tabProdutos;
        private Button btnExportarProdutos;
        private TabPage tabPageVendas;
        private DataGridView tabVendas;
        private Button btnExportarVendas;
        private TabPage tabPageFuncionarios;
        private DataGridView tabFuncionarios;
        private Button btnExportarFuncionarios;
        private Button btnPesquisaVendas;
        private Label lblDataVenda;
        private DateTimePicker dtPickerVendas;
        private Button btnPesquisarFornecedores;
        private TextBox txtPesquisaFornecedores;
        private Button btnPesquisarClientes;
        private TextBox txtPesquisaClientes;
        private Button btnPesquisarProdutos;
        private TextBox txtPesquisaProdutos;
        private Button btnPesquisarFuncionarios;
        private TextBox txtPesquisaFuncionarios;
    }
}