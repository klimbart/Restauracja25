using Restauracja.Service;
using Restauracja.Model;

namespace Restauracja.View
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new Restauracja.ViewModel.ViewModel(Navigation, new DataService());
        }

        
    }

}
