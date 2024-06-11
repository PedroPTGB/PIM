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
using FazendaSharpCity.Model;
using Microsoft.VisualBasic;


namespace FazendaSharpCity.View.Forms
{
    public partial class RelatoriosView : Form
    {
        public RelatoriosView()
        {
            InitializeComponent();

            tabClientes.DataSource = BindListCliente();
            tabFornecedores.DataSource = BindListFornecedor();
            tabProdutos.DataSource = BindListProduto();
            tabVendas.DataSource = BindListVenda();
            tabFuncionarios.DataSource = BindListFuncionario();

        }

        ClientePFDAO pfDao = new ClientePFDAO("localhost", "5432", "PIM", "postgres", "dbadmin");
        FornecedorDAO fDao = new FornecedorDAO("localhost", "5432", "PIM", "postgres", "dbadmin");
        ProdutoDAO pDao = new ProdutoDAO("localhost", "5432", "PIM", "postgres", "dbadmin");
        VendaDAO vDao = new VendaDAO("localhost", "5432", "PIM", "postgres", "dbadmin");
        FuncionarioDAO funciDao = new FuncionarioDAO("localhost", "5432", "PIM", "postgres", "dbadmin");


        public System.Data.DataTable BindListCliente()
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table = pfDao.List();
            return table;
        }

        public System.Data.DataTable BindListFornecedor()
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table = fDao.List();
            return table;
        }

        public System.Data.DataTable BindListProduto()
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table = pDao.List();
            return table;
        }

        public System.Data.DataTable BindListVenda()
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table = vDao.List();
            return table;
        }

        public System.Data.DataTable BindListFuncionario()
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table = funciDao.List();
            return table;
        }

        private void btnPesquisarClientes_Click(object sender, EventArgs e)
        {
            ClientePFModel cliente = new ClientePFModel();

            if (Information.IsNumeric(txtPesquisaClientes.Text))
            {
                cliente.IdCliente = Convert.ToInt32(txtPesquisaClientes.Text);
            }
            else
            {
                cliente.Nome = txtPesquisaClientes.Text;
            }


            System.Data.DataTable table = new System.Data.DataTable();
            table = pfDao.Search(cliente);
            tabClientes.DataSource = table;
        }
        private void txtPesquisaClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPesquisarClientes_Click(sender, e);
        }

        private void btnPesquisarFornecedores_Click(object sender, EventArgs e)
        {
            FornecedorModel fornecedor = new FornecedorModel();

            if (Information.IsNumeric(txtPesquisaFornecedores.Text))
            {
                fornecedor.idFornecedor = Convert.ToInt32(txtPesquisaFornecedores.Text);
            }
            else
            {
                fornecedor.NomeFantasia = txtPesquisaFornecedores.Text;
                fornecedor.razaoSocial = txtPesquisaFornecedores.Text;
            }


            System.Data.DataTable table = new System.Data.DataTable();
            table = fDao.Search(fornecedor);
            tabFornecedores.DataSource = table;
        }
        private void txtPesquisaFornecedores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPesquisarFornecedores_Click(sender, e);
        }

        private void btnPesquisarProdutos_Click(object sender, EventArgs e)
        {
            ProdutoModel produto = new ProdutoModel();

            if (Information.IsNumeric(txtPesquisaProdutos.Text))
            {
                produto.idProduto = Convert.ToInt32(txtPesquisaProdutos.Text);
            }
            else { }


            System.Data.DataTable table = new System.Data.DataTable();
            table = pDao.Search(produto);
            tabProdutos.DataSource = table;
        }
        private void txtPesquisaProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPesquisarProdutos_Click(sender, e);
        }

        private void btnPesquisaVendas_Click(object sender, EventArgs e)
        {
            VendaModel venda = new VendaModel();

            
            venda.DtVenda = dtPickerDataVenda.Value;
            

            System.Data.DataTable table = new System.Data.DataTable();
            table = vDao.Search(venda);
            tabVendas.DataSource = table;
        }

        private void btnPesquisarFuncionarios_Click(object sender, EventArgs e)
        {
            FuncionarioModel funcionario = new FuncionarioModel();

            if (Information.IsNumeric(txtPesquisaFuncionarios.Text))
            {
                funcionario.idFuncionario = Convert.ToInt32(txtPesquisaFuncionarios.Text);
            }
            else
            {
                funcionario.Nome = txtPesquisaFuncionarios.Text;
            }

            System.Data.DataTable table = new System.Data.DataTable();
            table = funciDao.Search(funcionario);
            tabFuncionarios.DataSource = table;
        }
        private void txtPesquisaFuncionarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPesquisarFuncionarios_Click(sender, e);
        }


        private void btnExportarClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnExportarFornecedores_Click(object sender, EventArgs e)
        {

        }

        private void btnExportarProdutos_Click(object sender, EventArgs e)
        {

        }

        private void btnExportarVendas_Click(object sender, EventArgs e)
        {

        }

        private void btnExportarFuncionarios_Click(object sender, EventArgs e)
        {

        }




    }
}
