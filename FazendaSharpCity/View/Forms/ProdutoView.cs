using FazendaSharpCity.Model;
using Microsoft.VisualBasic;
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
    public partial class ProdutoView : Form
    {
        public ProdutoView()
        {
            InitializeComponent();
            tabProduto.DataSource = BindList();
            tabControllerProduto.TabPages.Remove(tabPageCadastro);
        }
        private int CellIndex;
        private bool Edita;

        ProdutoDAO pDao = new ProdutoDAO("localhost", "5432", "PIM", "postgres", "dbadmin");

        public System.Data.DataTable BindList()
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table = pDao.List();
            return table;
        }

        private void tabCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = tabProduto.Rows[e.RowIndex];
            CellIndex = e.RowIndex;

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ProdutoModel produto = new ProdutoModel();

            if (Information.IsNumeric(txtPesquisa.Text))
            {
                produto.idProduto = Convert.ToInt32(txtPesquisa.Text);
            }
            else
            {
                produto.nome = txtPesquisa.Text.ToLower();
            }

            System.Data.DataTable table = new System.Data.DataTable();
            table = pDao.Search(produto);
            tabProduto.DataSource = table;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja excluir o produto selecionado?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = tabProduto.Rows[CellIndex];

                ProdutoModel produto = new ProdutoModel();
                produto.idProduto = (int)row.Cells[0].Value;

                pDao.Delete(produto);

                tabProduto.DataSource = BindList();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Edita = false;
            tabControllerProduto.TabPages.Remove(tabPageListar);
            tabControllerProduto.TabPages.Add(tabPageCadastro);

            txtId.Text = "";
            txtNome.Text = "";
            txtQtd.Text = "";
            txtPreco.Text = "";
            dtPickerValidade.Text = "";
            txtDescricao.Text = "";
        }
    }

}
