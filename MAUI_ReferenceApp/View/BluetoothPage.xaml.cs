namespace MAUI_ReferenceApp.View;

public partial class BluetoothPage : ContentPage
{
	public BluetoothPage(BluetoothViewModel	vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}