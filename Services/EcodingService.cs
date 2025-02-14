namespace WebApi_ENDE_Crypt.Services;

public class EncodingService : IEncodingService
{
    public string Encode(string text, string key)
    {
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(key + text));
    }

    public string Decode(string encodedText, string key)
    {
        try
        {
            byte[] decodedBytes = Convert.FromBase64String(encodedText);
            string decodedText = System.Text.Encoding.UTF8.GetString(decodedBytes);

            return decodedText.StartsWith(key) ? decodedText.Substring(key.Length) : "Invalid Key";
        }
        catch
        {
            return "Invalid Base64 string";
        }
    }
}