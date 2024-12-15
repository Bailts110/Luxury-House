using System;
using System.Configuration; // For ConfigurationManager
using System.Windows.Forms;

namespace Luxury_House
{
    internal static class Program
    {
        // Define the connection string as a static property for global access
        public static string ConnectionString { get; private set; }

        static void Main()
        {
            // Initialize the connection string
            ConnectionString = "Server=.;Database=LuxoryHouse;Trusted_Connection=True;";

            // Initialize application configuration
            ApplicationConfiguration.Initialize();

            // Run the main form
            Application.Run(new Form1());
        }
    }
}
