namespace FazendaSharpCity
{
    partial class VendasView
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            btnExcluir = new Button();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            tabCliente = new DataGridView();
            txtId = new TextBox();
            panel3 = new Panel();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            lblId = new Label();
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
            btnCancelar = new Button();
            btnSalvar = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabCliente).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(975, 619);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tabCliente);
            tabPage1.Controls.Add(btnPesquisar);
            tabPage1.Controls.Add(txtPesquisa);
            tabPage1.Controls.Add(btnExcluir);
            tabPage1.Controls.Add(btnAdicionar);
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(967, 591);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
           
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnCancelar);
            tabPage2.Controls.Add(btnSalvar);
            tabPage2.Controls.Add(txtId);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(lblId);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(967, 591);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.Location = new Point(842, 117);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(82, 22);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdicionar.Location = new Point(842, 46);
            btnAdicionar.Margin = new Padding(3, 2, 3, 2);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(82, 22);
            btnAdicionar.TabIndex = 10;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Location = new Point(842, 82);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 22);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.Location = new Point(685, 16);
            btnPesquisar.Margin = new Padding(3, 2, 3, 2);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(84, 26);
            btnPesquisar.TabIndex = 14;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(24, 17);
            txtPesquisa.Margin = new Padding(3, 2, 3, 2);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(645, 23);
            txtPesquisa.TabIndex = 13;
            // 
            // tabCliente
            // 
            tabCliente.AllowUserToAddRows = false;
            tabCliente.AllowUserToDeleteRows = false;
            tabCliente.AllowUserToResizeColumns = false;
            tabCliente.AllowUserToResizeRows = false;
            tabCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabCliente.Location = new Point(24, 46);
            tabCliente.Margin = new Padding(3, 2, 3, 2);
            tabCliente.MultiSelect = false;
            tabCliente.Name = "tabCliente";
            tabCliente.ReadOnly = true;
            tabCliente.RowHeadersWidth = 51;
            tabCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabCliente.Size = new Size(796, 500);
            tabCliente.TabIndex = 15;
            // 
            // txtId
            // 
            txtId.Location = new Point(8, 28);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(110, 23);
            txtId.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtDescricao);
            panel3.Controls.Add(lblDescricao);
            panel3.Location = new Point(1, 299);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(889, 118);
            panel3.TabIndex = 10;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(7, 26);
            txtDescricao.Margin = new Padding(3, 2, 3, 2);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(878, 90);
            txtDescricao.TabIndex = 3;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(7, 9);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descricao";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(8, 10);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 9;
            lblId.Text = "ID";
            // 
            // panel2
            // 
            panel2.Controls.Add(dtPickerValidade);
            panel2.Controls.Add(lblValidade);
            panel2.Location = new Point(1, 228);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(892, 66);
            panel2.TabIndex = 8;
            // 
            // dtPickerValidade
            // 
            dtPickerValidade.Location = new Point(66, 22);
            dtPickerValidade.Margin = new Padding(3, 2, 3, 2);
            dtPickerValidade.Name = "dtPickerValidade";
            dtPickerValidade.Size = new Size(219, 23);
            dtPickerValidade.TabIndex = 2;
            // 
            // lblValidade
            // 
            lblValidade.AutoSize = true;
            lblValidade.Location = new Point(7, 26);
            lblValidade.Name = "lblValidade";
            lblValidade.Size = new Size(51, 15);
            lblValidade.TabIndex = 0;
            lblValidade.Text = "Validade";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtPreco);
            panel1.Controls.Add(txtQtd);
            panel1.Controls.Add(lblPreco);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(lblQtd);
            panel1.Controls.Add(lblNome);
            panel1.Location = new Point(1, 52);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 172);
            panel1.TabIndex = 7;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(7, 104);
            txtPreco.Margin = new Padding(3, 2, 3, 2);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(538, 23);
            txtPreco.TabIndex = 4;
            // 
            // txtQtd
            // 
            txtQtd.Location = new Point(7, 64);
            txtQtd.Margin = new Padding(3, 2, 3, 2);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(538, 23);
            txtQtd.TabIndex = 3;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(7, 87);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 1;
            lblPreco.Text = "Preço";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(7, 17);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(538, 23);
            txtNome.TabIndex = 2;
            // 
            // lblQtd
            // 
            lblQtd.AutoSize = true;
            lblQtd.Location = new Point(7, 47);
            lblQtd.Name = "lblQtd";
            lblQtd.Size = new Size(69, 15);
            lblQtd.TabIndex = 1;
            lblQtd.Text = "Quantidade";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(7, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(534, 507);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(286, 507);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(82, 22);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // VendasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 619);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VendasView";
            ShowIcon = false;
            ShowInTaskbar = false;
            TransparencyKey = Color.Transparent;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabCliente).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnExcluir;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private DataGridView tabCliente;
        private TextBox txtId;
        private Panel panel3;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private Label lblId;
        private Panel panel2;
        private DateTimePicker dtPickerValidade;
        private Label lblValidade;
        private Panel panel1;
        private TextBox txtPreco;
        private TextBox txtQtd;
        private Label lblPreco;
        private TextBox txtNome;
        private Label lblQtd;
        private Label lblNome;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}