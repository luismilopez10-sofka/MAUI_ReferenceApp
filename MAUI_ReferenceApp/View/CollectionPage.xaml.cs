namespace MAUI_ReferenceApp.View;

public partial class CollectionPage : ContentPage
{
	public CollectionPage(CollectionViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}