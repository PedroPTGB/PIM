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
            label1.Location = new Point(335, 294);
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
            tabControllerFornecedor.Size = new Size(1063, 668);
            tabControllerFornecedor.TabIndex = 2;
            // 
            // tabPageListar
            // 
            tabPageListar.Controls.Add(btnPesquisar);
            tabPageListar.Controls.Add(txtPesquisa);
            tabPageListar.Controls.Add(tabFornecedor);
            tabPageListar.Controls.Add(btnExcluir);
            tabPageListar.Controls.Add(btnAdicionar);
            tabPageListar.Controls.Add(btnEditar);
            tabPageListar.Location = new Point(4, 29);
            tabPageListar.Name = "tabPageListar";
            tabPageListar.Padding = new Padding(3);
            tabPageListar.Size = new Size(1055, 635);
            tabPageListar.TabIndex = 0;
            tabPageListar.Text = "Listar";
            tabPageListar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.Location = new Point(784, 16);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 11;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(24, 18);
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
            tabFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabFornecedor.Location = new Point(24, 70);
            tabFornecedor.MultiSelect = false;
            tabFornecedor.Name = "tabFornecedor";
            tabFornecedor.ReadOnly = true;
            tabFornecedor.RowHeadersWidth = 51;
            tabFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabFornecedor.Size = new Size(854, 548);
            tabFornecedor.TabIndex = 6;
            tabFornecedor.CellClick += tabFornecedor_CellClick;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.Location = new Point(936, 166);
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
            btnAdicionar.Location = new Point(936, 70);
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
            btnEditar.Location = new Point(936, 118);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // tabPageCadastro
            // 
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
            tabPageCadastro.Size = new Size(1055, 635);
            tabPageCadastro.TabIndex = 1;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(596, 579);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(228, 579);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(46, 10);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 4;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(16, 14);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 3;
            lblId.Text = "ID";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTelefone);
            panel3.Controls.Add(lblEmail);
            panel3.Controls.Add(txtTelefone);
            panel3.Controls.Add(txtEmail);
            panel3.Location = new Point(3, 444);
            panel3.Name = "panel3";
            panel3.Size = new Size(1049, 129);
            panel3.TabIndex = 2;
            // 
            // lblTelefone
            // 
            lblTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(11, 66);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(66, 20);
            lblTelefone.TabIndex = 7;
            lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(11, 10);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefone.Location = new Point(11, 88);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(617, 27);
            txtTelefone.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(11, 32);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(617, 27);
            txtEmail.TabIndex = 4;
            // 
            // panel2
            // 
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
            panel2.Location = new Point(3, 248);
            panel2.Name = "panel2";
            panel2.Size = new Size(1049, 190);
            panel2.TabIndex = 1;
            // 
            // lblNumero
            // 
            lblNumero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(563, 68);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(63, 20);
            lblNumero.TabIndex = 31;
            lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(563, 91);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(124, 27);
            txtNumero.TabIndex = 30;
            // 
            // txtCidade
            // 
            txtCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCidade.Location = new Point(14, 155);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(910, 27);
            txtCidade.TabIndex = 29;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(14, 132);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(56, 20);
            lblCidade.TabIndex = 28;
            lblCidade.Text = "Cidade";
            // 
            // lblComplemento
            // 
            lblComplemento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(694, 68);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(104, 20);
            lblComplemento.TabIndex = 27;
            lblComplemento.Text = "Complemento";
            // 
            // lblBairro
            // 
            lblBairro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(14, 68);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(49, 20);
            lblBairro.TabIndex = 26;
            lblBairro.Text = "Bairro";
            // 
            // lblLogradouro
            // 
            lblLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(166, 8);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(87, 20);
            lblLogradouro.TabIndex = 25;
            lblLogradouro.Text = "Logradouro";
            // 
            // lblCep
            // 
            lblCep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCep.AutoSize = true;
            lblCep.Location = new Point(14, 8);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(34, 20);
            lblCep.TabIndex = 24;
            lblCep.Text = "CEP";
            // 
            // lblUF
            // 
            lblUF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUF.AutoSize = true;
            lblUF.Location = new Point(930, 132);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(26, 20);
            lblUF.TabIndex = 23;
            lblUF.Text = "UF";
            // 
            // txtComplemento
            // 
            txtComplemento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtComplemento.Location = new Point(694, 91);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(343, 27);
            txtComplemento.TabIndex = 21;
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBairro.Location = new Point(14, 91);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(543, 27);
            txtBairro.TabIndex = 20;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLogradouro.Location = new Point(166, 31);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(866, 27);
            txtLogradouro.TabIndex = 19;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(11, 31);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(153, 27);
            txtCep.TabIndex = 18;
            // 
            // cBoxUF
            // 
            cBoxUF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBoxUF.FormattingEnabled = true;
            cBoxUF.Location = new Point(930, 155);
            cBoxUF.Name = "cBoxUF";
            cBoxUF.Size = new Size(108, 28);
            cBoxUF.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblNomeFantasia);
            panel1.Controls.Add(txtNomeFantasia);
            panel1.Controls.Add(lblCnpj);
            panel1.Controls.Add(lblRazaoSocial);
            panel1.Controls.Add(txtCnpj);
            panel1.Controls.Add(txtRazaoSocial);
            panel1.Location = new Point(3, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(1052, 188);
            panel1.TabIndex = 0;
            // 
            // lblNomeFantasia
            // 
            lblNomeFantasia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeFantasia.AutoSize = true;
            lblNomeFantasia.Location = new Point(11, 69);
            lblNomeFantasia.Name = "lblNomeFantasia";
            lblNomeFantasia.Size = new Size(107, 20);
            lblNomeFantasia.TabIndex = 21;
            lblNomeFantasia.Text = "Nome Fantasia";
            // 
            // txtNomeFantasia
            // 
            txtNomeFantasia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomeFantasia.Location = new Point(11, 92);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.Size = new Size(615, 27);
            txtNomeFantasia.TabIndex = 20;
            // 
            // lblCnpj
            // 
            lblCnpj.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCnpj.AutoSize = true;
            lblCnpj.Location = new Point(14, 137);
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
            txtCnpj.Location = new Point(11, 160);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(621, 27);
            txtCnpj.TabIndex = 13;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRazaoSocial.Location = new Point(11, 30);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(615, 27);
            txtRazaoSocial.TabIndex = 12;
            // 
            // FornecedorView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 668);
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