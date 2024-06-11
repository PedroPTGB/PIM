namespace FazendaSharpCity.View
{
    partial class FornecedorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FornecedorView));
            label1 = new Label();
            tabControllerFornecedor = new TabControl();
            tabPageListar = new TabPage();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            tabFornecedor = new DataGridView();
            btnExcluir = new Button();
            btnAdicionar = new Button();
            btnEditar = new Button();
            tabPageCadastro = new TabPage();
            btnCancelar = new Button();
            btnSalvar = new Button();
            txtId = new TextBox();
            lblId = new Label();
            panel3 = new Panel();
            lblTelefone = new Label();
            lblEmail = new Label();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            panel2 = new Panel();
            lblNumero = new Label();
            txtNumero = new TextBox();
            txtCidade = new TextBox();
            lblCidade = new Label();
            lblComplemento = new Label();
            lblBairro = new Label();
            lblLogradouro = new Label();
            lblCep = new Label();
            lblUF = new Label();
            txtComplemento = new TextBox();
            txtBairro = new TextBox();
            txtLogradouro = new TextBox();
            txtCep = new TextBox();
            cBoxUF = new ComboBox();
            panel1 = new Panel();
            lblNomeFantasia = new Label();
            txtNomeFantasia = new TextBox();
            lblCnpj = new Label();
            lblRazaoSocial = new Label();
            txtCnpj = new TextBox();
            txtRazaoSocial = new TextBox();
            tabControllerFornecedor.SuspendLayout();
            tabPageListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabFornecedor).BeginInit();
            tabPageCadastro.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 260);
            label1.Name = "label1";
            label1.Size = new Size(0, 81);
            label1.TabIndex = 1;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControllerFornecedor
            // 
            tabControllerFornecedor.Controls.Add(tabPageListar);
            tabControllerFornecedor.Controls.Add(tabPageCadastro);
            tabControllerFornecedor.Dock = DockStyle.Fill;
            tabControllerFornecedor.Location = new Point(0, 0);
            tabControllerFornecedor.Name = "tabControllerFornecedor";
            tabControllerFornecedor.SelectedIndex = 0;
            tabControllerFornecedor.Size = new Size(1063, 603);
            tabControllerFornecedor.TabIndex = 2;
            // 
            // tabPageListar
            // 
            tabPageListar.BackColor = Color.LightSlateGray;
            tabPageListar.Controls.Add(btnPesquisar);
            tabPageListar.Controls.Add(txtPesquisa);
            tabPageListar.Controls.Add(tabFornecedor);
            tabPageListar.Controls.Add(btnExcluir);
            tabPageListar.Controls.Add(btnAdicionar);
            tabPageListar.Controls.Add(btnEditar);
            tabPageListar.Location = new Point(4, 29);
            tabPageListar.Name = "tabPageListar";
            tabPageListar.Padding = new Padding(3);
            tabPageListar.Size = new Size(1055, 570);
            tabPageListar.TabIndex = 0;
            tabPageListar.Text = "Listar";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.BackgroundImage = (Image)resources.GetObject("btnPesquisar.BackgroundImage");
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(784, 16);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(113, 33);
            btnPesquisar.TabIndex = 11;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(24, 19);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(737, 27);
            txtPesquisa.TabIndex = 10;
            txtPesquisa.KeyDown += txtPesquisa_KeyDown;
            // 
            // tabFornecedor
            // 
            tabFornecedor.AllowUserToAddRows = false;
            tabFornecedor.AllowUserToDeleteRows = false;
            tabFornecedor.AllowUserToResizeColumns = false;
            tabFornecedor.AllowUserToResizeRows = false;
            tabFornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabFornecedor.BackgroundColor = Color.LightGray;
            tabFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabFornecedor.Location = new Point(24, 69);
            tabFornecedor.MultiSelect = false;
            tabFornecedor.Name = "tabFornecedor";
            tabFornecedor.ReadOnly = true;
            tabFornecedor.RowHeadersWidth = 51;
            tabFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabFornecedor.Size = new Size(854, 483);
            tabFornecedor.TabIndex = 6;
            tabFornecedor.CellClick += tabFornecedor_CellClick;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(936, 165);
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
            btnAdicionar.Location = new Point(936, 69);
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
            btnEditar.Location = new Point(936, 117);
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
            tabPageCadastro.Controls.Add(btnCancelar);
            tabPageCadastro.Controls.Add(btnSalvar);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(lblId);
            tabPageCadastro.Controls.Add(panel3);
            tabPageCadastro.Controls.Add(panel2);
            tabPageCadastro.Controls.Add(panel1);
            tabPageCadastro.Location = new Point(4, 29);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(1055, 570);
            tabPageCadastro.TabIndex = 1;
            tabPageCadastro.Text = "Cadastro";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(597, 519);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 43);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.BackgroundImage = (Image)resources.GetObject("btnSalvar.BackgroundImage");
            btnSalvar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(288, 519);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(118, 43);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(46, 11);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 4;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(16, 13);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 3;
            lblId.Text = "ID";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(lblTelefone);
            panel3.Controls.Add(lblEmail);
            panel3.Controls.Add(txtTelefone);
            panel3.Controls.Add(txtEmail);
            panel3.Location = new Point(6, 405);
            panel3.Name = "panel3";
            panel3.Size = new Size(1041, 115);
            panel3.TabIndex = 2;
            // 
            // lblTelefone
            // 
            lblTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(10, 57);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(66, 20);
            lblTelefone.TabIndex = 7;
            lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(10, 1);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefone.Location = new Point(10, 78);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(609, 27);
            txtTelefone.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(10, 22);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(609, 27);
            txtEmail.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(lblNumero);
            panel2.Controls.Add(txtNumero);
            panel2.Controls.Add(txtCidade);
            panel2.Controls.Add(lblCidade);
            panel2.Controls.Add(lblComplemento);
            panel2.Controls.Add(lblBairro);
            panel2.Controls.Add(lblLogradouro);
            panel2.Controls.Add(lblCep);
            panel2.Controls.Add(lblUF);
            panel2.Controls.Add(txtComplemento);
            panel2.Controls.Add(txtBairro);
            panel2.Controls.Add(txtLogradouro);
            panel2.Controls.Add(txtCep);
            panel2.Controls.Add(cBoxUF);
            panel2.Location = new Point(5, 231);
            panel2.Name = "panel2";
            panel2.Size = new Size(1042, 172);
            panel2.TabIndex = 1;
            // 
            // lblNumero
            // 
            lblNumero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(548, 58);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(63, 20);
            lblNumero.TabIndex = 31;
            lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNumero.Location = new Point(548, 81);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(124, 27);
            txtNumero.TabIndex = 30;
            // 
            // txtCidade
            // 
            txtCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCidade.Location = new Point(5, 131);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(903, 27);
            txtCidade.TabIndex = 29;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(5, 108);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(56, 20);
            lblCidade.TabIndex = 28;
            lblCidade.Text = "Cidade";
            // 
            // lblComplemento
            // 
            lblComplemento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(679, 58);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(104, 20);
            lblComplemento.TabIndex = 27;
            lblComplemento.Text = "Complemento";
            // 
            // lblBairro
            // 
            lblBairro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(6, 58);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(49, 20);
            lblBairro.TabIndex = 26;
            lblBairro.Text = "Bairro";
            // 
            // lblLogradouro
            // 
            lblLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(163, 6);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(87, 20);
            lblLogradouro.TabIndex = 25;
            lblLogradouro.Text = "Logradouro";
            // 
            // lblCep
            // 
            lblCep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCep.AutoSize = true;
            lblCep.Location = new Point(8, 6);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(34, 20);
            lblCep.TabIndex = 24;
            lblCep.Text = "CEP";
            // 
            // lblUF
            // 
            lblUF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUF.AutoSize = true;
            lblUF.Location = new Point(914, 108);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(26, 20);
            lblUF.TabIndex = 23;
            lblUF.Text = "UF";
            // 
            // txtComplemento
            // 
            txtComplemento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtComplemento.Location = new Point(679, 81);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(343, 27);
            txtComplemento.TabIndex = 21;
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBairro.Location = new Point(6, 81);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(536, 27);
            txtBairro.TabIndex = 20;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLogradouro.Location = new Point(163, 29);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(859, 27);
            txtLogradouro.TabIndex = 19;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(8, 29);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(153, 27);
            txtCep.TabIndex = 18;
            // 
            // cBoxUF
            // 
            cBoxUF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBoxUF.FormattingEnabled = true;
            cBoxUF.Location = new Point(914, 131);
            cBoxUF.Name = "cBoxUF";
            cBoxUF.Size = new Size(108, 28);
            cBoxUF.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblNomeFantasia);
            panel1.Controls.Add(txtNomeFantasia);
            panel1.Controls.Add(lblCnpj);
            panel1.Controls.Add(lblRazaoSocial);
            panel1.Controls.Add(txtCnpj);
            panel1.Controls.Add(txtRazaoSocial);
            panel1.Location = new Point(3, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(1044, 175);
            panel1.TabIndex = 0;
            // 
            // lblNomeFantasia
            // 
            lblNomeFantasia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeFantasia.AutoSize = true;
            lblNomeFantasia.Location = new Point(13, 59);
            lblNomeFantasia.Name = "lblNomeFantasia";
            lblNomeFantasia.Size = new Size(107, 20);
            lblNomeFantasia.TabIndex = 21;
            lblNomeFantasia.Text = "Nome Fantasia";
            // 
            // txtNomeFantasia
            // 
            txtNomeFantasia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomeFantasia.Location = new Point(11, 82);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.Size = new Size(608, 27);
            txtNomeFantasia.TabIndex = 20;
            // 
            // lblCnpj
            // 
            lblCnpj.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCnpj.AutoSize = true;
            lblCnpj.Location = new Point(13, 112);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(41, 20);
            lblCnpj.TabIndex = 17;
            lblCnpj.Text = "CNPJ";
            // 
            // lblRazaoSocial
            // 
            lblRazaoSocial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblRazaoSocial.AutoSize = true;
            lblRazaoSocial.Location = new Point(13, 7);
            lblRazaoSocial.Name = "lblRazaoSocial";
            lblRazaoSocial.Size = new Size(94, 20);
            lblRazaoSocial.TabIndex = 16;
            lblRazaoSocial.Text = "Razao Social";
            // 
            // txtCnpj
            // 
            txtCnpj.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCnpj.Location = new Point(11, 135);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(614, 27);
            txtCnpj.TabIndex = 13;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRazaoSocial.Location = new Point(11, 29);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(608, 27);
            txtRazaoSocial.TabIndex = 12;
            // 
            // FornecedorView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 603);
            Controls.Add(tabControllerFornecedor);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FornecedorView";
            Text = "ProdutoView";
            tabControllerFornecedor.ResumeLayout(false);
            tabPageListar.ResumeLayout(false);
            tabPageListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabFornecedor).EndInit();
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControllerFornecedor;
        private TabPage tabPageListar;
        private TabPage tabPageCadastro;
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private DataGridView tabFornecedor;
        private Button btnExcluir;
        private Button btnAdicionar;
        private Button btnEditar;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private TextBox txtId;
        private Label lblId;
        private Label lblCnpj;
        private Label lblRazaoSocial;
        private TextBox txtCnpj;
        private TextBox txtRazaoSocial;
        private TextBox txtCidade;
        private Label lblCidade;
        private Label lblComplemento;
        private Label lblBairro;
        private Label lblLogradouro;
        private Label lblCep;
        private Label lblUF;
        private TextBox txtComplemento;
        private TextBox txtBairro;
        private TextBox txtLogradouro;
        private TextBox txtCep;
        private ComboBox cBoxUF;
        private Button btnCancelar;
        private Button btnSalvar;
        private Label lblNomeFantasia;
        private TextBox txtNomeFantasia;
        private Label lblTelefone;
        private Label lblEmail;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Label lblNumero;
        private TextBox txtNumero;
    }
}