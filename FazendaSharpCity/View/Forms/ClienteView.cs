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

namespace FazendaSharpCity.View
{
    public partial class ClienteView : Form
    {
        public ClienteView()
        {
            InitializeComponent();
            tabCliente.DataSource = BindList();
        }

        ClientePFDAO pfDao = new ClientePFDAO("localhost", "5432", "cliente", "postgres", "dbadmin");
        //ClientePFModel cliente = new ClientePFModel();

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //cliente.Nome = txtPesquisa.Text.ToString();
            //pfDao.Search(cliente);
        }

        public System.Data.DataTable BindList()
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table = pfDao.List();
            return table;
        }
    }
}
