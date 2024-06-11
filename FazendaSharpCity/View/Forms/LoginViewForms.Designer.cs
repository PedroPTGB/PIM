namespace FazendaSharpCity.View
{
    partial class LoginViewForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginViewForms));
            loginTbx = new TextBox();
            senhaTbx = new TextBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            colorDialog1 = new ColorDialog();
            colorDialog2 = new ColorDialog();
            btnEntrar = new Button();
            label1 = new Label();
            panelSuperior = new Panel();
            btnClose = new Button();
            panelCentro = new Panel();
            panelSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // loginTbx
            // 
            loginTbx.AllowDrop = true;
            loginTbx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loginTbx.BackColor = Color.SeaGreen;
            loginTbx.Font = new Font("Corbel", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginTbx.ForeColor = SystemColors.Window;
            loginTbx.Location = new Point(628, 327);
            loginTbx.Multiline = true;
            loginTbx.Name = "loginTbx";
            loginTbx.PlaceholderText = "        USUARIO";
            loginTbx.Size = new Size(267, 71);
            loginTbx.TabIndex = 3;
            // 
            // senhaTbx
            // 
            senhaTbx.AllowDrop = true;
            senhaTbx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            senhaTbx.BackColor = Color.SeaGreen;
            senhaTbx.Font = new Font("Corbel", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            senhaTbx.ForeColor = SystemColors.Window;
            senhaTbx.Location = new Point(628, 429);
            senhaTbx.Multiline = true;
            senhaTbx.Name = "senhaTbx";
            senhaTbx.PasswordChar = '*';
            senhaTbx.PlaceholderText = "          SENHA";
            senhaTbx.Size = new Size(267, 69);
            senhaTbx.TabIndex = 4;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(0, 64, 0);
            linkLabel1.AllowDrop = true;
            linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.SeaGreen;
            linkLabel1.Location = new Point(701, 589);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(122, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Esqueceu Senha?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.FromArgb(0, 64, 0);
            linkLabel2.AllowDrop = true;
            linkLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.LinkColor = Color.SeaGreen;
            linkLabel2.Location = new Point(717, 623);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(83, 20);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Criar Conta";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // btnEntrar
            // 
            btnEntrar.AllowDrop = true;
            btnEntrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEntrar.BackColor = Color.SeaGreen;
            btnEntrar.Location = new Point(670, 523);
            btnEntrar.Margin = new Padding(3, 4, 3, 4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(177, 53);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(661, 216);
            label1.Name = "label1";
            label1.Size = new Size(221, 70);
            label1.TabIndex = 8;
            label1.Text = "LOGIN";
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.Transparent;
            panelSuperior.BackgroundImage = (Image)resources.GetObject("panelSuperior.BackgroundImage");
            panelSuperior.Controls.Add(btnClose);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1181, 48);
            panelSuperior.TabIndex = 9;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.botao_excluir_3_;
            btnClose.Location = new Point(1124, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 45);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelCentro
            // 
            panelCentro.BackgroundImage = (Image)resources.GetObject("panelCentro.BackgroundImage");
            panelCentro.Dock = DockStyle.Fill;
            panelCentro.Location = new Point(0, 0);
            panelCentro.Name = "panelCentro";
            panelCentro.Size = new Size(1181, 661);
            panelCentro.TabIndex = 10;
            // 
            // LoginViewForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1181, 661);
            Controls.Add(panelSuperior);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(senhaTbx);
            Controls.Add(loginTbx);
            Controls.Add(panelCentro);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginViewForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            panelSuperior.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox loginTbx;
        private TextBox senhaTbx;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
        private Label label1;
        public Button btnEntrar;
        private Panel panelSuperior;
        private Panel panelCentro;
        private Button btnClose;
    }
}