using Newtonsoft.Json;
using NLog;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MAUI.MaintenanceApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        //TODO: Use MVVM toolkit...
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}