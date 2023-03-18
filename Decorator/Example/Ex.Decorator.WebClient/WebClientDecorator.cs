using System.Net;

namespace Ex.Decorator.WebClientApp;

public class WebClientDecorator:WebClient
{
    private readonly System.Net.WebClient _webClient;

    public WebClientDecorator(WebClient webClient)
    {
        _webClient = webClient;
    }

    public string DownloadString(string address)
    {
        if (address.StartsWith("https://github.com"))
            return _webClient.DownloadString(address);

        return string.Empty;
    }
}