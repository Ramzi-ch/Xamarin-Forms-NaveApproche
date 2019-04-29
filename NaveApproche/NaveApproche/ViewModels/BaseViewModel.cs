using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace NaveApproche.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public INavigation _nav;
        public ContentPage CurrentPage { get; set; }
        public virtual void OpenPage()
        {
            if(CurrentPage != null)
            {
                CurrentPage.BindingContext = this;//BindingContext mech ta3mel liaison bin le view w model view mta3 l page eli 3meltelha appel
                _nav.PushAsync(CurrentPage);//passage de navigation
            }
        }
        public bool isBusy = false;//inisialiser à pas de traitement 
        public bool IsBusy
        {
            get
            {
                if(IsBusy==true)
                {
                    CurrentPage.IsEnabled = false;
                }
                else
                {
                    CurrentPage.IsEnabled = true;
                }
                return isBusy;
            }
            set
            {
                SetProperty(ref isBusy, value);

            }

        }
        string title = "";
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                SetProperty(ref title, value);
            }
        }
        
        protected virtual void OnPropertyChanged(string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName]string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
