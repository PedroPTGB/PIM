﻿namespace FazendaSharpCity.View
{
    partial class ClienteView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteView));
            tabCliente = new DataGridView();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            txtPesquisa = new TextBox();
            btnPesquisar = new Button();
            tControlCliente = new TabControl();
            tpgListar = new TabPage();
            tpgCadastro = new TabPage();
<<<<<<< HEAD
            btnSalvar = new Button();
=======
>>>>>>> 4ee1059985eaaf7790f1f0a769c26cc2e8553f5a
            btnCancelar = new Button();
            panel3 = new Panel();
            lblTelefone = new Label();
            lblEmail = new Label();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            btnSalvar = new Button();
            panel2 = new Panel();
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
            dtPicker = new DateTimePicker();
            lblDtNasc = new Label();
            lblCpf = new Label();
            lblNome = new Label();
            panel5 = new Panel();
            rdbPJ = new RadioButton();
            rdbPF = new RadioButton();
            panel4 = new Panel();
            rdbIndef = new RadioButton();
            rdvFem = new RadioButton();
            rdbMasc = new RadioButton();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            lblId = new Label();
            ((System.ComponentModel.ISupportInitialize)tabCliente).BeginInit();
            tControlCliente.SuspendLayout();
            tpgListar.SuspendLayout();
            tpgCadastro.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tabCliente
            // 
            tabCliente.AllowUserToAddRows = false;
            tabCliente.AllowUserToDeleteRows = false;
            tabCliente.AllowUserToResizeColumns = false;
            tabCliente.AllowUserToResizeRows = false;
            tabCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabCliente.BackgroundColor = Color.LightGray;
            tabCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabCliente.Location = new Point(10, 59);
            tabCliente.Margin = new Padding(3, 2, 3, 2);
            tabCliente.MultiSelect = false;
            tabCliente.Name = "tabCliente";
            tabCliente.ReadOnly = true;
            tabCliente.RowHeadersWidth = 51;
            tabCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabCliente.Size = new Size(747, 418);
            tabCliente.TabIndex = 0;
            tabCliente.CellClick += tabCliente_CellClick;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdicionar.BackgroundImage = (Image)resources.GetObject("btnAdicionar.BackgroundImage");
            btnAdicionar.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(808, 59);
            btnAdicionar.Margin = new Padding(3, 2, 3, 2);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(82, 22);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(808, 95);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 22);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(808, 131);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(82, 22);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(10, 20);
            txtPesquisa.Margin = new Padding(3, 2, 3, 2);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(645, 23);
            txtPesquisa.TabIndex = 4;
            txtPesquisa.KeyDown += txtPesquisa_KeyDown;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.BackgroundImage = (Image)resources.GetObject("btnPesquisar.BackgroundImage");
            btnPesquisar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(661, 12);
            btnPesquisar.Margin = new Padding(3, 2, 3, 2);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(82, 35);
            btnPesquisar.TabIndex = 5;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // tControlCliente
            // 
            tControlCliente.Controls.Add(tpgListar);
            tControlCliente.Controls.Add(tpgCadastro);
            tControlCliente.Dock = DockStyle.Fill;
            tControlCliente.Location = new Point(0, 0);
            tControlCliente.Margin = new Padding(3, 2, 3, 2);
            tControlCliente.Name = "tControlCliente";
            tControlCliente.SelectedIndex = 0;
            tControlCliente.Size = new Size(930, 508);
            tControlCliente.TabIndex = 6;
            // 
            // tpgListar
            // 
            tpgListar.BackColor = Color.LightSlateGray;
            tpgListar.Controls.Add(btnPesquisar);
            tpgListar.Controls.Add(txtPesquisa);
            tpgListar.Controls.Add(tabCliente);
            tpgListar.Controls.Add(btnExcluir);
            tpgListar.Controls.Add(btnAdicionar);
            tpgListar.Controls.Add(btnEditar);
            tpgListar.Location = new Point(4, 24);
            tpgListar.Margin = new Padding(3, 2, 3, 2);
            tpgListar.Name = "tpgListar";
<<<<<<< HEAD
            tpgListar.Padding = new Padding(3, 2, 3, 2);
            tpgListar.Size = new Size(922, 480);
=======
            tpgListar.Padding = new Padding(3);
            tpgListar.Size = new Size(1055, 635);
>>>>>>> 4ee1059985eaaf7790f1f0a769c26cc2e8553f5a
            tpgListar.TabIndex = 0;
            tpgListar.Text = "Listar";
            // 
            // tpgCadastro
            // 
