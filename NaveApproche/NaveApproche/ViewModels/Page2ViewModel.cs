using NaveApproche.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace NaveApproche.ViewModels
{
    public class Page2ViewModel : BaseViewModel
    {

        public Page2ViewModel(INavigation nav)
        {
            Title = "Page 2";
            _nav = nav;
            CurrentPage = DependencyInject<Page2>.Get();
            OpenPage();
        }
        // c'est la structure lamda, au lieu de déclarer  public ICommand SubmitCommand { protected set; get; }
        //public AdminViewModel()
        //{
        //    SubmitCommand = new Command(GoToPage3);
        //}
        public ICommand GoToPage3 => new Command(() =>
        {
            _nav.PushAsync(DependencyInject<Page3>.Get());
        });


    }
}