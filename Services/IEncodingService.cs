public interface IEncodingService
{
    string Encode(string text, string key);
    string Decode(string encodedText, string key);
}