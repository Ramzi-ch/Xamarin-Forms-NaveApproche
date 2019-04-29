using NaveApproche.ViewModels;
using NaveApproche.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NaveApproche
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new NaveApproche.MainPage();
            //appeller le viewmodel de la page (1)
            var model = DependencyInject<Page1ViewModel>.Get();

            //appeller contentpage (UI) (2)
            model.CurrentPage = DependencyInject<Page1>.Get();

            //affecter la laison entre les deux (3)
            model.CurrentPage.BindingContext = model;  //(3)

            //étape de navigation
            var nav = new NavigationPage(model.CurrentPage);
            model._nav = nav.Navigation;
            MainPage = nav;


        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
