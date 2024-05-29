using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FazendaSharpCity.Controller;
using FazendaSharpCity.Model;
using Microsoft.VisualBasic;

namespace FazendaSharpCity.View
{
    public partial class ClienteView : Form
    {
        public ClienteView()
        {
            InitializeComponent();
            tabCliente.DataSource = BindList();
        }

        ClientePFDAO pfDao = new ClientePFDAO("localhost", "5432", "PIM", "postgres", "dbadmin");

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ClientePFModel cliente = new ClientePFModel();

            if (Information.IsNumeric(txtPesquisa.Text))
            {
                cliente.IdCliente = Convert.ToInt32(txtPesquisa.Text);
            }
            else
            {
                cliente.Nome = txtPesquisa.Text.ToLower();
            }


            System.Data.DataTable table = new System.Data.DataTable();
            table = pfDao.Search(cliente);
            tabCliente.DataSource = table;
        }

        public System.Data.DataTable BindList()
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table = pfDao.List();
            return table;
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPesquisar_Click(sender, e);
        }
    }
}
