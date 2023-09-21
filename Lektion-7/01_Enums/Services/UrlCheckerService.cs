using _01_Enums.Enums;

namespace _01_Enums.Services;

internal class UrlCheckerService
{
    public async Task Run(string url)
    {
        var result = await CheckUrlAsync(url);
        switch (result)
        {
            case StatusCodes.Online:
                Console.WriteLine($"{url} is online and available.");
                break;

            case StatusCodes.Offline:
                Console.WriteLine($"{url} is offline and not available.");
                break;
        }

        Console.ReadKey();
    }

    public async Task<StatusCodes> CheckUrlAsync(string url)
    {
        try
        {
            using var http = new HttpClient();
            var response = await http.GetAsync(url);

            if (response.IsSuccessStatusCode)
                return StatusCodes.Online;
        }
        catch { }

        return StatusCodes.Offline;
    }
}
