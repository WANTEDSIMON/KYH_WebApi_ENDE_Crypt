using WebApi_ENDE_Crypt.Services;
using Xunit;

namespace WebApi_ENDE_Crypt.Test.Services;

public class EncodingServiceTests
{
    private readonly EncodingService _encodingService;

    public EncodingServiceTests()
    {
        _encodingService = new EncodingService();
    }

    [Fact]
    public void Encode_ShouldReturn_Base64EncodedString()
    {
        string text = "HelloWorld";
        string key = "MySecretKey";
        string encoded = _encodingService.Encode(text, key);
        Assert.False(string.IsNullOrEmpty(encoded));
    }
}