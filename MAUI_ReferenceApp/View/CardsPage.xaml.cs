namespace MAUI_ReferenceApp.View;

public partial class CardsPage : ContentPage
{
	public CardsPage(CardsViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}