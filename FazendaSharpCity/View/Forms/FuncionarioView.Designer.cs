namespace FazendaSharpCity.View.Forms
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
            lblSenha = new Label();
            lblLogin = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
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
            txtCidade.Location = new Point(6, 155);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(850, 27);
            txtCidade.TabIndex = 17;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(6, 132);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(56, 20);
            lblCidade.TabIndex = 16;
            lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            lblBairro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(6, 68);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(49, 20);
            lblBairro.TabIndex = 14;
            lblBairro.Text = "Bairro";
            // 
            // lblLogradouro
            // 
            lblLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(158, 8);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(87, 20);
            lblLogradouro.TabIndex = 13;
            lblLogradouro.Text = "Logradouro";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblSenha);
            panel1.Controls.Add(lblLogin);
            panel1.Controls.Add(txtLogin);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(lblSalario);
            panel1.Controls.Add(txtSalario);
            panel1.Controls.Add(dtPicker);
            panel1.Controls.Add(lblDtNasc);
            panel1.Controls.Add(lblCpf);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(txtCpf);
            panel1.Controls.Add(txtNome);
            panel1.Location = new Point(3, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(986, 195);
            panel1.TabIndex = 2;
            // 
            // lblSenha
            // 
            lblSenha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(784, 63);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(49, 20);
            lblSenha.TabIndex = 18;
            lblSenha.Text = "Senha";
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(784, 8);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(46, 20);
            lblLogin.TabIndex = 17;
            lblLogin.Text = "Login";
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtLogin.Location = new Point(784, 31);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(125, 27);
            txtLogin.TabIndex = 16;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSenha.Location = new Point(784, 85);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(125, 27);
            txtSenha.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Controls.Add(rdbFuncionario);
            panel5.Controls.Add(rdbGerente);
            panel5.Location = new Point(598, 29);
            panel5.Name = "panel5";
            panel5.Size = new Size(147, 115);
            panel5.TabIndex = 14;
            // 
            // rdbFuncionario
            // 
            rdbFuncionario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdbFuncionario.AutoSize = true;
            rdbFuncionario.Location = new Point(15, 1);
            rdbFuncionario.Name = "rdbFuncionario";
            rdbFuncionario.Size = new Size(107, 24);
            rdbFuncionario.TabIndex = 1;
            rdbFuncionario.TabStop = true;
            rdbFuncionario.Text = "Funcionario";
            rdbFuncionario.UseVisualStyleBackColor = true;
            // 
            // rdbGerente
            // 
            rdbGerente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdbGerente.AutoSize = true;
            rdbGerente.Location = new Point(15, 53);
            rdbGerente.Name = "rdbGerente";
            rdbGerente.Size = new Size(82, 24);
            rdbGerente.TabIndex = 0;
            rdbGerente.TabStop = true;
            rdbGerente.Text = "Gerente";
            rdbGerente.UseVisualStyleBackColor = true;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(219, 128);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(55, 20);
            lblSalario.TabIndex = 13;
            lblSalario.Text = "Salário";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(219, 149);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(125, 27);
            txtSalario.TabIndex = 12;
            txtSalario.KeyPress += txtSalario_KeyPress;
            // 
            // dtPicker
            // 
            dtPicker.CustomFormat = "dd/MM/yyyy";
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.Location = new Point(3, 149);
            dtPicker.MaxDate = new DateTime(2024, 6, 3, 0, 0, 0, 0);
            dtPicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(127, 27);
            dtPicker.TabIndex = 11;
            dtPicker.Value = new DateTime(2024, 6, 3, 0, 0, 0, 0);
            // 
            // lblDtNasc
            // 
            lblDtNasc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDtNasc.AutoSize = true;
            lblDtNasc.Location = new Point(3, 125);
            lblDtNasc.Name = "lblDtNasc";
            lblDtNasc.Size = new Size(145, 20);
            lblDtNasc.TabIndex = 10;
            lblDtNasc.Text = "Data de Nascimento";
            // 
            // lblCpf
            // 
            lblCpf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(6, 63);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(33, 20);
            lblCpf.TabIndex = 9;
            lblCpf.Text = "CPF";
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.Location = new Point(6, 8);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 8;
            lblNome.Text = "Nome";
            // 
            // txtCpf
            // 
            txtCpf.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCpf.BackColor = Color.White;
            txtCpf.Location = new Point(3, 85);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(561, 27);
            txtCpf.TabIndex = 1;
            txtCpf.KeyPress += txtCpf_KeyPress;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.BackColor = Color.White;
            txtNome.Location = new Point(3, 31);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(561, 27);
            txtNome.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.Location = new Point(38, 5);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(95, 27);
            txtId.TabIndex = 1;
            // 
            // lblComplemento
            // 
            lblComplemento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(527, 68);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(104, 20);
            lblComplemento.TabIndex = 15;
            lblComplemento.Text = "Complemento";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(11, 13);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblCep
            // 
            lblCep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCep.AutoSize = true;
            lblCep.Location = new Point(6, 8);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(34, 20);
            lblCep.TabIndex = 12;
            lblCep.Text = "CEP";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.BackgroundImage = (Image)resources.GetObject("btnPesquisar.BackgroundImage");
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(805, 13);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(125, 51);
            btnPesquisar.TabIndex = 5;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(13, 19);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(785, 27);
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
            tabFunci.Location = new Point(13, 69);
            tabFunci.MultiSelect = false;
            tabFunci.Name = "tabFunci";
            tabFunci.ReadOnly = true;
            tabFunci.RowHeadersWidth = 51;
            tabFunci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabFunci.Size = new Size(902, 475);
            tabFunci.TabIndex = 0;
            tabFunci.CellClick += tabFunci_CellClick;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(928, 144);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(101, 31);
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
            btnAdicionar.Location = new Point(928, 69);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(101, 31);
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
            btnEditar.Location = new Point(928, 107);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(101, 31);
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
            tabControllerFunci.Name = "tabControllerFunci";
            tabControllerFunci.SelectedIndex = 0;
            tabControllerFunci.Size = new Size(1045, 629);
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
            tabPageListar.Location = new Point(4, 29);
            tabPageListar.Name = "tabPageListar";
            tabPageListar.Padding = new Padding(3, 4, 3, 4);
            tabPageListar.Size = new Size(1037, 596);
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
            tabPageCadastro.Location = new Point(4, 29);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3, 4, 3, 4);
            tabPageCadastro.Size = new Size(1037, 596);
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
            panel3.Location = new Point(6, 452);
            panel3.Name = "panel3";
            panel3.Size = new Size(986, 128);
            panel3.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.SeaGreen;
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(830, 84);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 41);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.BackColor = Color.SeaGreen;
            btnSalvar.BackgroundImage = (Image)resources.GetObject("btnSalvar.BackgroundImage");
            btnSalvar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(669, 84);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 41);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblTelefone
            // 
            lblTelefone.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(3, 67);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(66, 20);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(3, 11);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefone.BackColor = Color.White;
            txtTelefone.Location = new Point(3, 91);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(434, 27);
            txtTelefone.TabIndex = 1;
            txtTelefone.KeyPress += txtTelefone_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.White;
            txtEmail.Location = new Point(3, 33);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(434, 27);
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
            panel2.Location = new Point(3, 244);
            panel2.Name = "panel2";
            panel2.Size = new Size(986, 216);
            panel2.TabIndex = 3;
            // 
            // lblNumero
            // 
            lblNumero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(443, 68);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(63, 20);
            lblNumero.TabIndex = 19;
            lblNumero.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNumero.BackColor = Color.White;
            txtNumero.Location = new Point(443, 91);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(78, 27);
            txtNumero.TabIndex = 18;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // lblUF
            // 
            lblUF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUF.AutoSize = true;
            lblUF.Location = new Point(865, 132);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(26, 20);
            lblUF.TabIndex = 11;
            lblUF.Text = "UF";
            // 
            // txtComplemento
            // 
            txtComplemento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtComplemento.BackColor = Color.White;
            txtComplemento.Location = new Point(527, 91);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(442, 27);
            txtComplemento.TabIndex = 3;
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBairro.BackColor = Color.White;
            txtBairro.Location = new Point(6, 91);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(431, 27);
            txtBairro.TabIndex = 2;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLogradouro.BackColor = Color.White;
            txtLogradouro.Location = new Point(158, 31);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(805, 27);
            txtLogradouro.TabIndex = 1;
            // 
            // txtCep
            // 
            txtCep.BackColor = Color.White;
            txtCep.Location = new Point(3, 31);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(153, 27);
            txtCep.TabIndex = 0;
            txtCep.KeyPress += txtCep_KeyPress;
            // 
            // cBoxUF
            // 
            cBoxUF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cBoxUF.BackColor = Color.White;
            cBoxUF.FormattingEnabled = true;
            cBoxUF.Location = new Point(862, 155);
            cBoxUF.Name = "cBoxUF";
            cBoxUF.Size = new Size(108, 28);
            cBoxUF.TabIndex = 7;
            // 
            // FuncionarioView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 629);
            Controls.Add(tabControllerFunci);
            FormBorderStyle = FormBorderStyle.None;
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
        private Label lblSenha;
        private Label lblLogin;
        private TextBox txtLogin;
        private TextBox txtSenha;
    }
}