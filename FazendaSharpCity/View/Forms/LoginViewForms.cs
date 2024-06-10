using FazendaSharpCity.Controller;
using FazendaSharpCity.Model;
using FazendaSharpCity.View.Forms;
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
            if (loginController.VerificaLogin(ususario) == 1)
            {
                MainView mainView = new MainView();
                this.Visible = false;
                var result = mainView.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (mainView.close)
                    {
                        this.Close();
                    }
                    else
                    {
                        Application.Restart();
                    }
                }
            }
            else if (loginController.VerificaLogin(ususario) == 2)
            {
                MainViewFuncionario mainViewFunci = new MainViewFuncionario();
                this.Visible = false;
                var result = mainViewFunci.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (mainViewFunci.close)
                    {
                        this.Close();
                    }
                    else
                    {
                        Application.Restart();
                    }
                }
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos. Tente novamente.");
            }


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
