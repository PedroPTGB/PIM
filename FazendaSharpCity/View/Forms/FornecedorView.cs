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
    public partial class FornecedorView : Form
    {
        public FornecedorView()
        {
            InitializeComponent();
            tabFornecedor.DataSource = BindList();
            tabControllerFornecedor.TabPages.Remove(tabPageCadastro);

            cBoxUF.Items.Clear();
            cBoxUF.Items.Add("AC");
            cBoxUF.Items.Add("AL");
            cBoxUF.Items.Add("AP");
            cBoxUF.Items.Add("AM");
            cBoxUF.Items.Add("BA");
            cBoxUF.Items.Add("CE");
            cBoxUF.Items.Add("DF");
            cBoxUF.Items.Add("ES");
            cBoxUF.Items.Add("GO");
            cBoxUF.Items.Add("MA");
            cBoxUF.Items.Add("MT");
            cBoxUF.Items.Add("MS");
            cBoxUF.Items.Add("MG");
            cBoxUF.Items.Add("PA");
            cBoxUF.Items.Add("PB");
            cBoxUF.Items.Add("PR");
            cBoxUF.Items.Add("PE");
            cBoxUF.Items.Add("PI");
            cBoxUF.Items.Add("RJ");
            cBoxUF.Items.Add("RN");
            cBoxUF.Items.Add("RS");
            cBoxUF.Items.Add("RO");
            cBoxUF.Items.Add("RR");
            cBoxUF.Items.Add("SC");
            cBoxUF.Items.Add("SP");
            cBoxUF.Items.Add("SE");
            cBoxUF.Items.Add("TO");

        }
        private int CellIndex = 0;
        private bool Edita;

        FornecedorDAO fDao = new FornecedorDAO("localhost", "5432", "PIM", "postgres", "dbadmin");

        public System.Data.DataTable BindList()
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table = fDao.List();
            return table;
        }
        private void tabFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = tabFornecedor.Rows[e.RowIndex];
            CellIndex = e.RowIndex;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FornecedorModel fornecedor = new FornecedorModel();

            if (Information.IsNumeric(txtPesquisa.Text))
            {
                fornecedor.idFornecedor = Convert.ToInt32(txtPesquisa.Text);
            }
            else
            {
                fornecedor.NomeFantasia = txtPesquisa.Text;
                fornecedor.razaoSocial = txtPesquisa.Text;
            }


            System.Data.DataTable table = new System.Data.DataTable();
            table = fDao.Search(fornecedor);
            tabFornecedor.DataSource = table;

        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPesquisar_Click(sender, e);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja excluir o fornecedor selecionado?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = tabFornecedor.Rows[CellIndex];

                FornecedorModel fornecedor = new FornecedorModel();
                fornecedor.idFornecedor = (int)row.Cells[0].Value;

                fDao.Delete(fornecedor);

                tabFornecedor.DataSource = BindList();

                CellIndex = 0;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Edita = false;
            tabControllerFornecedor.TabPages.Remove(tabPageListar);
            tabControllerFornecedor.TabPages.Add(tabPageCadastro);

            txtId.Text = "";
            txtRazaoSocial.Text = "";
            txtNomeFantasia.Text = "";
            txtCnpj.Text = "";
            txtCep.Text = "";
            txtLogradouro.Text = "";
            txtBairro.Text = "";
            txtComplemento.Text = "";
            txtCidade.Text = "";

            cBoxUF.SelectedItem = -1;

            txtEmail.Text = "";
            txtTelefone.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Edita = true;
            DataGridViewRow row = tabFornecedor.Rows[CellIndex];
            FornecedorModel fornecedor = new FornecedorModel();
            System.Data.DataTable table = new System.Data.DataTable();
            fornecedor.idFornecedor = (int)row.Cells[0].Value;

            fornecedor = fDao.SearchCompleto(fornecedor);
            fornecedor.Endereco = fDao.SearchEndereco(fornecedor);

            tabControllerFornecedor.TabPages.Remove(tabPageListar);
            tabControllerFornecedor.TabPages.Add(tabPageCadastro);

            txtId.Text = fornecedor.idFornecedor.ToString();
            txtRazaoSocial.Text = fornecedor.razaoSocial;
            txtNomeFantasia.Text = fornecedor.NomeFantasia;
            txtCnpj.Text = fornecedor.cnpj;
            txtCep.Text = fornecedor.Endereco.cep;
            txtLogradouro.Text = fornecedor.Endereco.Logradouro;
            txtBairro.Text = fornecedor.Endereco.bairro;
            txtComplemento.Text = fornecedor.Endereco.Complemento;
            txtCidade.Text = fornecedor.Endereco.Cidade;

            cBoxUF.SelectedItem = -1;
            for (int i = 0; i <= cBoxUF.Items.Count - 1; i++)
            {
                var vPos = Strings.InStr(cBoxUF.Items[i].ToString(), fornecedor.Endereco.Estado);
                if (vPos > 0)
                {
                    cBoxUF.SelectedIndex = i;
                }
                if (fornecedor.Endereco.Estado == null)
                    cBoxUF.SelectedItem = -1;
            }

            txtEmail.Text = fornecedor.Email;
            txtTelefone.Text = fornecedor.Telefone;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool sucess = true;
            FornecedorModel fornecedor = new FornecedorModel();
            fornecedor.Endereco = new EnderecoModel();
            if (Edita)
            {
                var result = MessageBox.Show("Deseja salvar a alteração?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    fornecedor.idFornecedor = Convert.ToInt32(txtId.Text);
                    fornecedor.razaoSocial = txtRazaoSocial.Text;
                    fornecedor.NomeFantasia = txtNomeFantasia.Text;
                    fornecedor.cnpj = txtCnpj.Text;
                    fornecedor.Endereco.cep = txtCep.Text;
                    fornecedor.Endereco.Logradouro = txtLogradouro.Text;
                    fornecedor.Endereco.bairro = txtBairro.Text;
                    fornecedor.Endereco.Complemento = txtComplemento.Text;
                    fornecedor.Endereco.Cidade = txtCidade.Text;
                    fornecedor.Endereco.Estado = cBoxUF.Text;
                    fornecedor.Email = txtEmail.Text;
                    fornecedor.Telefone = txtTelefone.Text;

                    try
                    {
                        fDao.Update(fornecedor);
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
                        tabControllerFornecedor.TabPages.Remove(tabPageCadastro);
                        tabControllerFornecedor.TabPages.Add(tabPageListar);
                        tabFornecedor.DataSource = BindList();
                    }
                }
            }
            else
            {
                var result = MessageBox.Show("Deseja adicionar novo cliente?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    
                    fornecedor.razaoSocial = txtRazaoSocial.Text;
                    fornecedor.NomeFantasia = txtNomeFantasia.Text;
                    fornecedor.cnpj = txtCnpj.Text;
                    fornecedor.Endereco.cep = txtCep.Text;
                    fornecedor.Endereco.Logradouro = txtLogradouro.Text;
                    fornecedor.Endereco.bairro = txtBairro.Text;
                    fornecedor.Endereco.num = Convert.ToInt32(txtNumero.Text);
                    fornecedor.Endereco.Complemento = txtComplemento.Text;
                    fornecedor.Endereco.Cidade = txtCidade.Text;
                    fornecedor.Endereco.Estado = cBoxUF.Text;
                    fornecedor.Email = txtEmail.Text;
                    fornecedor.Telefone = txtTelefone.Text;

                    try
                    {
                        fDao.Insert(fornecedor);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                        sucess = false;
                    }
                    if (sucess)
                    {
                        MessageBox.Show("Cliente adicionado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro na gravação no banco de dados");
                    }

                    var r = MessageBox.Show("Deseja voltar à tela de listagem?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (r == DialogResult.Yes)
                    {
                        tabControllerFornecedor.TabPages.Remove(tabPageCadastro);
                        tabControllerFornecedor.TabPages.Add(tabPageListar);
                        tabFornecedor.DataSource = BindList();
                    }


                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            var c = MessageBox.Show("Tem certeza que deseja cancelar? Todos os dados do fornecedor serão perdidos...", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (c == DialogResult.Yes)
            {
                txtId.Text = "";
                txtRazaoSocial.Text = "";
                txtNomeFantasia.Text = "";
                txtCnpj.Text = "";
                txtCep.Text = "";
                txtLogradouro.Text = "";
                txtBairro.Text = "";
                txtComplemento.Text = "";
                txtCidade.Text = "";

                cBoxUF.SelectedItem = -1;

                txtEmail.Text = "";
                txtTelefone.Text = "";
            }

            var r = MessageBox.Show("Deseja voltar à tela de listagem?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                tabControllerFornecedor.TabPages.Remove(tabPageCadastro);
                tabControllerFornecedor.TabPages.Add(tabPageListar);
                tabFornecedor.DataSource = BindList();
            }

        }
    }
}
