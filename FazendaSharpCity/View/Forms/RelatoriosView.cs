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
            table = pfDao.ListR();
            return table;
        }

        public System.Data.DataTable BindListFornecedor()
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table = fDao.ListR();
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
            table = funciDao.ListR();
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
            table = pfDao.SearchR(cliente);
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
            table = fDao.SearchR(fornecedor);
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
            else
            {
                produto.nome = txtPesquisaProdutos.Text;
            }


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

            venda.DtVenda = dtPickerVendas.Value.Date;

            System.Data.DataTable table = new System.Data.DataTable();
            table = vDao.SearchDT(venda);
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
            try
            {
                using (StreamWriter csv = new StreamWriter(@"..\..\..\relatorios\relatorio_clientes.csv"))
                {
                    var header =    tabClientes.Columns["idcliente"].Name.ToString() + ";" +
                                    tabClientes.Columns["nome"].Name.ToString() + ";" +
                                    tabClientes.Columns["cpf"].Name.ToString() + ";" +
                                    tabClientes.Columns["cnpj"].Name.ToString() + ";" +
                                    tabClientes.Columns["dtnascimento"].Name.ToString() + ";" +
                                    tabClientes.Columns["email"].Name.ToString() + ";" +
                                    tabClientes.Columns["estado"].Name.ToString() + ";" +
                                    tabClientes.Columns["cidade"].Name.ToString() + ";" +
                                    tabClientes.Columns["bairro"].Name.ToString() + ";" +
                                    tabClientes.Columns["logradouro"].Name.ToString() + ";" +
                                    tabClientes.Columns["numero"].Name.ToString() + ";" +
                                    tabClientes.Columns["complemento"].Name.ToString() + ";" +
                                    tabClientes.Columns["cep"].Name.ToString() + ";" +
                                    tabClientes.Columns["tipopessoa"].Name.ToString() + ";" +
                                    tabClientes.Columns["sexo"].Name.ToString() + ";" +
                                    tabClientes.Columns["telefone"].Name.ToString();

                    csv.Write(header);

                    for (int i = 0; i < tabClientes.RowCount; i++)
                    {
                        var linha = tabClientes.Rows[i].Cells[0].Value.ToString() + ";" +
                                    tabClientes.Rows[i].Cells[1].Value.ToString() + ";" +
                                    tabClientes.Rows[i].Cells[2].Value.ToString() + ";" +
                                    tabClientes.Rows[i].Cells[3].Value.ToString() + ";" +
                                    tabClientes.Rows[i].Cells[4].Value.ToString() + ";" +
                                    tabClientes.Rows[i].Cells[5].Value.ToString() + ";" +
                                    tabClientes.Rows[i].Cells[6].Value.ToString() + ";" +
                                    tabClientes.Rows[i].Cells[7].Value.ToString() + ";" +
                                    tabClientes.Rows[i].Cells[8].Value.ToString() + ";" +
                                    tabClientes.Rows[i].Cells[9].Value.ToString() + ";" +
                                    tabClientes.Rows[i].Cells[10].Value.ToString() + ";" +
                                    tabClientes.Rows[i].Cells[11].Value.ToString() + ";" +
                                    tabClientes.Rows[i].Cells[12].Value.ToString() + ";" +
                                    tabClientes.Rows[i].Cells[13].Value.ToString() + ";" +
                                    tabClientes.Rows[i].Cells[14].Value.ToString() + ";" +
                                    tabClientes.Rows[i].Cells[15].Value.ToString();

                        csv.WriteLine(linha);
                    }
                }
                MessageBox.Show("Gravado em arquivo .csv com sucesso!");
            }
            catch
            {
                MessageBox.Show("Erro na gravação do arquivo csv.");
            }
        }

        private void btnExportarFornecedores_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter csv = new StreamWriter(@"..\..\..\relatorios\relatorio_fornecedores.csv"))
                {

                    var header =    tabFornecedores.Columns["idfornecedor"].Name.ToString() + ";" +
                                    tabFornecedores.Columns["nomefantasia"].Name.ToString() + ";" +
                                    tabFornecedores.Columns["razaosocial"].Name.ToString() + ";" +
                                    tabFornecedores.Columns["cnpj"].Name.ToString() + ";" +
                                    tabFornecedores.Columns["email"].Name.ToString() + ";" +
                                    tabFornecedores.Columns["estado"].Name.ToString() + ";" +
                                    tabFornecedores.Columns["cidade"].Name.ToString() + ";" +
                                    tabFornecedores.Columns["bairro"].Name.ToString() + ";" +
                                    tabFornecedores.Columns["numero"].Name.ToString() + ";" +
                                    tabFornecedores.Columns["complemento"].Name.ToString() + ";" +
                                    tabFornecedores.Columns["cep"].Name.ToString() + ";" +
                                    tabFornecedores.Columns["logradouro"].Name.ToString() + ";" +
                                    tabFornecedores.Columns["telefone"].Name.ToString();
                                    
                    csv.Write(header);

                    for (int i = 0; i < tabFornecedores.RowCount; i++)
                    {
                        var linha = tabFornecedores.Rows[i].Cells[0].Value.ToString() + ";" +
                                    tabFornecedores.Rows[i].Cells[1].Value.ToString() + ";" +
                                    tabFornecedores.Rows[i].Cells[2].Value.ToString() + ";" +
                                    tabFornecedores.Rows[i].Cells[3].Value.ToString() + ";" +
                                    tabFornecedores.Rows[i].Cells[4].Value.ToString() + ";" +
                                    tabFornecedores.Rows[i].Cells[5].Value.ToString() + ";" +
                                    tabFornecedores.Rows[i].Cells[6].Value.ToString() + ";" +
                                    tabFornecedores.Rows[i].Cells[7].Value.ToString() + ";" +
                                    tabFornecedores.Rows[i].Cells[8].Value.ToString() + ";" +
                                    tabFornecedores.Rows[i].Cells[9].Value.ToString() + ";" +
                                    tabFornecedores.Rows[i].Cells[10].Value.ToString() + ";" +
                                    tabFornecedores.Rows[i].Cells[11].Value.ToString() + ";" +
                                    tabFornecedores.Rows[i].Cells[12].Value.ToString();

                        csv.WriteLine(linha);
                    }
                }
                MessageBox.Show("Gravado em arquivo .csv com sucesso!");
            }
            catch
            {
                MessageBox.Show("Erro na gravação do arquivo csv.");
            }
}

        private void btnExportarProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter csv = new StreamWriter(@"..\..\..\relatorios\relatorio_produtos.csv"))
                {

                    var header = tabProdutos.Columns["idproduto"].Name.ToString() + ";" +
                                   tabProdutos.Columns["produto"].Name.ToString() + ";" +
                                   tabProdutos.Columns["qtdproduto"].Name.ToString() + ";" +
                                   tabProdutos.Columns["validade"].Name.ToString() + ";" +
                                   tabProdutos.Columns["preco"].Name.ToString() + ";" +
                                   tabProdutos.Columns["descricao"].Name.ToString();

                    csv.Write(header);

                    for (int i = 0; i < tabProdutos.RowCount; i++)
                    {
                        var linha = tabProdutos.Rows[i].Cells[0].Value.ToString() + ";" +
                                    tabProdutos.Rows[i].Cells[1].Value.ToString() + ";" +
                                    tabProdutos.Rows[i].Cells[2].Value.ToString() + ";" +
                                    tabProdutos.Rows[i].Cells[3].Value.ToString() + ";" +
                                    tabProdutos.Rows[i].Cells[4].Value.ToString() + ";" +
                                    tabProdutos.Rows[i].Cells[5].Value.ToString();

                        csv.WriteLine(linha);
                    }
                }
                MessageBox.Show("Gravado em arquivo .csv com sucesso!");
            }
            catch
            {
                MessageBox.Show("Erro na gravação do arquivo csv.");
            }
        }

        private void btnExportarVendas_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter csv = new StreamWriter(@"..\..\..\relatorios\relatorio_vendas.csv"))
                {

                    var header =   tabVendas.Columns["idvenda"].Name.ToString() + ";" +
                                   tabVendas.Columns["precounitario"].Name.ToString() + ";" +
                                   tabVendas.Columns["dtvenda"].Name.ToString() + ";" +
                                   tabVendas.Columns["formapagamento"].Name.ToString() + ";" +
                                   tabVendas.Columns["quantidade"].Name.ToString();

                    csv.Write(header);

                    for (int i = 0; i < tabVendas.RowCount; i++)
                    {
                        var linha = tabVendas.Rows[i].Cells[0].Value.ToString() + ";" +
                                    tabVendas.Rows[i].Cells[1].Value.ToString() + ";" +
                                    tabVendas.Rows[i].Cells[2].Value.ToString() + ";" +
                                    tabVendas.Rows[i].Cells[3].Value.ToString() + ";" +
                                    tabVendas.Rows[i].Cells[4].Value.ToString();

                        csv.WriteLine(linha);
                    }
                }
                MessageBox.Show("Gravado em arquivo .csv com sucesso!");
            }
            catch
            {
                MessageBox.Show("Erro na gravação do arquivo csv.");
            }
        }
    


        private void btnExportarFuncionarios_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter csv = new StreamWriter(@"..\..\..\relatorios\relatorio_funcionarios.csv"))
                {

                    var header =    tabFuncionarios.Columns["idfuncionario"].Name.ToString() + ";" +
                                    tabFuncionarios.Columns["nome"].Name.ToString() + ";" +
                                    tabFuncionarios.Columns["cpf"].Name.ToString() + ";" +
                                    tabFuncionarios.Columns["dtnascimento"].Name.ToString() + ";" +
                                    tabFuncionarios.Columns["email"].Name.ToString() + ";" +
                                    tabFuncionarios.Columns["gerente"].Name.ToString() + ";" +
                                    tabFuncionarios.Columns["salario"].Name.ToString() + ";" +
                                    tabFuncionarios.Columns["estado"].Name.ToString() + ";" +
                                    tabFuncionarios.Columns["cidade"].Name.ToString() + ";" +
                                    tabFuncionarios.Columns["bairro"].Name.ToString() + ";" +
                                    tabFuncionarios.Columns["numero"].Name.ToString() + ";" +
                                    tabFuncionarios.Columns["complemento"].Name.ToString() + ";" +
                                    tabFuncionarios.Columns["cep"].Name.ToString() + ";" +
                                    tabFuncionarios.Columns["logradouro"].Name.ToString() + ";" +
                                    tabFuncionarios.Columns["telefone"].Name.ToString();

                    csv.Write(header);

                    for (int i = 0; i < tabFuncionarios.RowCount; i++)
                    {
                        var linha = tabFuncionarios.Rows[i].Cells[0].Value.ToString() + ";" +
                                    tabFuncionarios.Rows[i].Cells[1].Value.ToString() + ";" +
                                    tabFuncionarios.Rows[i].Cells[2].Value.ToString() + ";" +
                                    tabFuncionarios.Rows[i].Cells[3].Value.ToString() + ";" +
                                    tabFuncionarios.Rows[i].Cells[4].Value.ToString() + ";" +
                                    tabFuncionarios.Rows[i].Cells[5].Value.ToString() + ";" +
                                    tabFuncionarios.Rows[i].Cells[6].Value.ToString() + ";" +
                                    tabFuncionarios.Rows[i].Cells[7].Value.ToString() + ";" +
                                    tabFuncionarios.Rows[i].Cells[8].Value.ToString() + ";" +
                                    tabFuncionarios.Rows[i].Cells[9].Value.ToString() + ";" +
                                    tabFuncionarios.Rows[i].Cells[10].Value.ToString() + ";" +
                                    tabFuncionarios.Rows[i].Cells[11].Value.ToString() + ";" +
                                    tabFuncionarios.Rows[i].Cells[12].Value.ToString() + ";" +
                                    tabFuncionarios.Rows[i].Cells[13].Value.ToString() + ";" +
                                    tabFuncionarios.Rows[i].Cells[14].Value.ToString();

                        csv.WriteLine(linha);
                    }
                }
                MessageBox.Show("Gravado em arquivo .csv com sucesso!");
            }
            catch
            {
                MessageBox.Show("Erro na gravação do arquivo csv.");
            }

        }




    }
}
