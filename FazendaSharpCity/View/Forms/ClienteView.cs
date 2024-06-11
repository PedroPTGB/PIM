using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        private int CellIndex = 0;
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
                cliente.Nome = txtPesquisa.Text;
            }


            System.Data.DataTable table = new System.Data.DataTable();
            table = pfDao.Search(cliente);
            tabCliente.DataSource = table;
        }
        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPesquisar_Click(sender, e);
        }

        public System.Data.DataTable BindList()
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table = pfDao.List();
            return table;
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

                CellIndex = 0;
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
            cliente = pfDao.SearchCompleto(cliente);
            cliente.Endereco = pfDao.SearchEndereco(cliente);

            tControlCliente.TabPages.Remove(tpgListar);
            tControlCliente.TabPages.Add(tpgCadastro);
            txtId.Text = cliente.IdCliente.ToString();
            txtNome.Text = cliente.Nome;
            if (cliente.Cpf != "")
                txtCpf.Text = cliente.Cpf;
            if (cliente.Cnpj != "")
                txtCpf.Text = cliente.Cnpj;
            dtPicker.Value = cliente.DtNasc;
            txtCep.Text = cliente.Endereco.cep;
            txtLogradouro.Text = cliente.Endereco.Logradouro;
            txtBairro.Text = cliente.Endereco.bairro;
            txtComplemento.Text = cliente.Endereco.Complemento;
            txtCidade.Text = cliente.Endereco.Cidade;
            txtNumero.Text = cliente.Endereco.num.ToString();

            if (cliente.Sexo == "M")
            {
                rdbMasc.Checked = true;
                rdbFem.Checked = false;
                rdbIndef.Checked = false;
            }
            else if (cliente.Sexo == "F")
            {
                rdbMasc.Checked = false;
                rdbFem.Checked = true;
                rdbIndef.Checked = false;
            }
            else
            {
                rdbMasc.Checked = false;
                rdbFem.Checked = false;
                rdbIndef.Checked = true;
            }

            if (cliente.TipoPessoa)
            {
                rdbPF.Checked = true;
                rdbPJ.Checked = false;
                lblCpf.Text = "CPF";
            }
            else
            {
                rdbPF.Checked = false;
                rdbPJ.Checked = true;
                lblCpf.Text = "CNPJ";
            }

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

            txtId.Text = "";
            txtNome.Text = "";
            txtCpf.Text = "";
            dtPicker.Text = "";
            txtCep.Text = "";
            txtLogradouro.Text = "";
            txtBairro.Text = "";
            txtComplemento.Text = "";
            txtCidade.Text = "";

            cBoxUF.SelectedItem = -1;

            txtEmail.Text = "";
            txtTelefone.Text = "";
            rdbPF.Checked = true;
            rdbPJ.Checked = false;
            rdbIndef.Checked = true;
            rdbMasc.Checked = false;
            rdbFem.Checked = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool sucess = true;
            ClientePFModel cliente = new ClientePFModel();
            cliente.Endereco = new EnderecoModel();
            string f = ValidaForms();
            if(f != null && f!= "")
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

                        cliente.Nome = txtNome.Text;
                        cliente.Cpf = txtCpf.Text;
                        cliente.Cnpj = txtCpf.Text;
                        cliente.DtNasc = dtPicker.Value;
                        cliente.Endereco.cep = txtCep.Text;
                        cliente.Endereco.Logradouro = txtLogradouro.Text;
                        cliente.Endereco.bairro = txtBairro.Text;
                        cliente.Endereco.Complemento = txtComplemento.Text;
                        cliente.Endereco.Cidade = txtCidade.Text;
                        cliente.Endereco.Estado = cBoxUF.Text;
                        if (txtNumero.Text != "")
                            cliente.Endereco.num = Convert.ToInt32(txtNumero.Text);
                        else
                            cliente.Endereco.num = 0;
                        cliente.Email = txtEmail.Text;
                        cliente.Telefone = txtTelefone.Text;

                        if (rdbPF.Checked)
                        {
                            cliente.TipoPessoa = true;
                        }
                        else if (rdbPJ.Checked)
                        {
                            cliente.TipoPessoa = false;
                        }

                        if (rdbMasc.Checked)
                        {
                            cliente.Sexo = "M";
                        }
                        else if (rdbFem.Checked)
                        {
                            cliente.Sexo = "F";
                        }
                        else
                        {
                            cliente.Sexo = "I";
                        }

                        try
                        {
                            pfDao.Update(cliente);
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
                            tControlCliente.TabPages.Remove(tpgCadastro);
                            tControlCliente.TabPages.Add(tpgListar);
                            tabCliente.DataSource = BindList();
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
                        cliente.Cnpj = txtCpf.Text;
                        cliente.DtNasc = dtPicker.Value;
                        cliente.Endereco.cep = txtCep.Text;
                        cliente.Endereco.Logradouro = txtLogradouro.Text;
                        cliente.Endereco.bairro = txtBairro.Text;
                        cliente.Endereco.Complemento = txtComplemento.Text;
                        cliente.Endereco.Cidade = txtCidade.Text;
                        cliente.Endereco.Estado = cBoxUF.Text;
                        if (txtNumero.Text != "")
                            cliente.Endereco.num = Convert.ToInt32(txtNumero.Text);
                        else
                            cliente.Endereco.num = 0;
                        cliente.Email = txtEmail.Text;
                        cliente.Telefone = txtTelefone.Text;

                        if (rdbPF.Checked)
                        {
                            cliente.TipoPessoa = true;
                            cliente.Cnpj = "";
                        }
                        else
                        {
                            cliente.TipoPessoa = false;
                            cliente.Cpf = "";
                        }

                        if (rdbMasc.Checked)
                        {
                            cliente.Sexo = "M";
                        }
                        else if (rdbFem.Checked)
                        {
                            cliente.Sexo = "F";
                        }
                        else if (rdbIndef.Checked)
                        {
                            cliente.Sexo = "I";
                        }

                        try
                        {
                            pfDao.Insert(cliente);
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
                            tControlCliente.TabPages.Remove(tpgCadastro);
                            tControlCliente.TabPages.Add(tpgListar);
                            tabCliente.DataSource = BindList();
                        }


                    }

                }
            }
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Edita)
            {
                var c = MessageBox.Show("Tem certeza que deseja cancelar? Todos os dados alterados do cliente serão perdidos...", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (c == DialogResult.Yes)
                {
                    txtId.Text = "";
                    txtNome.Text = "";
                    txtCpf.Text = "";
                    dtPicker.Text = "";
                    txtCep.Text = "";
                    txtLogradouro.Text = "";
                    txtBairro.Text = "";
                    txtComplemento.Text = "";
                    txtCidade.Text = "";

                    cBoxUF.SelectedItem = -1;

                    txtEmail.Text = "";
                    txtTelefone.Text = "";
                    rdbPF.Checked = true;
                    rdbPJ.Checked = false;
                    rdbIndef.Checked = true;
                    rdbMasc.Checked = false;
                    rdbFem.Checked = false;

                    var f = MessageBox.Show("Deseja voltar à tela de listagem?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (f == DialogResult.Yes)
                    {
                        tControlCliente.TabPages.Remove(tpgCadastro);
                        tControlCliente.TabPages.Add(tpgListar);
                        tabCliente.DataSource = BindList();
                    }

                }
            }
            else
            {
                var c = MessageBox.Show("Tem certeza que deseja cancelar? Todos os dados do cliente serão perdidos...", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (c == DialogResult.Yes)
                {
                    txtId.Text = "";
                    txtNome.Text = "";
                    txtCpf.Text = "";
                    dtPicker.Text = "";
                    txtCep.Text = "";
                    txtLogradouro.Text = "";
                    txtBairro.Text = "";
                    txtComplemento.Text = "";
                    txtCidade.Text = "";

                    cBoxUF.SelectedItem = -1;

                    txtEmail.Text = "";
                    txtTelefone.Text = "";
                    rdbPF.Checked = true;
                    rdbPJ.Checked = false;
                    rdbIndef.Checked = true;
                    rdbMasc.Checked = false;
                    rdbFem.Checked = false;

                    var f = MessageBox.Show("Deseja voltar à tela de listagem?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (f == DialogResult.Yes)
                    {
                        tControlCliente.TabPages.Remove(tpgCadastro);
                        tControlCliente.TabPages.Add(tpgListar);
                        tabCliente.DataSource = BindList();
                    }

                }
            }

        }

        private void rdbPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPJ.Checked)
            {
                lblCpf.Text = "CNPJ";
            }
        }

        private void rdbPF_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPF.Checked)
            {
                lblCpf.Text = "CPF";
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
            if (rdbPF.Checked)
            {
                if(txtCpf.Text == "")
                {
                    sbrErrors.AppendLine("O CPF é obrigatório.");
                }
                if (txtCpf.TextLength < 11 || txtCpf.TextLength > 11)
                {
                    sbrErrors.AppendLine("O CPF precisa conter 11 numeros.");
                }
            }
            else if (rdbPJ.Checked)
            {
                if (txtCpf.Text == "")
                {
                    sbrErrors.AppendLine("O CNPJ é obrigatório.");
                }
                if (txtCpf.TextLength < 14 || txtCpf.TextLength > 14)
                {
                    sbrErrors.AppendLine("O CNPJ precisa conter 14 numeros.");
                }
            }
            if(txtCep.TextLength < 8 ||  txtCep.TextLength > 8)
            {
                sbrErrors.AppendLine("O CEP deve pssuir 8 dígitos.");
            }
            if(txtLogradouro.TextLength < 5 || txtLogradouro.Text.Length > 100) 
            {
                sbrErrors.AppendLine("O Logradouro deve possuir entre 5 e 100 caracteres.");
            }
            if(txtBairro.TextLength < 5 || txtBairro.Text.Length > 100)
            {
                sbrErrors.AppendLine("O Bairro deve possuir entre 5 e 100 caracteres.");
            }
            if(txtNumero.TextLength == 0 || txtNumero.Text.Length > 8)
            {
                sbrErrors.AppendLine("O Número do endereço deve possuir entre 1 e 8 dígitos.");
            }
            if(txtComplemento.TextLength > 100)
            {
                sbrErrors.AppendLine("O Complemento pode possuir no máximo 100 caracteres.");
            }
            if(txtCidade.TextLength < 5 || txtCidade.TextLength > 100)
            {
                sbrErrors.AppendLine("O nome da Cidade deve possuir entre 5 e 100 caracteres.");
            }
            if(cBoxUF.SelectedIndex == -1)
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