<<<<<<< HEAD
            tpgCadastro.BackColor = Color.LightSlateGray;
=======
>>>>>>> 4ee1059985eaaf7790f1f0a769c26cc2e8553f5a
            tpgCadastro.Controls.Add(btnSalvar);
            tpgCadastro.Controls.Add(btnCancelar);
            tpgCadastro.Controls.Add(panel3);
            tpgCadastro.Controls.Add(panel2);
            tpgCadastro.Controls.Add(panel1);
            tpgCadastro.Controls.Add(txtId);
            tpgCadastro.Controls.Add(lblId);
            tpgCadastro.Location = new Point(4, 24);
            tpgCadastro.Margin = new Padding(3, 2, 3, 2);
            tpgCadastro.Name = "tpgCadastro";
<<<<<<< HEAD
            tpgCadastro.Padding = new Padding(3, 2, 3, 2);
            tpgCadastro.Size = new Size(922, 480);
=======
            tpgCadastro.Padding = new Padding(3);
            tpgCadastro.Size = new Size(1055, 635);
>>>>>>> 4ee1059985eaaf7790f1f0a769c26cc2e8553f5a
            tpgCadastro.TabIndex = 1;
            tpgCadastro.Text = "Cadastro";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.SeaGreen;
            btnSalvar.BackgroundImage = (Image)resources.GetObject("btnSalvar.BackgroundImage");
            btnSalvar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(216, 438);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(87, 35);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.SeaGreen;
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(442, 438);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 35);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(505, 584);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.LightSlateGray;
            panel3.Controls.Add(lblTelefone);
            panel3.Controls.Add(lblEmail);
            panel3.Controls.Add(txtTelefone);
            panel3.Controls.Add(txtEmail);
            panel3.Location = new Point(0, 323);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(922, 102);
            panel3.TabIndex = 4;
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
            txtTelefone.Size = new Size(554, 23);
            txtTelefone.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.White;
            txtEmail.Location = new Point(3, 25);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(554, 23);
            txtEmail.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(137, 584);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            panel2.Location = new Point(0, 180);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(922, 146);
            panel2.TabIndex = 3;
            // 
            // txtCidade
            // 
            txtCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCidade.BackColor = Color.White;
            txtCidade.Location = new Point(5, 116);
            txtCidade.Margin = new Padding(3, 2, 3, 2);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(808, 23);
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
            // lblComplemento
            // 
            lblComplemento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(497, 51);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 15;
            lblComplemento.Text = "Complemento";
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
            // lblUF
            // 
            lblUF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUF.AutoSize = true;
            lblUF.Location = new Point(818, 99);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(21, 15);
            lblUF.TabIndex = 11;
            lblUF.Text = "UF";
            // 
            // txtComplemento
            // 
            txtComplemento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtComplemento.BackColor = Color.White;
            txtComplemento.Location = new Point(497, 68);
            txtComplemento.Margin = new Padding(3, 2, 3, 2);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(415, 23);
            txtComplemento.TabIndex = 3;
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBairro.BackColor = Color.White;
            txtBairro.Location = new Point(5, 68);
            txtBairro.Margin = new Padding(3, 2, 3, 2);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(487, 23);
            txtBairro.TabIndex = 2;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLogradouro.BackColor = Color.White;
            txtLogradouro.Location = new Point(138, 23);
            txtLogradouro.Margin = new Padding(3, 2, 3, 2);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(769, 23);
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
            cBoxUF.Location = new Point(818, 116);
            cBoxUF.Margin = new Padding(3, 2, 3, 2);
            cBoxUF.Name = "cBoxUF";
            cBoxUF.Size = new Size(95, 23);
            cBoxUF.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dtPicker);
            panel1.Controls.Add(lblDtNasc);
            panel1.Controls.Add(lblCpf);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(txtCpf);
            panel1.Controls.Add(txtNome);
            panel1.Location = new Point(0, 29);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 250);
            panel1.TabIndex = 2;
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
            dtPicker.Size = new Size(187, 23);
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
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Controls.Add(rdbPJ);
            panel5.Controls.Add(rdbPF);
            panel5.Location = new Point(597, 0);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(279, 62);
            panel5.TabIndex = 6;
            // 
            // rdbPJ
            // 
            rdbPJ.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdbPJ.AutoSize = true;
            rdbPJ.Location = new Point(156, 24);
            rdbPJ.Margin = new Padding(3, 2, 3, 2);
            rdbPJ.Name = "rdbPJ";
            rdbPJ.Size = new Size(104, 19);
            rdbPJ.TabIndex = 1;
            rdbPJ.TabStop = true;
            rdbPJ.Text = "Pessoa Jurídica";
            rdbPJ.UseVisualStyleBackColor = true;
            // 
            // rdbPF
            // 
            rdbPF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdbPF.AutoSize = true;
            rdbPF.Location = new Point(29, 24);
            rdbPF.Margin = new Padding(3, 2, 3, 2);
            rdbPF.Name = "rdbPF";
            rdbPF.Size = new Size(93, 19);
            rdbPF.TabIndex = 0;
            rdbPF.TabStop = true;
            rdbPF.Text = "Pessoa Física";
            rdbPF.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.Controls.Add(rdbIndef);
            panel4.Controls.Add(rdvFem);
            panel4.Controls.Add(rdbMasc);
            panel4.Location = new Point(597, 64);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(279, 82);
            panel4.TabIndex = 5;
            // 
            // rdbIndef
            // 
            rdbIndef.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdbIndef.AutoSize = true;
            rdbIndef.Location = new Point(97, 47);
            rdbIndef.Margin = new Padding(3, 2, 3, 2);
            rdbIndef.Name = "rdbIndef";
            rdbIndef.Size = new Size(79, 19);
            rdbIndef.TabIndex = 2;
            rdbIndef.TabStop = true;
            rdbIndef.Text = "Indefinido";
            rdbIndef.UseVisualStyleBackColor = true;
            // 
            // rdvFem
            // 
            rdvFem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdvFem.AutoSize = true;
            rdvFem.Location = new Point(156, 12);
            rdvFem.Margin = new Padding(3, 2, 3, 2);
            rdvFem.Name = "rdvFem";
            rdvFem.Size = new Size(75, 19);
            rdvFem.TabIndex = 1;
            rdvFem.TabStop = true;
            rdvFem.Text = "Feminino";
            rdvFem.UseVisualStyleBackColor = true;
            // 
            // rdbMasc
            // 
            rdbMasc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdbMasc.AutoSize = true;
            rdbMasc.Location = new Point(29, 12);
            rdbMasc.Margin = new Padding(3, 2, 3, 2);
            rdbMasc.Name = "rdbMasc";
            rdbMasc.Size = new Size(80, 19);
            rdbMasc.TabIndex = 0;
            rdbMasc.TabStop = true;
            rdbMasc.Text = "Masculino";
            rdbMasc.UseVisualStyleBackColor = true;
            // 
            // txtCpf
            // 
            txtCpf.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCpf.BackColor = Color.White;
            txtCpf.Location = new Point(3, 64);
            txtCpf.Margin = new Padding(3, 2, 3, 2);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(555, 23);
            txtCpf.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.BackColor = Color.White;
            txtNome.Location = new Point(3, 23);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(555, 23);
            txtNome.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.Location = new Point(33, 4);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(110, 23);
            txtId.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(7, 7);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // ClienteView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 508);
            Controls.Add(tControlCliente);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClienteView";
            Text = "ClienteView";
            ((System.ComponentModel.ISupportInitialize)tabCliente).EndInit();
            tControlCliente.ResumeLayout(false);
            tpgListar.ResumeLayout(false);
            tpgListar.PerformLayout();
            tpgCadastro.ResumeLayout(false);
            tpgCadastro.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabCliente;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnExcluir;
        private TextBox txtPesquisa;
        private Button btnPesquisar;
        private TabControl tControlCliente;
        private TabPage tpgListar;
        private TabPage tpgCadastro;
        private Label lblId;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtComplemento;
        private TextBox txtBairro;
        private TextBox txtLogradouro;
        private TextBox txtCep;
        private Panel panel5;
        private TextBox txtCpf;
        private Label lblUF;
        private ComboBox cBoxUF;
        private Label lblDtNasc;
        private Label lblCpf;
        private Label lblNome;
        private Label lblTelefone;
        private Label lblEmail;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Label lblComplemento;
        private Label lblBairro;
        private Label lblLogradouro;
        private Label lblCep;
        private DateTimePicker dtPicker;
        private RadioButton rdbPJ;
        private RadioButton rdbPF;
        private RadioButton rdbIndef;
        private RadioButton rdvFem;
        private RadioButton rdbMasc;
        private TextBox txtCidade;
        private Label lblCidade;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}