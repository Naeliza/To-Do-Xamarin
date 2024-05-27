using System;
using System.Collections.Generic;
using System.ComponentModel;
using toDo.Models;
using toDo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace toDo.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}