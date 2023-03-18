using System.Net;

namespace Ex.Decorator.App;

public class WebClientDecorator : WebClient
{
    private readonly WebClient _webClient;

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