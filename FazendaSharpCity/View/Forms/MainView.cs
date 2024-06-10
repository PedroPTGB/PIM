using FazendaSharpCity.Controller;
using FazendaSharpCity.View;
using FazendaSharpCity.View.Forms;

namespace FazendaSharpCity
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        public void LoadForm(object form)
        {
            if (this.pictureBox2.Controls.Count > 0)
            {
                this.pictureBox2.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pictureBox2.Controls.Add(f);
            this.pictureBox2.Tag = f;
            f.Show();
        }

        public bool close;

        private void btnCliente_Click(object sender, EventArgs e)
        {

            LoadForm(new ClienteView());

        }


        private void btnFornecedor_Click(object sender, EventArgs e)
        {

            LoadForm(new FornecedorView());
        }


        private void btnProduto_Click(object sender, EventArgs e)
        {

            LoadForm(new ProdutoView());
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            LoadForm(new VendasView());
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            LoadForm(new FuncionarioView());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.close = false;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.close = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
