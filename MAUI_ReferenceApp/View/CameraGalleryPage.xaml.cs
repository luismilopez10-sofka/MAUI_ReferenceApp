namespace MAUI_ReferenceApp.View;

public partial class CameraGalleryPage : ContentPage
{
	public CameraGalleryPage(CameraGalleryViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}