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


namespace FazendaSharpCity.View.Forms
{
    public partial class RelatoriosView : Form
    {
        public RelatoriosView()
        {
            InitializeComponent();
        }

        ClientePFDAO pfDao = new ClientePFDAO("localhost", "5432", "PIM", "postgres", "dbadmin");
        FornecedorDAO fDao = new FornecedorDAO("localhost", "5432", "PIM", "postgres", "dbadmin");
        ProdutoDAO pDao = new ProdutoDAO("localhost", "5432", "PIM", "postgres", "dbadmin");
        VendaDAO vDao = new VendaDAO("localhost", "5432", "PIM", "postgres", "dbadmin");
        FuncionarioDAO funciDao = new FuncionarioDAO("localhost", "5432", "PIM", "postgres", "dbadmin");

        
        public System.Data.DataTable BindList()
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table = fDao.List();
            return table;
        }
        

    }
}
