namespace FazendaSharpCity.View
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
            btnSalvar = new Button();
            btnCancelar = new Button();
            panel3 = new Panel();
            lblTelefone = new Label();
            lblEmail = new Label();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
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
            rdbFem = new RadioButton();
            rdbMasc = new RadioButton();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            lblId = new Label();
            txtNumero = new TextBox();
            lblNumero = new Label();
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
            tabCliente.Location = new Point(11, 79);
            tabCliente.MultiSelect = false;
            tabCliente.Name = "tabCliente";
            tabCliente.ReadOnly = true;
            tabCliente.RowHeadersWidth = 51;
            tabCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabCliente.Size = new Size(854, 488);
            tabCliente.TabIndex = 0;
            tabCliente.CellClick += tabCliente_CellClick;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdicionar.BackgroundImage = (Image)resources.GetObject("btnAdicionar.BackgroundImage");
            btnAdicionar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(923, 79);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
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
            btnEditar.Location = new Point(923, 127);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(923, 175);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(11, 27);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(737, 27);
            txtPesquisa.TabIndex = 4;
            txtPesquisa.KeyDown += txtPesquisa_KeyDown;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.BackgroundImage = (Image)resources.GetObject("btnPesquisar.BackgroundImage");
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(755, 16);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(110, 47);
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
            tControlCliente.Name = "tControlCliente";
            tControlCliente.SelectedIndex = 0;
            tControlCliente.Size = new Size(1063, 608);
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
            tpgListar.Location = new Point(4, 29);
            tpgListar.Name = "tpgListar";
            tpgListar.Padding = new Padding(3, 4, 3, 4);
            tpgListar.Size = new Size(1055, 575);
            tpgListar.TabIndex = 0;
            tpgListar.Text = "Listar";
            // 
            // tpgCadastro
            // 
            tpgCadastro.BackColor = Color.LightSlateGray;
            tpgCadastro.Controls.Add(btnSalvar);
            tpgCadastro.Controls.Add(btnCancelar);
            tpgCadastro.Controls.Add(panel3);
            tpgCadastro.Controls.Add(panel2);
            tpgCadastro.Controls.Add(panel1);
            tpgCadastro.Controls.Add(txtId);
            tpgCadastro.Controls.Add(lblId);
            tpgCadastro.Location = new Point(4, 29);
            tpgCadastro.Name = "tpgCadastro";
            tpgCadastro.Padding = new Padding(3, 4, 3, 4);
            tpgCadastro.Size = new Size(1055, 575);
            tpgCadastro.TabIndex = 1;
            tpgCadastro.Text = "Cadastro";
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.BackColor = Color.SeaGreen;
            btnSalvar.BackgroundImage = (Image)resources.GetObject("btnSalvar.BackgroundImage");
            btnSalvar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(327, 528);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(107, 39);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.SeaGreen;
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(660, 528);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 39);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.LightSlateGray;
            panel3.Controls.Add(lblTelefone);
            panel3.Controls.Add(lblEmail);
            panel3.Controls.Add(txtTelefone);
            panel3.Controls.Add(txtEmail);
            panel3.Location = new Point(3, 383);
            panel3.Name = "panel3";
            panel3.Size = new Size(1044, 129);
            panel3.TabIndex = 4;
            // 
            // lblTelefone
            // 
            lblTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(3, 67);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(66, 20);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(3, 11);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefone.BackColor = Color.White;
            txtTelefone.Location = new Point(3, 89);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(623, 27);
            txtTelefone.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.White;
            txtEmail.Location = new Point(3, 33);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(623, 27);
            txtEmail.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            panel2.Location = new Point(3, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(1046, 177);
            panel2.TabIndex = 3;
            // 
            // txtCidade
            // 
            txtCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCidade.BackColor = Color.White;
            txtCidade.Location = new Point(6, 138);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(915, 27);
            txtCidade.TabIndex = 17;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(6, 115);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(56, 20);
            lblCidade.TabIndex = 16;
            lblCidade.Text = "Cidade";
            // 
            // lblComplemento
            // 
            lblComplemento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(581, 62);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(104, 20);
            lblComplemento.TabIndex = 15;
            lblComplemento.Text = "Complemento";
            // 
            // lblBairro
            // 
            lblBairro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(6, 62);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(49, 20);
            lblBairro.TabIndex = 14;
            lblBairro.Text = "Bairro";
            // 
            // lblLogradouro
            // 
            lblLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(158, 9);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(87, 20);
            lblLogradouro.TabIndex = 13;
            lblLogradouro.Text = "Logradouro";
            // 
            // lblCep
            // 
            lblCep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCep.AutoSize = true;
            lblCep.Location = new Point(6, 9);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(34, 20);
            lblCep.TabIndex = 12;
            lblCep.Text = "CEP";
            // 
            // lblUF
            // 
            lblUF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUF.AutoSize = true;
            lblUF.Location = new Point(927, 115);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(26, 20);
            lblUF.TabIndex = 11;
            lblUF.Text = "UF";
            // 
            // txtComplemento
            // 
            txtComplemento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtComplemento.BackColor = Color.White;
            txtComplemento.Location = new Point(581, 85);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(453, 27);
            txtComplemento.TabIndex = 3;
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBairro.BackColor = Color.White;
            txtBairro.Location = new Point(6, 85);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(476, 27);
            txtBairro.TabIndex = 2;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLogradouro.BackColor = Color.White;
            txtLogradouro.Location = new Point(158, 32);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(870, 27);
            txtLogradouro.TabIndex = 1;
            // 
            // txtCep
            // 
            txtCep.BackColor = Color.White;
            txtCep.Location = new Point(3, 32);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(153, 27);
            txtCep.TabIndex = 0;
            // 
            // cBoxUF
            // 
            cBoxUF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBoxUF.BackColor = Color.White;
            cBoxUF.FormattingEnabled = true;
            cBoxUF.Location = new Point(927, 138);
            cBoxUF.Name = "cBoxUF";
            cBoxUF.Size = new Size(108, 28);
            cBoxUF.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dtPicker);
            panel1.Controls.Add(lblDtNasc);
            panel1.Controls.Add(lblCpf);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(txtCpf);
            panel1.Controls.Add(txtNome);
            panel1.Location = new Point(0, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(1052, 155);
            panel1.TabIndex = 2;
            // 
            // dtPicker
            // 
            dtPicker.CustomFormat = "dd/MM/yyyy";
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.Location = new Point(161, 119);
            dtPicker.MaxDate = new DateTime(2024, 6, 3, 0, 0, 0, 0);
            dtPicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(126, 27);
            dtPicker.TabIndex = 11;
            dtPicker.Value = new DateTime(2024, 6, 3, 0, 0, 0, 0);
            // 
            // lblDtNasc
            // 
            lblDtNasc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDtNasc.AutoSize = true;
            lblDtNasc.Location = new Point(6, 120);
            lblDtNasc.Name = "lblDtNasc";
            lblDtNasc.Size = new Size(145, 20);
            lblDtNasc.TabIndex = 10;
            lblDtNasc.Text = "Data de Nascimento";
            // 
            // lblCpf
            // 
            lblCpf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(9, 59);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(33, 20);
            lblCpf.TabIndex = 9;
            lblCpf.Text = "CPF";
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.Location = new Point(6, 6);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 8;
            lblNome.Text = "Nome";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Controls.Add(rdbPJ);
            panel5.Controls.Add(rdbPF);
            panel5.Location = new Point(680, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(319, 83);
            panel5.TabIndex = 6;
            // 
            // rdbPJ
            // 
            rdbPJ.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdbPJ.AutoSize = true;
            rdbPJ.Location = new Point(178, 32);
            rdbPJ.Name = "rdbPJ";
            rdbPJ.Size = new Size(128, 24);
            rdbPJ.TabIndex = 1;
            rdbPJ.TabStop = true;
            rdbPJ.Text = "Pessoa Jurídica";
            rdbPJ.UseVisualStyleBackColor = true;
            rdbPJ.CheckedChanged += rdbPJ_CheckedChanged;
            // 
            // rdbPF
            // 
            rdbPF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdbPF.AutoSize = true;
            rdbPF.Location = new Point(33, 32);
            rdbPF.Name = "rdbPF";
            rdbPF.Size = new Size(114, 24);
            rdbPF.TabIndex = 0;
            rdbPF.TabStop = true;
            rdbPF.Text = "Pessoa Física";
            rdbPF.UseVisualStyleBackColor = true;
            rdbPF.CheckedChanged += rdbPF_CheckedChanged;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.Controls.Add(rdbIndef);
            panel4.Controls.Add(rdbFem);
            panel4.Controls.Add(rdbMasc);
            panel4.Location = new Point(680, 85);
            panel4.Name = "panel4";
            panel4.Size = new Size(319, 62);
            panel4.TabIndex = 5;
            // 
            // rdbIndef
            // 
            rdbIndef.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdbIndef.AutoSize = true;
            rdbIndef.Location = new Point(105, 37);
            rdbIndef.Name = "rdbIndef";
            rdbIndef.Size = new Size(98, 24);
            rdbIndef.TabIndex = 2;
            rdbIndef.TabStop = true;
            rdbIndef.Text = "Indefinido";
            rdbIndef.UseVisualStyleBackColor = true;
            // 
            // rdbFem
            // 
            rdbFem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdbFem.AutoSize = true;
            rdbFem.Location = new Point(178, 16);
            rdbFem.Name = "rdbFem";
            rdbFem.Size = new Size(91, 24);
            rdbFem.TabIndex = 1;
            rdbFem.TabStop = true;
            rdbFem.Text = "Feminino";
            rdbFem.UseVisualStyleBackColor = true;
            // 
            // rdbMasc
            // 
            rdbMasc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdbMasc.AutoSize = true;
            rdbMasc.Location = new Point(33, 16);
            rdbMasc.Name = "rdbMasc";
            rdbMasc.Size = new Size(97, 24);
            rdbMasc.TabIndex = 0;
            rdbMasc.TabStop = true;
            rdbMasc.Text = "Masculino";
            rdbMasc.UseVisualStyleBackColor = true;
            // 
            // txtCpf
            // 
            txtCpf.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCpf.BackColor = Color.White;
            txtCpf.Location = new Point(8, 82);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(632, 27);
            txtCpf.TabIndex = 1;
            txtCpf.KeyPress += txtCpf_KeyPress;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.BackColor = Color.White;
            txtNome.Location = new Point(8, 29);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(632, 27);
            txtNome.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.Location = new Point(38, 5);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(8, 9);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // txtNumero
            // 
            txtNumero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNumero.Location = new Point(488, 85);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(87, 27);
            txtNumero.TabIndex = 18;
            // 
            // lblNumero
            // 
            lblNumero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(488, 62);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(63, 20);
            lblNumero.TabIndex = 19;
            lblNumero.Text = "Numero";
            // 
            // ClienteView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 608);
            Controls.Add(tControlCliente);
            FormBorderStyle = FormBorderStyle.None;
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
        private RadioButton rdbFem;
        private RadioButton rdbMasc;
        private TextBox txtCidade;
        private Label lblCidade;
        private Button btnCancelar;
        private Button btnSalvar;
        private Label lblNumero;
        private TextBox txtNumero;
    }
}