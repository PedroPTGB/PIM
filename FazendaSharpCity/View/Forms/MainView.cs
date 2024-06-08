using FazendaSharpCity.View;

namespace FazendaSharpCity
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            CostumizeDesign();
        }

        public void LoadForm(object Form)
        {
            if (this.panelViewChange.Controls.Count > 0)
            {
                this.panelViewChange.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelViewChange.Controls.Add(f);
            this.panelViewChange.Tag = f;
            f.Show();
        }

        private void CostumizeDesign()
        {

            //...
        }



        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {

                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

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
    }
}
