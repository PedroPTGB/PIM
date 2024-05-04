using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.View
{
    public interface IMainView
    {
        event EventHandler ShowClienteView;
        event EventHandler ShowFornecedorView;
        event EventHandler ShowProdutoView;
    }
}
