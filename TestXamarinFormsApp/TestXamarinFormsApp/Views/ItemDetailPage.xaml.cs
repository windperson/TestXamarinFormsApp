using System.ComponentModel;
using TestXamarinFormsApp.ViewModels;
using Xamarin.Forms;

namespace TestXamarinFormsApp.Views
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