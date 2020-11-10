using System.ComponentModel;
using Xamarin.Forms;
using EriExpress_v0._0.ViewModels;

namespace EriExpress_v0._0.Views
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