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
            colorDialog1 = new ColorDialog();
            colorDialog2 = new ColorDialog();
            btnEntrar = new Button();
            label1 = new Label();
            panelSuperior = new Panel();
            btnClose = new Button();
            panelCentro = new Panel();
            linkLabel1 = new LinkLabel();
            panelSuperior.SuspendLayout();
            panelCentro.SuspendLayout();
            SuspendLayout();
            // 
            // loginTbx
            // 
            loginTbx.AllowDrop = true;
            loginTbx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loginTbx.BackColor = Color.SeaGreen;
            loginTbx.Font = new Font("Corbel", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginTbx.ForeColor = SystemColors.Window;
            loginTbx.Location = new Point(576, 199);
            loginTbx.Margin = new Padding(3, 2, 3, 2);
            loginTbx.Multiline = true;
            loginTbx.Name = "loginTbx";
            loginTbx.PlaceholderText = "        USUARIO";
            loginTbx.Size = new Size(234, 54);
            loginTbx.TabIndex = 3;
            // 
            // senhaTbx
            // 
            senhaTbx.AllowDrop = true;
            senhaTbx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            senhaTbx.BackColor = Color.SeaGreen;
            senhaTbx.Font = new Font("Corbel", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            senhaTbx.ForeColor = SystemColors.Window;
            senhaTbx.Location = new Point(576, 274);
            senhaTbx.Margin = new Padding(3, 2, 3, 2);
            senhaTbx.Multiline = true;
            senhaTbx.Name = "senhaTbx";
            senhaTbx.PasswordChar = '*';
            senhaTbx.PlaceholderText = "          SENHA";
            senhaTbx.Size = new Size(234, 53);
            senhaTbx.TabIndex = 4;
            // 
            // btnEntrar
            // 
            btnEntrar.AllowDrop = true;
            btnEntrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEntrar.BackColor = Color.SeaGreen;
            btnEntrar.Location = new Point(613, 343);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(155, 40);
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
            label1.Location = new Point(608, 120);
            label1.Name = "label1";
            label1.Size = new Size(175, 56);
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
            panelSuperior.Margin = new Padding(3, 2, 3, 2);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1033, 36);
            panelSuperior.TabIndex = 9;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.botao_excluir_3_;
            btnClose.Location = new Point(984, 2);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(39, 34);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelCentro
            // 
            panelCentro.BackgroundImage = Properties.Resources.linkLab21el2;
            panelCentro.Controls.Add(linkLabel1);
            panelCentro.Controls.Add(label1);
            panelCentro.Controls.Add(btnEntrar);
            panelCentro.Controls.Add(loginTbx);
            panelCentro.Controls.Add(senhaTbx);
            panelCentro.Dock = DockStyle.Fill;
            panelCentro.Location = new Point(0, 0);
            panelCentro.Margin = new Padding(3, 2, 3, 2);
            panelCentro.Name = "panelCentro";
            panelCentro.Size = new Size(1033, 496);
            panelCentro.TabIndex = 10;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.SeaGreen;
            linkLabel1.Location = new Point(874, 456);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(108, 15);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quem Somos Nós?";
            linkLabel1.VisitedLinkColor = Color.White;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // LoginViewForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1033, 496);
            Controls.Add(panelSuperior);
            Controls.Add(panelCentro);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginViewForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            panelSuperior.ResumeLayout(false);
            panelCentro.ResumeLayout(false);
            panelCentro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox loginTbx;
        private TextBox senhaTbx;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
        private Label label1;
        public Button btnEntrar;
        private Panel panelSuperior;
        private Panel panelCentro;
        private Button btnClose;
        private LinkLabel linkLabel1;
    }
}