using Restauracja.Model;

namespace Restauracja.View;

public partial class DetailedPage : ContentPage
{
    private Potrawa _potrawa;
    public DetailedPage(Potrawa potrawa)
	{
		InitializeComponent();
        _potrawa = potrawa;
        BindingContext = potrawa;

    }

    public void EdytujPotrawe(
            Potrawa potrawa,
            string? NewName,
            string? NewDescription,
            string? NewCategory,
            string? NewImageUrl)
    {
        potrawa.Name = NewName;
        potrawa.Description = NewDescription;
        potrawa.Category = NewCategory;
        potrawa.ImageUrl = NewImageUrl;

        // Ustawia nowe wartoœci dla wybranej potrawy

    }

    public async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        // Ka¿da wartoœæ jest odœwie¿ana
        _potrawa.OnPropertyChanged(nameof(Potrawa.Name));
        _potrawa.OnPropertyChanged(nameof(Potrawa.Price));
        _potrawa.OnPropertyChanged(nameof(Potrawa.Description));
        _potrawa.OnPropertyChanged(nameof(Potrawa.Category));
        _potrawa.OnPropertyChanged(nameof(Potrawa.ImageUrl));
        _potrawa.OnPropertyChanged(nameof(Potrawa.Ingredients));

        // Zapisuje zmiany i wraca do mainpage
        await Navigation.PopAsync();
    }
}