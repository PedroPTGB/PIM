using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FazendaSharpCity.View;
using FazendaSharpCity.Model;
using System.Windows.Forms;

namespace FazendaSharpCity.Controller
{
    public class LoginController
    {
        public int  VerificaLogin(Usuario usuario)
        {
            if (usuario.login == "admin" && usuario.password == "123456")
            {
                return 1;
            }
            else if (usuario.login == "funcionario" && usuario.password == "654321")
            {
                return 2;
            }
            return 0;
            
        }
    }
}
