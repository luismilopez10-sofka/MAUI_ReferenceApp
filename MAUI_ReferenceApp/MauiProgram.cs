using MAUI_ReferenceApp.Services;
using MAUI_ReferenceApp.View;

namespace MAUI_ReferenceApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("MaterialIcons-Regular.ttf", "IconFontTypes");
            });

        #region DEPENDENCY_INJECTION_REGISTRATION
        /*
         * En el registro se puede usar:
         * 'AddSingleton' : Para que cada que se instancie, siempre retorne la misma.
         * 'AddTransient' : Se creará una diferente cada vez que se instancie (Ejemplo: Una página que muestra los detalles de un producto que viene de una página con una lista de productos, cada una de esas páginas será diferente para cada producto).
         */

        // Login
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<LoginViewModel>();
        builder.Services.AddSingleton<LoginService>();

        // Home
        builder.Services.AddSingleton<HomePage>();
        builder.Services.AddSingleton<HomeViewModel>();

        // Collection
        builder.Services.AddSingleton<CollectionPage>();
        builder.Services.AddSingleton<CollectionViewModel>();
        builder.Services.AddSingleton<MonkeyService>();

        // Alert
        builder.Services.AddSingleton<AlertPage>();
        builder.Services.AddSingleton<AlertViewModel>();

        // Cards
        builder.Services.AddSingleton<CardsPage>();
        builder.Services.AddSingleton<CardsViewModel>();

        // TextInputs
        builder.Services.AddSingleton<TextInputsPage>();
        builder.Services.AddSingleton<TextInputsViewModel>();

        // SlidersChecks
        builder.Services.AddSingleton<SlidersChecksPage>();
        builder.Services.AddSingleton<SlidersChecksViewModel>();

        // InfiniteScroll
        builder.Services.AddSingleton<InfiniteScrollPage>();
        builder.Services.AddSingleton<InfiniteScrollViewModel>();

        // Volumen
        builder.Services.AddSingleton<VolumenPage>();
        builder.Services.AddSingleton<VolumenViewModel>();

        // CameraGallery
        builder.Services.AddSingleton<CameraGalleryPage>();
        builder.Services.AddSingleton<CameraGalleryViewModel>();

        // GPS
        builder.Services.AddSingleton<GPSPage>();
        builder.Services.AddSingleton<GPSViewModel>();

        // Bluetooth
        builder.Services.AddSingleton<BluetoothPage>();
        builder.Services.AddSingleton<BluetoothViewModel>();
        #endregion

        return builder.Build();
	}
}
