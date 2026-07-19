namespace UtilLib
{
    public class UrlHostNameParser
    {
        public string ParseHostName(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                return string.Empty;

            Uri uri = new Uri(url);

            return uri.Host;
        }
    }
}
