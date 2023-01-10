using Milea_Petrica_Lab7.Models;

namespace Milea_Petrica_Lab7;

public partial class ShopPage : ContentPage
{
	public ShopPage()
	{
		InitializeComponent();
	}

    async void OnSaveButtonClicked(object sender, EventArgs e) 
	{ 
		var shop = (Shop)BindingContext; 
		await App.Database.SaveShopAsync(shop); 
		await Navigation.PopAsync(); 
	}
}