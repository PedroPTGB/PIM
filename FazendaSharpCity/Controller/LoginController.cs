﻿using System;
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
        public bool LoginViewRun()
        {
            bool resp;
            LoginViewForms lv = new LoginViewForms();
            lv.Show();
            resp = lv.LoginClick();
            return resp;
        }

        public void VerificaLogin()
        {
            throw new NotImplementedException();
        }
    }
}
