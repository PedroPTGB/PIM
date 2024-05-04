using FazendaSharpCity.Controller;
using FazendaSharpCity.View;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            IMainView mainView = new MainView();
            new MainController(mainView);
            Application.Run(new LoginView());
        }
    }
}