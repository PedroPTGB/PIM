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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutoView));
            tabControllerProduto = new TabControl();
            tabPageListar = new TabPage();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            tabProduto = new DataGridView();
            btnExcluir = new Button();
            btnAdicionar = new Button();
            btnEditar = new Button();
            tabPageCadastro = new TabPage();
            txtId = new TextBox();
            panel3 = new Panel();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            lblId = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
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
            tabControllerProduto.SuspendLayout();
            tabPageListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabProduto).BeginInit();
            tabPageCadastro.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControllerProduto
            // 
            tabControllerProduto.Controls.Add(tabPageListar);
            tabControllerProduto.Controls.Add(tabPageCadastro);
            tabControllerProduto.Dock = DockStyle.Fill;
            tabControllerProduto.Location = new Point(0, 0);
            tabControllerProduto.Margin = new Padding(3, 2, 3, 2);
            tabControllerProduto.Name = "tabControllerProduto";
            tabControllerProduto.SelectedIndex = 0;
            tabControllerProduto.Size = new Size(899, 507);
            tabControllerProduto.TabIndex = 0;
            // 
            // tabPageListar
            // 
            tabPageListar.BackColor = Color.LightSlateGray;
            tabPageListar.Controls.Add(btnPesquisar);
            tabPageListar.Controls.Add(txtPesquisa);
            tabPageListar.Controls.Add(tabProduto);
            tabPageListar.Controls.Add(btnExcluir);
            tabPageListar.Controls.Add(btnAdicionar);
            tabPageListar.Controls.Add(btnEditar);
            tabPageListar.Location = new Point(4, 24);
            tabPageListar.Margin = new Padding(3, 2, 3, 2);
            tabPageListar.Name = "tabPageListar";
            tabPageListar.Padding = new Padding(3, 2, 3, 2);
            tabPageListar.Size = new Size(891, 479);
            tabPageListar.TabIndex = 0;
            tabPageListar.Text = "Listar";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.BackgroundImage = (Image)resources.GetObject("btnPesquisar.BackgroundImage");
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(670, 15);
            btnPesquisar.Margin = new Padding(3, 2, 3, 2);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(97, 31);
            btnPesquisar.TabIndex = 11;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(8, 20);
            txtPesquisa.Margin = new Padding(3, 2, 3, 2);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(642, 23);
            txtPesquisa.TabIndex = 10;
            txtPesquisa.KeyDown += txtPesquisa_KeyDown;
            // 
            // tabProduto
            // 
            tabProduto.AllowUserToAddRows = false;
            tabProduto.AllowUserToDeleteRows = false;
            tabProduto.AllowUserToResizeColumns = false;
            tabProduto.AllowUserToResizeRows = false;
            tabProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabProduto.BackgroundColor = Color.LightGray;
            tabProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabProduto.Location = new Point(8, 56);
            tabProduto.Margin = new Padding(3, 2, 3, 2);
            tabProduto.MultiSelect = false;
            tabProduto.Name = "tabProduto";
            tabProduto.ReadOnly = true;
            tabProduto.RowHeadersWidth = 51;
            tabProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabProduto.Size = new Size(747, 418);
            tabProduto.TabIndex = 6;
            tabProduto.CellClick += tabProduto_CellClick;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(786, 127);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(82, 22);
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
            btnAdicionar.Location = new Point(786, 56);
            btnAdicionar.Margin = new Padding(3, 2, 3, 2);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(82, 22);
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
            btnEditar.Location = new Point(786, 92);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 22);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.BackColor = Color.LightSlateGray;
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(panel3);
            tabPageCadastro.Controls.Add(lblId);
            tabPageCadastro.Controls.Add(btnCancelar);
            tabPageCadastro.Controls.Add(btnSalvar);
            tabPageCadastro.Controls.Add(panel2);
            tabPageCadastro.Controls.Add(panel1);
            tabPageCadastro.Location = new Point(4, 24);
            tabPageCadastro.Margin = new Padding(3, 2, 3, 2);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3, 2, 3, 2);
            tabPageCadastro.Size = new Size(891, 479);
            tabPageCadastro.TabIndex = 1;
            tabPageCadastro.Text = "Cadastro";
            // 
            // txtId
            // 
            txtId.Location = new Point(7, 20);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(110, 23);
            txtId.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtDescricao);
            panel3.Controls.Add(lblDescricao);
            panel3.Location = new Point(0, 291);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(889, 118);
            panel3.TabIndex = 5;
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = Color.White;
            txtDescricao.Location = new Point(5, 26);
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
            lblId.Location = new Point(7, 2);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 4;
            lblId.Text = "ID";
            // 
            // btnCancelar
            // 
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(458, 427);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 35);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackgroundImage = (Image)resources.GetObject("btnSalvar.BackgroundImage");
            btnSalvar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(198, 427);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(87, 35);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtPickerValidade);
            panel2.Controls.Add(lblValidade);
            panel2.Location = new Point(0, 220);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(892, 66);
            panel2.TabIndex = 1;
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
            panel1.Location = new Point(0, 44);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 172);
            panel1.TabIndex = 0;
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
            // ProdutoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 507);
            Controls.Add(tabControllerProduto);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProdutoView";
            Text = "FornecedorView";
            tabControllerProduto.ResumeLayout(false);
            tabPageListar.ResumeLayout(false);
            tabPageListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabProduto).EndInit();
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControllerProduto;
        private TabPage tabPageListar;
        private TabPage tabPageCadastro;
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private DataGridView tabProduto;
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