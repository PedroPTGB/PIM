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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendasView));
            tabControllerVendas = new TabControl();
            tabPageListar = new TabPage();
            tabVendas = new DataGridView();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            btnExcluir = new Button();
            btnAdicionar = new Button();
            btnEditar = new Button();
            tabPageCadastro = new TabPage();
            btnListar = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            txtId = new TextBox();
            panel3 = new Panel();
            btnCalcular = new Button();
            txtTotal = new TextBox();
            lblTotal = new Label();
            lblId = new Label();
            panel2 = new Panel();
            dtPickerDataVenda = new DateTimePicker();
            lblDataVenda = new Label();
            panel1 = new Panel();
            txtFormaPag = new TextBox();
            txtQtd = new TextBox();
            lblFormaPag = new Label();
            txtPrecoUnit = new TextBox();
            lblQtd = new Label();
            lblPrecoUnit = new Label();
            tabControllerVendas.SuspendLayout();
            tabPageListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabVendas).BeginInit();
            tabPageCadastro.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControllerVendas
            // 
            tabControllerVendas.Controls.Add(tabPageListar);
            tabControllerVendas.Controls.Add(tabPageCadastro);
            tabControllerVendas.Dock = DockStyle.Fill;
            tabControllerVendas.Location = new Point(0, 0);
            tabControllerVendas.Margin = new Padding(3, 4, 3, 4);
            tabControllerVendas.Name = "tabControllerVendas";
            tabControllerVendas.SelectedIndex = 0;
            tabControllerVendas.Size = new Size(1045, 629);
            tabControllerVendas.TabIndex = 0;
            // 
            // tabPageListar
            // 
            tabPageListar.BackColor = Color.LightSlateGray;
            tabPageListar.Controls.Add(tabVendas);
            tabPageListar.Controls.Add(btnPesquisar);
            tabPageListar.Controls.Add(txtPesquisa);
            tabPageListar.Controls.Add(btnExcluir);
            tabPageListar.Controls.Add(btnAdicionar);
            tabPageListar.Controls.Add(btnEditar);
            tabPageListar.Location = new Point(4, 29);
            tabPageListar.Margin = new Padding(3, 4, 3, 4);
            tabPageListar.Name = "tabPageListar";
            tabPageListar.Padding = new Padding(3, 4, 3, 4);
            tabPageListar.Size = new Size(1037, 596);
            tabPageListar.TabIndex = 0;
            tabPageListar.Text = "Listar";
            // 
            // tabVendas
            // 
            tabVendas.AllowUserToAddRows = false;
            tabVendas.AllowUserToDeleteRows = false;
            tabVendas.AllowUserToResizeColumns = false;
            tabVendas.AllowUserToResizeRows = false;
            tabVendas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabVendas.BackgroundColor = Color.LightGray;
            tabVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabVendas.Location = new Point(27, 61);
            tabVendas.MultiSelect = false;
            tabVendas.Name = "tabVendas";
            tabVendas.ReadOnly = true;
            tabVendas.RowHeadersWidth = 51;
            tabVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabVendas.Size = new Size(910, 501);
            tabVendas.TabIndex = 15;
            tabVendas.CellClick += tabVendas_CellClick;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(783, 23);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(128, 33);
            btnPesquisar.TabIndex = 14;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(27, 23);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(737, 27);
            txtPesquisa.TabIndex = 13;
            txtPesquisa.KeyDown += txtPesquisa_KeyDown;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(938, 135);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdicionar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(938, 61);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 33);
            btnAdicionar.TabIndex = 10;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(938, 100);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.BackColor = Color.LightSlateGray;
            tabPageCadastro.Controls.Add(btnListar);
            tabPageCadastro.Controls.Add(btnCancelar);
            tabPageCadastro.Controls.Add(btnSalvar);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(panel3);
            tabPageCadastro.Controls.Add(lblId);
            tabPageCadastro.Controls.Add(panel2);
            tabPageCadastro.Controls.Add(panel1);
            tabPageCadastro.Location = new Point(4, 29);
            tabPageCadastro.Margin = new Padding(3, 4, 3, 4);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3, 4, 3, 4);
            tabPageCadastro.Size = new Size(1037, 596);
            tabPageCadastro.TabIndex = 1;
            tabPageCadastro.Text = "Cadastro";
            // 
            // btnListar
            // 
            btnListar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnListar.BackgroundImage = (Image)resources.GetObject("btnListar.BackgroundImage");
            btnListar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListar.Location = new Point(799, 543);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(109, 47);
            btnListar.TabIndex = 14;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(560, 543);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 47);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.BackgroundImage = (Image)resources.GetObject("btnSalvar.BackgroundImage");
            btnSalvar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(347, 543);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(114, 47);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(14, 37);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(btnCalcular);
            panel3.Controls.Add(txtTotal);
            panel3.Controls.Add(lblTotal);
            panel3.Location = new Point(6, 373);
            panel3.Name = "panel3";
            panel3.Size = new Size(1023, 164);
            panel3.TabIndex = 10;
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCalcular.BackgroundImage = (Image)resources.GetObject("btnCalcular.BackgroundImage");
            btnCalcular.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(8, 109);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(208, 32);
            btnCalcular.TabIndex = 15;
            btnCalcular.Text = "Calcular Valor Total";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTotal.Location = new Point(8, 35);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(1010, 47);
            txtTotal.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Enabled = false;
            lblTotal.Location = new Point(8, 12);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(80, 20);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Valor Total";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(9, 13);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 9;
            lblId.Text = "ID";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dtPickerDataVenda);
            panel2.Controls.Add(lblDataVenda);
            panel2.Location = new Point(6, 277);
            panel2.Name = "panel2";
            panel2.Size = new Size(1026, 89);
            panel2.TabIndex = 8;
            // 
            // dtPickerDataVenda
            // 
            dtPickerDataVenda.CustomFormat = "dd/MMMM/yyyy";
            dtPickerDataVenda.Format = DateTimePickerFormat.Custom;
            dtPickerDataVenda.Location = new Point(121, 29);
            dtPickerDataVenda.Name = "dtPickerDataVenda";
            dtPickerDataVenda.Size = new Size(175, 27);
            dtPickerDataVenda.TabIndex = 2;
            dtPickerDataVenda.Value = new DateTime(2024, 6, 8, 16, 38, 26, 0);
            // 
            // lblDataVenda
            // 
            lblDataVenda.AutoSize = true;
            lblDataVenda.Location = new Point(8, 35);
            lblDataVenda.Name = "lblDataVenda";
            lblDataVenda.Size = new Size(107, 20);
            lblDataVenda.TabIndex = 0;
            lblDataVenda.Text = "Data da Venda";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txtFormaPag);
            panel1.Controls.Add(txtQtd);
            panel1.Controls.Add(lblFormaPag);
            panel1.Controls.Add(txtPrecoUnit);
            panel1.Controls.Add(lblQtd);
            panel1.Controls.Add(lblPrecoUnit);
            panel1.Location = new Point(6, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(1026, 203);
            panel1.TabIndex = 7;
            // 
            // txtFormaPag
            // 
            txtFormaPag.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFormaPag.Location = new Point(8, 151);
            txtFormaPag.Name = "txtFormaPag";
            txtFormaPag.Size = new Size(621, 27);
            txtFormaPag.TabIndex = 4;
            // 
            // txtQtd
            // 
            txtQtd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtQtd.Location = new Point(8, 97);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(621, 27);
            txtQtd.TabIndex = 3;
            txtQtd.KeyPress += txtQtd_KeyPress;
            // 
            // lblFormaPag
            // 
            lblFormaPag.AutoSize = true;
            lblFormaPag.Location = new Point(8, 128);
            lblFormaPag.Name = "lblFormaPag";
            lblFormaPag.Size = new Size(151, 20);
            lblFormaPag.TabIndex = 1;
            lblFormaPag.Text = "Forma de Pagamento";
            // 
            // txtPrecoUnit
            // 
            txtPrecoUnit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPrecoUnit.Location = new Point(8, 35);
            txtPrecoUnit.Name = "txtPrecoUnit";
            txtPrecoUnit.Size = new Size(621, 27);
            txtPrecoUnit.TabIndex = 2;
            txtPrecoUnit.KeyPress += txtPrecoUnit_KeyPress;
            // 
            // lblQtd
            // 
            lblQtd.AutoSize = true;
            lblQtd.Location = new Point(8, 75);
            lblQtd.Name = "lblQtd";
            lblQtd.Size = new Size(87, 20);
            lblQtd.TabIndex = 1;
            lblQtd.Text = "Quantidade";
            // 
            // lblPrecoUnit
            // 
            lblPrecoUnit.AutoSize = true;
            lblPrecoUnit.Location = new Point(8, 12);
            lblPrecoUnit.Name = "lblPrecoUnit";
            lblPrecoUnit.Size = new Size(103, 20);
            lblPrecoUnit.TabIndex = 0;
            lblPrecoUnit.Text = "Preco Unitário";
            // 
            // VendasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 629);
            Controls.Add(tabControllerVendas);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "VendasView";
            ShowIcon = false;
            ShowInTaskbar = false;
            TransparencyKey = Color.Transparent;
            tabControllerVendas.ResumeLayout(false);
            tabPageListar.ResumeLayout(false);
            tabPageListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabVendas).EndInit();
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

        private TabControl tabControllerVendas;
        private TabPage tabPageListar;
        private TabPage tabPageCadastro;
        private Button btnExcluir;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private DataGridView tabVendas;
        private TextBox txtId;
        private Label lblId;
        private Panel panel2;
        private DateTimePicker dtPickerDataVenda;
        private Label lblDataVenda;
        private Panel panel1;
        private TextBox txtFormaPag;
        private TextBox txtQtd;
        private Label lblFormaPag;
        private TextBox txtPrecoUnit;
        private Label lblQtd;
        private Label lblPrecoUnit;
        private Button btnCancelar;
        private Button btnSalvar;
        private Panel panel3;
        private TextBox txtTotal;
        private Label lblTotal;
        private Button btnListar;
        private Button btnCalcular;
    }
}