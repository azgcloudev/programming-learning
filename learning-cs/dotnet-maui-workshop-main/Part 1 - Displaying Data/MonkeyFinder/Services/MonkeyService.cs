using System.Net.Http.Json;

namespace MonkeyFinder.Services;

public class MonkeyService
{
    HttpClient httpClient;

    List<Monkey> monkeytList = new();

    public MonkeyService()
    {
        httpClient = new HttpClient();
    }

    public async Task<List<Monkey>> GetMonkeys()
    {
        if (monkeytList?.Count > 0)
        {
            return monkeytList;
        }

        string url = "https://montemagno.com/monkeys.json";

        var response = await httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            monkeytList = await response.Content.ReadFromJsonAsync<List<Monkey>>();
        }

        return monkeytList;
    }
}
