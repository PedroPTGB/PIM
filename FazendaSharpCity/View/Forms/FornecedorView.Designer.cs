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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            tabCliente = new DataGridView();
            btnExcluir = new Button();
            btnAdicionar = new Button();
            btnEditar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            txtId = new TextBox();
            lblId = new Label();
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
            btnCancelar = new Button();
            btnSalvar = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabCliente).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1063, 668);
            tabControl1.TabIndex = 2;
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
            tabPage1.Size = new Size(1055, 635);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnCancelar);
            tabPage2.Controls.Add(btnSalvar);
            tabPage2.Controls.Add(txtId);
            tabPage2.Controls.Add(lblId);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1055, 635);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
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
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(24, 18);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(737, 27);
            txtPesquisa.TabIndex = 10;
            // 
            // tabCliente
            // 
            tabCliente.AllowUserToAddRows = false;
            tabCliente.AllowUserToDeleteRows = false;
            tabCliente.AllowUserToResizeColumns = false;
            tabCliente.AllowUserToResizeRows = false;
            tabCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabCliente.Location = new Point(24, 70);
            tabCliente.MultiSelect = false;
            tabCliente.Name = "tabCliente";
            tabCliente.ReadOnly = true;
            tabCliente.RowHeadersWidth = 51;
            tabCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabCliente.Size = new Size(854, 548);
            tabCliente.TabIndex = 6;
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
            panel1.Location = new Point(3, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(1052, 188);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
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
            // panel3
            // 
            panel3.Location = new Point(3, 444);
            panel3.Name = "panel3";
            panel3.Size = new Size(1049, 108);
            panel3.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(34, 6);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 4;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(4, 10);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 3;
            lblId.Text = "ID";
            // 
            // dtPicker
            // 
            dtPicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtPicker.CustomFormat = "dd/MM/yyyy";
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.Location = new Point(30, 146);
            dtPicker.MaxDate = new DateTime(2024, 6, 3, 0, 0, 0, 0);
            dtPicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(201, 27);
            dtPicker.TabIndex = 19;
            dtPicker.Value = new DateTime(2024, 6, 3, 0, 0, 0, 0);
            // 
            // lblDtNasc
            // 
            lblDtNasc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDtNasc.AutoSize = true;
            lblDtNasc.Location = new Point(30, 122);
            lblDtNasc.Name = "lblDtNasc";
            lblDtNasc.Size = new Size(145, 20);
            lblDtNasc.TabIndex = 18;
            lblDtNasc.Text = "Data de Nascimento";
            // 
            // lblCpf
            // 
            lblCpf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(33, 60);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(33, 20);
            lblCpf.TabIndex = 17;
            lblCpf.Text = "CPF";
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.Location = new Point(33, 5);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 16;
            lblNome.Text = "Nome";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Controls.Add(rdbPJ);
            panel5.Controls.Add(rdbPF);
            panel5.Location = new Point(697, -3);
            panel5.Name = "panel5";
            panel5.Size = new Size(325, 83);
            panel5.TabIndex = 15;
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
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.Controls.Add(rdbIndef);
            panel4.Controls.Add(rdvFem);
            panel4.Controls.Add(rdbMasc);
            panel4.Location = new Point(697, 82);
            panel4.Name = "panel4";
            panel4.Size = new Size(319, 109);
            panel4.TabIndex = 14;
            // 
            // rdbIndef
            // 
            rdbIndef.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdbIndef.AutoSize = true;
            rdbIndef.Location = new Point(111, 63);
            rdbIndef.Name = "rdbIndef";
            rdbIndef.Size = new Size(98, 24);
            rdbIndef.TabIndex = 2;
            rdbIndef.TabStop = true;
            rdbIndef.Text = "Indefinido";
            rdbIndef.UseVisualStyleBackColor = true;
            // 
            // rdvFem
            // 
            rdvFem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdvFem.AutoSize = true;
            rdvFem.Location = new Point(178, 16);
            rdvFem.Name = "rdvFem";
            rdvFem.Size = new Size(91, 24);
            rdvFem.TabIndex = 1;
            rdvFem.TabStop = true;
            rdvFem.Text = "Feminino";
            rdvFem.UseVisualStyleBackColor = true;
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
            txtCpf.Location = new Point(30, 82);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(621, 27);
            txtCpf.TabIndex = 13;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(30, 28);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(621, 27);
            txtNome.TabIndex = 12;
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
            lblComplemento.Location = new Point(563, 68);
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
            txtComplemento.Location = new Point(563, 91);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(474, 27);
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
            // btnCancelar
            // 
            btnCancelar.Location = new Point(596, 579);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(228, 579);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // FornecedorView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 668);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FornecedorView";
            Text = "ProdutoView";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabCliente).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private DataGridView tabCliente;
        private Button btnExcluir;
        private Button btnAdicionar;
        private Button btnEditar;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private TextBox txtId;
        private Label lblId;
        private DateTimePicker dtPicker;
        private Label lblDtNasc;
        private Label lblCpf;
        private Label lblNome;
        private Panel panel5;
        private RadioButton rdbPJ;
        private RadioButton rdbPF;
        private Panel panel4;
        private RadioButton rdbIndef;
        private RadioButton rdvFem;
        private RadioButton rdbMasc;
        private TextBox txtCpf;
        private TextBox txtNome;
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
    }
}