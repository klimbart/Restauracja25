using Restauracja.Model;
using Restauracja.Service;
using Restauracja.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Restauracja.ViewModel
{
    public class ViewModel
    {
        private Potrawa _selectedPotrawa;
        public Potrawa SelectedPotrawa
        {
            get => _selectedPotrawa;
            set
            {
                _selectedPotrawa = value;
            }
        }
        public ObservableCollection<Potrawa> Potrawy { get; set; } = new ObservableCollection<Potrawa>();
        public Command EditDishCmd { get; }
        private readonly INavigation _navigation;
        private readonly DataService _dataService;
        public ViewModel(INavigation navigation, DataService dataService)
        {
            _navigation = navigation;
            _dataService = dataService;
            Potrawy = _dataService.Potrawy;
            EditDishCmd = new Command<Potrawa>(async (potrawa) => await EditDish(potrawa));
            _selectedPotrawa = Potrawy[0];
            SelectedPotrawa = Potrawy[0];
        }

        private async Task EditDish(Potrawa potrawa)
        {
            if (potrawa != null)
                SelectedPotrawa = potrawa;
            await _navigation.PushAsync(new DetailedPage(potrawa));
        }

    }
}
