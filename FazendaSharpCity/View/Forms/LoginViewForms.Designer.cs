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
            SuspendLayout();
            // 
            // loginTbx
            // 
            loginTbx.AllowDrop = true;
            loginTbx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loginTbx.BackColor = Color.SeaGreen;
            loginTbx.Font = new Font("Corbel", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginTbx.ForeColor = SystemColors.Window;
            loginTbx.Location = new Point(700, 245);
            loginTbx.Margin = new Padding(3, 2, 3, 2);
            loginTbx.Multiline = true;
            loginTbx.Name = "loginTbx";
            loginTbx.PlaceholderText = "        USUARIO";
            loginTbx.Size = new Size(234, 54);
            loginTbx.TabIndex = 3;
            loginTbx.TextChanged += loginTbx_TextChanged;
            // 
            // senhaTbx
            // 
            senhaTbx.AllowDrop = true;
            senhaTbx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            senhaTbx.BackColor = Color.SeaGreen;
            senhaTbx.Font = new Font("Corbel", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            senhaTbx.ForeColor = SystemColors.Window;
            senhaTbx.Location = new Point(700, 322);
            senhaTbx.Margin = new Padding(3, 2, 3, 2);
            senhaTbx.Multiline = true;
            senhaTbx.Name = "senhaTbx";
            senhaTbx.PasswordChar = '*';
            senhaTbx.PlaceholderText = "          SENHA";
            senhaTbx.Size = new Size(234, 53);
            senhaTbx.TabIndex = 4;
            senhaTbx.TextChanged += senhaTbx_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(0, 64, 0);
            linkLabel1.AllowDrop = true;
            linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.SeaGreen;
            linkLabel1.Location = new Point(764, 442);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(97, 15);
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
            linkLabel2.Location = new Point(778, 467);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(67, 15);
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
            btnEntrar.Location = new Point(737, 392);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(155, 40);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(729, 162);
            label1.Name = "label1";
            label1.Size = new Size(175, 56);
            label1.TabIndex = 8;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // LoginViewForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 661);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(senhaTbx);
            Controls.Add(loginTbx);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginViewForms";
            Text = " ";
            Load += LoginViewForms_Load;
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
    }
}