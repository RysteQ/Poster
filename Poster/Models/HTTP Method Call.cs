using Poster.Enums;

namespace Poster.Models;

internal class HTTPMethodCall
{
    public HTTPMethodCall(MethodsEnum Method, string URL, Dictionary<string, string> Parameters, string Response)
    {
        this.Method = Method;
        this.URL = URL;
        this.Parameters = Parameters;
        this.Response = Response;
    }

    public MethodsEnum Method { get; set; }
    public string URL { get; set; }
    public Dictionary<string, string> Parameters { get; set; }
    public string Response { get; set; }
}