﻿using FazendaSharpCity.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FazendaSharpCity
{
    public partial class QuemSomosNos : Form
    {
        public QuemSomosNos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginViewForms LoginViewForms = new LoginViewForms();
            LoginViewForms.ShowDialog();
            this.Close();
        }
    }
}
