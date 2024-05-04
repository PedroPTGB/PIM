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
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
            //button1.Click += new EventHandler(button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainView mainView = new MainView();
            mainView.Show();
            //this.Close();
        }
    }
}
