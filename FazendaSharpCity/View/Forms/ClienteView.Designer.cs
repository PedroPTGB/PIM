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
            ((System.ComponentModel.ISupportInitialize)tabCliente).BeginInit();
            SuspendLayout();
            // 
            // tabCliente
            // 
            tabCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabCliente.Location = new Point(12, 96);
            tabCliente.Name = "tabCliente";
            tabCliente.RowHeadersWidth = 51;
            tabCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabCliente.Size = new Size(522, 324);
            tabCliente.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdicionar.Location = new Point(575, 96);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Location = new Point(575, 145);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.Location = new Point(575, 195);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(12, 34);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(522, 27);
            txtPesquisa.TabIndex = 4;
            txtPesquisa.KeyDown += txtPesquisa_KeyDown;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.Location = new Point(575, 32);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 5;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // ClienteView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 442);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisa);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(tabCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClienteView";
            Text = "ClienteView";
            ((System.ComponentModel.ISupportInitialize)tabCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabCliente;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnExcluir;
        private TextBox txtPesquisa;
        private Button btnPesquisar;
    }
}