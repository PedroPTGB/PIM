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
    public class MainController
    {
        public void MainViewRun()
        {
            MainView mv = new MainView();
            mv.Show();
        }
    }
}
