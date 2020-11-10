using System;
using System.Collections.Generic;
using EriExpress_v0._0.ViewModels;
using EriExpress_v0._0.Views;
using Xamarin.Forms;

namespace EriExpress_v0._0
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
