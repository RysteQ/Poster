using System.Web;

namespace Poster.Services.HTTP;

internal static class HTTPMethodCaller
{
    public static async Task<HttpResponseMessage> POST(string url, Dictionary<string, string> parameters, string username = "", string password = "")
    {
        HttpClient client = new()
        {
            Timeout = new(0, 0, 10)
        };

        return await client.PostAsync(url, new FormUrlEncodedContent(parameters));
    }

    public static async Task<HttpResponseMessage> GET(string url, Dictionary<string, string> parameters, string username = "", string password = "")
    {
        HttpClient client = new()
        {
            Timeout = new(0, 0, 10)
        };

        string test = url + "?" + ConvertParametersToString(parameters);

        if (parameters.Count != 0)
            return await client.GetAsync(url + "?" + ConvertParametersToString(parameters));

        return await client.GetAsync(url);
    }

    public static async Task<HttpResponseMessage> PUT(string url, Dictionary<string, string> parameters, string username = "", string password = "")
    {
        HttpClient client = new()
        {
            Timeout = new(0, 0, 10)
        };

        return await client.PutAsync(url, new FormUrlEncodedContent(parameters));
    }

    public static async Task<HttpResponseMessage> PATCH(string url, Dictionary<string, string> parameters, string username = "", string password = "")
    {
        HttpClient client = new()
        {
            Timeout = new(0, 0, 10)
        };

        return await client.PatchAsync(url, new FormUrlEncodedContent(parameters));
    }

    public static async Task<HttpResponseMessage> DELETE(string url, Dictionary<string, string> parameters, string username = "", string password = "")
    {
        HttpClient client = new()
        {
            Timeout = new(0, 0, 10)
        };

        if (parameters.Count != 0)
            return await client.DeleteAsync(ConvertParametersToString(parameters));
        
        return await client.DeleteAsync(url);
    }

    private static string ConvertParametersToString(Dictionary<string, string> parameters)
    {
        string to_return = string.Empty;

        foreach (KeyValuePair<string, string> key_value_pair in parameters)
            to_return += $"{key_value_pair.Key}={key_value_pair.Value}&";

        return HttpUtility.UrlEncode(to_return.TrimEnd('&')).Replace("%3d", "=");
    }
}