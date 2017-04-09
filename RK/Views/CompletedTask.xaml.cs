using RK.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RK.Views
{
    public partial class CompletedTask : ContentPage
    {
        private readonly CompletedTaskViewModel _viewmodel;

        public CompletedTask()
        {
            InitializeComponent();
            BindingContext = new CompletedTaskViewModel();
        }

        private async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
