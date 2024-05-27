using SQLite;
using System;
using toDo.Services;
using toDo.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace toDo
{
    public partial class App : Application
    {
        public static TareaDatabase Database { get; private set; }

        public App(string dbPath)
        {
            InitializeComponent();
            InitializeDatabase(dbPath);
            try
            {
                MainPage = new NavigationPage(new MainPage());
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("Error al abrir la base de datos: " + ex.Message);
                System.Environment.Exit(1);
            }
        }

        private void InitializeDatabase(string dbPath)
        {
            Database = new TareaDatabase(dbPath);
        }
    }
}
