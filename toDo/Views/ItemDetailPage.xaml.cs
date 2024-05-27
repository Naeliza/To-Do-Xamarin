using System.ComponentModel;
using toDo.ViewModels;
using Xamarin.Forms;

namespace toDo.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}