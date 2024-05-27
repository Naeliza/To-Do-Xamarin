using System;
using toDo.Models;
using toDo.Services;
using Xamarin.Forms;

namespace toDo.Views
{
    public partial class TaskDetailPage : ContentPage
    {
        private Tarea tarea;
        private TareaDatabase database;
        private Action updateAction;

        public TaskDetailPage(Tarea tarea, TareaDatabase database, Action updateAction)
        {
            InitializeComponent();
            this.tarea = tarea;
            this.database = database;
            this.updateAction = updateAction;

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

            updateAction();
            await Navigation.PopAsync();
        }

        private async void DeleteButton_Clicked(object sender, EventArgs e)
        {
            if (tarea != null)
            {
                await database.DeleteTareaAsync(tarea);
                updateAction();
                await Navigation.PopAsync();
            }
        }
    }
}
