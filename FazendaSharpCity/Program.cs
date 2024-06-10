using FazendaSharpCity.Controller;
using FazendaSharpCity.View;
using FazendaSharpCity.Model;

namespace FazendaSharpCity
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginViewForms());
        }
    }
}