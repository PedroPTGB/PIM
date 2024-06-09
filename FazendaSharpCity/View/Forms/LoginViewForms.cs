using FazendaSharpCity.Controller;
using FazendaSharpCity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FazendaSharpCity.View
{
    public partial class LoginViewForms : Form
    {
        private LoginController loginController;
        public LoginViewForms()
        {
            InitializeComponent();
            loginController = new LoginController();
            this.AcceptButton = btnEntrar;

        }

        public void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario ususario = new Usuario();
            ususario.login = loginTbx.Text;
            ususario.password = senhaTbx.Text;
            if (loginController.VerificaLogin(ususario))
            {
                MainView mainView = new MainView();
                this.Visible = false;
                mainView.ShowDialog();
                this.Close();
            }
            else
            {
              
            }


        }
        public bool LoginClick()
        {
            Show();
            return true;
        }

        private void LoginViewForms_Load(object sender, EventArgs e)
        {

        }

        private void loginTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario ususario = new Usuario();
            ususario.login = loginTbx.Text;
            ususario.password = senhaTbx.Text;
            if (loginController.VerificaLogin(ususario))
            {
                MessageBox.Show("Login bem-sucedido!");
                MainView mainView = new MainView();
                this.Visible = false;
                mainView.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nome ou senha incorretos. Tente novamente.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void senhaTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
