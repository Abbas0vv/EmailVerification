namespace Pustok.Helpers;

public class GenerateConfirmEmailToken
{
    public static string GetConfirmEmailToken()
    {
        var token = new Guid.NewGuid().ToString();
    }
}
