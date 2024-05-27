using System;
using Xamarin.Forms;
using System.IO;
using toDo.Services;

namespace toDo
{
    public partial class App : Application
    {
        static TareaDatabase database;

        public static TareaDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new TareaDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Tareas.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
