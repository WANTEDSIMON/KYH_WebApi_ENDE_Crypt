namespace WebApi_ENDE_Crypt.Services;

public class KeyService : IKeyService
{
    public string GenerateRandomKey()
    {
        return KeyGenerator.GenerateRandomKey();
    }
}