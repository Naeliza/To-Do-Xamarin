using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using toDo.Models;
using toDo.Services;

namespace toDo.Views
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Tarea> tareas;
        private TareaDatabase database;

        public MainPage()
        {
            InitializeComponent();
            var fileHelper = DependencyService.Get<IFileHelper>();
            string dbPath = fileHelper.GetLocalFilePath("tareas.db");
            database = new TareaDatabase(dbPath);
            LoadTareas();
        }

        private async void LoadTareas()
        {
            var tareasList = await database.GetTareasAsync();
            tareas = new ObservableCollection<Tarea>(tareasList);
            taskList.ItemsSource = tareas;
        }

        private async void OnTaskSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var tarea = e.SelectedItem as Tarea;
                await Navigation.PushAsync(new TaskDetailPage(tarea, database, UpdateTaskList));
            }
        }

        private async void OnAddTaskClicked(object sender, EventArgs e)
        {
            Tarea nuevaTarea = new Tarea();
            await Navigation.PushAsync(new TaskDetailPage(nuevaTarea, database, UpdateTaskList));
        }

        private async void UpdateTaskList()
        {
            var tareasList = await database.GetTareasAsync();
            tareas = new ObservableCollection<Tarea>(tareasList);
            taskList.ItemsSource = tareas;
        }
    }

}
