namespace WebApi_ENDE_Crypt.Services;

public class PasswordService : IPasswordService
{
    public string GenerateSecurePassword(int length)
    {
        return PasswordGenerator.GenerateSecurePassword(length);
    }
}