using MAUI_ReferenceApp.Helpers;
using MAUI_ReferenceApp.View;

namespace MAUI_ReferenceApp.ViewModel;

public partial class HomeViewModel : BaseViewModel
{
    #region VARIABLES
    static Dictionary<string, string> screenNames = new Dictionary<string, string>()
    {
        {nameof(CollectionViewModel), "CollectionView"},
        {nameof(AlertViewModel), "Alerts"},
        {nameof(CardsViewModel), "Cards"},
        //{nameof(CircleAvatarViewModel), "Circle Avatar"},
        {nameof(TextInputsViewModel), "Text Inputs"},
        {nameof(SlidersChecksViewModel), "Sliders & Checks"},
        {nameof(InfiniteScrollViewModel), "Infinite Scroll & Pull Refresh"},
        {nameof(VolumenViewModel), "Volumen"},
        {nameof(CameraGalleryViewModel), "Camera & Gallery"},
        {nameof(GPSViewModel), "GPS"},
        {nameof(BluetoothViewModel), "Bluetooth"},
    };
    #endregion

    #region PROPERTIES
    [ObservableProperty]
    private List<MdlListTile> screens = new List<MdlListTile>{
        new MdlListTile(IconFont.List, screenNames[nameof(CollectionViewModel)]),
        new MdlListTile(IconFont.Add_alert, screenNames[nameof(AlertViewModel)]),
        new MdlListTile(IconFont.Credit_card, screenNames[nameof(CardsViewModel)]),
        //new MdlListTile(IconFont.Supervised_user_circle, screenNames[nameof(CircleAvatarViewModel)]),
        new MdlListTile(IconFont.Input, screenNames[nameof(TextInputsViewModel)]),
        new MdlListTile(IconFont.Slow_motion_video, screenNames[nameof(SlidersChecksViewModel)]),
        new MdlListTile(IconFont.Build_circle, screenNames[nameof(InfiniteScrollViewModel)]),
        new MdlListTile(IconFont.Volume_up, screenNames[nameof(VolumenViewModel)]),
        new MdlListTile(IconFont.Camera, screenNames[nameof(CameraGalleryViewModel)]),
        new MdlListTile(IconFont.Gps_fixed, screenNames[nameof(GPSViewModel)]),
        new MdlListTile(IconFont.Bluetooth, screenNames[nameof(BluetoothViewModel)]),
    };
    #endregion

    #region CONSTRUCTORS
    public HomeViewModel()
    {
        Title = "Componentes en MAUI";
    }
    #endregion

    #region COMMANDS
    [RelayCommand]
    async Task GoToAsync(string screenName)
    {
        if (screenName == screenNames[nameof(CollectionViewModel)])
        {
            await Shell.Current.GoToAsync($"{nameof(CollectionPage)}");
        }
        else if (screenName == screenNames[nameof(AlertViewModel)])
        {
            await Shell.Current.GoToAsync($"{nameof(AlertPage)}");
        }
        else if (screenName == screenNames[nameof(CardsViewModel)])
        {
            await Shell.Current.GoToAsync($"{nameof(CardsPage)}");
        }
        //else if (screenName == screenNames[nameof(CircleAvatarViewModel)])
        //{
        //    await Shell.Current.GoToAsync($"{nameof(CircleAvatarPage)}");
        //}
        else if (screenName == screenNames[nameof(TextInputsViewModel)])
        {
            await Shell.Current.GoToAsync($"{nameof(TextInputsPage)}");
        }
        else if (screenName == screenNames[nameof(SlidersChecksViewModel)])
        {
            await Shell.Current.GoToAsync($"{nameof(SlidersChecksPage)}");
        }
        else if (screenName == screenNames[nameof(InfiniteScrollViewModel)])
        {
            await Shell.Current.GoToAsync($"{nameof(InfiniteScrollPage)}");
        }
        else if (screenName == screenNames[nameof(VolumenViewModel)])
        {
            await Shell.Current.GoToAsync($"{nameof(VolumenPage)}");
        }
        else if (screenName == screenNames[nameof(CameraGalleryViewModel)])
        {
            await Shell.Current.GoToAsync($"{nameof(CameraGalleryPage)}");
        }
        else if (screenName == screenNames[nameof(GPSViewModel)])
        {
            await Shell.Current.GoToAsync($"{nameof(GPSPage)}");
        }
        else if (screenName == screenNames[nameof(BluetoothViewModel)])
        {
            await Shell.Current.GoToAsync($"{nameof(BluetoothPage)}");
        } 
        else
        {
            await Shell.Current.DisplayAlert("Info", "In Progress", "OK");
        }
    }
    #endregion
}