using Proyecto_MauroMur.Presentacion.Formularios.Lobi;
using Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionGerente;
using Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor;

namespace Proyecto_MauroMur
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
            Application.Run(new FLobi());
        }
    }
}