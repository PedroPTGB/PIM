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
            tabControllerProduto.TabPages.Remove(tabPageListar);
        }
        private int CellIndex = 0;
        private bool Edita;

        ProdutoDAO pDao = new ProdutoDAO("localhost", "5432", "PIM", "postgres", "dbadmin");

        public System.Data.DataTable BindList()
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table = pDao.List();
            return table;
        }

        private void tabProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = tabProduto.Rows[e.RowIndex];
            CellIndex = e.RowIndex;

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            VendaModel produto = new VendaModel();

            if (Information.IsNumeric(txtPesquisa.Text))
            {
                produto.idProduto = Convert.ToInt32(txtPesquisa.Text);
            }
            else { }
            

            System.Data.DataTable table = new System.Data.DataTable();
            table = pDao.Search(produto);
            tabProduto.DataSource = table;
        }
        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPesquisar_Click(sender, e);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja excluir o produto selecionado?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = tabProduto.Rows[CellIndex];

                VendaModel produto = new VendaModel();
                produto.idProduto = (int)row.Cells[0].Value;

                pDao.Delete(produto);

                tabProduto.DataSource = BindList();
                CellIndex = 0;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Edita = true;
            DataGridViewRow row = tabProduto.Rows[CellIndex];
            VendaModel produto = new VendaModel();

            produto.idProduto = (int)row.Cells[0].Value;
            produto.nome = (string)row.Cells[1].Value;
            produto.qtd = (int)row.Cells[2].Value;
            produto.validade = (DateTime)row.Cells[3].Value;
            produto.preco = (decimal)row.Cells[4].Value;
            produto.descricao = (string)row.Cells[5].Value;

            tabControllerProduto.TabPages.Remove(tabPageListar);
            tabControllerProduto.TabPages.Add(tabPageCadastro);

            txtId.Text = produto.idProduto.ToString();
            txtNome.Text = produto.nome;
            txtQtd.Text = produto.qtd.ToString();
            txtPreco.Text = produto.preco.ToString();
            dtPickerValidade.Text = produto.validade.ToString();
            txtDescricao.Text = produto.descricao;



        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool sucess = true;
            VendaModel produto = new VendaModel();

            if (Edita)
            {
                var result = MessageBox.Show("Deseja salvar a alteração?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    produto.idProduto = Convert.ToInt32(txtId.Text);
                    produto.nome = txtNome.Text;
                    produto.qtd = Convert.ToInt32(txtQtd.Text);
                    produto.preco = (decimal)float.Parse(txtPreco.Text);
                    produto.validade = dtPickerValidade.Value;
                    produto.descricao = txtDescricao.Text;


                    try
                    {
                        pDao.Update(produto);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                        sucess = false;
                    }
                    if (sucess)
                    {
                        MessageBox.Show("Alteração realizada com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro na gravação no banco de dados");
                    }

                    var r = MessageBox.Show("Deseja voltar à tela de listagem?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (r == DialogResult.Yes)
                    {
                        tabControllerProduto.TabPages.Remove(tabPageCadastro);
                        tabControllerProduto.TabPages.Add(tabPageListar);
                        tabProduto.DataSource = BindList();
                    }
                }
            }
            else
            {
                var result = MessageBox.Show("Deseja adicionar novo produto?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    produto.nome = txtNome.Text;
                    produto.qtd = Convert.ToInt32(txtQtd.Text);
                    produto.preco = (decimal)float.Parse(txtPreco.Text);
                    produto.validade = dtPickerValidade.Value;
                    produto.descricao = txtDescricao.Text;

                    try
                    {
                        pDao.Insert(produto);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                        sucess = false;
                    }
                    if (sucess)
                    {
                        MessageBox.Show("Produto adicionado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro na gravação no banco de dados");
                    }

                    var r = MessageBox.Show("Deseja voltar à tela de listagem?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (r == DialogResult.Yes)
                    {
                        tabControllerProduto.TabPages.Remove(tabPageCadastro);
                        tabControllerProduto.TabPages.Add(tabPageListar);
                        tabProduto.DataSource = BindList();
                    }


                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var c = MessageBox.Show("Tem certeza que deseja cancelar? Todos os dados do produto serão perdidos...", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (c == DialogResult.Yes)
            {
                txtId.Text = "";
                txtNome.Text = "";
                txtQtd.Text = "";
                txtPreco.Text = "";
                dtPickerValidade.Text = "";
                txtDescricao.Text = "";
            }

            var r = MessageBox.Show("Deseja voltar à tela de listagem?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                tabControllerProduto.TabPages.Remove(tabPageCadastro);
                tabControllerProduto.TabPages.Add(tabPageListar);
                tabProduto.DataSource = BindList();
            }
        }

    }

}
