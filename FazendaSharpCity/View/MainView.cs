using FazendaSharpCity.View;

namespace FazendaSharpCity
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            CostumizeDesign();
        }
        
        public event EventHandler ShowClienteView;
        public event EventHandler ShowFornecedorView;
        public event EventHandler ShowProdutoView;
        
        private void CostumizeDesign()
        {
            panelSubMenuCliente.Visible = false;
            panelSubMenuFornecedor.Visible = false;
            panelSubMenuProduto.Visible = false;
            //...
        }

        private void HideSubMenu()
        {
            if (panelSubMenuCliente.Visible == true)
                panelSubMenuCliente.Visible = false;
            if (panelSubMenuFornecedor.Visible == true)
                panelSubMenuFornecedor.Visible = false;
            if (panelSubMenuProduto.Visible == true)
                panelSubMenuProduto.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuCliente);
        }

        private void btnListaCliente_Click(object sender, EventArgs e)
        {
            //...

            //...
            HideSubMenu();
        }
        private void btnCadastraCliente_Click(object sender, EventArgs e)
        {
            //...

            //...
            HideSubMenu();
        }
        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuFornecedor);
        }

        private void btnListaFornecedor_Click(object sender, EventArgs e)
        {
            //...

            //...
            HideSubMenu();
        }

        private void btnCadastraFornecedor_Click(object sender, EventArgs e)
        {
            //...

            //...
            HideSubMenu();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuProduto);
        }

        private void btnListaProduto_Click(object sender, EventArgs e)
        {
            //...
            
            //...
            HideSubMenu();
        }

        private void btnCadastraProduto_Click(object sender, EventArgs e)
        {
            //...
            
            //...
            HideSubMenu();
        }

    }
}
