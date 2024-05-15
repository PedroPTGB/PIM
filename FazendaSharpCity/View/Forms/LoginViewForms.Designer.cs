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
            btnEntrar = new Button();
            label1 = new Label();
            label2 = new Label();
            loginTbx = new TextBox();
            senhaTbx = new TextBox();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(307, 230);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(94, 29);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 60);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 1;
            label1.Text = "login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 104);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "senha";
            // 
            // loginTbx
            // 
            loginTbx.Location = new Point(228, 53);
            loginTbx.Name = "loginTbx";
            loginTbx.Size = new Size(125, 27);
            loginTbx.TabIndex = 3;
            // 
            // senhaTbx
            // 
            senhaTbx.Location = new Point(228, 101);
            senhaTbx.Name = "senhaTbx";
            senhaTbx.Size = new Size(125, 27);
            senhaTbx.TabIndex = 4;
            // 
            // LoginViewForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(senhaTbx);
            Controls.Add(loginTbx);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "LoginViewForms";
            Text = "FazendaSharpCity - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private Label label1;
        private Label label2;
        private TextBox loginTbx;
        private TextBox senhaTbx;
    }
}