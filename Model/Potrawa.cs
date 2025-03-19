using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja.Model
{
    public class Potrawa
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; }
        public new ObservableCollection<string> Ingredients { get; set; }

        public void EdytujPotrawe(
            Potrawa _selectedPotrawa,
            string? NewName,
            string? NewDescription,
            string? NewCategory,
            string? NewImageUrl,
            ObservableCollection<string>? NewIngredients)
        {
            
        }

    }
}
