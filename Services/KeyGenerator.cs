using System.Security.Cryptography;

namespace WebApi_ENDE_Crypt.Services;

public class KeyGenerator
{
    private const int KeyLength = 32;

    public static string GenerateRandomKey()
    {
        byte[] key = new byte[KeyLength];
        RandomNumberGenerator.Fill(key);
        return Convert.ToBase64String(key);
    }
}