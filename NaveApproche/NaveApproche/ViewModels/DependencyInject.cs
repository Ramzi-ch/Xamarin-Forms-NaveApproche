using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NaveApproche.ViewModels
{
    public class DependencyInject<T> where T : class
    {
        public static T Get()
        {
            return DependencyService.Get<T>() ?? (T)Activator.CreateInstance(typeof(T), new object[] { });//test sur l'existance de la class pour la création des instance
        }
    }
}
