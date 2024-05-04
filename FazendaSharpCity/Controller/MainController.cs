using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FazendaSharpCity.View;

namespace FazendaSharpCity.Controller
{
    public class MainController
    {
        private IMainView mainView;

        public MainController(IMainView mainView)
        {
            this.mainView = mainView;
        }
    }
}
