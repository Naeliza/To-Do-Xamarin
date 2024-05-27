using System;
using Xamarin.Forms;
using toDo.Models;
using toDo.Services;

namespace toDo.Views
{
    public partial class TaskDetailPage : ContentPage
    {
        private Tarea tarea;
        private TareaDatabase database;

        public TaskDetailPage(Tarea tarea)
        {
            InitializeComponent();
            this.tarea = tarea;
            database = new TareaDatabase("tareas.db");

            if (tarea != null)
            {
                nameEntry.Text = tarea.Nombre;
                descriptionEntry.Text = tarea.Descripcion;
            }
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            if (tarea == null)
            {
                tarea = new Tarea { Nombre = nameEntry.Text, Descripcion = descriptionEntry.Text };
                await database.SaveTareaAsync(tarea);
            }
            else
            {
                tarea.Nombre = nameEntry.Text;
                tarea.Descripcion = descriptionEntry.Text;
                await database.SaveTareaAsync(tarea);
            }

            await Navigation.PopAsync();
        }
    }
}
