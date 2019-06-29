using FreshMvvm;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace PanelViewControl
{
    public class MainPageModel : FreshBasePageModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;

        public Command ShowPanelView
        {
            get
            {
                return new Command(() =>
                {
                    PanelViewVisible = !PanelViewVisible;
                });
            }
        }
        bool _panelViewVisible;
        public bool PanelViewVisible
        {
            set { SetProperty(ref _panelViewVisible, value); }
            get { return _panelViewVisible; }
        }

        public Command PanelShowing
        {
            get
            {
                return new Command(() =>
                {
                });
            }
        }

        bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}