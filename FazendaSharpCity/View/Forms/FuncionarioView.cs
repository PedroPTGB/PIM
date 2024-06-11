﻿using FazendaSharpCity.Model;
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

namespace FazendaSharpCity.View.Forms
{
    public partial class FuncionarioView : Form
    {
        public FuncionarioView()
        {
            InitializeComponent();
            tabFunci.DataSource = BindList();
            tabControllerFunci.TabPages.Remove(tabPageCadastro);

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

        FuncionarioDAO fDao = new FuncionarioDAO("localhost", "5432", "PIM", "postgres", "dbadmin");

        public System.Data.DataTable BindList()
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table = fDao.List();
            return table;
        }

        private void tabFunci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = tabFunci.Rows[e.RowIndex];
            CellIndex = e.RowIndex;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FuncionarioModel funcionario = new FuncionarioModel();

            if (Information.IsNumeric(txtPesquisa.Text))
            {
                funcionario.idFuncionario = Convert.ToInt32(txtPesquisa.Text);
            }
            else
            {
                funcionario.Nome = txtPesquisa.Text;
            }

            System.Data.DataTable table = new System.Data.DataTable();
            table = fDao.Search(funcionario);
            tabFunci.DataSource = table;
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPesquisar_Click(sender, e);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja excluir o funcionario selecionado?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = tabFunci.Rows[CellIndex];

                FuncionarioModel funcionario = new FuncionarioModel();
                funcionario.idFuncionario = (int)row.Cells[0].Value;

                fDao.Delete(funcionario);

                tabFunci.DataSource = BindList();

                CellIndex = 0;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Edita = false;
            tabControllerFunci.TabPages.Remove(tabPageListar);
            tabControllerFunci.TabPages.Add(tabPageCadastro);

            txtId.Text = "";
            txtNome.Text = "";
            txtCpf.Text = "";
            txtSalario.Text = "0,00";
            txtCep.Text = "";
            txtLogradouro.Text = "";
            txtBairro.Text = "";
            txtComplemento.Text = "";
            txtCidade.Text = "";
            txtNumero.Text = "";

            cBoxUF.SelectedItem = -1;

            txtEmail.Text = "";
            txtTelefone.Text = "";
            rdbFuncionario.Checked = true;
            rdbGerente.Checked = false;
            txtLogin.Text = "";
            txtSenha.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Edita = true;
            DataGridViewRow row = tabFunci.Rows[CellIndex];
            FuncionarioModel funcionario = new FuncionarioModel();
            System.Data.DataTable table = new System.Data.DataTable();
            funcionario.idFuncionario = (int)row.Cells[0].Value;

            funcionario = fDao.SearchCompleto(funcionario);
            funcionario.Endereco = fDao.SearchEndereco(funcionario);

            tabControllerFunci.TabPages.Remove(tabPageListar);
            tabControllerFunci.TabPages.Add(tabPageCadastro);

            txtId.Text = funcionario.idFuncionario.ToString();
            txtNome.Text = funcionario.Nome;
            txtCpf.Text = funcionario.cpf;
            dtPicker.Value = funcionario.dtNasc;
            txtSalario.Text = funcionario.salario.ToString();
            txtCep.Text = funcionario.Endereco.cep;
            txtLogradouro.Text = funcionario.Endereco.Logradouro;
            txtBairro.Text = funcionario.Endereco.bairro;
            txtComplemento.Text = funcionario.Endereco.Complemento;
            txtNumero.Text = funcionario.Endereco.num.ToString();
            txtCidade.Text = funcionario.Endereco.Cidade;
            txtLogin.Text = funcionario.login.ToString();
            txtSenha.Text = funcionario.senha.ToString();
            if (funcionario.gerente == 1)
            {
                rdbGerente.Checked = true;
                rdbFuncionario.Checked = false;
            }
            else
            {
                rdbGerente.Checked = false;
                rdbFuncionario.Checked = true;
            }

            cBoxUF.SelectedItem = -1;
            for (int i = 0; i <= cBoxUF.Items.Count - 1; i++)
            {
                var vPos = Strings.InStr(cBoxUF.Items[i].ToString(), funcionario.Endereco.Estado);
                if (vPos > 0)
                {
                    cBoxUF.SelectedIndex = i;
                }
                if (funcionario.Endereco.Estado == null)
                    cBoxUF.SelectedItem = -1;
            }

