using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
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
            tControlCliente.TabPages.Remove(tpgCadastro);

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
        private int CellIndex;
        private bool Edita;

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Tem certeza que deseja excluir o cliente selecionado?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = tabCliente.Rows[CellIndex];

                ClientePFModel cliente = new ClientePFModel();
                cliente.IdCliente = (int)row.Cells[0].Value;

                pfDao.Delete(cliente);

                tabCliente.DataSource = BindList();
            }
        }

        private void tabCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = tabCliente.Rows[e.RowIndex];
            CellIndex = e.RowIndex;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Edita = true;
            DataGridViewRow row = tabCliente.Rows[CellIndex];
            ClientePFModel cliente = new ClientePFModel();

            cliente.IdCliente = (int)row.Cells[0].Value;
            cliente.Nome = (string)row.Cells[1].Value;
            cliente.Cpf = (string)row.Cells[2].Value;
            cliente.DtNasc = row.Cells[3].Value.ToString();
            cliente.Endereco = pfDao.SearchEndereco(cliente);

            if (!string.IsNullOrEmpty(row.Cells[4].Value.ToString()))
                cliente.Email = (string)row.Cells[4].Value;
            else
                cliente.Email = "";

            if (!string.IsNullOrEmpty(row.Cells[5].Value.ToString()))
                cliente.Telefone = (string)row.Cells[5].Value;
            else
                cliente.Telefone = "";


            tControlCliente.TabPages.Remove(tpgListar);
            tControlCliente.TabPages.Add(tpgCadastro);
            txtId.Text = cliente.IdCliente.ToString();
            txtNome.Text = cliente.Nome;
            txtCpf.Text = cliente.Cpf;
            dtPicker.Text = cliente.DtNasc;
            txtCep.Text = cliente.Endereco.cep;
            txtLogradouro.Text = cliente.Endereco.Logradouro;
            txtBairro.Text = cliente.Endereco.Bairro;
            txtComplemento.Text = cliente.Endereco.Complemento;
            txtCidade.Text = cliente.Endereco.Cidade;

            cBoxUF.SelectedItem = -1;
            for (int i = 0; i <= cBoxUF.Items.Count - 1; i++)
            {
                var vPos = Strings.InStr(cBoxUF.Items[i].ToString(), cliente.Endereco.Estado);
                if (vPos > 0)
                {
                    cBoxUF.SelectedIndex = i;
                }
                if (cliente.Endereco.Estado == null)
                    cBoxUF.SelectedItem = -1;
            }

            txtEmail.Text = cliente.Email;
            txtTelefone.Text = cliente.Telefone;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Edita = false;
            tControlCliente.TabPages.Remove(tpgListar);
            tControlCliente.TabPages.Add(tpgCadastro);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool sucess = true;
            ClientePFModel cliente = new ClientePFModel();
            cliente.Endereco = new EnderecoModel();
            if (Edita)
            {
                var result = MessageBox.Show("Deseja salvar a alteração?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    cliente.IdCliente  = Convert.ToInt32(txtId.Text);
                    cliente.Nome = txtNome.Text;
                    cliente.Cpf = txtCpf.Text;
                    cliente.DtNasc = dtPicker.Text;
                    cliente.Endereco.cep = txtCep.Text;
                    cliente.Endereco.Logradouro = txtLogradouro.Text;
                    cliente.Endereco.Bairro = txtBairro.Text;
                    cliente.Endereco.Complemento = txtComplemento.Text;
                    cliente.Endereco.Cidade = txtCidade.Text;
                    cliente.Endereco.Estado = cBoxUF.Text;
                    cliente.Email = txtEmail.Text;
                    cliente.Telefone = txtTelefone.Text;

                    try
                    {
                        pfDao.Update(cliente);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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
                }
            }
            else
            {
                var result = MessageBox.Show("Deseja adicionar novo cliente?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    cliente.Nome = txtNome.Text;
                    cliente.Cpf = txtCpf.Text;
                    cliente.DtNasc = dtPicker.Text;
                    cliente.Endereco.cep = txtCep.Text.ToString();
                    cliente.Endereco.Logradouro = txtLogradouro.Text;
                    cliente.Endereco.Bairro = txtBairro.Text;
                    cliente.Endereco.Complemento = txtComplemento.Text;
                    cliente.Endereco.Cidade = txtCidade.Text;
                    cliente.Endereco.Estado = cBoxUF.Text;
                    cliente.Email = txtEmail.Text;
                    cliente.Telefone = txtTelefone.Text;

                    try
                    {
                        pfDao.Insert(cliente);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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
                    
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tControlCliente.TabPages.Remove(tpgCadastro);
            tControlCliente.TabPages.Add(tpgListar);
        }
    }
}
