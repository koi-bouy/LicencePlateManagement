// Raphael Fernandes, 30099423
// Date: 3/11/2025
// Version: 1.0
// Name: Active Systems Pty. Library Management System
// Program that keeps track of West Australian licence plates.
namespace LicencePlateManagement
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
            Application.Run(new LicencePlateForm());
        }
    }
}