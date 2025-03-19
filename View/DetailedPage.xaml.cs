using Restauracja.Model;

namespace Restauracja.View;

public partial class DetailedPage : ContentPage
{
	public DetailedPage(Potrawa potrawa)
	{
		InitializeComponent();
        BindingContext = potrawa;
    }
}