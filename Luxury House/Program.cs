using System;
using System.Configuration; 
using System.Windows.Forms;

namespace Luxury_House
{
    internal static class Program
    {
        
        public static string ConnectionString { get; private set; }

        static void Main()
        {
            
            ConnectionString = "Server=.;Database=LuxoryHouse;Trusted_Connection=True;";

            
            ApplicationConfiguration.Initialize();

            
            Application.Run(new Form1());
        }
    }
}
