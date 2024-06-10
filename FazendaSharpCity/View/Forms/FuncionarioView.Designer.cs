﻿namespace FazendaSharpCity.View.Forms
{
    partial class FuncionarioView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuncionarioView));
            txtCidade = new TextBox();
            lblCidade = new Label();
            lblBairro = new Label();
            lblLogradouro = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            rdbFuncionario = new RadioButton();
            rdbGerente = new RadioButton();
            lblSalario = new Label();
            txtSalario = new TextBox();
            dtPicker = new DateTimePicker();
            lblDtNasc = new Label();
            lblCpf = new Label();
            lblNome = new Label();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            lblComplemento = new Label();
            lblId = new Label();
            lblCep = new Label();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            tabFunci = new DataGridView();
            btnExcluir = new Button();
            btnAdicionar = new Button();
            btnEditar = new Button();
            tabControllerFunci = new TabControl();
            tabPageListar = new TabPage();
            tabPageCadastro = new TabPage();
            panel3 = new Panel();
            btnCancelar = new Button();
            btnSalvar = new Button();
            lblTelefone = new Label();
            lblEmail = new Label();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            panel2 = new Panel();
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblUF = new Label();
            txtComplemento = new TextBox();
            txtBairro = new TextBox();
            txtLogradouro = new TextBox();
            txtCep = new TextBox();
            cBoxUF = new ComboBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabFunci).BeginInit();
            tabControllerFunci.SuspendLayout();
            tabPageListar.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtCidade
            // 
            txtCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCidade.BackColor = Color.White;
            txtCidade.Location = new Point(5, 116);
            txtCidade.Margin = new Padding(3, 2, 3, 2);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(744, 23);
            txtCidade.TabIndex = 17;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(5, 99);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 16;
            lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            lblBairro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(5, 51);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 14;
            lblBairro.Text = "Bairro";
            // 
            // lblLogradouro
            // 
            lblLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(138, 6);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 13;
            lblLogradouro.Text = "Logradouro";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(lblSalario);
            panel1.Controls.Add(txtSalario);
            panel1.Controls.Add(dtPicker);
            panel1.Controls.Add(lblDtNasc);
            panel1.Controls.Add(lblCpf);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(txtCpf);
            panel1.Controls.Add(txtNome);
            panel1.Location = new Point(3, 32);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(863, 146);
            panel1.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Controls.Add(rdbFuncionario);
            panel5.Controls.Add(rdbGerente);
            panel5.Location = new Point(572, 23);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(129, 86);
            panel5.TabIndex = 14;
            // 
            // rdbFuncionario
            // 
            rdbFuncionario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdbFuncionario.AutoSize = true;
            rdbFuncionario.Location = new Point(13, 1);
            rdbFuncionario.Margin = new Padding(3, 2, 3, 2);
            rdbFuncionario.Name = "rdbFuncionario";
            rdbFuncionario.Size = new Size(88, 19);
            rdbFuncionario.TabIndex = 1;
            rdbFuncionario.TabStop = true;
            rdbFuncionario.Text = "Funcionario";
            rdbFuncionario.UseVisualStyleBackColor = true;
            // 
            // rdbGerente
            // 
            rdbGerente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdbGerente.AutoSize = true;
            rdbGerente.Location = new Point(13, 40);
            rdbGerente.Margin = new Padding(3, 2, 3, 2);
            rdbGerente.Name = "rdbGerente";
            rdbGerente.Size = new Size(66, 19);
            rdbGerente.TabIndex = 0;
            rdbGerente.TabStop = true;
            rdbGerente.Text = "Gerente";
            rdbGerente.UseVisualStyleBackColor = true;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(192, 96);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(42, 15);
            lblSalario.TabIndex = 13;
            lblSalario.Text = "Salário";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(192, 113);
            txtSalario.Margin = new Padding(3, 2, 3, 2);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(110, 23);
            txtSalario.TabIndex = 12;
            // 
            // dtPicker
            // 
            dtPicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtPicker.CustomFormat = "dd/MM/yyyy";
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.Location = new Point(3, 112);
            dtPicker.Margin = new Padding(3, 2, 3, 2);
            dtPicker.MaxDate = new DateTime(2024, 6, 3, 0, 0, 0, 0);
            dtPicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(112, 23);
            dtPicker.TabIndex = 11;
            dtPicker.Value = new DateTime(2024, 6, 3, 0, 0, 0, 0);
            // 
            // lblDtNasc
            // 
            lblDtNasc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDtNasc.AutoSize = true;
            lblDtNasc.Location = new Point(3, 94);
            lblDtNasc.Name = "lblDtNasc";
            lblDtNasc.Size = new Size(114, 15);
            lblDtNasc.TabIndex = 10;
            lblDtNasc.Text = "Data de Nascimento";
            // 
            // lblCpf
            // 
            lblCpf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(5, 47);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 9;
            lblCpf.Text = "CPF";
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.Location = new Point(5, 6);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 8;
            lblNome.Text = "Nome";
            // 
            // txtCpf
            // 
            txtCpf.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCpf.BackColor = Color.White;
            txtCpf.Location = new Point(3, 64);
            txtCpf.Margin = new Padding(3, 2, 3, 2);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(491, 23);
            txtCpf.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.BackColor = Color.White;
            txtNome.Location = new Point(3, 23);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(491, 23);
            txtNome.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.Location = new Point(33, 4);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(84, 23);
            txtId.TabIndex = 1;
            // 
            // lblComplemento
            // 
            lblComplemento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(461, 51);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 15;
            lblComplemento.Text = "Complemento";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(10, 10);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblCep
            // 
            lblCep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCep.AutoSize = true;
            lblCep.Location = new Point(5, 6);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 12;
            lblCep.Text = "CEP";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.BackgroundImage = (Image)resources.GetObject("btnPesquisar.BackgroundImage");
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(704, 10);
            btnPesquisar.Margin = new Padding(3, 2, 3, 2);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(109, 38);
            btnPesquisar.TabIndex = 5;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(11, 14);
            txtPesquisa.Margin = new Padding(3, 2, 3, 2);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(687, 23);
            txtPesquisa.TabIndex = 4;
            txtPesquisa.KeyDown += txtPesquisa_KeyDown;
            // 
            // tabFunci
            // 
            tabFunci.AllowUserToAddRows = false;
            tabFunci.AllowUserToDeleteRows = false;
            tabFunci.AllowUserToResizeColumns = false;
            tabFunci.AllowUserToResizeRows = false;
            tabFunci.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabFunci.BackgroundColor = Color.LightGray;
            tabFunci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabFunci.Location = new Point(11, 52);
            tabFunci.Margin = new Padding(3, 2, 3, 2);
            tabFunci.MultiSelect = false;
            tabFunci.Name = "tabFunci";
            tabFunci.ReadOnly = true;
            tabFunci.RowHeadersWidth = 51;
            tabFunci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabFunci.Size = new Size(789, 356);
            tabFunci.TabIndex = 0;
            tabFunci.CellClick += tabFunci_CellClick;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(812, 108);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(88, 23);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdicionar.BackgroundImage = (Image)resources.GetObject("btnAdicionar.BackgroundImage");
            btnAdicionar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(812, 52);
            btnAdicionar.Margin = new Padding(3, 2, 3, 2);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(88, 23);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(812, 80);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(88, 23);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // tabControllerFunci
            // 
            tabControllerFunci.Controls.Add(tabPageListar);
            tabControllerFunci.Controls.Add(tabPageCadastro);
            tabControllerFunci.Dock = DockStyle.Fill;
            tabControllerFunci.Location = new Point(0, 0);
            tabControllerFunci.Margin = new Padding(3, 2, 3, 2);
            tabControllerFunci.Name = "tabControllerFunci";
            tabControllerFunci.SelectedIndex = 0;
            tabControllerFunci.Size = new Size(914, 472);
            tabControllerFunci.TabIndex = 7;
            // 
            // tabPageListar
            // 
            tabPageListar.BackColor = Color.LightSlateGray;
            tabPageListar.Controls.Add(btnPesquisar);
            tabPageListar.Controls.Add(txtPesquisa);
            tabPageListar.Controls.Add(tabFunci);
            tabPageListar.Controls.Add(btnExcluir);
            tabPageListar.Controls.Add(btnAdicionar);
            tabPageListar.Controls.Add(btnEditar);
            tabPageListar.Location = new Point(4, 24);
            tabPageListar.Margin = new Padding(3, 2, 3, 2);
            tabPageListar.Name = "tabPageListar";
            tabPageListar.Padding = new Padding(3, 3, 3, 3);
            tabPageListar.Size = new Size(906, 444);
            tabPageListar.TabIndex = 0;
            tabPageListar.Text = "Listar";
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.BackColor = Color.LightSlateGray;
            tabPageCadastro.Controls.Add(panel3);
            tabPageCadastro.Controls.Add(panel2);
            tabPageCadastro.Controls.Add(panel1);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(lblId);
            tabPageCadastro.Location = new Point(4, 24);
            tabPageCadastro.Margin = new Padding(3, 2, 3, 2);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3, 3, 3, 3);
            tabPageCadastro.Size = new Size(906, 444);
            tabPageCadastro.TabIndex = 1;
            tabPageCadastro.Text = "Cadastro";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.LightSlateGray;
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnSalvar);
            panel3.Controls.Add(lblTelefone);
            panel3.Controls.Add(lblEmail);
            panel3.Controls.Add(txtTelefone);
            panel3.Controls.Add(txtEmail);
            panel3.Location = new Point(3, 326);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(863, 116);
            panel3.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.SeaGreen;
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(726, 83);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 31);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.SeaGreen;
            btnSalvar.BackgroundImage = (Image)resources.GetObject("btnSalvar.BackgroundImage");
            btnSalvar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(585, 83);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(82, 31);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblTelefone
            // 
            lblTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(3, 50);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(3, 8);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefone.BackColor = Color.White;
            txtTelefone.Location = new Point(3, 67);
            txtTelefone.Margin = new Padding(3, 2, 3, 2);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(380, 23);
            txtTelefone.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.White;
            txtEmail.Location = new Point(3, 25);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(380, 23);
            txtEmail.TabIndex = 0;
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
            panel2.Location = new Point(3, 183);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(863, 143);
            panel2.TabIndex = 3;
            // 
            // lblNumero
            // 
            lblNumero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(388, 51);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 19;
            lblNumero.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNumero.BackColor = Color.White;
            txtNumero.Location = new Point(388, 68);
            txtNumero.Margin = new Padding(3, 2, 3, 2);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(69, 23);
            txtNumero.TabIndex = 18;
            // 
            // lblUF
            // 
            lblUF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUF.AutoSize = true;
            lblUF.Location = new Point(757, 99);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(21, 15);
            lblUF.TabIndex = 11;
            lblUF.Text = "UF";
            // 
            // txtComplemento
            // 
            txtComplemento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtComplemento.BackColor = Color.White;
            txtComplemento.Location = new Point(461, 68);
            txtComplemento.Margin = new Padding(3, 2, 3, 2);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(387, 23);
            txtComplemento.TabIndex = 3;
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBairro.BackColor = Color.White;
            txtBairro.Location = new Point(5, 68);
            txtBairro.Margin = new Padding(3, 2, 3, 2);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(378, 23);
            txtBairro.TabIndex = 2;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLogradouro.BackColor = Color.White;
            txtLogradouro.Location = new Point(138, 23);
            txtLogradouro.Margin = new Padding(3, 2, 3, 2);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(705, 23);
            txtLogradouro.TabIndex = 1;
            // 
            // txtCep
            // 
            txtCep.BackColor = Color.White;
            txtCep.Location = new Point(3, 23);
            txtCep.Margin = new Padding(3, 2, 3, 2);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(134, 23);
            txtCep.TabIndex = 0;
            // 
            // cBoxUF
            // 
            cBoxUF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBoxUF.BackColor = Color.White;
            cBoxUF.FormattingEnabled = true;
            cBoxUF.Location = new Point(754, 116);
            cBoxUF.Margin = new Padding(3, 2, 3, 2);
            cBoxUF.Name = "cBoxUF";
            cBoxUF.Size = new Size(95, 23);
            cBoxUF.TabIndex = 7;
            // 
            // FuncionarioView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 472);
            Controls.Add(tabControllerFunci);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FuncionarioView";
            Text = "FuncionarioView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabFunci).EndInit();
            tabControllerFunci.ResumeLayout(false);
            tabPageListar.ResumeLayout(false);
            tabPageListar.PerformLayout();
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtCidade;
        private Label lblCidade;
        private Label lblBairro;
        private Label lblLogradouro;
        private Panel panel1;
        private DateTimePicker dtPicker;
        private Label lblDtNasc;
        private Label lblCpf;
        private Label lblNome;
        private Panel panel5;
        private RadioButton rdbPJ;
        private RadioButton rdbPF;
        private TextBox txtCpf;
        private TextBox txtNome;
        private TextBox txtId;
        private Label lblComplemento;
        private Label lblId;
        private Label lblCep;
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private DataGridView tabFunci;
        private Button btnExcluir;
        private Button btnAdicionar;
        private Button btnEditar;
        private TabControl tabControllerFunci;
        private TabPage tabPageListar;
        private TabPage tabPageCadastro;
        private Panel panel3;
        private Button btnCancelar;
        private Button btnSalvar;
        private Label lblTelefone;
        private Label lblEmail;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Panel panel2;
        private Label lblUF;
        private TextBox txtComplemento;
        private TextBox txtBairro;
        private TextBox txtLogradouro;
        private TextBox txtCep;
        private ComboBox cBoxUF;
        private Label lblSalario;
        private TextBox txtSalario;
        private Label lblNumero;
        private TextBox txtNumero;
        private RadioButton rdbFuncionario;
        private RadioButton rdbGerente;
    }
}