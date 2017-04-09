using RK.Models;
using RK.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RK.ViewModels
{
    public class CompletedTaskViewModel
    {
        public ObservableCollection<CompletedTaskModel> Task { get; set; } = new ObservableCollection<CompletedTaskModel>
        {
            new CompletedTaskModel
            {
                Name = "Задача 1",
            },
        };

        /*public ICommand OpenAddCompletedTask { get; set; }

        private Page _page;

        public CompletedTaskViewModel(Page page)
        {
            _page = page;
            OpenAddCompletedTask = new Command(AddCompletedTask);
        }

        private async void AddCompletedTask()
        {
            await _page.Navigation.PushAsync(new Page());
        }*/
    }
}
