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
            
        }

        public void btnEntrar_Click(object sender, EventArgs e)
        {
            Ususario ususario = new Ususario();
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
                MessageBox.Show("Invalid login");
            }


        }
        public bool LoginClick() 
        {
            Show();
            return true;
        }
    }
}