            txtEmail.Text = funcionario.Email;
            txtTelefone.Text = funcionario.Telefone;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool sucess = true;
            FuncionarioModel funcionario = new FuncionarioModel();
            string f = ValidaForms();
            if (f != null && f != "")
            {
                var r = MessageBox.Show(f, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Edita)
                {
                    var result = MessageBox.Show("Deseja salvar a alteração?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        funcionario.idFuncionario = Convert.ToInt32(txtId.Text);
                        funcionario.Nome = txtNome.Text;
                        funcionario.cpf = txtCpf.Text;
                        funcionario.dtNasc = dtPicker.Value;
                        funcionario.salario = decimal.Parse(txtSalario.Text);
                        funcionario.Endereco.cep = txtCep.Text;
                        funcionario.Endereco.Logradouro = txtLogradouro.Text;
                        funcionario.Endereco.bairro = txtBairro.Text;
                        funcionario.Endereco.Complemento = txtComplemento.Text;
                        funcionario.Endereco.Cidade = txtCidade.Text;
                        funcionario.Endereco.Estado = cBoxUF.Text;
                        funcionario.Endereco.num = Convert.ToInt32(txtNumero.Text);
                        funcionario.Email = txtEmail.Text;
                        funcionario.Telefone = txtTelefone.Text;
                        funcionario.login = txtLogin.Text;
                        funcionario.senha = txtSenha.Text;

                        if (rdbGerente.Checked)
                        {
                            funcionario.gerente = 1;
                        }
                        else if (rdbFuncionario.Checked)
                        {
                            funcionario.gerente = 0;
                        }

                        try
                        {
                            fDao.Update(funcionario);
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
                            tabControllerFunci.TabPages.Remove(tabPageCadastro);
                            tabControllerFunci.TabPages.Add(tabPageListar);
                            tabFunci.DataSource = BindList();
                        }
                    }
                }
                else
                {
                    var result = MessageBox.Show("Deseja adicionar novo cliente?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        funcionario.Nome = txtNome.Text;
                        funcionario.cpf = txtCpf.Text;
                        funcionario.dtNasc = dtPicker.Value;
                        funcionario.salario = decimal.Parse(txtSalario.Text);
                        funcionario.Endereco.cep = txtCep.Text;
                        funcionario.Endereco.Logradouro = txtLogradouro.Text;
                        funcionario.Endereco.bairro = txtBairro.Text;
                        funcionario.Endereco.Complemento = txtComplemento.Text;
                        funcionario.Endereco.Cidade = txtCidade.Text;
                        funcionario.Endereco.Estado = cBoxUF.Text;
                        funcionario.Endereco.num = Convert.ToInt32(txtNumero.Text);
                        funcionario.Email = txtEmail.Text;
                        funcionario.Telefone = txtTelefone.Text;
                        funcionario.login = txtLogin.Text;
                        funcionario.senha = txtSenha.Text;

                        if (rdbGerente.Checked)
                        {
                            funcionario.gerente = 1;
                        }
                        else
                            funcionario.gerente = 0;


                        try
                        {
                            fDao.Insert(funcionario);
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
                            tabControllerFunci.TabPages.Remove(tabPageCadastro);
                            tabControllerFunci.TabPages.Add(tabPageListar);
                            tabFunci.DataSource = BindList();
                        }


                    }
                }
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Edita)
            {
                var c = MessageBox.Show("Tem certeza que deseja cancelar? Todos os dados editados do funcionario serão perdidos...", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (c == DialogResult.Yes)
                {
                    txtId.Text = "";
                    txtNome.Text = "";
                    txtCpf.Text = "";
                    txtSalario.Text = "";
                    txtCep.Text = "";
                    txtLogradouro.Text = "";
                    txtBairro.Text = "";
                    txtComplemento.Text = "";
                    txtCidade.Text = "";
                    txtNumero.Text = "";

                    cBoxUF.SelectedItem = -1;

                    txtEmail.Text = "";
                    txtTelefone.Text = "";
                    rdbFuncionario.Checked = true;
                    rdbGerente.Checked = false;
                    txtLogin.Text = "";
                    txtSenha.Text = "";

                    var r = MessageBox.Show("Deseja voltar à tela de listagem?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (r == DialogResult.Yes)
                    {
                        tabControllerFunci.TabPages.Remove(tabPageCadastro);
                        tabControllerFunci.TabPages.Add(tabPageListar);
                        tabFunci.DataSource = BindList();
                    }
                }

            }
            else
            {
                var c = MessageBox.Show("Tem certeza que deseja cancelar? Todos os dados do funcionario serão perdidos...", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (c == DialogResult.Yes)
                {
                    txtId.Text = "";
                    txtNome.Text = "";
                    txtCpf.Text = "";
                    txtSalario.Text = "0,00";
                    txtCep.Text = "";
                    txtLogradouro.Text = "";
                    txtBairro.Text = "";
                    txtComplemento.Text = "";
                    txtCidade.Text = "";
                    txtNumero.Text = "";

                    cBoxUF.SelectedItem = -1;

                    txtEmail.Text = "";
                    txtTelefone.Text = "";
                    rdbFuncionario.Checked = true;
                    rdbGerente.Checked = false;
                    txtLogin.Text = "";
                    txtSenha.Text = "";

                    var r = MessageBox.Show("Deseja voltar à tela de listagem?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (r == DialogResult.Yes)
                    {
                        tabControllerFunci.TabPages.Remove(tabPageCadastro);
                        tabControllerFunci.TabPages.Add(tabPageListar);
                        tabFunci.DataSource = BindList();
                    }
                }
            }



        }

        public static void IntNumber(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntNumber(e);
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntNumber(e);
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntNumber(e);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntNumber(e);
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntNumber(e);
        }

        private string ValidaForms()
        {
            StringBuilder sbrErrors = new StringBuilder();
            if (txtNome.TextLength < 5)
            {
                sbrErrors.AppendLine("O Nome é obrigatório e precisa ter mais que 5 caracteres.");
            }
            else if (txtNome.TextLength > 100)
            {
                sbrErrors.AppendLine("O Nome deve possuir no máximo 100 caracteres.");
            }
            
            if (txtCpf.Text == "")
            {
                sbrErrors.AppendLine("O CPF é obrigatório.");
            }
            if (txtCpf.TextLength < 11 || txtCpf.TextLength > 11)
            {
                sbrErrors.AppendLine("O CPF precisa conter 11 numeros.");
            }
            if(Convert.ToDecimal(txtSalario.Text) < 1400)
            {
                sbrErrors.AppendLine("O Salário deve ser superior ao salário mínimo.");
            }

            if (txtLogin.TextLength < 5)
            {
                sbrErrors.AppendLine("O Login é obrigatório e precisa ter mais que 5 caracteres.");
            }
            else if (txtLogin.TextLength > 100)
            {
                sbrErrors.AppendLine("O Login deve possuir no máximo 100 caracteres.");
            }

            if (txtSenha.TextLength < 5)
            {
                sbrErrors.AppendLine("A senha é obrigatória e precisa ter mais que 5 caracteres.");
            }
            else if (txtSenha.TextLength > 100)
            {
                sbrErrors.AppendLine("A senha deve possuir no máximo 100 caracteres.");
            }

            if (txtCep.TextLength < 8 || txtCep.TextLength > 8)
            {
                sbrErrors.AppendLine("O CEP deve pssuir 8 dígitos.");
            }
            if (txtLogradouro.TextLength < 5 || txtLogradouro.Text.Length > 100)
            {
                sbrErrors.AppendLine("O Logradouro deve possuir entre 5 e 100 caracteres.");
            }
            if (txtBairro.TextLength < 5 || txtBairro.Text.Length > 100)
            {
                sbrErrors.AppendLine("O Bairro deve possuir entre 5 e 100 caracteres.");
            }
            if (txtNumero.TextLength == 0 || txtNumero.Text.Length > 8)
            {
                sbrErrors.AppendLine("O Número do endereço deve possuir entre 1 e 8 dígitos.");
            }
            if (txtComplemento.TextLength > 100)
            {
                sbrErrors.AppendLine("O Complemento pode possuir no máximo 100 caracteres.");
            }
            if (txtCidade.TextLength < 5 || txtCidade.TextLength > 100)
            {
                sbrErrors.AppendLine("O nome da Cidade deve possuir entre 5 e 100 caracteres.");
            }
            if (cBoxUF.SelectedIndex == -1)
            {
                sbrErrors.AppendLine("Selecione uma UF.");
            }
            if (txtEmail.TextLength < 5 || txtEmail.TextLength > 100)
            {
                sbrErrors.AppendLine("O Email deve possuir entre 5 e 100 caracteres.");
            }
            if (txtTelefone.TextLength != 11)
            {
                sbrErrors.AppendLine("O telefone deve possuir 11 digitos, contando com o DDD.");
            }
            return sbrErrors.ToString();
        }

    }
}
