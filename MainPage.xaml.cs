using MAUI.MaintenanceApp.ViewModels;

namespace MAUI.MaintenanceApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}