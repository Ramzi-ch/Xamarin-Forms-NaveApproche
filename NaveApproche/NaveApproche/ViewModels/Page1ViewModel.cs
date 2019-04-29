using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using NaveApproche.Views;
using Xamarin.Forms;

namespace NaveApproche.ViewModels
{
    public class Page1ViewModel : BaseViewModel
    {
        public Page1ViewModel()
        {
            Title = "Page 1";
        }

        public Page1ViewModel(INavigation nav)
        {
            _nav = nav;
            CurrentPage = DependencyInject<Page1>.Get();
        }
        // c'est la structure lamda, au lieu de déclarer  public ICommand SubmitCommand { protected set; get; }
        //public AdminViewModel()
        //{
        //    SubmitCommand = new Command(GoToPage2);
        //}
        public ICommand GoToPage2 => new Command(() =>
        {
            var ss = DependencyService.Get<Page2ViewModel>() ?? (new Page2ViewModel(_nav));
        });
    }
}
