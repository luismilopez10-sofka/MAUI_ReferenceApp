using MAUI_ReferenceApp.View;

namespace MAUI_ReferenceApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        #region ROUTES_REGISTRY
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(CollectionPage), typeof(CollectionPage));
        Routing.RegisterRoute(nameof(AlertPage), typeof(AlertPage));
        Routing.RegisterRoute(nameof(CardsPage), typeof(CardsPage));
        Routing.RegisterRoute(nameof(TextInputsPage), typeof(TextInputsPage));
        Routing.RegisterRoute(nameof(SlidersChecksPage), typeof(SlidersChecksPage));
        Routing.RegisterRoute(nameof(InfiniteScrollPage), typeof(InfiniteScrollPage));
        Routing.RegisterRoute(nameof(VolumenPage), typeof(VolumenPage));
        Routing.RegisterRoute(nameof(CameraGalleryPage), typeof(CameraGalleryPage));
        Routing.RegisterRoute(nameof(GPSPage), typeof(GPSPage));
        Routing.RegisterRoute(nameof(BluetoothPage), typeof(BluetoothPage));
        #endregion
    }
}
