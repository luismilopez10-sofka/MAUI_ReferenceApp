using MAUI_ReferenceApp.Helpers;
using MAUI_ReferenceApp.View;

namespace MAUI_ReferenceApp.ViewModel;

public partial class HomeViewModel : BaseViewModel
{
    #region VARIABLES
    #endregion

    #region PROPERTIES
    [ObservableProperty]
    private List<MdlListTile> screens = new List<MdlListTile>{
        new MdlListTile(IconFont.List, "CollectionView"),
        new MdlListTile(IconFont.Add_alert, "Alerts"),
        new MdlListTile(IconFont.Credit_card, "Cards"),
        new MdlListTile(IconFont.Supervised_user_circle, "Circle Avatar"),
        new MdlListTile(IconFont.Input, "Text Inputs"),
        new MdlListTile(IconFont.Slow_motion_video, "Sliders and Checks"),
        new MdlListTile(IconFont.Build_circle, "Infinite Scroll and Pull Refresh"),
        new MdlListTile(IconFont.Volume_up, "Volumen"),
        new MdlListTile(IconFont.Camera, "Camera"),
        new MdlListTile(IconFont.Gps_fixed, "GPS"),
        new MdlListTile(IconFont.Bluetooth, "Bluetooth"),
        new MdlListTile(IconFont.Photo_album, "Gallery"),
    };
    #endregion

    #region CONSTRUCTORS
    public HomeViewModel()
    {
        Title = "Home";
    }
    #endregion

    #region COMMANDS
    [RelayCommand]
    async Task GoToAsync(string screenName)
    {
        switch (screenName)
        {
            case "CollectionView":
                await Shell.Current.GoToAsync($"{nameof(CollectionPage)}");
                break;
            case "Alerts":
                await Shell.Current.GoToAsync($"{nameof(CollectionPage)}");
                break;
            case "Cards":
                await Shell.Current.GoToAsync($"{nameof(CollectionPage)}");
                break;
            case "Circle Avatar":
                await Shell.Current.GoToAsync($"{nameof(CollectionPage)}");
                break;
            case "Text Inputs":
                await Shell.Current.GoToAsync($"{nameof(CollectionPage)}");
                break;
            case "Sliders and Checks":
                await Shell.Current.GoToAsync($"{nameof(CollectionPage)}");
                break;
            case "Infinite Scroll and Pull Refresh":
                await Shell.Current.GoToAsync($"{nameof(CollectionPage)}");
                break;
        }
    }
    #endregion
}