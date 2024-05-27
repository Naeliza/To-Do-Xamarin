// MainPage.xaml.cs
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using toDo.Models;
using toDo.Services;
using System.Threading;

namespace toDo.Views
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Tarea> tareas;
        private TareaDatabase database;

        public MainPage()
        {
            InitializeComponent();
            database = new TareaDatabase("tareas.db");
            LoadTareas();
        }

        private async void LoadTareas()
        {
            var tareasList = await database.GetTareasAsync();
            tareas = new ObservableCollection<Tarea>(tareasList);
            mainPage.BindingContext = this;
        }

        private async void OnTaskSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var tarea = e.SelectedItem as Tarea;
                await Navigation.PushAsync(new TaskDetailPage(tarea));
            }
        }
        private async void OnAddTaskClicked(object sender, EventArgs e)
        {
            Tarea nuevaTarea = new Tarea();
            await Navigation.PushAsync(new TaskDetailPage(nuevaTarea));
        }

    }
}
