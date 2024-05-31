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
            tabCliente = new DataGridView();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            txtPesquisa = new TextBox();
            btnPesquisar = new Button();
            tControlCliente = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panel3 = new Panel();
            lblTelefone = new Label();
            lblEmail = new Label();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            panel2 = new Panel();
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
            panel4 = new Panel();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            lblId = new Label();
            rdbPF = new RadioButton();
            rdbPJ = new RadioButton();
            rdbMasc = new RadioButton();
            rdvFem = new RadioButton();
            rdbIndef = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)tabCliente).BeginInit();
            tControlCliente.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
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
            tabCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabCliente.Location = new Point(11, 79);
            tabCliente.MultiSelect = false;
            tabCliente.Name = "tabCliente";
            tabCliente.ReadOnly = true;
            tabCliente.RowHeadersWidth = 51;
            tabCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabCliente.Size = new Size(531, 317);
            tabCliente.TabIndex = 0;
            tabCliente.CellClick += tabCliente_CellClick;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdicionar.Location = new Point(564, 79);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Location = new Point(564, 128);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.Location = new Point(564, 178);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(11, 26);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(531, 27);
            txtPesquisa.TabIndex = 4;
            txtPesquisa.KeyDown += txtPesquisa_KeyDown;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.Location = new Point(564, 24);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 5;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // tControlCliente
            // 
            tControlCliente.Controls.Add(tabPage1);
            tControlCliente.Controls.Add(tabPage2);
            tControlCliente.Dock = DockStyle.Fill;
            tControlCliente.Location = new Point(0, 0);
            tControlCliente.Name = "tControlCliente";
            tControlCliente.SelectedIndex = 0;
            tControlCliente.Size = new Size(871, 565);
            tControlCliente.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnPesquisar);
            tabPage1.Controls.Add(txtPesquisa);
            tabPage1.Controls.Add(tabCliente);
            tabPage1.Controls.Add(btnExcluir);
            tabPage1.Controls.Add(btnAdicionar);
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(863, 532);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(txtId);
            tabPage2.Controls.Add(lblId);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(863, 532);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cadastro";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTelefone);
            panel3.Controls.Add(lblEmail);
            panel3.Controls.Add(textBox10);
            panel3.Controls.Add(textBox9);
            panel3.Location = new Point(11, 368);
            panel3.Name = "panel3";
            panel3.Size = new Size(847, 119);
            panel3.TabIndex = 4;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(3, 66);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(66, 20);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(3, 10);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(3, 89);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(426, 27);
            textBox10.TabIndex = 1;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(3, 33);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(426, 27);
            textBox9.TabIndex = 0;
            // 
            // panel2
            // 
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
            panel2.Location = new Point(8, 240);
            panel2.Name = "panel2";
            panel2.Size = new Size(849, 122);
            panel2.TabIndex = 3;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(364, 68);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(104, 20);
            lblComplemento.TabIndex = 15;
            lblComplemento.Text = "Complemento";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(6, 68);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(49, 20);
            lblBairro.TabIndex = 14;
            lblBairro.Text = "Bairro";
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(158, 8);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(87, 20);
            lblLogradouro.TabIndex = 13;
            lblLogradouro.Text = "Logradouro";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(6, 8);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(34, 20);
            lblCep.TabIndex = 12;
            lblCep.Text = "CEP";
            // 
            // lblUF
            // 
            lblUF.AutoSize = true;
            lblUF.Location = new Point(768, 68);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(26, 20);
            lblUF.TabIndex = 11;
            lblUF.Text = "UF";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(364, 92);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(398, 27);
            txtComplemento.TabIndex = 3;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(6, 91);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(352, 27);
            txtBairro.TabIndex = 2;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(158, 31);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(675, 27);
            txtLogradouro.TabIndex = 1;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(3, 31);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(149, 27);
            txtCep.TabIndex = 0;
            // 
            // cBoxUF
            // 
            cBoxUF.FormattingEnabled = true;
            cBoxUF.Location = new Point(768, 91);
            cBoxUF.Name = "cBoxUF";
            cBoxUF.Size = new Size(68, 28);
            cBoxUF.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtPicker);
            panel1.Controls.Add(lblDtNasc);
            panel1.Controls.Add(lblCpf);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(txtCpf);
            panel1.Controls.Add(txtNome);
            panel1.Location = new Point(8, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 195);
            panel1.TabIndex = 2;
            // 
            // dtPicker
            // 
            dtPicker.Location = new Point(0, 149);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(299, 27);
            dtPicker.TabIndex = 11;
            // 
            // lblDtNasc
            // 
            lblDtNasc.AutoSize = true;
            lblDtNasc.Location = new Point(3, 126);
            lblDtNasc.Name = "lblDtNasc";
            lblDtNasc.Size = new Size(145, 20);
            lblDtNasc.TabIndex = 10;
            lblDtNasc.Text = "Data de Nascimento";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(6, 63);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(33, 20);
            lblCpf.TabIndex = 9;
            lblCpf.Text = "CPF";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(6, 8);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 8;
            lblNome.Text = "Nome";
            // 
            // panel5
            // 
            panel5.Controls.Add(rdbPJ);
            panel5.Controls.Add(rdbPF);
            panel5.Location = new Point(530, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(325, 83);
            panel5.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Controls.Add(rdbIndef);
            panel4.Controls.Add(rdvFem);
            panel4.Controls.Add(rdbMasc);
            panel4.Location = new Point(530, 86);
            panel4.Name = "panel4";
            panel4.Size = new Size(319, 109);
            panel4.TabIndex = 5;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(3, 86);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(521, 27);
            txtCpf.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(3, 31);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(521, 27);
            txtNome.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(38, 6);
            txtId.Name = "txtId";
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
            // rdbPF
            // 
            rdbPF.AutoSize = true;
            rdbPF.Location = new Point(33, 32);
            rdbPF.Name = "rdbPF";
            rdbPF.Size = new Size(114, 24);
            rdbPF.TabIndex = 0;
            rdbPF.TabStop = true;
            rdbPF.Text = "Pessoa Física";
            rdbPF.UseVisualStyleBackColor = true;
            // 
            // rdbPJ
            // 
            rdbPJ.AutoSize = true;
            rdbPJ.Location = new Point(178, 32);
            rdbPJ.Name = "rdbPJ";
            rdbPJ.Size = new Size(128, 24);
            rdbPJ.TabIndex = 1;
            rdbPJ.TabStop = true;
            rdbPJ.Text = "Pessoa Jurídica";
            rdbPJ.UseVisualStyleBackColor = true;
            // 
            // rdbMasc
            // 
            rdbMasc.AutoSize = true;
            rdbMasc.Location = new Point(33, 16);
            rdbMasc.Name = "rdbMasc";
            rdbMasc.Size = new Size(97, 24);
            rdbMasc.TabIndex = 0;
            rdbMasc.TabStop = true;
            rdbMasc.Text = "Masculino";
            rdbMasc.UseVisualStyleBackColor = true;
            // 
            // rdvFem
            // 
            rdvFem.AutoSize = true;
            rdvFem.Location = new Point(178, 16);
            rdvFem.Name = "rdvFem";
            rdvFem.Size = new Size(91, 24);
            rdvFem.TabIndex = 1;
            rdvFem.TabStop = true;
            rdvFem.Text = "Feminino";
            rdvFem.UseVisualStyleBackColor = true;
            // 
            // rdbIndef
            // 
            rdbIndef.AutoSize = true;
            rdbIndef.Location = new Point(111, 63);
            rdbIndef.Name = "rdbIndef";
            rdbIndef.Size = new Size(98, 24);
            rdbIndef.TabIndex = 2;
            rdbIndef.TabStop = true;
            rdbIndef.Text = "Indefinido";
            rdbIndef.UseVisualStyleBackColor = true;
            // 
            // ClienteView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 565);
            Controls.Add(tControlCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClienteView";
            Text = "ClienteView";
            ((System.ComponentModel.ISupportInitialize)tabCliente).EndInit();
            tControlCliente.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
        private TabPage tabPage1;
        private TabPage tabPage2;
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
        private TextBox textBox10;
        private TextBox textBox9;
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
    }
}