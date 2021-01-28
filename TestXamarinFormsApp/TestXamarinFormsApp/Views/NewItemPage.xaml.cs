using System;
using System.Collections.Generic;
using System.ComponentModel;
using TestXamarinFormsApp.Models;
using TestXamarinFormsApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXamarinFormsApp.Views
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