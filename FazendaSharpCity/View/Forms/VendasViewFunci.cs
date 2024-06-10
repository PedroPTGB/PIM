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

namespace FazendaSharpCity.View.Forms
{
    public partial class VendasViewFunci : Form
    {
        public VendasViewFunci()
        {
            InitializeComponent();
            tabVendas.DataSource = BindList();
            tabControllerVendas.TabPages.Remove(tabPageListar);
        }

        private int CellIndex = 0;
        private bool Edita;

        VendaDAO vDao = new VendaDAO("localhost", "5432", "PIM", "postgres", "dbadmin");

        public System.Data.DataTable BindList()
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table = vDao.List();
            return table;
        }

        private void tabVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = tabVendas.Rows[e.RowIndex];
            CellIndex = e.RowIndex;
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            VendaModel venda = new VendaModel();

            if (Information.IsNumeric(txtPesquisa.Text))
            {
                venda.IdVenda = Convert.ToInt32(txtPesquisa.Text);
            }
            else
            {
                MessageBox.Show("Pesquise apenas pelo ID da Venda!");
            }

            System.Data.DataTable table = new System.Data.DataTable();
            table = vDao.Search(venda);
            tabVendas.DataSource = table;
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPesquisar_Click(sender, e);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Edita = false;
            tabControllerVendas.TabPages.Remove(tabPageListar);
            tabControllerVendas.TabPages.Add(tabPageCadastro);

            txtId.Text = "";
            txtPrecoUnit.Text = "0,00";
            txtQtd.Text = "00";
            txtFormaPag.Text = "";
            dtPickerDataVenda.Text = "";
            txtTotal.Text = "R$0.00";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool sucess = true;
            VendaModel venda = new VendaModel();

            if (Edita)
            {
                var result = MessageBox.Show("Deseja salvar a alteração?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    venda.IdVenda = Convert.ToInt32(txtId.Text);
                    venda.PrecoUnit = Convert.ToInt32(txtPrecoUnit.Text);
                    venda.DtVenda = dtPickerDataVenda.Value;
                    venda.FormaPag = txtFormaPag.Text;
                    venda.Qtd = Convert.ToInt32(txtQtd.Text);


                    try
                    {
                        vDao.Update(venda);
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
                        tabControllerVendas.TabPages.Remove(tabPageCadastro);
                        tabControllerVendas.TabPages.Add(tabPageListar);
                        tabVendas.DataSource = BindList();
                    }
                }
            }
            else
            {
                var result = MessageBox.Show("Deseja cadastrar a venda?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    venda.PrecoUnit = float.Parse(txtPrecoUnit.Text);
                    venda.DtVenda = dtPickerDataVenda.Value;
                    venda.FormaPag = txtFormaPag.Text;
                    venda.Qtd = Convert.ToInt32(txtQtd.Text);

                    try
                    {
                        vDao.Insert(venda);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                        sucess = false;
                    }
                    if (sucess)
                    {
                        MessageBox.Show("Venda cadastrada com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro na gravação no banco de dados");
                    }

                    var r = MessageBox.Show("Deseja voltar à tela de listagem?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (r == DialogResult.Yes)
                    {
                        tabControllerVendas.TabPages.Remove(tabPageCadastro);
                        tabControllerVendas.TabPages.Add(tabPageListar);
                        tabVendas.DataSource = BindList();
                    }
                    else
                    {
                        if (sucess)
                        {
                            txtId.Text = "";
                            txtPrecoUnit.Text = "";
                            txtQtd.Text = "";
                            txtFormaPag.Text = "";
                            dtPickerDataVenda.Text = "";
                            txtTotal.Text = "R$0.00";
                        }
                    }


                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Tem certeza que deseja cancelar? Todos os dados da venda serão perdidos...", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                txtId.Text = "";
                txtPrecoUnit.Text = "";
                txtQtd.Text = "";
                txtFormaPag.Text = "";
                dtPickerDataVenda.Text = "";
                txtTotal.Text = "R$0.00";
            }
        }
        private float ObterTotal()
        {
            if(Convert.ToInt32(txtQtd.Text) != 0 && Convert.ToInt32(txtPrecoUnit.Text) != 0)
            {
                float n1 = float.Parse(txtPrecoUnit.Text);
                float n2 = float.Parse(txtQtd.Text);
                return n1 * n2;
            }
            return 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtTotal.Text = "R$" + ObterTotal().ToString();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            tabControllerVendas.TabPages.Remove(tabPageCadastro);
            tabControllerVendas.TabPages.Add(tabPageListar);
            tabVendas.DataSource = BindList();
        }

        
    }

}
