namespace FazendaSharpCity.View
{
    partial class ProdutoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutoView));
            tabControllerProduto = new TabControl();
            tabPageListar = new TabPage();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            tabProduto = new DataGridView();
            btnExcluir = new Button();
            btnAdicionar = new Button();
            btnEditar = new Button();
            tabPageCadastro = new TabPage();
            txtId = new TextBox();
            panel3 = new Panel();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            lblId = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            panel2 = new Panel();
            dtPickerValidade = new DateTimePicker();
            lblValidade = new Label();
            panel1 = new Panel();
            txtPreco = new TextBox();
            txtQtd = new TextBox();
            lblPreco = new Label();
            txtNome = new TextBox();
            lblQtd = new Label();
            lblNome = new Label();
            tabControllerProduto.SuspendLayout();
            tabPageListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabProduto).BeginInit();
            tabPageCadastro.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControllerProduto
            // 
            tabControllerProduto.Controls.Add(tabPageListar);
            tabControllerProduto.Controls.Add(tabPageCadastro);
            tabControllerProduto.Dock = DockStyle.Fill;
            tabControllerProduto.Location = new Point(0, 0);
            tabControllerProduto.Name = "tabControllerProduto";
            tabControllerProduto.SelectedIndex = 0;
            tabControllerProduto.Size = new Size(1027, 525);
            tabControllerProduto.TabIndex = 0;
            // 
            // tabPageListar
            // 
            tabPageListar.BackColor = Color.LightSlateGray;
            tabPageListar.Controls.Add(btnPesquisar);
            tabPageListar.Controls.Add(txtPesquisa);
            tabPageListar.Controls.Add(tabProduto);
            tabPageListar.Controls.Add(btnExcluir);
            tabPageListar.Controls.Add(btnAdicionar);
            tabPageListar.Controls.Add(btnEditar);
            tabPageListar.Location = new Point(4, 29);
            tabPageListar.Name = "tabPageListar";
            tabPageListar.Padding = new Padding(3);
            tabPageListar.Size = new Size(1019, 492);
            tabPageListar.TabIndex = 0;
            tabPageListar.Text = "Listar";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.BackgroundImage = (Image)resources.GetObject("btnPesquisar.BackgroundImage");
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(766, 20);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(111, 41);
            btnPesquisar.TabIndex = 11;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(9, 27);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(733, 27);
            txtPesquisa.TabIndex = 10;
            txtPesquisa.KeyDown += txtPesquisa_KeyDown;
            // 
            // tabProduto
            // 
            tabProduto.AllowUserToAddRows = false;
            tabProduto.AllowUserToDeleteRows = false;
            tabProduto.AllowUserToResizeColumns = false;
            tabProduto.AllowUserToResizeRows = false;
            tabProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabProduto.BackgroundColor = Color.LightGray;
            tabProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabProduto.Location = new Point(9, 75);
            tabProduto.MultiSelect = false;
            tabProduto.Name = "tabProduto";
            tabProduto.ReadOnly = true;
            tabProduto.RowHeadersWidth = 51;
            tabProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabProduto.Size = new Size(854, 406);
            tabProduto.TabIndex = 6;
            tabProduto.CellClick += tabProduto_CellClick;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(898, 169);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdicionar.BackgroundImage = (Image)resources.GetObject("btnAdicionar.BackgroundImage");
            btnAdicionar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(898, 75);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(898, 123);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.BackColor = Color.LightSlateGray;
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(panel3);
            tabPageCadastro.Controls.Add(lblId);
            tabPageCadastro.Controls.Add(btnCancelar);
            tabPageCadastro.Controls.Add(btnSalvar);
            tabPageCadastro.Controls.Add(panel2);
            tabPageCadastro.Controls.Add(panel1);
            tabPageCadastro.Location = new Point(4, 29);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(1019, 492);
            tabPageCadastro.TabIndex = 1;
            tabPageCadastro.Text = "Cadastro";
            // 
            // txtId
            // 
            txtId.Location = new Point(8, 27);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(txtDescricao);
            panel3.Controls.Add(lblDescricao);
            panel3.Location = new Point(3, 296);
            panel3.Name = "panel3";
            panel3.Size = new Size(1013, 123);
            panel3.TabIndex = 5;
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = Color.White;
            txtDescricao.Location = new Point(6, 35);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(1002, 81);
            txtDescricao.TabIndex = 3;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(6, 12);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(74, 20);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descricao";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(8, 3);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 4;
            lblId.Text = "ID";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(534, 425);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 47);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.BackgroundImage = (Image)resources.GetObject("btnSalvar.BackgroundImage");
            btnSalvar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(237, 425);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(99, 47);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dtPickerValidade);
            panel2.Controls.Add(lblValidade);
            panel2.Location = new Point(3, 236);
            panel2.Name = "panel2";
            panel2.Size = new Size(1013, 54);
            panel2.TabIndex = 1;
            // 
            // dtPickerValidade
            // 
            dtPickerValidade.CustomFormat = "dd/MMMM/yyyy";
            dtPickerValidade.Format = DateTimePickerFormat.Custom;
            dtPickerValidade.Location = new Point(78, 14);
            dtPickerValidade.Name = "dtPickerValidade";
            dtPickerValidade.Size = new Size(177, 27);
            dtPickerValidade.TabIndex = 2;
            // 
            // lblValidade
            // 
            lblValidade.AutoSize = true;
            lblValidade.Location = new Point(5, 14);
            lblValidade.Name = "lblValidade";
            lblValidade.Size = new Size(67, 20);
            lblValidade.TabIndex = 0;
            lblValidade.Text = "Validade";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txtPreco);
            panel1.Controls.Add(txtQtd);
            panel1.Controls.Add(lblPreco);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(lblQtd);
            panel1.Controls.Add(lblNome);
            panel1.Location = new Point(0, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(1011, 171);
            panel1.TabIndex = 0;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(6, 134);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(614, 27);
            txtPreco.TabIndex = 4;
            txtPreco.KeyPress += txtPreco_KeyPress;
            // 
            // txtQtd
            // 
            txtQtd.Location = new Point(3, 81);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(614, 27);
            txtQtd.TabIndex = 3;
            txtQtd.KeyPress += txtQtd_KeyPress;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(8, 111);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(46, 20);
            lblPreco.TabIndex = 1;
            lblPreco.Text = "Preço";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 28);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(614, 27);
            txtNome.TabIndex = 2;
            // 
            // lblQtd
            // 
            lblQtd.AutoSize = true;
            lblQtd.Location = new Point(3, 58);
            lblQtd.Name = "lblQtd";
            lblQtd.Size = new Size(87, 20);
            lblQtd.TabIndex = 1;
            lblQtd.Text = "Quantidade";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(6, 5);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // ProdutoView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 525);
            Controls.Add(tabControllerProduto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProdutoView";
            Text = "FornecedorView";
            tabControllerProduto.ResumeLayout(false);
            tabPageListar.ResumeLayout(false);
            tabPageListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabProduto).EndInit();
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControllerProduto;
        private TabPage tabPageListar;
        private TabPage tabPageCadastro;
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private DataGridView tabProduto;
        private Button btnExcluir;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnCancelar;
        private Button btnSalvar;
        private Panel panel2;
        private Panel panel1;
        private Label lblId;
        private Label lblPreco;
        private Label lblValidade;
        private Label lblQtd;
        private Label lblNome;
        private TextBox txtId;
        private Panel panel3;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private DateTimePicker dtPickerValidade;
        private TextBox txtPreco;
        private TextBox txtQtd;
        private TextBox txtNome;
    }
}