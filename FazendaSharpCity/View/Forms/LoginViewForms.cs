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
        public LoginViewForms()
        {
            InitializeComponent();
            
        }

        public void btnEntrar_Click(object sender, EventArgs e)
        {
            LoginClick();
        }
        public bool LoginClick() 
        {
            Show();
            return true;
        }
    }
}
