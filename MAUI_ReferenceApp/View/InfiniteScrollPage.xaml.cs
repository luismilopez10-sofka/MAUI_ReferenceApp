namespace MAUI_ReferenceApp.View;

public partial class InfiniteScrollPage : ContentPage
{
	public InfiniteScrollPage(InfiniteScrollViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}