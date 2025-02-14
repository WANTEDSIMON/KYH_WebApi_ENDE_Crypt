using WebApi_ENDE_Crypt.Services;
using Xunit;

namespace WebApi_ENDE_Crypt.Test.Services;

public class PasswordServiceTests
{
    private readonly PasswordService _passwordService;

    public PasswordServiceTests()
    {
        _passwordService = new PasswordService();
    }

    [Fact]
    public void GenerateSecurePassword_ShouldReturn_CorrectLength()
    {
        int expectedLength = 16;
        string password = _passwordService.GenerateSecurePassword(expectedLength);
        Assert.Equal(expectedLength, password.Length);
    }
}