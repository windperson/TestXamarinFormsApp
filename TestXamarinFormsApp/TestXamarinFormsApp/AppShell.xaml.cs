using System;
using System.Collections.Generic;
using TestXamarinFormsApp.ViewModels;
using TestXamarinFormsApp.Views;
using Xamarin.Forms;

namespace TestXamarinFormsApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
