using System.Net.Http.Json;

namespace MAUI_ReferenceApp.Services;

public class MonkeyService
{
    #region VARIABLES
    List<MdlMonkey> monkeyList;
    readonly HttpClient httpClient;
    readonly string baseUrl = "https://montemagno.com";
    #endregion

    #region CONSTRUCTORS
    public MonkeyService()
    {
        httpClient = new();
    }
    #endregion

    #region METHODS
    public async Task<List<MdlMonkey>> GetMonkeys()
    {
        if (monkeyList?.Count > 0)
            return monkeyList;

        var url = "/monkeys.json";
        var uri = new Uri(baseUrl + url);

        var response = await httpClient.GetAsync(uri);
        if (response.IsSuccessStatusCode)
        {
            monkeyList = await response.Content.ReadFromJsonAsync<List<MdlMonkey>>();
        }

        return monkeyList;
    }
    #endregion
}