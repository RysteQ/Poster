using Poster.Enums;

namespace Poster.Models;

internal class HTTPRequestCall
{
    public HTTPRequestCall(RequestEnum Method, string URL, Dictionary<string, string> Parameters, HttpResponseMessage Response)
    {
        this.Method = Method;
        this.URL = URL;
        this.Parameters = Parameters;
        this.Response = Response;
    }

    public RequestEnum Method { get; private set; }
    public string URL { get; private set; }
    public Dictionary<string, string> Parameters { get; private set; }
    public HttpResponseMessage Response { get; private set; }
}