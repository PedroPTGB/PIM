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
            btnSalvar = new Button();
            btnCancelar = new Button();
            lblId = new Label();
            lblNome = new Label();
            lblQtd = new Label();
            lblValidade = new Label();
            lblPreco = new Label();
            lblDescricao = new Label();
            panel3 = new Panel();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtQtd = new TextBox();
            dtPickerValidade = new DateTimePicker();
            txtPreco = new TextBox();
            txtDescricao = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabCliente).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            tabControl1.Size = new Size(1027, 676);
            tabControl1.TabIndex = 0;
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
            tabPage1.Size = new Size(1019, 643);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtId);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(lblId);
            tabPage2.Controls.Add(btnCancelar);
            tabPage2.Controls.Add(btnSalvar);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1019, 643);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.Location = new Point(766, 20);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 11;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(6, 22);
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
            tabCliente.Location = new Point(6, 74);
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
            btnExcluir.Location = new Point(898, 169);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdicionar.Location = new Point(898, 74);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Location = new Point(898, 122);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtPreco);
            panel1.Controls.Add(txtQtd);
            panel1.Controls.Add(lblPreco);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(lblQtd);
            panel1.Controls.Add(lblNome);
            panel1.Location = new Point(0, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(1019, 229);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtPickerValidade);
            panel2.Controls.Add(lblValidade);
            panel2.Location = new Point(0, 294);
            panel2.Name = "panel2";
            panel2.Size = new Size(1019, 88);
            panel2.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(232, 582);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(515, 582);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
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
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(8, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // lblQtd
            // 
            lblQtd.AutoSize = true;
            lblQtd.Location = new Point(8, 63);
            lblQtd.Name = "lblQtd";
            lblQtd.Size = new Size(87, 20);
            lblQtd.TabIndex = 1;
            lblQtd.Text = "Quantidade";
            // 
            // lblValidade
            // 
            lblValidade.AutoSize = true;
            lblValidade.Location = new Point(8, 34);
            lblValidade.Name = "lblValidade";
            lblValidade.Size = new Size(67, 20);
            lblValidade.TabIndex = 0;
            lblValidade.Text = "Validade";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(8, 116);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(46, 20);
            lblPreco.TabIndex = 1;
            lblPreco.Text = "Preço";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(8, 12);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(74, 20);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descricao";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtDescricao);
            panel3.Controls.Add(lblDescricao);
            panel3.Location = new Point(0, 388);
            panel3.Name = "panel3";
            panel3.Size = new Size(1016, 157);
            panel3.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new Point(8, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(8, 23);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(614, 27);
            txtNome.TabIndex = 2;
            // 
            // txtQtd
            // 
            txtQtd.Location = new Point(8, 86);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(614, 27);
            txtQtd.TabIndex = 3;
            // 
            // dtPickerValidade
            // 
            dtPickerValidade.Location = new Point(76, 29);
            dtPickerValidade.Name = "dtPickerValidade";
            dtPickerValidade.Size = new Size(250, 27);
            dtPickerValidade.TabIndex = 2;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(8, 139);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(614, 27);
            txtPreco.TabIndex = 4;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(8, 35);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(1003, 119);
            txtDescricao.TabIndex = 3;
            // 
            // FornecedorView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 676);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FornecedorView";
            Text = "FornecedorView";
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private DataGridView tabCliente;
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